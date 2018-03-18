namespace Lab5
{
    partial class FigureInputForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblBaseR = new System.Windows.Forms.Label();
            this.tbBaseR = new System.Windows.Forms.TextBox();
            this.lblTopR = new System.Windows.Forms.Label();
            this.tbTopR = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.pColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(96, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Створити";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Конус",
            "Циліндр",
            "Конічний циліндр"});
            this.cbType.Location = new System.Drawing.Point(50, 12);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.Text = "Конічний циліндр";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Х :";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(109, 66);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(62, 20);
            this.tbX.TabIndex = 3;
            this.tbX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(109, 92);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(62, 20);
            this.tbY.TabIndex = 3;
            this.tbY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Z :";
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(109, 118);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(62, 20);
            this.tbZ.TabIndex = 3;
            this.tbZ.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Висота :";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(109, 144);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(62, 20);
            this.tbHeight.TabIndex = 3;
            this.tbHeight.Text = "1";
            // 
            // lblBaseR
            // 
            this.lblBaseR.AutoSize = true;
            this.lblBaseR.Location = new System.Drawing.Point(12, 173);
            this.lblBaseR.Name = "lblBaseR";
            this.lblBaseR.Size = new System.Drawing.Size(84, 13);
            this.lblBaseR.TabIndex = 2;
            this.lblBaseR.Text = "Радіус основи :";
            // 
            // tbBaseR
            // 
            this.tbBaseR.Location = new System.Drawing.Point(109, 170);
            this.tbBaseR.Name = "tbBaseR";
            this.tbBaseR.Size = new System.Drawing.Size(62, 20);
            this.tbBaseR.TabIndex = 3;
            this.tbBaseR.Text = "1";
            // 
            // lblTopR
            // 
            this.lblTopR.AutoSize = true;
            this.lblTopR.Location = new System.Drawing.Point(12, 199);
            this.lblTopR.Name = "lblTopR";
            this.lblTopR.Size = new System.Drawing.Size(91, 13);
            this.lblTopR.TabIndex = 2;
            this.lblTopR.Text = "Радіус верхівки :";
            // 
            // tbTopR
            // 
            this.tbTopR.Location = new System.Drawing.Point(109, 196);
            this.tbTopR.Name = "tbTopR";
            this.tbTopR.Size = new System.Drawing.Size(62, 20);
            this.tbTopR.TabIndex = 3;
            this.tbTopR.Text = "0.5";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 39);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 21);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Колір";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pColor
            // 
            this.pColor.BackColor = System.Drawing.Color.Black;
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(96, 39);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(75, 21);
            this.pColor.TabIndex = 5;
            // 
            // FigureInputForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(181, 259);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.tbTopR);
            this.Controls.Add(this.lblTopR);
            this.Controls.Add(this.tbBaseR);
            this.Controls.Add(this.lblBaseR);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 298);
            this.Name = "FigureInputForm";
            this.Text = "Нова фігура";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblBaseR;
        private System.Windows.Forms.TextBox tbBaseR;
        private System.Windows.Forms.Label lblTopR;
        private System.Windows.Forms.TextBox tbTopR;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel pColor;
    }
}