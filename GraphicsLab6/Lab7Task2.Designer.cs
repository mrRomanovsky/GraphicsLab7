namespace GraphicsLab6
{
    partial class Lab7Task2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countPoints = new System.Windows.Forms.TextBox();
            this.listPoints = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countParts = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.build = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во точек образующей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список точек образующей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ось вращения";
            // 
            // countPoints
            // 
            this.countPoints.Location = new System.Drawing.Point(63, 55);
            this.countPoints.Name = "countPoints";
            this.countPoints.Size = new System.Drawing.Size(136, 20);
            this.countPoints.TabIndex = 3;
            this.countPoints.Text = "2";
            // 
            // listPoints
            // 
            this.listPoints.Location = new System.Drawing.Point(63, 118);
            this.listPoints.Multiline = true;
            this.listPoints.Name = "listPoints";
            this.listPoints.Size = new System.Drawing.Size(136, 70);
            this.listPoints.TabIndex = 4;
            this.listPoints.Text = "0,0,0; 0,0,1;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во разбиений";
            // 
            // countParts
            // 
            this.countParts.Location = new System.Drawing.Point(270, 135);
            this.countParts.Name = "countParts";
            this.countParts.Size = new System.Drawing.Size(95, 20);
            this.countParts.TabIndex = 6;
            this.countParts.Text = "2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ox",
            "Oy",
            "Oz"});
            this.listBox1.Location = new System.Drawing.Point(270, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(95, 43);
            this.listBox1.TabIndex = 7;
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(184, 250);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(75, 23);
            this.build.TabIndex = 8;
            this.build.Text = "Построить";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // Lab7Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 301);
            this.Controls.Add(this.build);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.countParts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listPoints);
            this.Controls.Add(this.countPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab7Task2";
            this.Text = "Lab7Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countPoints;
        private System.Windows.Forms.TextBox listPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countParts;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button build;
    }
}