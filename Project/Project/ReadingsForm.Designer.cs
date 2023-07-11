namespace Project
{
    partial class ReadingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBillingMonthRF = new System.Windows.Forms.DateTimePicker();
            this.lblBillingMonthRF = new System.Windows.Forms.Label();
            this.lblNumberOfResidentsRF = new System.Windows.Forms.Label();
            this.tbNumberOfResidentsRF = new System.Windows.Forms.TextBox();
            this.lblReadingsHVSRF = new System.Windows.Forms.Label();
            this.tbReadingsHVSRF = new System.Windows.Forms.TextBox();
            this.cbCheckHVSRB = new System.Windows.Forms.CheckBox();
            this.cbCheckGVSRF = new System.Windows.Forms.CheckBox();
            this.lblReadingsGVSRF = new System.Windows.Forms.Label();
            this.tbReadingsGVSRF = new System.Windows.Forms.TextBox();
            this.cbCheckEERF = new System.Windows.Forms.CheckBox();
            this.lblReadingsEENightRF = new System.Windows.Forms.Label();
            this.lblReadingsEEDayRF = new System.Windows.Forms.Label();
            this.tbReadingsEENightRF = new System.Windows.Forms.TextBox();
            this.tbReadingsEEDayRF = new System.Windows.Forms.TextBox();
            this.btnSaveReadingsRF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpBillingMonthRF
            // 
            this.dtpBillingMonthRF.CalendarFont = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBillingMonthRF.CustomFormat = "MM.yyyy";
            this.dtpBillingMonthRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBillingMonthRF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillingMonthRF.Location = new System.Drawing.Point(268, 27);
            this.dtpBillingMonthRF.Name = "dtpBillingMonthRF";
            this.dtpBillingMonthRF.ShowUpDown = true;
            this.dtpBillingMonthRF.Size = new System.Drawing.Size(100, 29);
            this.dtpBillingMonthRF.TabIndex = 0;
            this.dtpBillingMonthRF.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // lblBillingMonthRF
            // 
            this.lblBillingMonthRF.AutoSize = true;
            this.lblBillingMonthRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBillingMonthRF.Location = new System.Drawing.Point(27, 33);
            this.lblBillingMonthRF.Name = "lblBillingMonthRF";
            this.lblBillingMonthRF.Size = new System.Drawing.Size(150, 21);
            this.lblBillingMonthRF.TabIndex = 1;
            this.lblBillingMonthRF.Text = "Расчетный месяц";
            // 
            // lblNumberOfResidentsRF
            // 
            this.lblNumberOfResidentsRF.AutoSize = true;
            this.lblNumberOfResidentsRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfResidentsRF.Location = new System.Drawing.Point(27, 74);
            this.lblNumberOfResidentsRF.Name = "lblNumberOfResidentsRF";
            this.lblNumberOfResidentsRF.Size = new System.Drawing.Size(227, 21);
            this.lblNumberOfResidentsRF.TabIndex = 1;
            this.lblNumberOfResidentsRF.Text = "Количество проживающих";
            // 
            // tbNumberOfResidentsRF
            // 
            this.tbNumberOfResidentsRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumberOfResidentsRF.Location = new System.Drawing.Point(268, 71);
            this.tbNumberOfResidentsRF.Name = "tbNumberOfResidentsRF";
            this.tbNumberOfResidentsRF.Size = new System.Drawing.Size(100, 29);
            this.tbNumberOfResidentsRF.TabIndex = 2;
            this.tbNumberOfResidentsRF.Text = "1";
            this.tbNumberOfResidentsRF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRF_KeyPress);
            // 
            // lblReadingsHVSRF
            // 
            this.lblReadingsHVSRF.AutoSize = true;
            this.lblReadingsHVSRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadingsHVSRF.Location = new System.Drawing.Point(27, 150);
            this.lblReadingsHVSRF.Name = "lblReadingsHVSRF";
            this.lblReadingsHVSRF.Size = new System.Drawing.Size(138, 21);
            this.lblReadingsHVSRF.TabIndex = 1;
            this.lblReadingsHVSRF.Text = "Показания ХВС";
            this.lblReadingsHVSRF.Visible = false;
            // 
            // tbReadingsHVSRF
            // 
            this.tbReadingsHVSRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadingsHVSRF.Location = new System.Drawing.Point(268, 147);
            this.tbReadingsHVSRF.Name = "tbReadingsHVSRF";
            this.tbReadingsHVSRF.Size = new System.Drawing.Size(100, 29);
            this.tbReadingsHVSRF.TabIndex = 2;
            this.tbReadingsHVSRF.Text = "0";
            this.tbReadingsHVSRF.Visible = false;
            this.tbReadingsHVSRF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRF_KeyPress);
            // 
            // cbCheckHVSRB
            // 
            this.cbCheckHVSRB.AutoSize = true;
            this.cbCheckHVSRB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCheckHVSRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCheckHVSRB.Location = new System.Drawing.Point(27, 111);
            this.cbCheckHVSRB.Name = "cbCheckHVSRB";
            this.cbCheckHVSRB.Size = new System.Drawing.Size(261, 25);
            this.cbCheckHVSRB.TabIndex = 3;
            this.cbCheckHVSRB.Text = "Наличие прибора учета ХВС";
            this.cbCheckHVSRB.UseVisualStyleBackColor = true;
            this.cbCheckHVSRB.CheckedChanged += new System.EventHandler(this.cbCheckHVSRB_CheckedChanged);
            // 
            // cbCheckGVSRF
            // 
            this.cbCheckGVSRF.AutoSize = true;
            this.cbCheckGVSRF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCheckGVSRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCheckGVSRF.Location = new System.Drawing.Point(27, 192);
            this.cbCheckGVSRF.Name = "cbCheckGVSRF";
            this.cbCheckGVSRF.Size = new System.Drawing.Size(259, 25);
            this.cbCheckGVSRF.TabIndex = 3;
            this.cbCheckGVSRF.Text = "Наличие прибора учета ГВС";
            this.cbCheckGVSRF.UseVisualStyleBackColor = true;
            this.cbCheckGVSRF.CheckedChanged += new System.EventHandler(this.cbCheckGVSRF_CheckedChanged);
            // 
            // lblReadingsGVSRF
            // 
            this.lblReadingsGVSRF.AutoSize = true;
            this.lblReadingsGVSRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadingsGVSRF.Location = new System.Drawing.Point(27, 237);
            this.lblReadingsGVSRF.Name = "lblReadingsGVSRF";
            this.lblReadingsGVSRF.Size = new System.Drawing.Size(136, 21);
            this.lblReadingsGVSRF.TabIndex = 1;
            this.lblReadingsGVSRF.Text = "Показания ГВС";
            this.lblReadingsGVSRF.Visible = false;
            // 
            // tbReadingsGVSRF
            // 
            this.tbReadingsGVSRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadingsGVSRF.Location = new System.Drawing.Point(268, 234);
            this.tbReadingsGVSRF.Name = "tbReadingsGVSRF";
            this.tbReadingsGVSRF.Size = new System.Drawing.Size(103, 29);
            this.tbReadingsGVSRF.TabIndex = 2;
            this.tbReadingsGVSRF.Text = "0";
            this.tbReadingsGVSRF.Visible = false;
            this.tbReadingsGVSRF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRF_KeyPress);
            // 
            // cbCheckEERF
            // 
            this.cbCheckEERF.AutoSize = true;
            this.cbCheckEERF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCheckEERF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCheckEERF.Location = new System.Drawing.Point(27, 278);
            this.cbCheckEERF.Name = "cbCheckEERF";
            this.cbCheckEERF.Size = new System.Drawing.Size(249, 25);
            this.cbCheckEERF.TabIndex = 3;
            this.cbCheckEERF.Text = "Наличие прибора учета ЭЭ";
            this.cbCheckEERF.UseVisualStyleBackColor = true;
            this.cbCheckEERF.CheckedChanged += new System.EventHandler(this.cbCheckEERF_CheckedChanged);
            // 
            // lblReadingsEENightRF
            // 
            this.lblReadingsEENightRF.AutoSize = true;
            this.lblReadingsEENightRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadingsEENightRF.Location = new System.Drawing.Point(27, 321);
            this.lblReadingsEENightRF.Name = "lblReadingsEENightRF";
            this.lblReadingsEENightRF.Size = new System.Drawing.Size(170, 21);
            this.lblReadingsEENightRF.TabIndex = 1;
            this.lblReadingsEENightRF.Text = "Показания ЭЭ ночь";
            this.lblReadingsEENightRF.Visible = false;
            // 
            // lblReadingsEEDayRF
            // 
            this.lblReadingsEEDayRF.AutoSize = true;
            this.lblReadingsEEDayRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadingsEEDayRF.Location = new System.Drawing.Point(27, 359);
            this.lblReadingsEEDayRF.Name = "lblReadingsEEDayRF";
            this.lblReadingsEEDayRF.Size = new System.Drawing.Size(168, 21);
            this.lblReadingsEEDayRF.TabIndex = 1;
            this.lblReadingsEEDayRF.Text = "Показания ЭЭ день";
            this.lblReadingsEEDayRF.Visible = false;
            // 
            // tbReadingsEENightRF
            // 
            this.tbReadingsEENightRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadingsEENightRF.Location = new System.Drawing.Point(268, 318);
            this.tbReadingsEENightRF.Name = "tbReadingsEENightRF";
            this.tbReadingsEENightRF.Size = new System.Drawing.Size(103, 29);
            this.tbReadingsEENightRF.TabIndex = 2;
            this.tbReadingsEENightRF.Text = "0";
            this.tbReadingsEENightRF.Visible = false;
            this.tbReadingsEENightRF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRF_KeyPress);
            // 
            // tbReadingsEEDayRF
            // 
            this.tbReadingsEEDayRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReadingsEEDayRF.Location = new System.Drawing.Point(268, 356);
            this.tbReadingsEEDayRF.Name = "tbReadingsEEDayRF";
            this.tbReadingsEEDayRF.Size = new System.Drawing.Size(103, 29);
            this.tbReadingsEEDayRF.TabIndex = 2;
            this.tbReadingsEEDayRF.Text = "0";
            this.tbReadingsEEDayRF.Visible = false;
            this.tbReadingsEEDayRF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRF_KeyPress);
            // 
            // btnSaveReadingsRF
            // 
            this.btnSaveReadingsRF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveReadingsRF.Location = new System.Drawing.Point(112, 404);
            this.btnSaveReadingsRF.Name = "btnSaveReadingsRF";
            this.btnSaveReadingsRF.Size = new System.Drawing.Size(187, 36);
            this.btnSaveReadingsRF.TabIndex = 4;
            this.btnSaveReadingsRF.Text = "Провести расчёт";
            this.btnSaveReadingsRF.UseVisualStyleBackColor = true;
            this.btnSaveReadingsRF.Click += new System.EventHandler(this.btnSaveReadingsRF_Click);
            // 
            // ReadingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 452);
            this.Controls.Add(this.btnSaveReadingsRF);
            this.Controls.Add(this.tbReadingsEEDayRF);
            this.Controls.Add(this.tbReadingsEENightRF);
            this.Controls.Add(this.lblReadingsEEDayRF);
            this.Controls.Add(this.lblReadingsEENightRF);
            this.Controls.Add(this.cbCheckEERF);
            this.Controls.Add(this.tbReadingsGVSRF);
            this.Controls.Add(this.lblReadingsGVSRF);
            this.Controls.Add(this.cbCheckGVSRF);
            this.Controls.Add(this.cbCheckHVSRB);
            this.Controls.Add(this.tbReadingsHVSRF);
            this.Controls.Add(this.lblReadingsHVSRF);
            this.Controls.Add(this.tbNumberOfResidentsRF);
            this.Controls.Add(this.lblNumberOfResidentsRF);
            this.Controls.Add(this.lblBillingMonthRF);
            this.Controls.Add(this.dtpBillingMonthRF);
            this.Name = "ReadingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод показаний";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpBillingMonthRF;
        private System.Windows.Forms.Label lblBillingMonthRF;
        private System.Windows.Forms.Label lblReadingsHVSRF;
        private System.Windows.Forms.Label lblNumberOfResidentsRF;
        private System.Windows.Forms.Label lblReadingsGVSRF;
        private System.Windows.Forms.Label lblReadingsEENightRF;
        private System.Windows.Forms.Label lblReadingsEEDayRF;
        public System.Windows.Forms.TextBox tbNumberOfResidentsRF;
        public System.Windows.Forms.TextBox tbReadingsHVSRF;
        public System.Windows.Forms.TextBox tbReadingsEENightRF;
        public System.Windows.Forms.TextBox tbReadingsEEDayRF;
        public System.Windows.Forms.TextBox tbReadingsGVSRF;
        public System.Windows.Forms.CheckBox cbCheckHVSRB;
        public System.Windows.Forms.CheckBox cbCheckGVSRF;
        public System.Windows.Forms.CheckBox cbCheckEERF;
        private System.Windows.Forms.Button btnSaveReadingsRF;
    }
}