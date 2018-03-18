using OpenGLWinControl.OpenGL;
using OpenGLWinControl.OpenGL.Enumerations.GLU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Figure : IDisposable
    {
        /// <summary>
        ///     Avaliable shapes
        /// </summary>
        public enum FigureType
        {
            [Description("Конус")]
            Cone,
            [Description("Циліндр")]
            Cylinder,
            [Description("Конічний циліндр")]
            ConicCylinder
        }

        public GLU.Quadric Quadric;

        public Color Color { get; set; }

        public FigureType Type { get; set; }
        public QuadricDrawStyle Style { get; set; } = QuadricDrawStyle.FILL;
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double BaseRadius { get; set; }

        public double topRadius;
        public double TopRadius
        {
            get => 
                this.Type == FigureType.Cone ? 0 : 
                this.Type == FigureType.Cylinder ? BaseRadius : 
                topRadius;
            set => topRadius = value;
        }
        public double Height { get; set; }

        /// <summary>
        /// The number of subdivisions around the z-axis.
        /// </summary>
        public int Slices { get; set; } = 10;
        /// <summary>
        /// The number of subdivisions along the z-axis.
        /// </summary>
        public int Stacks { get; set; } = 1;

        /// <summary>
        ///     Generates Quadric object
        /// </summary>
        /// <param name="glu"></param>
        public void Generate(GLU glu)
        {
            this.glu = glu;
            if (Quadric != null)
            {
                glu.DeleteQuadric(Quadric);
                Quadric = null;
            }
            Quadric = glu.NewQuadric();
        }

        GLU glu;
        public void Draw(GL gl, GLU glu)
        {
            this.glu = glu;
            gl.PushMatrix();

            gl.Translate(X, Y, Z);

            gl.Color4(Color.R, Color.G, Color.B, Color.A);
            glu.QuadricDrawStyle(Quadric, Style);
            glu.Cylinder(Quadric, BaseRadius, TopRadius, 
                Height, Slices, Stacks);
            glu.Disk(Quadric, 0, BaseRadius,
                Slices, 1);
            if(TopRadius != 0)
            {
                gl.Translate(0, 0, Height);
                glu.Disk(Quadric, 0, TopRadius,
                    Slices, 1);
            }

            gl.PopMatrix();
        }

        public void Dispose()
        {
            if (Quadric != null)
            {
                glu.DeleteQuadric(Quadric);
                Quadric = null;
            }
        }

        ~Figure()
        {
            if (Quadric != null)
            {
                glu.DeleteQuadric(Quadric);
                Quadric = null;
            }
        }
    }
}
