namespace GraphicsLab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.task1Button = new System.Windows.Forms.Button();
            this.task2Button = new System.Windows.Forms.Button();
            this.task3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task1Button
            // 
            this.task1Button.Location = new System.Drawing.Point(32, 373);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(75, 23);
            this.task1Button.TabIndex = 0;
            this.task1Button.Text = "task1";
            this.task1Button.UseVisualStyleBackColor = true;
            // 
            // task2Button
            // 
            this.task2Button.Location = new System.Drawing.Point(337, 373);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(75, 23);
            this.task2Button.TabIndex = 1;
            this.task2Button.Text = "task2";
            this.task2Button.UseVisualStyleBackColor = true;
            // 
            // task3Button
            // 
            this.task3Button.Location = new System.Drawing.Point(658, 373);
            this.task3Button.Name = "task3Button";
            this.task3Button.Size = new System.Drawing.Size(75, 23);
            this.task3Button.TabIndex = 2;
            this.task3Button.Text = "task3";
            this.task3Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task3Button);
            this.Controls.Add(this.task2Button);
            this.Controls.Add(this.task1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.Button task3Button;
    }
}

