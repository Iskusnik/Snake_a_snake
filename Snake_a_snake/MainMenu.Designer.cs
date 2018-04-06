namespace Snake_a_snake
{
    partial class MainMenu
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
            this.pictureBoxSnake1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSnake2 = new System.Windows.Forms.PictureBox();
            this.numericUpDownSpeed1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScore1 = new System.Windows.Forms.TextBox();
            this.textBoxSumScore = new System.Windows.Forms.TextBox();
            this.textBoxScore2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed2 = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RightMaxLenght = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftMaxLenght = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMaxLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMaxLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSnake1
            // 
            this.pictureBoxSnake1.BackColor = System.Drawing.Color.White;
            this.pictureBoxSnake1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSnake1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSnake1.Name = "pictureBoxSnake1";
            this.pictureBoxSnake1.Size = new System.Drawing.Size(300, 400);
            this.pictureBoxSnake1.TabIndex = 0;
            this.pictureBoxSnake1.TabStop = false;
            // 
            // pictureBoxSnake2
            // 
            this.pictureBoxSnake2.BackColor = System.Drawing.Color.White;
            this.pictureBoxSnake2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSnake2.Location = new System.Drawing.Point(410, 12);
            this.pictureBoxSnake2.Name = "pictureBoxSnake2";
            this.pictureBoxSnake2.Size = new System.Drawing.Size(300, 400);
            this.pictureBoxSnake2.TabIndex = 1;
            this.pictureBoxSnake2.TabStop = false;
            // 
            // numericUpDownSpeed1
            // 
            this.numericUpDownSpeed1.Location = new System.Drawing.Point(73, 445);
            this.numericUpDownSpeed1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed1.Name = "numericUpDownSpeed1";
            this.numericUpDownSpeed1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSpeed1.TabIndex = 3;
            this.numericUpDownSpeed1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed1.ValueChanged += new System.EventHandler(this.numericUpDownSpeed1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Скорость";
            // 
            // textBoxScore1
            // 
            this.textBoxScore1.Location = new System.Drawing.Point(12, 418);
            this.textBoxScore1.Name = "textBoxScore1";
            this.textBoxScore1.ReadOnly = true;
            this.textBoxScore1.Size = new System.Drawing.Size(85, 20);
            this.textBoxScore1.TabIndex = 5;
            // 
            // textBoxSumScore
            // 
            this.textBoxSumScore.Location = new System.Drawing.Point(318, 12);
            this.textBoxSumScore.Name = "textBoxSumScore";
            this.textBoxSumScore.ReadOnly = true;
            this.textBoxSumScore.Size = new System.Drawing.Size(86, 20);
            this.textBoxSumScore.TabIndex = 6;
            // 
            // textBoxScore2
            // 
            this.textBoxScore2.Location = new System.Drawing.Point(625, 418);
            this.textBoxScore2.Name = "textBoxScore2";
            this.textBoxScore2.ReadOnly = true;
            this.textBoxScore2.Size = new System.Drawing.Size(85, 20);
            this.textBoxScore2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Скорость";
            // 
            // numericUpDownSpeed2
            // 
            this.numericUpDownSpeed2.Location = new System.Drawing.Point(471, 445);
            this.numericUpDownSpeed2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed2.Name = "numericUpDownSpeed2";
            this.numericUpDownSpeed2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSpeed2.TabIndex = 8;
            this.numericUpDownSpeed2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(318, 39);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(86, 23);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(318, 68);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(86, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Стоп";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Максимальная длина";
            // 
            // RightMaxLenght
            // 
            this.RightMaxLenght.Location = new System.Drawing.Point(660, 445);
            this.RightMaxLenght.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RightMaxLenght.Name = "RightMaxLenght";
            this.RightMaxLenght.Size = new System.Drawing.Size(50, 20);
            this.RightMaxLenght.TabIndex = 15;
            this.RightMaxLenght.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Максимальная длина";
            // 
            // LeftMaxLenght
            // 
            this.LeftMaxLenght.Location = new System.Drawing.Point(262, 445);
            this.LeftMaxLenght.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LeftMaxLenght.Name = "LeftMaxLenght";
            this.LeftMaxLenght.Size = new System.Drawing.Size(50, 20);
            this.LeftMaxLenght.TabIndex = 13;
            this.LeftMaxLenght.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RightMaxLenght);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LeftMaxLenght);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxScore2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSpeed2);
            this.Controls.Add(this.textBoxSumScore);
            this.Controls.Add(this.textBoxScore1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSpeed1);
            this.Controls.Add(this.pictureBoxSnake2);
            this.Controls.Add(this.pictureBoxSnake1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMaxLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMaxLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxSnake1;
        public System.Windows.Forms.PictureBox pictureBoxSnake2;
        public System.Windows.Forms.NumericUpDown numericUpDownSpeed1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxScore1;
        public System.Windows.Forms.TextBox textBoxSumScore;
        public System.Windows.Forms.TextBox textBoxScore2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numericUpDownSpeed2;
        public System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown RightMaxLenght;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown LeftMaxLenght;
    }
}

