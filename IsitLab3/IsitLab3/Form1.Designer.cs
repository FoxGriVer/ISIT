namespace IsitLab3
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
            this.DownloadTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.param1 = new System.Windows.Forms.TextBox();
            this.param2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.param3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultClassLabel = new System.Windows.Forms.Label();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DownloadTable
            // 
            this.DownloadTable.Location = new System.Drawing.Point(608, 64);
            this.DownloadTable.Name = "DownloadTable";
            this.DownloadTable.Size = new System.Drawing.Size(182, 66);
            this.DownloadTable.TabIndex = 0;
            this.DownloadTable.Text = "Загрузить таблицу";
            this.DownloadTable.UseVisualStyleBackColor = true;
            this.DownloadTable.Click += new System.EventHandler(this.DownloadTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметр 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // param1
            // 
            this.param1.Location = new System.Drawing.Point(154, 6);
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(100, 31);
            this.param1.TabIndex = 2;
            // 
            // param2
            // 
            this.param2.Location = new System.Drawing.Point(420, 6);
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(100, 31);
            this.param2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Параметр 2:";
            // 
            // param3
            // 
            this.param3.Location = new System.Drawing.Point(690, 6);
            this.param3.Name = "param3";
            this.param3.Size = new System.Drawing.Size(100, 31);
            this.param3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Параметр 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Класс :";
            // 
            // ResultClassLabel
            // 
            this.ResultClassLabel.AutoSize = true;
            this.ResultClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultClassLabel.Location = new System.Drawing.Point(132, 93);
            this.ResultClassLabel.Name = "ResultClassLabel";
            this.ResultClassLabel.Size = new System.Drawing.Size(0, 37);
            this.ResultClassLabel.TabIndex = 8;
            // 
            // ButtonResult
            // 
            this.ButtonResult.Location = new System.Drawing.Point(410, 64);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(182, 66);
            this.ButtonResult.TabIndex = 9;
            this.ButtonResult.Text = "Вывести результат";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 142);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ResultClassLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.param3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.param2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.param1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox param1;
        private System.Windows.Forms.TextBox param2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox param3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResultClassLabel;
        private System.Windows.Forms.Button ButtonResult;
    }
}

