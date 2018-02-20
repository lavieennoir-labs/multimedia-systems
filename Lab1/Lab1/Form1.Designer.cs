namespace Lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinX = new System.Windows.Forms.TextBox();
            this.tbMaxX = new System.Windows.Forms.TextBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pMinXUnderline = new System.Windows.Forms.Panel();
            this.pMaxXUnderline = new System.Windows.Forms.Panel();
            this.openGLControl = new OpenGLWinControl.OpenGLControl();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Інтервал відображення:";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.tbMinX, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tbMaxX, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(614, 33);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(165, 39);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "[";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ";";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "]";
            // 
            // tbMinX
            // 
            this.tbMinX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinX.Location = new System.Drawing.Point(21, 3);
            this.tbMinX.MaximumSize = new System.Drawing.Size(50, 0);
            this.tbMinX.MaxLength = 3;
            this.tbMinX.MinimumSize = new System.Drawing.Size(15, 0);
            this.tbMinX.Name = "tbMinX";
            this.tbMinX.Size = new System.Drawing.Size(50, 15);
            this.tbMinX.TabIndex = 2;
            this.tbMinX.TextChanged += new System.EventHandler(this.tbMinX_TextChanged);
            // 
            // tbMaxX
            // 
            this.tbMaxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxX.Location = new System.Drawing.Point(94, 3);
            this.tbMaxX.MaximumSize = new System.Drawing.Size(50, 0);
            this.tbMaxX.MaxLength = 3;
            this.tbMaxX.MinimumSize = new System.Drawing.Size(15, 0);
            this.tbMaxX.Name = "tbMaxX";
            this.tbMaxX.Size = new System.Drawing.Size(50, 15);
            this.tbMaxX.TabIndex = 2;
            this.tbMaxX.TextChanged += new System.EventHandler(this.tbMaxX_TextChanged);
            // 
            // btnRender
            // 
            this.btnRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRender.Location = new System.Drawing.Point(611, 78);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(193, 29);
            this.btnRender.TabIndex = 3;
            this.btnRender.Text = "Побудувати";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(611, 110);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(193, 294);
            this.lblError.TabIndex = 1;
            // 
            // pMinXUnderline
            // 
            this.pMinXUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMinXUnderline.BackColor = System.Drawing.Color.ForestGreen;
            this.pMinXUnderline.Location = new System.Drawing.Point(635, 51);
            this.pMinXUnderline.Name = "pMinXUnderline";
            this.pMinXUnderline.Size = new System.Drawing.Size(50, 2);
            this.pMinXUnderline.TabIndex = 4;
            // 
            // pMaxXUnderline
            // 
            this.pMaxXUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMaxXUnderline.BackColor = System.Drawing.Color.ForestGreen;
            this.pMaxXUnderline.Location = new System.Drawing.Point(708, 51);
            this.pMaxXUnderline.Name = "pMaxXUnderline";
            this.pMaxXUnderline.Size = new System.Drawing.Size(50, 2);
            this.pMaxXUnderline.TabIndex = 4;
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.AutoRefresh = true;
            this.openGLControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openGLControl.Location = new System.Drawing.Point(13, 13);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.RefreshInterval = 1;
            this.openGLControl.RenderingContext = null;
            this.openGLControl.Size = new System.Drawing.Size(592, 391);
            this.openGLControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 415);
            this.Controls.Add(this.pMaxXUnderline);
            this.Controls.Add(this.pMinXUnderline);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openGLControl);
            this.MinimumSize = new System.Drawing.Size(540, 363);
            this.Name = "Form1";
            this.Text = "Lab1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenGLWinControl.OpenGLControl openGLControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinX;
        private System.Windows.Forms.TextBox tbMaxX;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pMinXUnderline;
        private System.Windows.Forms.Panel pMaxXUnderline;
    }
}

