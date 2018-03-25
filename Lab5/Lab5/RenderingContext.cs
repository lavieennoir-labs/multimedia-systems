using OpenGLWinControl.OpenGL;
using OpenGLWinControl.OpenGL.Enumerations.GL;
using OpenGLWinControl.OpenGL.Enumerations.GLUT;
using OpenGLWinControl.OpenGL.HeapData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class RenderingContext : IRenderingContext
    {
        public Form1 Parent { get; set; }
        public PolygonMode PolyMode = PolygonMode.LINE;
        public ShadingModel SmoothMode = ShadingModel.FLAT;
        public bool UseOrthoProjection = true;

        public List<Figure> Figures = new List<Figure>();

        /// <summary>
        ///     Set to true to invoke update scene ortho.
        /// </summary>
        public bool GridResized { get; set; } = false;

        Color gridColor = Color.DarkGray;
        public float GridStep = 1;

        //ortho
        public float MinAvailableX { get; set; } = -10;
        public float MaxAvailableX { get; set; } = 10;
        public float MinAvailableY { get => MinAvailableX * heightFactor; }
        public float MaxAvailableY { get => MaxAvailableX * heightFactor; }

        //size
        int width;
        int height;
        float heightFactor { get => height / (float)width; }

        //invoke provider
        GL glMethod;
        GLU gluMethod;
        GLUT glutMethod;

        public void Init(GL gl, GLU glu, GLUT glut, int contextWidth, int contextHeight)
        {
            glMethod = gl;
            gluMethod = glu;
            glutMethod = glut;

            //upadte size
            width = contextWidth;
            height = contextHeight;
            glMethod.Viewport(0, 0, (uint)contextWidth, (uint)contextHeight);

            gl.ClearColor(1.0f, 1.0f, 1.0f, 0.5f);
            gl.ClearDepth(1.0f);

            gl.Enable(Capability.LIGHTING);
            gl.Enable(Capability.LIGHT0);
            gl.Enable(Capability.COLOR_MATERIAL);
            //gl.Lightfv(LightName.LIGHT0, LightParameter.SPECULAR, new float[] { 1f, 1f, 1f, 1f });
            //gl.Lightfv(LightName.LIGHT0, LightParameter.AMBIENT, new float[] { 0, 0, 0, 1 });
            gl.Lightfv(LightName.LIGHT0, LightParameter.DIFFUSE, new float[] { 1, 1, 1, 1 });
            gl.Lightfv(LightName.LIGHT0, LightParameter.POSITION, new float[] { 1, 1, 1, 0 });
            //gl.LightModelf(LightModelParams.LIGHT_MODEL_AMBIENT, new float[] { 0.2f, 0.2f, 0.2f, 1 });

            //gl.Materialfv(FacingMode.FRONT_AND_BACK, LightParameter.SPECULAR, new float[] { 1, 1, 1, 1 });
            

            gl.Enable(Capability.DEPTH_TEST);
            gl.DepthFunc(AlphaFunction.LEQUAL);
            gl.Hint(HintTarget.PERSPECTIVE_CORRECTION_HINT, HintMode.NICEST);

            gl.Viewport(0, 0, (uint)contextWidth, (uint)contextHeight);
            gl.MatrixMode(MatrixMode.PROJECTION);                        // Select The Projection Matrix
            gl.LoadIdentity();                                   // Reset The Projection Matrix
            if(UseOrthoProjection)
            {
                gl.Ortho(MinAvailableX, MaxAvailableX, MinAvailableY, MaxAvailableY,
                    -100, 100);
            }
            else
            {
                // Calculate The Aspect Ratio Of The Window
                glu.Perspective(45.0f, (float)contextWidth / (float)contextHeight, 0.1f, 100.0f);
            }
            gl.MatrixMode(MatrixMode.MODELVIEW);                         // Select The Modelview Matrix
            gl.LoadIdentity();

            //gl.ColorMaterial(GL_FRONT_AND_BACK, GL_EMISSION);
            //gl.Enable(Capability.COLOR_MATERIAL);

            //FitOrtho();
            //glMethod.Ortho(MinX, MaxX, MinY, MaxY, -1, 1);


            InitMenu();
        }

        void InitMenu()
        {
            var polyModeMenu = glutMethod.CreateMenu(new GLUT.MenuFunction(
                (selectedItem) =>
                {
                    switch (selectedItem)
                    {
                        case 1:
                            PolyMode = PolygonMode.LINE;
                            break;
                        case 2:
                            PolyMode = PolygonMode.FILL;
                            break;
                    }
                    glutMethod.PostRedisplay();
                }
            ));
            glutMethod.AddMenuEntry("Каркасні", 1);
            glutMethod.AddMenuEntry("Зафарбовані грані", 2);
            var projModeMenu = glutMethod.CreateMenu(new GLUT.MenuFunction(
                (selectedItem) =>
                {
                    switch (selectedItem)
                    {
                        case 1:
                            UseOrthoProjection = true;
                            break;
                        case 2:
                            UseOrthoProjection = false;
                            break;
                    }
                    glutMethod.PostRedisplay();
                }
            ));
            glutMethod.AddMenuEntry("Каркасні", 1);
            glutMethod.AddMenuEntry("Зафарбовані грані", 2);
            var mainMenu = glutMethod.CreateMenu(new GLUT.MenuFunction(
                (selectedItem) =>
                {
                    switch (selectedItem)
                    {
                        case 3:
                            Parent.btnClear_Click(this, EventArgs.Empty);
                            break;
                        case 4:
                            Parent.btnAdd_Click(this, EventArgs.Empty);
                            break;
                    }
                    glutMethod.PostRedisplay();
                }
            ));
            glutMethod.AddMenuEntry("Відображення об'єктів", polyModeMenu);
            glutMethod.AddMenuEntry("Проекція", projModeMenu);
            glutMethod.AddMenuEntry("Очистити сцену", 3);
            glutMethod.AddMenuEntry("Додати фігуру", 4);
            glutMethod.AttachMenu(Button.RIGHT_BUTTON);
        }

        public void Render(GL gl, GLU glu, GLUT glut, int contextWidth, int contextHeight)
        {

            gl.Clear(ClearAttributeMask.COLOR_BUFFER_BIT | ClearAttributeMask.DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
            gl.ShadeModel(SmoothMode);
            gl.PolygonMode(FacingMode.FRONT_AND_BACK, PolyMode);
            

            if (GridResized)
            {
                Resize(gl,glu,glut,contextWidth, contextHeight);
                GridResized = false;
            }

            if (UseOrthoProjection)
            {
                gl.Rotate(-60, 1, 0, 0);
            }
            else
            {
                gl.Translate(0, -2, -10);
                gl.Rotate(-90, 1, 0, 0);
            }

            DrawGrid();

            foreach (var figure in Figures)
            {
                if (figure.Quadric == null)
                    figure.Generate(glu);
                figure.Draw(gl, glu);
            }
            
        }

        protected void DrawGrid()
        {
            var gridLen = 20;
            glMethod.LineWidth(0.5F);
            glMethod.Color4(gridColor.R, gridColor.G, gridColor.B, gridColor.A);

            glMethod.Begin(BeginMode.LINES);
            //vertical lines
            for (float i = GridStep; i < gridLen; i += GridStep)
            {
                glMethod.Vertex2(i, -gridLen);
                glMethod.Vertex2(i, gridLen);
            }
            for (float i = GridStep; i > -gridLen; i -= GridStep)
            {
                glMethod.Vertex2(i, -gridLen);
                glMethod.Vertex2(i, gridLen);
            }

            //horizontal lines
            for (float i = GridStep; i < gridLen; i += GridStep)
            {
                glMethod.Vertex2(-gridLen, i);
                glMethod.Vertex2(gridLen, i);
            }
            for (float i = GridStep; i > -gridLen; i -= GridStep)
            {
                glMethod.Vertex2(-gridLen, i);
                glMethod.Vertex2(gridLen, i);
            }
            glMethod.End();

            glMethod.LineWidth(1.0F);
        }

        public void Resize(GL gl, GLU glu, GLUT glut, int contextWidth, int contextHeight)
        {
            //upadte size
            width = contextWidth;
            height = contextHeight;

            gl.Viewport(0, 0, (uint)contextWidth, (uint)contextHeight);
            gl.MatrixMode(MatrixMode.PROJECTION);                        // Select The Projection Matrix
            gl.LoadIdentity();                                   // Reset The Projection Matrix

            if (UseOrthoProjection)
            {
                gl.Ortho(MinAvailableX, MaxAvailableX, MinAvailableY, MaxAvailableY,
                    -100, 100);
            }
            else
            {
                // Calculate The Aspect Ratio Of The Window
                glu.Perspective(45.0f, (float)contextWidth / (float)contextHeight, 0.1f, 100.0f);
            }

            gl.MatrixMode(MatrixMode.MODELVIEW);                         // Select The Modelview Matrix
            gl.LoadIdentity();

        }

        /// <summary>
        ///     Fit ortho to non rectangular container.
        /// </summary>
        protected void FitOrtho()
        {
            //MaxY = (MaxX - MinX) / 2.0F * heightFactor;
            //MinY = -MaxY;
        }

        public GLHeapData SetupGLDataLimits()
        {
            return new GLHeapData();
        }

        public GLUHeapData SetupGLUDataLimits()
        {
            return new GLUHeapData();
        }

        public GLUTHeapData SetupGLUTDataLimits()
        {
            return new GLUTHeapData();
        }
    }
}
