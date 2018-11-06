namespace GraphicsLab6
{
    partial class Lab7task3
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
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.checkBoxSinCos = new System.Windows.Forms.CheckBox();
            this.checkBoxXXYY = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAbs = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(250, 24);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 0;
            this.textBoxX1.Text = "-10";
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(250, 67);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 20);
            this.textBoxY1.TabIndex = 1;
            this.textBoxY1.Text = "-10";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(356, 24);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 2;
            this.textBoxX2.Text = "10";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(356, 67);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 20);
            this.textBoxY2.TabIndex = 3;
            this.textBoxY2.Text = "10";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(462, 24);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStep.TabIndex = 4;
            this.textBoxStep.Text = "1";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(462, 67);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 20);
            this.buttonDraw.TabIndex = 5;
            this.buttonDraw.Text = "Draw!";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // checkBoxSinCos
            // 
            this.checkBoxSinCos.AutoSize = true;
            this.checkBoxSinCos.Location = new System.Drawing.Point(48, 67);
            this.checkBoxSinCos.Name = "checkBoxSinCos";
            this.checkBoxSinCos.Size = new System.Drawing.Size(82, 17);
            this.checkBoxSinCos.TabIndex = 6;
            this.checkBoxSinCos.Text = "sin(x)*cos(y)";
            this.checkBoxSinCos.UseVisualStyleBackColor = true;
            // 
            // checkBoxXXYY
            // 
            this.checkBoxXXYY.AutoSize = true;
            this.checkBoxXXYY.Location = new System.Drawing.Point(48, 24);
            this.checkBoxXXYY.Name = "checkBoxXXYY";
            this.checkBoxXXYY.Size = new System.Drawing.Size(72, 17);
            this.checkBoxXXYY.TabIndex = 7;
            this.checkBoxXXYY.Text = "x^2 + y^2";
            this.checkBoxXXYY.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(148, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "???";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbs
            // 
            this.checkBoxAbs.AutoSize = true;
            this.checkBoxAbs.Location = new System.Drawing.Point(148, 24);
            this.checkBoxAbs.Name = "checkBoxAbs";
            this.checkBoxAbs.Size = new System.Drawing.Size(91, 17);
            this.checkBoxAbs.TabIndex = 9;
            this.checkBoxAbs.Text = "abs(x) - abs(y)";
            this.checkBoxAbs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Step";
            // 
            // Lab7task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 113);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAbs);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBoxXXYY);
            this.Controls.Add(this.checkBoxSinCos);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Name = "Lab7task3";
            this.Text = "Lab7task3";
            this.Load += new System.EventHandler(this.Lab7task3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.CheckBox checkBoxSinCos;
        private System.Windows.Forms.CheckBox checkBoxXXYY;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxAbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}