namespace SampleNote.Main.Modals
{
    partial class Admittance_Info
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admittance_Info));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.tb_Remarks = new System.Windows.Forms.TextBox();
            this.groupbox_VehicleInfo = new System.Windows.Forms.GroupBox();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.cbx_TripsToSite = new System.Windows.Forms.ComboBox();
            this.cbx_DailyRate = new System.Windows.Forms.ComboBox();
            this.cbx_kmDriven = new System.Windows.Forms.ComboBox();
            this.lbl_kmDriven = new System.Windows.Forms.Label();
            this.lbl_tripsToSite = new System.Windows.Forms.Label();
            this.lbl_dailyRate = new System.Windows.Forms.Label();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.btnPreviewPrint = new System.Windows.Forms.Button();
            this.groupbox_TimeInfo = new System.Windows.Forms.GroupBox();
            this.tb_Other = new System.Windows.Forms.TextBox();
            this.tb_Testing = new System.Windows.Forms.TextBox();
            this.tb_StandBy = new System.Windows.Forms.TextBox();
            this.tb_Mob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupbox_Other = new System.Windows.Forms.GroupBox();
            this.cbx_HourlyTesting = new System.Windows.Forms.ComboBox();
            this.checkbox_HourlyTesting = new System.Windows.Forms.CheckBox();
            this.checkbox_Field = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCurrentLog = new System.Windows.Forms.Button();
            this.dialog_ReportLogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ReportPDFWriter = new System.ComponentModel.BackgroundWorker();
            this.Form_Header.SuspendLayout();
            this.groupbox_VehicleInfo.SuspendLayout();
            this.groupbox_TimeInfo.SuspendLayout();
            this.groupbox_Other.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(701, 34);
            this.Form_Header.TabIndex = 2;
            // 
            // button_exitform
            // 
            this.button_exitform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(171)))));
            this.button_exitform.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exitform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_exitform.FlatAppearance.BorderSize = 0;
            this.button_exitform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_exitform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_exitform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exitform.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.button_exitform.ForeColor = System.Drawing.Color.White;
            this.button_exitform.Location = new System.Drawing.Point(594, 0);
            this.button_exitform.Margin = new System.Windows.Forms.Padding(4);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(107, 34);
            this.button_exitform.TabIndex = 3;
            this.button_exitform.Text = "Exit";
            this.button_exitform.UseVisualStyleBackColor = false;
            this.button_exitform.Click += new System.EventHandler(this.button_exitform_Click);
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.ForeColor = System.Drawing.Color.White;
            this.FormName.Location = new System.Drawing.Point(9, 6);
            this.FormName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(128, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "Admittance Data";
            // 
            // tb_Remarks
            // 
            this.tb_Remarks.Location = new System.Drawing.Point(388, 249);
            this.tb_Remarks.Name = "tb_Remarks";
            this.tb_Remarks.Size = new System.Drawing.Size(299, 26);
            this.tb_Remarks.TabIndex = 0;
            // 
            // groupbox_VehicleInfo
            // 
            this.groupbox_VehicleInfo.Controls.Add(this.tb_Unit);
            this.groupbox_VehicleInfo.Controls.Add(this.cbx_TripsToSite);
            this.groupbox_VehicleInfo.Controls.Add(this.cbx_DailyRate);
            this.groupbox_VehicleInfo.Controls.Add(this.cbx_kmDriven);
            this.groupbox_VehicleInfo.Controls.Add(this.lbl_kmDriven);
            this.groupbox_VehicleInfo.Controls.Add(this.lbl_tripsToSite);
            this.groupbox_VehicleInfo.Controls.Add(this.lbl_dailyRate);
            this.groupbox_VehicleInfo.Controls.Add(this.lbl_unit);
            this.groupbox_VehicleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.groupbox_VehicleInfo.Location = new System.Drawing.Point(13, 51);
            this.groupbox_VehicleInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupbox_VehicleInfo.Name = "groupbox_VehicleInfo";
            this.groupbox_VehicleInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupbox_VehicleInfo.Size = new System.Drawing.Size(461, 181);
            this.groupbox_VehicleInfo.TabIndex = 1;
            this.groupbox_VehicleInfo.TabStop = false;
            this.groupbox_VehicleInfo.Text = "Vehicle Info";
            // 
            // tb_Unit
            // 
            this.tb_Unit.Location = new System.Drawing.Point(156, 30);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(278, 26);
            this.tb_Unit.TabIndex = 5;
            // 
            // cbx_TripsToSite
            // 
            this.cbx_TripsToSite.FormattingEnabled = true;
            this.cbx_TripsToSite.Location = new System.Drawing.Point(156, 98);
            this.cbx_TripsToSite.Name = "cbx_TripsToSite";
            this.cbx_TripsToSite.Size = new System.Drawing.Size(278, 30);
            this.cbx_TripsToSite.TabIndex = 2;
            // 
            // cbx_DailyRate
            // 
            this.cbx_DailyRate.FormattingEnabled = true;
            this.cbx_DailyRate.Location = new System.Drawing.Point(156, 62);
            this.cbx_DailyRate.Name = "cbx_DailyRate";
            this.cbx_DailyRate.Size = new System.Drawing.Size(278, 30);
            this.cbx_DailyRate.TabIndex = 1;
            // 
            // cbx_kmDriven
            // 
            this.cbx_kmDriven.FormattingEnabled = true;
            this.cbx_kmDriven.Items.AddRange(new object[] {
            "From Vehicle Log"});
            this.cbx_kmDriven.Location = new System.Drawing.Point(156, 134);
            this.cbx_kmDriven.Name = "cbx_kmDriven";
            this.cbx_kmDriven.Size = new System.Drawing.Size(278, 30);
            this.cbx_kmDriven.TabIndex = 3;
            // 
            // lbl_kmDriven
            // 
            this.lbl_kmDriven.AllowDrop = true;
            this.lbl_kmDriven.AutoSize = true;
            this.lbl_kmDriven.ForeColor = System.Drawing.Color.White;
            this.lbl_kmDriven.Location = new System.Drawing.Point(21, 134);
            this.lbl_kmDriven.Name = "lbl_kmDriven";
            this.lbl_kmDriven.Size = new System.Drawing.Size(95, 22);
            this.lbl_kmDriven.TabIndex = 4;
            this.lbl_kmDriven.Text = "km. Driven:";
            // 
            // lbl_tripsToSite
            // 
            this.lbl_tripsToSite.AutoSize = true;
            this.lbl_tripsToSite.ForeColor = System.Drawing.Color.White;
            this.lbl_tripsToSite.Location = new System.Drawing.Point(21, 98);
            this.lbl_tripsToSite.Name = "lbl_tripsToSite";
            this.lbl_tripsToSite.Size = new System.Drawing.Size(102, 22);
            this.lbl_tripsToSite.TabIndex = 3;
            this.lbl_tripsToSite.Text = "Trips to Site:";
            // 
            // lbl_dailyRate
            // 
            this.lbl_dailyRate.AutoSize = true;
            this.lbl_dailyRate.ForeColor = System.Drawing.Color.White;
            this.lbl_dailyRate.Location = new System.Drawing.Point(21, 62);
            this.lbl_dailyRate.Name = "lbl_dailyRate";
            this.lbl_dailyRate.Size = new System.Drawing.Size(88, 22);
            this.lbl_dailyRate.TabIndex = 2;
            this.lbl_dailyRate.Text = "Daily Rate:";
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.ForeColor = System.Drawing.Color.White;
            this.lbl_unit.Location = new System.Drawing.Point(21, 26);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(45, 22);
            this.lbl_unit.TabIndex = 0;
            this.lbl_unit.Text = "Unit:";
            // 
            // btnPreviewPrint
            // 
            this.btnPreviewPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(191)))));
            this.btnPreviewPrint.FlatAppearance.BorderSize = 0;
            this.btnPreviewPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewPrint.Location = new System.Drawing.Point(521, 359);
            this.btnPreviewPrint.Name = "btnPreviewPrint";
            this.btnPreviewPrint.Size = new System.Drawing.Size(159, 33);
            this.btnPreviewPrint.TabIndex = 5;
            this.btnPreviewPrint.Text = "Preview Print";
            this.btnPreviewPrint.UseVisualStyleBackColor = false;
            // 
            // groupbox_TimeInfo
            // 
            this.groupbox_TimeInfo.Controls.Add(this.tb_Other);
            this.groupbox_TimeInfo.Controls.Add(this.tb_Testing);
            this.groupbox_TimeInfo.Controls.Add(this.tb_StandBy);
            this.groupbox_TimeInfo.Controls.Add(this.tb_Mob);
            this.groupbox_TimeInfo.Controls.Add(this.label1);
            this.groupbox_TimeInfo.Controls.Add(this.label2);
            this.groupbox_TimeInfo.Controls.Add(this.label3);
            this.groupbox_TimeInfo.Controls.Add(this.label4);
            this.groupbox_TimeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.groupbox_TimeInfo.Location = new System.Drawing.Point(491, 51);
            this.groupbox_TimeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupbox_TimeInfo.Name = "groupbox_TimeInfo";
            this.groupbox_TimeInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupbox_TimeInfo.Size = new System.Drawing.Size(196, 181);
            this.groupbox_TimeInfo.TabIndex = 2;
            this.groupbox_TimeInfo.TabStop = false;
            this.groupbox_TimeInfo.Text = "Time Info (hours)";
            // 
            // tb_Other
            // 
            this.tb_Other.Location = new System.Drawing.Point(124, 134);
            this.tb_Other.Name = "tb_Other";
            this.tb_Other.Size = new System.Drawing.Size(55, 26);
            this.tb_Other.TabIndex = 8;
            // 
            // tb_Testing
            // 
            this.tb_Testing.Location = new System.Drawing.Point(124, 98);
            this.tb_Testing.Name = "tb_Testing";
            this.tb_Testing.Size = new System.Drawing.Size(55, 26);
            this.tb_Testing.TabIndex = 7;
            // 
            // tb_StandBy
            // 
            this.tb_StandBy.Location = new System.Drawing.Point(124, 62);
            this.tb_StandBy.Name = "tb_StandBy";
            this.tb_StandBy.Size = new System.Drawing.Size(55, 26);
            this.tb_StandBy.TabIndex = 6;
            // 
            // tb_Mob
            // 
            this.tb_Mob.Location = new System.Drawing.Point(124, 26);
            this.tb_Mob.Name = "tb_Mob";
            this.tb_Mob.Size = new System.Drawing.Size(55, 26);
            this.tb_Mob.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Other:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Testing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Standby:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mob:";
            // 
            // groupbox_Other
            // 
            this.groupbox_Other.Controls.Add(this.cbx_HourlyTesting);
            this.groupbox_Other.Controls.Add(this.checkbox_HourlyTesting);
            this.groupbox_Other.Controls.Add(this.checkbox_Field);
            this.groupbox_Other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.groupbox_Other.Location = new System.Drawing.Point(13, 239);
            this.groupbox_Other.Name = "groupbox_Other";
            this.groupbox_Other.Size = new System.Drawing.Size(289, 153);
            this.groupbox_Other.TabIndex = 7;
            this.groupbox_Other.TabStop = false;
            this.groupbox_Other.Text = "Other";
            // 
            // cbx_HourlyTesting
            // 
            this.cbx_HourlyTesting.Enabled = false;
            this.cbx_HourlyTesting.FormattingEnabled = true;
            this.cbx_HourlyTesting.Location = new System.Drawing.Point(25, 101);
            this.cbx_HourlyTesting.Name = "cbx_HourlyTesting";
            this.cbx_HourlyTesting.Size = new System.Drawing.Size(243, 30);
            this.cbx_HourlyTesting.TabIndex = 2;
            this.cbx_HourlyTesting.SelectedIndexChanged += new System.EventHandler(this.cbx_HourlyTesting_SelectedIndexChanged);
            this.cbx_HourlyTesting.TextUpdate += new System.EventHandler(this.cbx_HourlyTesting_TextUpdate);
            // 
            // checkbox_HourlyTesting
            // 
            this.checkbox_HourlyTesting.AutoSize = true;
            this.checkbox_HourlyTesting.Location = new System.Drawing.Point(25, 69);
            this.checkbox_HourlyTesting.Name = "checkbox_HourlyTesting";
            this.checkbox_HourlyTesting.Size = new System.Drawing.Size(128, 26);
            this.checkbox_HourlyTesting.TabIndex = 1;
            this.checkbox_HourlyTesting.Text = "Hourly Testing";
            this.checkbox_HourlyTesting.UseVisualStyleBackColor = true;
            this.checkbox_HourlyTesting.CheckedChanged += new System.EventHandler(this.checkbox_HourlyTesting_CheckedChanged);
            this.checkbox_HourlyTesting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkbox_HourlyTesting_MouseClick);
            // 
            // checkbox_Field
            // 
            this.checkbox_Field.AutoSize = true;
            this.checkbox_Field.Location = new System.Drawing.Point(25, 37);
            this.checkbox_Field.Name = "checkbox_Field";
            this.checkbox_Field.Size = new System.Drawing.Size(187, 26);
            this.checkbox_Field.TabIndex = 0;
            this.checkbox_Field.Text = "Field (Density Testing)";
            this.checkbox_Field.UseVisualStyleBackColor = true;
            this.checkbox_Field.CheckedChanged += new System.EventHandler(this.checkbox_Field_CheckedChanged);
            this.checkbox_Field.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkbox_Field_MouseClick);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(308, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remarks:";
            // 
            // btnCurrentLog
            // 
            this.btnCurrentLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCurrentLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCurrentLog.FlatAppearance.BorderSize = 0;
            this.btnCurrentLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentLog.ForeColor = System.Drawing.Color.White;
            this.btnCurrentLog.Location = new System.Drawing.Point(521, 323);
            this.btnCurrentLog.Name = "btnCurrentLog";
            this.btnCurrentLog.Size = new System.Drawing.Size(159, 30);
            this.btnCurrentLog.TabIndex = 9;
            this.btnCurrentLog.Text = "Log: CAL-1";
            this.btnCurrentLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTip.SetToolTip(this.btnCurrentLog, "Set Log Directory");
            this.btnCurrentLog.UseVisualStyleBackColor = false;
            this.btnCurrentLog.Click += new System.EventHandler(this.btnCurrentLog_Click);
            // 
            // dialog_ReportLogFolder
            // 
            this.dialog_ReportLogFolder.Description = "Directory to store Log Reports";
            this.dialog_ReportLogFolder.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // Admittance_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(701, 408);
            this.Controls.Add(this.btnCurrentLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Remarks);
            this.Controls.Add(this.groupbox_Other);
            this.Controls.Add(this.groupbox_TimeInfo);
            this.Controls.Add(this.btnPreviewPrint);
            this.Controls.Add(this.groupbox_VehicleInfo);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admittance_Info";
            this.ShowIcon = false;
            this.Text = "Admittance Info";
            this.TopMost = true;
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.groupbox_VehicleInfo.ResumeLayout(false);
            this.groupbox_VehicleInfo.PerformLayout();
            this.groupbox_TimeInfo.ResumeLayout(false);
            this.groupbox_TimeInfo.PerformLayout();
            this.groupbox_Other.ResumeLayout(false);
            this.groupbox_Other.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.GroupBox groupbox_VehicleInfo;
        private System.Windows.Forms.Label lbl_dailyRate;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label lbl_tripsToSite;
        private System.Windows.Forms.Label lbl_kmDriven;
        private System.Windows.Forms.ComboBox cbx_kmDriven;
        private System.Windows.Forms.ComboBox cbx_TripsToSite;
        private System.Windows.Forms.ComboBox cbx_DailyRate;
        private System.Windows.Forms.Button btnPreviewPrint;
        private System.Windows.Forms.GroupBox groupbox_TimeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Remarks;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.GroupBox groupbox_Other;
        private System.Windows.Forms.CheckBox checkbox_HourlyTesting;
        private System.Windows.Forms.CheckBox checkbox_Field;
        private System.Windows.Forms.ComboBox cbx_HourlyTesting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Other;
        private System.Windows.Forms.TextBox tb_Testing;
        private System.Windows.Forms.TextBox tb_StandBy;
        private System.Windows.Forms.TextBox tb_Mob;
        private System.Windows.Forms.Button btnCurrentLog;
        private System.Windows.Forms.FolderBrowserDialog dialog_ReportLogFolder;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.ComponentModel.BackgroundWorker ReportPDFWriter;
    }
}