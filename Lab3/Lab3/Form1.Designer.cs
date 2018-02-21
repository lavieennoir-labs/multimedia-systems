namespace Lab3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMinX = new System.Windows.Forms.TextBox();
            this.tbMaxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pMinXUnderline = new System.Windows.Forms.Panel();
            this.pMaxXUnderline = new System.Windows.Forms.Panel();
            this.openGLControl = new OpenGLWinControl.OpenGLControl();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFunc = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.pAUnderline = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApplyCoef = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblAngle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.pAngleUnderline = new System.Windows.Forms.Panel();
            this.btnTurn = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Інтервал відображення:";
            this.toolTip.SetToolTip(this.label1, "Межі по осі 0Х , у яких буде показано координатну площину.");
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(701, 50);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(165, 39);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ";";
            // 
            // tbMinX
            // 
            this.tbMinX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinX.Location = new System.Drawing.Point(22, 3);
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
            this.tbMaxX.Location = new System.Drawing.Point(97, 3);
            this.tbMaxX.MaximumSize = new System.Drawing.Size(50, 0);
            this.tbMaxX.MaxLength = 3;
            this.tbMaxX.MinimumSize = new System.Drawing.Size(15, 0);
            this.tbMaxX.Name = "tbMaxX";
            this.tbMaxX.Size = new System.Drawing.Size(50, 15);
            this.tbMaxX.TabIndex = 2;
            this.tbMaxX.TextChanged += new System.EventHandler(this.tbMaxX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "[";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "]";
            // 
            // btnRender
            // 
            this.btnRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRender.Location = new System.Drawing.Point(701, 95);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(190, 25);
            this.btnRender.TabIndex = 3;
            this.btnRender.Text = "Маштабувати";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(698, 281);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(193, 238);
            this.lblError.TabIndex = 1;
            // 
            // pMinXUnderline
            // 
            this.pMinXUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMinXUnderline.BackColor = System.Drawing.Color.ForestGreen;
            this.pMinXUnderline.Location = new System.Drawing.Point(722, 68);
            this.pMinXUnderline.Name = "pMinXUnderline";
            this.pMinXUnderline.Size = new System.Drawing.Size(50, 2);
            this.pMinXUnderline.TabIndex = 4;
            // 
            // pMaxXUnderline
            // 
            this.pMaxXUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pMaxXUnderline.BackColor = System.Drawing.Color.ForestGreen;
            this.pMaxXUnderline.Location = new System.Drawing.Point(795, 68);
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
            this.openGLControl.Size = new System.Drawing.Size(679, 506);
            this.openGLControl.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(698, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "(по осі 0Х)";
            this.toolTip.SetToolTip(this.label5, "Межі по осі 0Х , у яких буде показано координатну площину.");
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.BackColor = System.Drawing.Color.White;
            this.lblFunc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.Location = new System.Drawing.Point(15, 15);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(85, 16);
            this.lblFunc.TabIndex = 1;
            this.lblFunc.Text = "y = a * x^2";
            this.toolTip.SetToolTip(this.lblFunc, "Формула зображеного графіка функції.");
            // 
            // tbA
            // 
            this.tbA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(734, 153);
            this.tbA.MaximumSize = new System.Drawing.Size(100, 0);
            this.tbA.MaxLength = 20;
            this.tbA.MinimumSize = new System.Drawing.Size(15, 0);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 15);
            this.tbA.TabIndex = 2;
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // pAUnderline
            // 
            this.pAUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAUnderline.BackColor = System.Drawing.Color.ForestGreen;
            this.pAUnderline.Location = new System.Drawing.Point(734, 166);
            this.pAUnderline.Name = "pAUnderline";
            this.pAUnderline.Size = new System.Drawing.Size(100, 2);
            this.pAUnderline.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(698, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "a =";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(698, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Коефіцієнт функції:";
            this.toolTip.SetToolTip(this.label7, "Коефіцієнт а функціїї y = a * x^2.");
            // 
            // btnApplyCoef
            // 
            this.btnApplyCoef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyCoef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApplyCoef.Location = new System.Drawing.Point(701, 174);
            this.btnApplyCoef.Name = "btnApplyCoef";
            this.btnApplyCoef.Size = new System.Drawing.Size(190, 25);
            this.btnApplyCoef.TabIndex = 3;
            this.btnApplyCoef.Text = "Побудувати";
            this.btnApplyCoef.UseVisualStyleBackColor = true;
            this.btnApplyCoef.Click += new System.EventHandler(this.btnApplyCoef_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Повернути графік:";
            this.toolTip.SetToolTip(this.label8, "Повернути графік навколо центру координат проти годинникової стрілки.");
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 300;
            this.toolTip.ReshowDelay = 100;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.BackColor = System.Drawing.Color.White;
            this.lblAngle.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.Location = new System.Drawing.Point(14, 31);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(47, 19);
            this.lblAngle.TabIndex = 1;
            this.lblAngle.Text = "α = 0°";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(698, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "α =";
            // 
            // tbAngle
            // 
            this.tbAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAngle.Location = new System.Drawing.Point(734, 232);
            this.tbAngle.MaximumSize = new System.Drawing.Size(100, 0);
            this.tbAngle.MaxLength = 20;
            this.tbAngle.MinimumSize = new System.Drawing.Size(15, 0);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(100, 15);
            this.tbAngle.TabIndex = 2;
            this.tbAngle.TextChanged += new System.EventHandler(this.tbAngle_TextChanged);
            // 
            // pAngleUnderline
            // 
            this.pAngleUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAngleUnderline.BackColor = System.Drawing.Color.ForestGreen;
            this.pAngleUnderline.Location = new System.Drawing.Point(734, 245);
            this.pAngleUnderline.Name = "pAngleUnderline";
            this.pAngleUnderline.Size = new System.Drawing.Size(100, 2);
            this.pAngleUnderline.TabIndex = 4;
            // 
            // btnTurn
            // 
            this.btnTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTurn.Location = new System.Drawing.Point(702, 253);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(190, 25);
            this.btnTurn.TabIndex = 3;
            this.btnTurn.Text = "Повернути";
            this.btnTurn.UseVisualStyleBackColor = true;
            this.btnTurn.Click += new System.EventHandler(this.btnTurn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 530);
            this.Controls.Add(this.pAngleUnderline);
            this.Controls.Add(this.pAUnderline);
            this.Controls.Add(this.pMaxXUnderline);
            this.Controls.Add(this.pMinXUnderline);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.btnApplyCoef);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openGLControl);
            this.MinimumSize = new System.Drawing.Size(919, 550);
            this.Name = "Form1";
            this.Text = "Lab3";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Panel pAUnderline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApplyCoef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Panel pAngleUnderline;
        private System.Windows.Forms.Button btnTurn;
    }
}

