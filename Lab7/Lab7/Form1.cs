using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

using SharpGL;

namespace Lab7
{
    public partial class Form1 : Form
    {
        float angle = 0;
        float rotSpeed = 1;
        float[] lightPos0 = new float[] { 0.0f, 0.0f, -6.0f, 1.0f };

        //  The texture identifier.
        uint[] textures = new uint[1];

        //  Storage the texture itself.
        Bitmap textureImage;


        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs e)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();


            gl.PushMatrix();

            gl.Translate(0.0f, 0.0f, -6.0f);
            gl.Rotate(angle, 1.0f, 1.0f, 1.0f);

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, textures[0]);

            gl.Begin(OpenGL.GL_QUADS);
            gl.Normal(0.0f, 0.0f, -1.0f);
            // Front Face
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);	// Bottom Left Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, -1.0f, 1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);	// Top Left Of The Texture and Quad

                // Back Face
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);	// Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Right Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f);	// Bottom Left Of The Texture and Quad

                // Top Face
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);

                // Bottom Face
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);

                // Right face
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f);
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, 1.0f);
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, -1.0f);

                // Left Face
                gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);
                gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, 1.0f);
                gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);
                gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.End();
            gl.PopMatrix();

            gl.Flush();

            angle += rotSpeed; 
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;

            gl.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            gl.ClearDepth(1.0f);

            // Setup lightning
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_LIGHT0);
            gl.Enable(OpenGL.GL_LIGHT1);
            gl.Enable(OpenGL.GL_COLOR_MATERIAL);
            
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, new float[] { 0.8f, 0.8f, 0.8f});
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, new float[] { 1f, 1f, 1f });
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, lightPos0);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPOT_CUTOFF, 45);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPOT_EXPONENT, 15);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPOT_DIRECTION, new float[] { 1f, 1f, 1f });

            gl.Material(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_DIFFUSE, new float[] { 1, 1, 1, 1 });
            gl.Material(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_AMBIENT, new float[] { 1, 1, 1, 1 });
            
            textureImage = new Bitmap("texture.bmp");
            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //  Get one texture id, and stick it into the textures array.
            gl.GenTextures(1, textures);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, textures[0]);

            //  Set texture data.
            gl.TexImage2D(OpenGL.GL_TEXTURE_2D, 0, 3, textureImage.Width, textureImage.Height, 0, OpenGL.GL_BGR, OpenGL.GL_UNSIGNED_BYTE,
                textureImage.LockBits(new Rectangle(0, 0, textureImage.Width, textureImage.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0);

            //  Specify linear filtering.
            gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MIN_FILTER, OpenGL.GL_LINEAR);
            gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_LINEAR);
        }

        private void btnApplySpeed_Click(object sender, EventArgs e)
        {
            if(float.TryParse(tbRotSpeed.Text, out float val))
            {
                rotSpeed = val;
            }
            else
            {
                MessageBox.Show("Ўвидк≥сть обертанн€ повинна бути числом");
                tbRotSpeed.Text = rotSpeed.ToString();
            }
        }

        private void cbLightEnabled_CheckedChanged(object sender, EventArgs e)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;
            if (cbLightEnabled.Checked)
            {
                gl.Enable(OpenGL.GL_LIGHT0);
            }
            else
            {
                gl.Disable(OpenGL.GL_LIGHT0);
            }
        }
    }
}