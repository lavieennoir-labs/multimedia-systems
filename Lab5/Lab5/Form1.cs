using OpenGLWinControl.OpenGL.Enumerations.GL;
using OpenGLWinControl.OpenGL.Enumerations.GLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        RenderingContext renderingContext;

        public Form1()
        {
            InitializeComponent();

            //init render
            renderingContext = new RenderingContext
            {
                SmoothMode = ShadingModel.FLAT,
                PolyMode = PolygonMode.LINE,
                UseOrthoProjection = true,
                Figures = new List<Figure>
                {
                    new Figure
                    {
                        Type = Figure.FigureType.ConicCylinder,
                        Color = Color.Red,
                        BaseRadius = 2,
                        TopRadius = 1,
                        Height = 2                     
                    }
                }
            };
            openGLControl.RenderingContext = renderingContext;
            
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            renderingContext.GridResized = true;

            openGLControl.Render();
        }
        

        #region form handlers
        private void rbPolyModeLine_CheckedChanged(object sender, EventArgs e)
        {
            (openGLControl.RenderingContext as RenderingContext).
                PolyMode = PolygonMode.LINE;
        }

        private void rbPolyModeFill_CheckedChanged(object sender, EventArgs e)
        {
            (openGLControl.RenderingContext as RenderingContext).
                PolyMode = PolygonMode.FILL;
        }

        private void rbSmoothModeFlat_CheckedChanged(object sender, EventArgs e)
        {
            (openGLControl.RenderingContext as RenderingContext).
                SmoothMode = ShadingModel.FLAT;
        }

        private void rbSmoothModeSmooth_CheckedChanged(object sender, EventArgs e)
        {
            (openGLControl.RenderingContext as RenderingContext).
                SmoothMode = ShadingModel.SMOOTH;
        }

        private void rbProjectionOrtho_CheckedChanged(object sender, EventArgs e)
        {
            var context = (openGLControl.RenderingContext as RenderingContext);
            context.UseOrthoProjection = true;
            context.GridResized = true;
        }

        private void rbProjectionPerspective_CheckedChanged(object sender, EventArgs e)
        {
            var context = (openGLControl.RenderingContext as RenderingContext);
            context.UseOrthoProjection = false;
            context.GridResized = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            (openGLControl.RenderingContext as RenderingContext).
                Figures.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FigureInputForm();
                form.Show();
            form.FigureCreated += (obj, figure) =>
                (openGLControl.RenderingContext as RenderingContext).
                    Figures.Add(figure);
        }
        #endregion
    }
}
