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
            this.checkBoxWall1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownSpeed1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScore1 = new System.Windows.Forms.TextBox();
            this.textBoxSumScore = new System.Windows.Forms.TextBox();
            this.textBoxScore2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed2 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWall2 = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed2)).BeginInit();
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
            // checkBoxWall1
            // 
            this.checkBoxWall1.AutoSize = true;
            this.checkBoxWall1.Location = new System.Drawing.Point(12, 418);
            this.checkBoxWall1.Name = "checkBoxWall1";
            this.checkBoxWall1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWall1.Size = new System.Drawing.Size(62, 17);
            this.checkBoxWall1.TabIndex = 2;
            this.checkBoxWall1.Text = "Стенка";
            this.checkBoxWall1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWall1.UseVisualStyleBackColor = true;
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
            this.textBoxScore1.Location = new System.Drawing.Point(227, 418);
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
            // checkBoxWall2
            // 
            this.checkBoxWall2.AutoSize = true;
            this.checkBoxWall2.Location = new System.Drawing.Point(410, 418);
            this.checkBoxWall2.Name = "checkBoxWall2";
            this.checkBoxWall2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWall2.Size = new System.Drawing.Size(62, 17);
            this.checkBoxWall2.TabIndex = 7;
            this.checkBoxWall2.Text = "Стенка";
            this.checkBoxWall2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWall2.UseVisualStyleBackColor = true;
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
            this.buttonReset.Text = "Заново";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 475);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxScore2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSpeed2);
            this.Controls.Add(this.checkBoxWall2);
            this.Controls.Add(this.textBoxSumScore);
            this.Controls.Add(this.textBoxScore1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSpeed1);
            this.Controls.Add(this.checkBoxWall1);
            this.Controls.Add(this.pictureBoxSnake2);
            this.Controls.Add(this.pictureBoxSnake1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSnake1;
        private System.Windows.Forms.PictureBox pictureBoxSnake2;
        private System.Windows.Forms.CheckBox checkBoxWall1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScore1;
        private System.Windows.Forms.TextBox textBoxSumScore;
        private System.Windows.Forms.TextBox textBoxScore2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed2;
        private System.Windows.Forms.CheckBox checkBoxWall2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
    }
}

