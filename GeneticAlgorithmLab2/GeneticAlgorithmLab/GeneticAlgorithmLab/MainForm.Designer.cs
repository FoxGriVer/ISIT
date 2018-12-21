namespace GeneticAlgorithmLab
{
    partial class MainForm
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
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelIndCount = new System.Windows.Forms.Label();
            this.labelGenerationNumber = new System.Windows.Forms.Label();
            this.textBoxIndCount = new System.Windows.Forms.TextBox();
            this.textBoxGenerationNumber = new System.Windows.Forms.TextBox();
            this.labelSelectionType = new System.Windows.Forms.Label();
            this.textBoxSelectionVal = new System.Windows.Forms.TextBox();
            this.buttonSaveGAParams = new System.Windows.Forms.Button();
            this.buttonStartGA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(509, 48);
            this.textBoxPoints.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPoints.Multiline = true;
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(111, 100);
            this.textBoxPoints.TabIndex = 1;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(949, 154);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(10, 10);
            this.textBoxLog.TabIndex = 3;
            this.textBoxLog.Visible = false;
            // 
            // labelIndCount
            // 
            this.labelIndCount.AutoSize = true;
            this.labelIndCount.Location = new System.Drawing.Point(15, 54);
            this.labelIndCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIndCount.Name = "labelIndCount";
            this.labelIndCount.Size = new System.Drawing.Size(156, 25);
            this.labelIndCount.TabIndex = 4;
            this.labelIndCount.Text = "Число особей:";
            // 
            // labelGenerationNumber
            // 
            this.labelGenerationNumber.AutoSize = true;
            this.labelGenerationNumber.Location = new System.Drawing.Point(15, 88);
            this.labelGenerationNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGenerationNumber.Name = "labelGenerationNumber";
            this.labelGenerationNumber.Size = new System.Drawing.Size(192, 25);
            this.labelGenerationNumber.TabIndex = 9;
            this.labelGenerationNumber.Text = "Число поколений:";
            // 
            // textBoxIndCount
            // 
            this.textBoxIndCount.Location = new System.Drawing.Point(345, 48);
            this.textBoxIndCount.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxIndCount.Name = "textBoxIndCount";
            this.textBoxIndCount.Size = new System.Drawing.Size(123, 31);
            this.textBoxIndCount.TabIndex = 10;
            // 
            // textBoxGenerationNumber
            // 
            this.textBoxGenerationNumber.Location = new System.Drawing.Point(345, 82);
            this.textBoxGenerationNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxGenerationNumber.Name = "textBoxGenerationNumber";
            this.textBoxGenerationNumber.Size = new System.Drawing.Size(123, 31);
            this.textBoxGenerationNumber.TabIndex = 12;
            // 
            // labelSelectionType
            // 
            this.labelSelectionType.AutoSize = true;
            this.labelSelectionType.Location = new System.Drawing.Point(15, 123);
            this.labelSelectionType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSelectionType.Name = "labelSelectionType";
            this.labelSelectionType.Size = new System.Drawing.Size(218, 25);
            this.labelSelectionType.TabIndex = 17;
            this.labelSelectionType.Text = "Параметр селекции:";
            // 
            // textBoxSelectionVal
            // 
            this.textBoxSelectionVal.Enabled = false;
            this.textBoxSelectionVal.Location = new System.Drawing.Point(345, 117);
            this.textBoxSelectionVal.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSelectionVal.Name = "textBoxSelectionVal";
            this.textBoxSelectionVal.Size = new System.Drawing.Size(123, 31);
            this.textBoxSelectionVal.TabIndex = 23;
            // 
            // buttonSaveGAParams
            // 
            this.buttonSaveGAParams.Location = new System.Drawing.Point(651, 42);
            this.buttonSaveGAParams.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSaveGAParams.Name = "buttonSaveGAParams";
            this.buttonSaveGAParams.Size = new System.Drawing.Size(262, 49);
            this.buttonSaveGAParams.TabIndex = 28;
            this.buttonSaveGAParams.Text = "Применить параметры";
            this.buttonSaveGAParams.UseVisualStyleBackColor = true;
            this.buttonSaveGAParams.Click += new System.EventHandler(this.buttonStartGA_Click);
            // 
            // buttonStartGA
            // 
            this.buttonStartGA.Location = new System.Drawing.Point(651, 103);
            this.buttonStartGA.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStartGA.Name = "buttonStartGA";
            this.buttonStartGA.Size = new System.Drawing.Size(262, 45);
            this.buttonStartGA.TabIndex = 29;
            this.buttonStartGA.Text = "Запустить алгоритм";
            this.buttonStartGA.UseVisualStyleBackColor = true;
            this.buttonStartGA.Click += new System.EventHandler(this.buttonStartGA_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Укажите параметры алгоритма:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(974, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartGA);
            this.Controls.Add(this.buttonSaveGAParams);
            this.Controls.Add(this.textBoxSelectionVal);
            this.Controls.Add(this.labelSelectionType);
            this.Controls.Add(this.textBoxGenerationNumber);
            this.Controls.Add(this.textBoxIndCount);
            this.Controls.Add(this.labelGenerationNumber);
            this.Controls.Add(this.labelIndCount);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.textBoxPoints);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1000, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "MainForm";
            this.Text = "Генетический алгоритм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelIndCount;
        private System.Windows.Forms.Label labelGenerationNumber;
        private System.Windows.Forms.TextBox textBoxIndCount;
        private System.Windows.Forms.TextBox textBoxGenerationNumber;
        private System.Windows.Forms.Label labelSelectionType;
        private System.Windows.Forms.TextBox textBoxSelectionVal;
        private System.Windows.Forms.Button buttonSaveGAParams;
        private System.Windows.Forms.Button buttonStartGA;
        private System.Windows.Forms.Label label1;
    }
}

