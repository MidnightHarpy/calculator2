namespace calculator2
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
            this.maininput = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maininput
            // 
            this.maininput.Location = new System.Drawing.Point(12, 12);
            this.maininput.Name = "maininput";
            this.maininput.Size = new System.Drawing.Size(366, 22);
            this.maininput.TabIndex = 0;
            this.maininput.TextChanged += new System.EventHandler(this.maininput_TextChanged);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(291, 127);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(87, 59);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(289, 192);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(89, 59);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(289, 257);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(89, 59);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(289, 322);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(89, 59);
            this.divide.TabIndex = 4;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.one.Location = new System.Drawing.Point(12, 65);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(87, 76);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.equal.Location = new System.Drawing.Point(105, 311);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(180, 74);
            this.equal.TabIndex = 6;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.two.Location = new System.Drawing.Point(105, 65);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(87, 76);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.three.Location = new System.Drawing.Point(198, 65);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(87, 76);
            this.three.TabIndex = 8;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.six.Location = new System.Drawing.Point(198, 147);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(87, 76);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.five.Location = new System.Drawing.Point(105, 147);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(87, 76);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.four.Location = new System.Drawing.Point(12, 147);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(87, 76);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nine.Location = new System.Drawing.Point(198, 229);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(87, 76);
            this.nine.TabIndex = 14;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.eight.Location = new System.Drawing.Point(105, 229);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(87, 76);
            this.eight.TabIndex = 13;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.seven.Location = new System.Drawing.Point(12, 229);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(87, 76);
            this.seven.TabIndex = 12;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.zero.Location = new System.Drawing.Point(12, 309);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(87, 76);
            this.zero.TabIndex = 15;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(291, 65);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(87, 59);
            this.remove.TabIndex = 16;
            this.remove.Text = "⌫";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 397);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.one);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.maininput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maininput;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button remove;
    }
}

