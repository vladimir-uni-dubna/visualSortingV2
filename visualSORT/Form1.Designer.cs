namespace visualSORT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonListGenerate = new System.Windows.Forms.Button();
            this.textBoxArrayLength = new System.Windows.Forms.TextBox();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 195);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 209);
            this.panel2.TabIndex = 1;
            // 
            // buttonListGenerate
            // 
            this.buttonListGenerate.Location = new System.Drawing.Point(658, 162);
            this.buttonListGenerate.Name = "buttonListGenerate";
            this.buttonListGenerate.Size = new System.Drawing.Size(130, 36);
            this.buttonListGenerate.TabIndex = 2;
            this.buttonListGenerate.Text = "сгенерировать массив";
            this.buttonListGenerate.UseVisualStyleBackColor = true;
            this.buttonListGenerate.Click += new System.EventHandler(this.buttonListGenerate_Click);
            // 
            // textBoxArrayLength
            // 
            this.textBoxArrayLength.Location = new System.Drawing.Point(658, 204);
            this.textBoxArrayLength.Name = "textBoxArrayLength";
            this.textBoxArrayLength.Size = new System.Drawing.Size(85, 20);
            this.textBoxArrayLength.TabIndex = 3;
            this.textBoxArrayLength.Text = "50";
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(658, 230);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(85, 20);
            this.textBoxMinValue.TabIndex = 4;
            this.textBoxMinValue.Text = "0";
            this.textBoxMinValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(658, 256);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(85, 20);
            this.textBoxMaxValue.TabIndex = 5;
            this.textBoxMaxValue.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "мин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "макс";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(658, 282);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(130, 24);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "отсортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaxValue);
            this.Controls.Add(this.textBoxMinValue);
            this.Controls.Add(this.textBoxArrayLength);
            this.Controls.Add(this.buttonListGenerate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonListGenerate;
        private System.Windows.Forms.TextBox textBoxArrayLength;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSort;
    }
}

