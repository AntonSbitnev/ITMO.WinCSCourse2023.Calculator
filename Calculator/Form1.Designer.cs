namespace Calculator
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

       
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.rovno = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.defect = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.one_div_x = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.pow_two = new System.Windows.Forms.Button();
            this.pow_3 = new System.Windows.Forms.Button();
            this.pow_x_y = new System.Windows.Forms.Button();
            this.Очистить = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свернутьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engeneerpanel = new System.Windows.Forms.Panel();
            this.actorial = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.engeneerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox.Location = new System.Drawing.Point(12, 27);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(221, 40);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Очистить.SetToolTip(this.textBox, "Введите чило для расчета");
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.one.Location = new System.Drawing.Point(12, 204);
            this.one.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(35, 35);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.plus.Location = new System.Drawing.Point(123, 240);
            this.plus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 35);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.Очистить.SetToolTip(this.plus, "Сложение");
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // rovno
            // 
            this.rovno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rovno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rovno.Location = new System.Drawing.Point(179, 204);
            this.rovno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rovno.Name = "rovno";
            this.rovno.Size = new System.Drawing.Size(54, 71);
            this.rovno.TabIndex = 3;
            this.rovno.Text = "=";
            this.Очистить.SetToolTip(this.rovno, "Равно");
            this.rovno.UseVisualStyleBackColor = false;
            this.rovno.Click += new System.EventHandler(this.rovno_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.two.Location = new System.Drawing.Point(48, 204);
            this.two.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(35, 35);
            this.two.TabIndex = 4;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.three.Location = new System.Drawing.Point(84, 204);
            this.three.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(35, 35);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.four.Location = new System.Drawing.Point(12, 168);
            this.four.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(35, 35);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.five.Location = new System.Drawing.Point(48, 168);
            this.five.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(35, 35);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.six.Location = new System.Drawing.Point(84, 168);
            this.six.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(35, 35);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.seven.Location = new System.Drawing.Point(12, 131);
            this.seven.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(35, 35);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.eight.Location = new System.Drawing.Point(48, 131);
            this.eight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(35, 35);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nine.Location = new System.Drawing.Point(84, 131);
            this.nine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(35, 35);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.zero.Location = new System.Drawing.Point(12, 240);
            this.zero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(71, 35);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div.Location = new System.Drawing.Point(123, 131);
            this.div.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(52, 35);
            this.div.TabIndex = 13;
            this.div.Text = "/";
            this.Очистить.SetToolTip(this.div, "Деление");
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mul.Location = new System.Drawing.Point(123, 168);
            this.mul.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(52, 35);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.Очистить.SetToolTip(this.mul, "Умножение");
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // defect
            // 
            this.defect.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.defect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defect.Location = new System.Drawing.Point(123, 204);
            this.defect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.defect.Name = "defect";
            this.defect.Size = new System.Drawing.Size(52, 35);
            this.defect.TabIndex = 15;
            this.defect.Text = "-";
            this.Очистить.SetToolTip(this.defect, "Вычитание");
            this.defect.UseVisualStyleBackColor = false;
            this.defect.Click += new System.EventHandler(this.defect_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.Location = new System.Drawing.Point(84, 240);
            this.point.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(35, 35);
            this.point.TabIndex = 16;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // one_div_x
            // 
            this.one_div_x.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.one_div_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one_div_x.Location = new System.Drawing.Point(119, 3);
            this.one_div_x.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.one_div_x.Name = "one_div_x";
            this.one_div_x.Size = new System.Drawing.Size(35, 35);
            this.one_div_x.TabIndex = 17;
            this.one_div_x.Text = "1/x";
            this.Очистить.SetToolTip(this.one_div_x, "Расчет обратного значения");
            this.one_div_x.UseVisualStyleBackColor = false;
            this.one_div_x.Click += new System.EventHandler(this.one_div_x_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.Location = new System.Drawing.Point(158, 3);
            this.sqrt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(35, 35);
            this.sqrt.TabIndex = 18;
            this.sqrt.Text = "√";
            this.Очистить.SetToolTip(this.sqrt, "Извлечение квадратного корня");
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(179, 131);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(54, 72);
            this.delete.TabIndex = 19;
            this.delete.Text = "С";
            this.Очистить.SetToolTip(this.delete, "Сброс");
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // pow_two
            // 
            this.pow_two.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pow_two.Location = new System.Drawing.Point(11, 3);
            this.pow_two.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pow_two.Name = "pow_two";
            this.pow_two.Size = new System.Drawing.Size(35, 35);
            this.pow_two.TabIndex = 27;
            this.pow_two.Text = "x²";
            this.Очистить.SetToolTip(this.pow_two, "Число во второй степени");
            this.pow_two.UseVisualStyleBackColor = false;
            this.pow_two.Click += new System.EventHandler(this.pow_two_Click);
            // 
            // pow_3
            // 
            this.pow_3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pow_3.Location = new System.Drawing.Point(48, 3);
            this.pow_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pow_3.Name = "pow_3";
            this.pow_3.Size = new System.Drawing.Size(35, 35);
            this.pow_3.TabIndex = 28;
            this.pow_3.Text = "x³";
            this.Очистить.SetToolTip(this.pow_3, "Число в третьей степени");
            this.pow_3.UseVisualStyleBackColor = false;
            this.pow_3.Click += new System.EventHandler(this.pow_three_Click);
            // 
            // pow_x_y
            // 
            this.pow_x_y.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pow_x_y.ForeColor = System.Drawing.SystemColors.Control;
            this.pow_x_y.Image = ((System.Drawing.Image)(resources.GetObject("pow_x_y.Image")));
            this.pow_x_y.Location = new System.Drawing.Point(84, 3);
            this.pow_x_y.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pow_x_y.Name = "pow_x_y";
            this.pow_x_y.Size = new System.Drawing.Size(35, 35);
            this.pow_x_y.TabIndex = 29;
            this.Очистить.SetToolTip(this.pow_x_y, "Х в степени у");
            this.pow_x_y.UseVisualStyleBackColor = false;
            this.pow_x_y.Click += new System.EventHandler(this.pow_x_y_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.инженерныйToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(243, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сбToolStripMenuItem,
            this.свернутьОкноToolStripMenuItem,
            this.закрытьОкноToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // сбToolStripMenuItem
            // 
            this.сбToolStripMenuItem.Name = "сбToolStripMenuItem";
            this.сбToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.сбToolStripMenuItem.Text = "Сброс";
            this.сбToolStripMenuItem.Click += new System.EventHandler(this.сбToolStripMenuItem_Click);
            // 
            // свернутьОкноToolStripMenuItem
            // 
            this.свернутьОкноToolStripMenuItem.Name = "свернутьОкноToolStripMenuItem";
            this.свернутьОкноToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.свернутьОкноToolStripMenuItem.Text = "Свернуть окно";
            this.свернутьОкноToolStripMenuItem.Click += new System.EventHandler(this.свернутьОкноToolStripMenuItem_Click);
            // 
            // закрытьОкноToolStripMenuItem
            // 
            this.закрытьОкноToolStripMenuItem.Name = "закрытьОкноToolStripMenuItem";
            this.закрытьОкноToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.закрытьОкноToolStripMenuItem.Text = "Закрыть окно";
            this.закрытьОкноToolStripMenuItem.Click += new System.EventHandler(this.закрытьОкноToolStripMenuItem_Click);
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменаToolStripMenuItem});
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            this.инженерныйToolStripMenuItem.ToolTipText = "Доп. панель ";
            this.инженерныйToolStripMenuItem.Click += new System.EventHandler(this.инженерныйToolStripMenuItem_Click);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.ToolTipText = "Скрыть доп.панель";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // engeneerpanel
            // 
            this.engeneerpanel.Controls.Add(this.actorial);
            this.engeneerpanel.Controls.Add(this.pow_two);
            this.engeneerpanel.Controls.Add(this.pow_x_y);
            this.engeneerpanel.Controls.Add(this.one_div_x);
            this.engeneerpanel.Controls.Add(this.sqrt);
            this.engeneerpanel.Controls.Add(this.pow_3);
            this.engeneerpanel.Location = new System.Drawing.Point(0, 80);
            this.engeneerpanel.Name = "engeneerpanel";
            this.engeneerpanel.Size = new System.Drawing.Size(243, 45);
            this.engeneerpanel.TabIndex = 31;
            this.engeneerpanel.Visible = false;
            this.engeneerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.engeneerpanel_Paint);
            // 
            // actorial
            // 
            this.actorial.Location = new System.Drawing.Point(196, 3);
            this.actorial.Name = "actorial";
            this.actorial.Size = new System.Drawing.Size(35, 35);
            this.actorial.TabIndex = 30;
            this.actorial.Text = "!n";
            this.Очистить.SetToolTip(this.actorial, "Факториал числа");
            this.actorial.UseVisualStyleBackColor = true;
            this.actorial.Click += new System.EventHandler(this.actorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(243, 287);
            this.Controls.Add(this.engeneerpanel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.point);
            this.Controls.Add(this.defect);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.div);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.rovno);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.one);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Калькулятор WF";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.engeneerpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button rovno;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button defect;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button one_div_x;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button pow_two;
        private System.Windows.Forms.Button pow_3;
        private System.Windows.Forms.Button pow_x_y;
        private System.Windows.Forms.ToolTip Очистить;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свернутьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженерныйToolStripMenuItem;
        private System.Windows.Forms.Panel engeneerpanel;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.Button actorial;
    }
}

