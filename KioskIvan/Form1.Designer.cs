namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAverageColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRValue = new System.Windows.Forms.Label();
            this.labelGValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 376);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(673, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(410, 376);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(137, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAverageColor
            // 
            this.labelAverageColor.AutoSize = true;
            this.labelAverageColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAverageColor.Location = new System.Drawing.Point(795, 31);
            this.labelAverageColor.Name = "labelAverageColor";
            this.labelAverageColor.Size = new System.Drawing.Size(181, 31);
            this.labelAverageColor.TabIndex = 3;
            this.labelAverageColor.Text = "Average color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(679, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "R:";
            // 
            // labelRValue
            // 
            this.labelRValue.AutoSize = true;
            this.labelRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelRValue.Location = new System.Drawing.Point(719, 469);
            this.labelRValue.Name = "labelRValue";
            this.labelRValue.Size = new System.Drawing.Size(29, 31);
            this.labelRValue.TabIndex = 5;
            this.labelRValue.Text = "0";
            // 
            // labelGValue
            // 
            this.labelGValue.AutoSize = true;
            this.labelGValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelGValue.Location = new System.Drawing.Point(859, 469);
            this.labelGValue.Name = "labelGValue";
            this.labelGValue.Size = new System.Drawing.Size(29, 31);
            this.labelGValue.TabIndex = 7;
            this.labelGValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(819, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "G:";
            // 
            // labelBValue
            // 
            this.labelBValue.AutoSize = true;
            this.labelBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelBValue.Location = new System.Drawing.Point(985, 469);
            this.labelBValue.Name = "labelBValue";
            this.labelBValue.Size = new System.Drawing.Size(29, 31);
            this.labelBValue.TabIndex = 9;
            this.labelBValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(945, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(63, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ctrl + X to exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 697);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelGValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAverageColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAverageColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRValue;
        private System.Windows.Forms.Label labelGValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

