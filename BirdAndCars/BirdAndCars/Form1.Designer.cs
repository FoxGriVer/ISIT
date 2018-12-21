namespace BirdAndCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.Car1SpeedBox = new System.Windows.Forms.TextBox();
            this.Car2SpeedBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirdSpeedBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DistanceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountDistanceButton = new System.Windows.Forms.Button();
            this.textBoxForResultDistance = new System.Windows.Forms.Label();
            this.ResultBirdDistanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорость машины 1:";
            // 
            // Car1SpeedBox
            // 
            this.Car1SpeedBox.Location = new System.Drawing.Point(237, 30);
            this.Car1SpeedBox.Name = "Car1SpeedBox";
            this.Car1SpeedBox.Size = new System.Drawing.Size(197, 31);
            this.Car1SpeedBox.TabIndex = 1;
            // 
            // Car2SpeedBox
            // 
            this.Car2SpeedBox.Location = new System.Drawing.Point(237, 88);
            this.Car2SpeedBox.Name = "Car2SpeedBox";
            this.Car2SpeedBox.Size = new System.Drawing.Size(197, 31);
            this.Car2SpeedBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скорость машины 2:";
            // 
            // BirdSpeedBox
            // 
            this.BirdSpeedBox.Location = new System.Drawing.Point(237, 150);
            this.BirdSpeedBox.Name = "BirdSpeedBox";
            this.BirdSpeedBox.Size = new System.Drawing.Size(197, 31);
            this.BirdSpeedBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Скорость птицы:";
            // 
            // DistanceBox
            // 
            this.DistanceBox.Location = new System.Drawing.Point(237, 207);
            this.DistanceBox.Name = "DistanceBox";
            this.DistanceBox.Size = new System.Drawing.Size(197, 31);
            this.DistanceBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Расстояние:";
            // 
            // CountDistanceButton
            // 
            this.CountDistanceButton.Location = new System.Drawing.Point(17, 392);
            this.CountDistanceButton.Name = "CountDistanceButton";
            this.CountDistanceButton.Size = new System.Drawing.Size(417, 61);
            this.CountDistanceButton.TabIndex = 8;
            this.CountDistanceButton.Text = "Произвести расчеты";
            this.CountDistanceButton.UseVisualStyleBackColor = true;
            this.CountDistanceButton.Click += new System.EventHandler(this.CountDistanceButton_Click);
            // 
            // textBoxForResultDistance
            // 
            this.textBoxForResultDistance.AutoSize = true;
            this.textBoxForResultDistance.Location = new System.Drawing.Point(12, 316);
            this.textBoxForResultDistance.Name = "textBoxForResultDistance";
            this.textBoxForResultDistance.Size = new System.Drawing.Size(177, 25);
            this.textBoxForResultDistance.TabIndex = 9;
            this.textBoxForResultDistance.Text = "Птица пролетит:";
            this.textBoxForResultDistance.Visible = false;
            // 
            // ResultBirdDistanceLabel
            // 
            this.ResultBirdDistanceLabel.AutoSize = true;
            this.ResultBirdDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBirdDistanceLabel.Location = new System.Drawing.Point(184, 295);
            this.ResultBirdDistanceLabel.Name = "ResultBirdDistanceLabel";
            this.ResultBirdDistanceLabel.Size = new System.Drawing.Size(47, 51);
            this.ResultBirdDistanceLabel.TabIndex = 10;
            this.ResultBirdDistanceLabel.Text = "0";
            this.ResultBirdDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultBirdDistanceLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 468);
            this.Controls.Add(this.ResultBirdDistanceLabel);
            this.Controls.Add(this.textBoxForResultDistance);
            this.Controls.Add(this.CountDistanceButton);
            this.Controls.Add(this.DistanceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirdSpeedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Car2SpeedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Car1SpeedBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BirdAndCars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Car1SpeedBox;
        private System.Windows.Forms.TextBox Car2SpeedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BirdSpeedBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DistanceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CountDistanceButton;
        private System.Windows.Forms.Label textBoxForResultDistance;
        private System.Windows.Forms.Label ResultBirdDistanceLabel;
    }
}

