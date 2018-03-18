namespace Lab5
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
            this.gbPolyMode = new System.Windows.Forms.GroupBox();
            this.rbPolyModeFill = new System.Windows.Forms.RadioButton();
            this.rbPolyModeLine = new System.Windows.Forms.RadioButton();
            this.gbSmoothMode = new System.Windows.Forms.GroupBox();
            this.rbSmoothModeSmooth = new System.Windows.Forms.RadioButton();
            this.rbSmoothModeFlat = new System.Windows.Forms.RadioButton();
            this.gbProjection = new System.Windows.Forms.GroupBox();
            this.rbProjectionPerspective = new System.Windows.Forms.RadioButton();
            this.rbProjectionOrtho = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.openGLControl = new OpenGLWinControl.OpenGLControl();
            this.gbPolyMode.SuspendLayout();
            this.gbSmoothMode.SuspendLayout();
            this.gbProjection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPolyMode
            // 
            this.gbPolyMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPolyMode.Controls.Add(this.rbPolyModeFill);
            this.gbPolyMode.Controls.Add(this.rbPolyModeLine);
            this.gbPolyMode.Location = new System.Drawing.Point(534, 12);
            this.gbPolyMode.Name = "gbPolyMode";
            this.gbPolyMode.Size = new System.Drawing.Size(138, 68);
            this.gbPolyMode.TabIndex = 1;
            this.gbPolyMode.TabStop = false;
            this.gbPolyMode.Text = "Відображення об\'єктів";
            // 
            // rbPolyModeFill
            // 
            this.rbPolyModeFill.AutoSize = true;
            this.rbPolyModeFill.Location = new System.Drawing.Point(6, 42);
            this.rbPolyModeFill.Name = "rbPolyModeFill";
            this.rbPolyModeFill.Size = new System.Drawing.Size(118, 17);
            this.rbPolyModeFill.TabIndex = 1;
            this.rbPolyModeFill.Text = "Зафарбовані грані";
            this.rbPolyModeFill.UseVisualStyleBackColor = true;
            this.rbPolyModeFill.CheckedChanged += new System.EventHandler(this.rbPolyModeFill_CheckedChanged);
            // 
            // rbPolyModeLine
            // 
            this.rbPolyModeLine.AutoSize = true;
            this.rbPolyModeLine.Checked = true;
            this.rbPolyModeLine.Location = new System.Drawing.Point(6, 19);
            this.rbPolyModeLine.Name = "rbPolyModeLine";
            this.rbPolyModeLine.Size = new System.Drawing.Size(70, 17);
            this.rbPolyModeLine.TabIndex = 0;
            this.rbPolyModeLine.TabStop = true;
            this.rbPolyModeLine.Text = "Каркасні";
            this.rbPolyModeLine.UseVisualStyleBackColor = true;
            this.rbPolyModeLine.CheckedChanged += new System.EventHandler(this.rbPolyModeLine_CheckedChanged);
            // 
            // gbSmoothMode
            // 
            this.gbSmoothMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSmoothMode.Controls.Add(this.rbSmoothModeSmooth);
            this.gbSmoothMode.Controls.Add(this.rbSmoothModeFlat);
            this.gbSmoothMode.Location = new System.Drawing.Point(534, 161);
            this.gbSmoothMode.Name = "gbSmoothMode";
            this.gbSmoothMode.Size = new System.Drawing.Size(138, 68);
            this.gbSmoothMode.TabIndex = 1;
            this.gbSmoothMode.TabStop = false;
            this.gbSmoothMode.Text = "Зафарбовування граней";
            this.gbSmoothMode.Visible = false;
            // 
            // rbSmoothModeSmooth
            // 
            this.rbSmoothModeSmooth.AutoSize = true;
            this.rbSmoothModeSmooth.Location = new System.Drawing.Point(6, 42);
            this.rbSmoothModeSmooth.Name = "rbSmoothModeSmooth";
            this.rbSmoothModeSmooth.Size = new System.Drawing.Size(101, 17);
            this.rbSmoothModeSmooth.TabIndex = 1;
            this.rbSmoothModeSmooth.Text = "Інтерполяційне";
            this.rbSmoothModeSmooth.UseVisualStyleBackColor = true;
            this.rbSmoothModeSmooth.CheckedChanged += new System.EventHandler(this.rbSmoothModeSmooth_CheckedChanged);
            // 
            // rbSmoothModeFlat
            // 
            this.rbSmoothModeFlat.AutoSize = true;
            this.rbSmoothModeFlat.Checked = true;
            this.rbSmoothModeFlat.Location = new System.Drawing.Point(6, 19);
            this.rbSmoothModeFlat.Name = "rbSmoothModeFlat";
            this.rbSmoothModeFlat.Size = new System.Drawing.Size(63, 17);
            this.rbSmoothModeFlat.TabIndex = 0;
            this.rbSmoothModeFlat.TabStop = true;
            this.rbSmoothModeFlat.Text = "Плоске";
            this.rbSmoothModeFlat.UseVisualStyleBackColor = true;
            this.rbSmoothModeFlat.CheckedChanged += new System.EventHandler(this.rbSmoothModeFlat_CheckedChanged);
            // 
            // gbProjection
            // 
            this.gbProjection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProjection.Controls.Add(this.rbProjectionPerspective);
            this.gbProjection.Controls.Add(this.rbProjectionOrtho);
            this.gbProjection.Location = new System.Drawing.Point(534, 86);
            this.gbProjection.Name = "gbProjection";
            this.gbProjection.Size = new System.Drawing.Size(138, 68);
            this.gbProjection.TabIndex = 1;
            this.gbProjection.TabStop = false;
            this.gbProjection.Text = "Проекція";
            // 
            // rbProjectionPerspective
            // 
            this.rbProjectionPerspective.AutoSize = true;
            this.rbProjectionPerspective.Location = new System.Drawing.Point(6, 42);
            this.rbProjectionPerspective.Name = "rbProjectionPerspective";
            this.rbProjectionPerspective.Size = new System.Drawing.Size(98, 17);
            this.rbProjectionPerspective.TabIndex = 1;
            this.rbProjectionPerspective.Text = "Перспективна";
            this.rbProjectionPerspective.UseVisualStyleBackColor = true;
            this.rbProjectionPerspective.CheckedChanged += new System.EventHandler(this.rbProjectionPerspective_CheckedChanged);
            // 
            // rbProjectionOrtho
            // 
            this.rbProjectionOrtho.AutoSize = true;
            this.rbProjectionOrtho.Checked = true;
            this.rbProjectionOrtho.Location = new System.Drawing.Point(6, 19);
            this.rbProjectionOrtho.Name = "rbProjectionOrtho";
            this.rbProjectionOrtho.Size = new System.Drawing.Size(97, 17);
            this.rbProjectionOrtho.TabIndex = 0;
            this.rbProjectionOrtho.TabStop = true;
            this.rbProjectionOrtho.Text = "Ортогональна";
            this.rbProjectionOrtho.UseVisualStyleBackColor = true;
            this.rbProjectionOrtho.CheckedChanged += new System.EventHandler(this.rbProjectionOrtho_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(534, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистити сцену";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(534, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати фігуру";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.AutoRefresh = true;
            this.openGLControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openGLControl.Location = new System.Drawing.Point(12, 12);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.RefreshInterval = 33;
            this.openGLControl.RenderingContext = null;
            this.openGLControl.Size = new System.Drawing.Size(516, 287);
            this.openGLControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 308);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbProjection);
            this.Controls.Add(this.gbSmoothMode);
            this.Controls.Add(this.gbPolyMode);
            this.Controls.Add(this.openGLControl);
            this.MinimumSize = new System.Drawing.Size(700, 347);
            this.Name = "Form1";
            this.Text = "Lab5";
            this.gbPolyMode.ResumeLayout(false);
            this.gbPolyMode.PerformLayout();
            this.gbSmoothMode.ResumeLayout(false);
            this.gbSmoothMode.PerformLayout();
            this.gbProjection.ResumeLayout(false);
            this.gbProjection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenGLWinControl.OpenGLControl openGLControl;
        private System.Windows.Forms.GroupBox gbPolyMode;
        private System.Windows.Forms.RadioButton rbPolyModeFill;
        private System.Windows.Forms.RadioButton rbPolyModeLine;
        private System.Windows.Forms.GroupBox gbSmoothMode;
        private System.Windows.Forms.RadioButton rbSmoothModeSmooth;
        private System.Windows.Forms.RadioButton rbSmoothModeFlat;
        private System.Windows.Forms.GroupBox gbProjection;
        private System.Windows.Forms.RadioButton rbProjectionPerspective;
        private System.Windows.Forms.RadioButton rbProjectionOrtho;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
    }
}

