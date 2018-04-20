namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRotSpeed = new System.Windows.Forms.TextBox();
            this.btnApplySpeed = new System.Windows.Forms.Button();
            this.cbLightEnabled = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.FrameRate = 28;
            this.openGLControl1.Location = new System.Drawing.Point(12, 12);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(400, 400);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Швидкість обертання";
            // 
            // tbRotSpeed
            // 
            this.tbRotSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotSpeed.Location = new System.Drawing.Point(421, 28);
            this.tbRotSpeed.Name = "tbRotSpeed";
            this.tbRotSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbRotSpeed.TabIndex = 2;
            this.tbRotSpeed.Text = "1";
            // 
            // btnApplySpeed
            // 
            this.btnApplySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplySpeed.Location = new System.Drawing.Point(421, 54);
            this.btnApplySpeed.Name = "btnApplySpeed";
            this.btnApplySpeed.Size = new System.Drawing.Size(100, 23);
            this.btnApplySpeed.TabIndex = 3;
            this.btnApplySpeed.Text = "Застосувати";
            this.btnApplySpeed.UseVisualStyleBackColor = true;
            this.btnApplySpeed.Click += new System.EventHandler(this.btnApplySpeed_Click);
            // 
            // cbLightEnabled
            // 
            this.cbLightEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLightEnabled.AutoSize = true;
            this.cbLightEnabled.Checked = true;
            this.cbLightEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLightEnabled.Location = new System.Drawing.Point(421, 91);
            this.cbLightEnabled.Name = "cbLightEnabled";
            this.cbLightEnabled.Size = new System.Drawing.Size(135, 17);
            this.cbLightEnabled.TabIndex = 4;
            this.cbLightEnabled.Text = "Ввімкнути освітлення";
            this.cbLightEnabled.UseVisualStyleBackColor = true;
            this.cbLightEnabled.CheckedChanged += new System.EventHandler(this.cbLightEnabled_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(421, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 2);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbLightEnabled);
            this.Controls.Add(this.btnApplySpeed);
            this.Controls.Add(this.tbRotSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openGLControl1);
            this.MinimumSize = new System.Drawing.Size(563, 463);
            this.Name = "Form1";
            this.Text = "Lab7";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRotSpeed;
        private System.Windows.Forms.Button btnApplySpeed;
        private System.Windows.Forms.CheckBox cbLightEnabled;
        private System.Windows.Forms.Panel panel1;
    }
}

