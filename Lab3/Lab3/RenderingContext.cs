using OpenGLWinControl.OpenGL;
using OpenGLWinControl.OpenGL.Enumerations.GL;
using OpenGLWinControl.OpenGL.Enumerations.GLUT;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class RenderingContext : IRenderingContext
    {
        byte[] axisColor = new byte[4];
        public Color AxisColor
        {
            get
            {
                return Color.FromArgb(
                    axisColor[3],
                    axisColor[0],
                    axisColor[1],
                    axisColor[2]);
            }
            set
            {
                axisColor[0] = value.R;
                axisColor[1] = value.G;
                axisColor[2] = value.B;
                axisColor[3] = value.A;
            }
        }

        byte[] gridColor = new byte[4];
        public Color GridColor
        {
            get
            {
                return Color.FromArgb(
                    gridColor[3],
                    gridColor[0],
                    gridColor[1],
                    gridColor[2]);
            }
            set
            {
                gridColor[0] = value.R;
                gridColor[1] = value.G;
                gridColor[2] = value.B;
                gridColor[3] = value.A;
            }
        }

        byte[] marksColor = new byte[4];
        public Color MarksColor
        {
            get
            {
                return Color.FromArgb(
                    marksColor[3],
                    marksColor[0],
                    marksColor[1],
                    marksColor[2]);
            }
            set
            {
                marksColor[0] = value.R;
                marksColor[1] = value.G;
                marksColor[2] = value.B;
                marksColor[3] = value.A;
            }
        }

        /// <summary>
        ///     Distance between lines in grid
        /// </summary>
        public float GridStep { get; set; }

        /// <summary>
        ///     Size of axis marks in uints.
        /// </summary>
        public float MarkSize { get; set; }

        /// <summary>
        ///     Value of coefitient 'a' in Function.
        /// </summary>
        public float FuncCoef { get; set; }


        public float rotationAngle;
        /// <summary>
        ///     Angle function chart is rotated
        /// </summary>
        public float RotationAngle
        {
            get => rotationAngle;
            set => rotationAngle = value % 360;
        }

        public float mirroringAngle;
        /// <summary>
        ///     Angle function chart is mirrored
        /// </summary>
        public float MirroringAngle
        {
            get => mirroringAngle;
            set => mirroringAngle = value % 360;
        }

        public float rotatePerFrameOZ;
        /// <summary>
        ///     Angle chart is rotating every frame around OZ axis
        /// </summary>
        public float RotatePerFrameOZ
        {
            get => rotatePerFrameOZ;
            set => rotatePerFrameOZ = value % 360;
        }

        public float rotatePerFrameOY;
        /// <summary>
        ///     Angle chart is rotating every frame around OY axis
        /// </summary>
        public float RotatePerFrameOY
        {
            get => rotatePerFrameOY;
            set => rotatePerFrameOY = value % 360;
        }

        public float ChartFixMultiplier { get; set; } = 100;

        /// <summary>
        ///     Set to true to invoke update scene ortho.
        /// </summary>
        public bool GridResized { get; set; } = false;

        /// <summary>
        ///     Function, that will be drawn.
        ///     First argment is X.
        ///     Second argument is A.
        /// </summary>
        public Func<float , float, float> Function { get; set; }

        //ortho
        public float MinX { get; set; }
        public float MaxX { get; set; }
        public float MinY { get; protected set; }
        public float MaxY { get; protected set; }

        public float MinAvailableX { get; set; }
        public float MaxAvailableX { get; set; }
        public float MinAvailableY { get => MinAvailableX * heightFactor; }
        public float MaxAvailableY { get => MaxAvailableX * heightFactor; }

        //size
        int width;
        int height;
        float heightFactor { get => height / (float)width; }

        public void Init(int contextWidth, int contextHeight)
        {
            //upadte size
            width = contextWidth;
            height = contextHeight;
            //calculate grid step and mark size
            var pixelsPerUnit = width / (MaxX - MinX);
            GridStep = GetGridStep(pixelsPerUnit);
            MarkSize = GetMarkSize(pixelsPerUnit);

            GL.ClearColor(1, 1, 1, 0);
            GL.MatrixMode(MatrixMode.PROJECTION);
            GL.LineWidth(2.0F);

            GL.Viewport(0, 0, (uint)contextWidth, (uint)contextHeight);

            FitOrtho();
            GL.Ortho(MinX, MaxX, MinY, MaxY, ChartFixMultiplier * MinX, ChartFixMultiplier * MaxX);
        }

        public void Render(int contextWidth, int contextHeight)
        {
            GL.Clear(ClearAttributeMask.COLOR_BUFFER_BIT);

            if (GridResized)
            {
                Resize(contextWidth, contextHeight);
                GridResized = false;
            }

            DrawGrid();
            DrawAxis();
            DrawFunction();
            DrawMarks();

            RotationAngle += RotatePerFrameOZ;
            MirroringAngle += RotatePerFrameOY;
        }

        public void Resize(int contextWidth, int contextHeight)
        {
            //upadte size
            width = contextWidth;
            height = contextHeight;

            GL.LoadIdentity();
            GL.Viewport(0, 0, (uint)contextWidth, (uint)contextHeight);

            FitOrtho();
            GL.Ortho(MinX, MaxX, MinY, MaxY, ChartFixMultiplier * MinX, ChartFixMultiplier * MaxX);

            //calculate grid step and mark size
            var pixelsPerUnit = width / (MaxX - MinX);
            GridStep = GetGridStep(pixelsPerUnit);
            MarkSize = GetMarkSize(pixelsPerUnit);
        }

        /// <summary>
        ///     Fit ortho to non rectangular container.
        /// </summary>
        protected void FitOrtho()
        {
            MaxY = (MaxX - MinX) / 2.0F * heightFactor;
            MinY = -MaxY;
        }

        #region Rendering functions

        protected void DrawAxis()
        {

            GL.LineWidth(2.0F);
            GL.Color4(axisColor);

            GL.Begin(BeginMode.LINES);
            //axis y
                GL.Vertex2(MinAvailableX, 0);
                GL.Vertex2(MaxAvailableX, 0);
            //axis x
                GL.Vertex2(0, MinAvailableY);
                GL.Vertex2(0, MaxAvailableY); 
            GL.End();

            GL.LineWidth(1.0F);

            GL.PushMatrix();
            GL.Translate(0, MaxY, 0);
            GL.Scale(MarkSize, MarkSize, 0);

            GL.Begin(BeginMode.TRIANGLES);
                //y
                GL.Vertex2(0, 0);
                GL.Vertex2(0.8F, -2);
                GL.Vertex2(-0.8F, -2);
            GL.End();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(MaxX, 0, 0);
            GL.Scale(MarkSize, MarkSize, 0);
            GL.Begin(BeginMode.TRIANGLES);
                //x
                GL.Vertex2(0, 0);
                GL.Vertex2(-2, 0.8F);
                GL.Vertex2(-2, -0.8F);
            GL.End();
            GL.PopMatrix();
        }

        protected void DrawGrid()
        {
            GL.LineWidth(0.5F);
            GL.Color4(gridColor);

            GL.Begin(BeginMode.LINES);
            //vertical lines
            for (float i = GridStep; i < MaxAvailableX; i += GridStep)
            {
                GL.Vertex2(i, MinAvailableY);
                GL.Vertex2(i, MaxAvailableY);
            }
            for (float i = GridStep; i > MinAvailableX; i -= GridStep)
            {
                GL.Vertex2(i, MinAvailableY);
                GL.Vertex2(i, MaxAvailableY);
            }

            //horizontal lines
            for (float i = GridStep; i < MaxAvailableY; i += GridStep)
            {
                GL.Vertex2(MinAvailableX, i);
                GL.Vertex2(MaxAvailableX, i);
            }
            for (float i = GridStep; i > MinAvailableY; i -= GridStep)
            {
                GL.Vertex2(MinAvailableX, i);
                GL.Vertex2(MaxAvailableX, i);
            }
            GL.End();

            GL.LineWidth(1.0F);
        }

        /// <summary>
        ///     Draws chart of function defined by Function property.
        /// </summary>
        protected void DrawFunction()
        {
            int vertextesPerUnit = (int)(128 / (MaxX - MinX) + 2);
            float step = 1.0F / vertextesPerUnit;

            float y;
            GL.LineWidth(2.0F);
            GL.PushMatrix();
            GL.Rotate(RotationAngle, 0, 0, 1);
            //mirror
            GL.Rotate(MirroringAngle, 0, 1, 0);
            GL.Begin(BeginMode.LINE_STRIP);

            for(float x = -ChartFixMultiplier * MaxX; x <= -ChartFixMultiplier * MinX; x+= step)
            {
                //fix zero vertex
                if(x > 0 && x - step < 0)
                {
                    y = Function(0, FuncCoef);
                    GL.Color3(GetColor3ByY(y));
                    GL.Vertex2(0, y);
                }
                y = Function(x, FuncCoef);
                GL.Color3(GetColor3ByY(y));
                GL.Vertex2(x, y);
            }

            GL.End();
            GL.PopMatrix();
            GL.LineWidth(1.0F);
        }

        /// <summary>
        ///     Calculates color to paint vertex depending on it`s Y position.
        /// </summary>
        /// <param name="y">Y coordinate of point will be colored</param>
        /// <returns>Byte array that represents RGB color</returns>
        protected byte[] GetColor3ByY(float y)
        {
            int huePerColor = 256;
            float scale = 1F;

            double rShift = 7 * Math.PI / 6;
            double gShift = -Math.PI / 2;
            double bShift = Math.PI / 2;

            //values in range [-1; 1]
            double r = (Math.Sin(y * scale - rShift) % huePerColor);
            double g = (Math.Sin(y * scale - gShift) % huePerColor);
            double b = (Math.Sin(y * scale - bShift) % huePerColor);

            //scaling to [0; 255]
            return new byte[] { (byte)((r + 1) * 127.5), (byte)((g + 1) * 127.5), (byte)((b + 1) * 127.5)};
        }


        protected void DrawMarks()
        {
            GL.Color4(marksColor);
            
            //horizontal marks
            for (float i = GridStep; i < MaxAvailableX; i += GridStep)
                DrawMark(i, 0, i);
            for (float i = GridStep; i > MinAvailableX; i -= GridStep)
                DrawMark(i, 0, i);

            //vertical marks
            for (float i = GridStep; i < MaxAvailableY; i += GridStep)
                DrawMark(0, i, i);
            for (float i = GridStep; i > MinAvailableY; i -= GridStep)
                DrawMark(0, i, i);

            //x and y marks
            DrawMark(MaxX - 2 * MarkSize, MarkSize / 2, "x", true, 1.5F);
            DrawMark(MarkSize / 2, MaxY - 2 * MarkSize, "y", true, 1.5F);

        }

        /// <summary>
        ///     Draws mark in the scene in position defined by parameters
        /// </summary>
        /// <param name="mark">Value to be drawn.</param>
        private void DrawMark(float x, float y, object mark, bool isAxisName = false, float scale = 1)
        {
            GL.PushMatrix();

            float offset = MarkSize / 3; // used because marks were intersecting with axises

            if (isAxisName)
                GL.Translate(
                 x + offset,
                 y + offset, 0);
            else
                GL.Translate(
                x - mark.ToString().Length * MarkSize - offset, 
                //set vertical marks left from y axis
                y - MarkSize - offset, 0);
                //set horisontal marks under x axis

            GL.Scale(0.01, 0.01, 1.0); // 0.01 - scale to 1x1 size
            GL.Scale(MarkSize * scale, MarkSize * scale, 1.0);

            foreach (var c in mark.ToString())
                GLUT.StrokeCharacter(StrokeFont.STROKE_ROMAN, c);

            GL.PopMatrix();
        }
        #endregion

        private int GetGridStep(float pixelsPerUnit)
        {
            const int scaleFactor = 28;
            int step = (int)Math.Round(scaleFactor / pixelsPerUnit);
            return step <= 0 ? 1 : step;
        }

        private float GetMarkSize(float pixelsPerUnit)
        {
            //if (pixelsPerUnit > 25)
            //    return 0.25F;
            //else if (pixelsPerUnit > 15)
            //    return 0.4F;
            //else if (pixelsPerUnit > 10)
            //    return 0.7F;
            //else if (pixelsPerUnit > 7)
            //    return 1.1F;
            //else if (pixelsPerUnit > 5)
            //    return 1.7F;
            //else if (pixelsPerUnit > 4)
            //    return 2.6F;
            //else if (pixelsPerUnit > 3)
            //    return 3.6F;
            //else if (pixelsPerUnit > 2)
            //    return 4.7F;
            //else if (pixelsPerUnit > 1)
            //    return 5.9F;
            //else
            //    return 7.2F;
            float scale = (float)(0.1085463 + (7.682735 - 0.1085463) / 
                (1 + Math.Pow(pixelsPerUnit / 2.270442, 1.677812))); //aproximated curve
            return scale;
        }
    }
}
