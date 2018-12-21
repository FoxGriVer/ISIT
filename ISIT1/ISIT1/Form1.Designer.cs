namespace ISIT1
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
            this.barFrontend = new System.Windows.Forms.HScrollBar();
            this.labelFrontend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBackend = new System.Windows.Forms.Label();
            this.barBackend = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStrongTyping = new System.Windows.Forms.Label();
            this.barStrongTyping = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPopularity = new System.Windows.Forms.Label();
            this.barPopularity = new System.Windows.Forms.HScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWorkWithForms = new System.Windows.Forms.Label();
            this.barWorkWithForms = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.labelEasyToTeach = new System.Windows.Forms.Label();
            this.barEasyToTeach = new System.Windows.Forms.HScrollBar();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barFrontend
            // 
            this.barFrontend.LargeChange = 1;
            this.barFrontend.Location = new System.Drawing.Point(9, 92);
            this.barFrontend.Maximum = 10;
            this.barFrontend.Name = "barFrontend";
            this.barFrontend.Size = new System.Drawing.Size(527, 20);
            this.barFrontend.TabIndex = 0;
            this.barFrontend.ValueChanged += new System.EventHandler(this.barFrontend_ValueChanged);
            // 
            // labelFrontend
            // 
            this.labelFrontend.AutoSize = true;
            this.labelFrontend.Location = new System.Drawing.Point(499, 65);
            this.labelFrontend.Name = "labelFrontend";
            this.labelFrontend.Size = new System.Drawing.Size(24, 25);
            this.labelFrontend.TabIndex = 1;
            this.labelFrontend.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Необходимость front-end части";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выбор критериев";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Необходимость back-end части";
            // 
            // labelBackend
            // 
            this.labelBackend.AutoSize = true;
            this.labelBackend.Location = new System.Drawing.Point(499, 147);
            this.labelBackend.Name = "labelBackend";
            this.labelBackend.Size = new System.Drawing.Size(24, 25);
            this.labelBackend.TabIndex = 5;
            this.labelBackend.Text = "0";
            // 
            // barBackend
            // 
            this.barBackend.LargeChange = 1;
            this.barBackend.Location = new System.Drawing.Point(9, 174);
            this.barBackend.Maximum = 10;
            this.barBackend.Name = "barBackend";
            this.barBackend.Size = new System.Drawing.Size(527, 20);
            this.barBackend.TabIndex = 4;
            this.barBackend.ValueChanged += new System.EventHandler(this.barBackend_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сложность обучения";
            // 
            // labelStrongTyping
            // 
            this.labelStrongTyping.AutoSize = true;
            this.labelStrongTyping.Location = new System.Drawing.Point(499, 224);
            this.labelStrongTyping.Name = "labelStrongTyping";
            this.labelStrongTyping.Size = new System.Drawing.Size(24, 25);
            this.labelStrongTyping.TabIndex = 8;
            this.labelStrongTyping.Text = "0";
            // 
            // barStrongTyping
            // 
            this.barStrongTyping.LargeChange = 1;
            this.barStrongTyping.Location = new System.Drawing.Point(9, 251);
            this.barStrongTyping.Maximum = 10;
            this.barStrongTyping.Name = "barStrongTyping";
            this.barStrongTyping.Size = new System.Drawing.Size(527, 20);
            this.barStrongTyping.TabIndex = 7;
            this.barStrongTyping.ValueChanged += new System.EventHandler(this.barStrongTyping_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Популярность";
            // 
            // labelPopularity
            // 
            this.labelPopularity.AutoSize = true;
            this.labelPopularity.Location = new System.Drawing.Point(499, 301);
            this.labelPopularity.Name = "labelPopularity";
            this.labelPopularity.Size = new System.Drawing.Size(24, 25);
            this.labelPopularity.TabIndex = 11;
            this.labelPopularity.Text = "0";
            // 
            // barPopularity
            // 
            this.barPopularity.LargeChange = 1;
            this.barPopularity.Location = new System.Drawing.Point(9, 328);
            this.barPopularity.Maximum = 10;
            this.barPopularity.Name = "barPopularity";
            this.barPopularity.Size = new System.Drawing.Size(527, 20);
            this.barPopularity.TabIndex = 10;
            this.barPopularity.ValueChanged += new System.EventHandler(this.barPopularity_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Работа с формами";
            // 
            // labelWorkWithForms
            // 
            this.labelWorkWithForms.AutoSize = true;
            this.labelWorkWithForms.Location = new System.Drawing.Point(499, 383);
            this.labelWorkWithForms.Name = "labelWorkWithForms";
            this.labelWorkWithForms.Size = new System.Drawing.Size(24, 25);
            this.labelWorkWithForms.TabIndex = 14;
            this.labelWorkWithForms.Text = "0";
            // 
            // barWorkWithForms
            // 
            this.barWorkWithForms.LargeChange = 1;
            this.barWorkWithForms.Location = new System.Drawing.Point(9, 410);
            this.barWorkWithForms.Maximum = 10;
            this.barWorkWithForms.Name = "barWorkWithForms";
            this.barWorkWithForms.Size = new System.Drawing.Size(527, 20);
            this.barWorkWithForms.TabIndex = 13;
            this.barWorkWithForms.ValueChanged += new System.EventHandler(this.barWorkWithForms_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 32);
            this.label11.TabIndex = 18;
            this.label11.Text = "Функциональность";
            // 
            // labelEasyToTeach
            // 
            this.labelEasyToTeach.AutoSize = true;
            this.labelEasyToTeach.Location = new System.Drawing.Point(499, 467);
            this.labelEasyToTeach.Name = "labelEasyToTeach";
            this.labelEasyToTeach.Size = new System.Drawing.Size(24, 25);
            this.labelEasyToTeach.TabIndex = 17;
            this.labelEasyToTeach.Text = "0";
            // 
            // barEasyToTeach
            // 
            this.barEasyToTeach.LargeChange = 1;
            this.barEasyToTeach.Location = new System.Drawing.Point(9, 492);
            this.barEasyToTeach.Maximum = 10;
            this.barEasyToTeach.Name = "barEasyToTeach";
            this.barEasyToTeach.Size = new System.Drawing.Size(527, 20);
            this.barEasyToTeach.TabIndex = 16;
            this.barEasyToTeach.ValueChanged += new System.EventHandler(this.barEasyToTeach_ValueChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(125, 558);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(289, 59);
            this.buttonResult.TabIndex = 19;
            this.buttonResult.Text = "Узнать результат";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 629);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelEasyToTeach);
            this.Controls.Add(this.barEasyToTeach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelWorkWithForms);
            this.Controls.Add(this.barWorkWithForms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPopularity);
            this.Controls.Add(this.barPopularity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelStrongTyping);
            this.Controls.Add(this.barStrongTyping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBackend);
            this.Controls.Add(this.barBackend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFrontend);
            this.Controls.Add(this.barFrontend);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспертная система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar barFrontend;
        private System.Windows.Forms.Label labelFrontend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBackend;
        private System.Windows.Forms.HScrollBar barBackend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStrongTyping;
        private System.Windows.Forms.HScrollBar barStrongTyping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPopularity;
        private System.Windows.Forms.HScrollBar barPopularity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWorkWithForms;
        private System.Windows.Forms.HScrollBar barWorkWithForms;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelEasyToTeach;
        private System.Windows.Forms.HScrollBar barEasyToTeach;
        private System.Windows.Forms.Button buttonResult;
    }
}

