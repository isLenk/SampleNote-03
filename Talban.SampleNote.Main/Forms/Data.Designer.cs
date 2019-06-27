namespace SampleNote.Main.Forms
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.panel_projectdata = new System.Windows.Forms.Panel();
            this.lock_fields = new System.Windows.Forms.PictureBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.checkbox_datenow = new System.Windows.Forms.CheckBox();
            this.label_daterecieved = new System.Windows.Forms.Label();
            this.textbox_clientname = new System.Windows.Forms.TextBox();
            this.label_clientname = new System.Windows.Forms.Label();
            this.textbox_projectlocation = new System.Windows.Forms.TextBox();
            this.textbox_projectname = new System.Windows.Forms.TextBox();
            this.label_projectlocation = new System.Windows.Forms.Label();
            this.label_projectname = new System.Windows.Forms.Label();
            this.textbox_projectnumber = new System.Windows.Forms.TextBox();
            this.label_projectnumber = new System.Windows.Forms.Label();
            this.panel_testlist = new System.Windows.Forms.Panel();
            this.button_clearform = new System.Windows.Forms.Button();
            this.listbox_testlist = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textbox_filtersearch = new System.Windows.Forms.TextBox();
            this.label_filtersearch = new System.Windows.Forms.Label();
            this.label_itemcount = new System.Windows.Forms.Label();
            this.label_testlist = new System.Windows.Forms.Label();
            this.panel_sampledata = new System.Windows.Forms.Panel();
            this.lock_fields1 = new System.Windows.Forms.PictureBox();
            this.textbox_sampledby = new System.Windows.Forms.TextBox();
            this.label_sampledby = new System.Windows.Forms.Label();
            this.textbox_suppliedby = new System.Windows.Forms.TextBox();
            this.textbox_samplelocation = new System.Windows.Forms.TextBox();
            this.label_suppliedby = new System.Windows.Forms.Label();
            this.label_samplelocation = new System.Windows.Forms.Label();
            this.textbox_sampledescription = new System.Windows.Forms.TextBox();
            this.label_sampledescription = new System.Windows.Forms.Label();
            this.panel_admitdata = new System.Windows.Forms.Panel();
            this.textbox_admittedby = new System.Windows.Forms.TextBox();
            this.label_admittedby = new System.Windows.Forms.Label();
            this.label_samplenumberheader = new System.Windows.Forms.Label();
            this.LABEL_labelView = new System.Windows.Forms.Panel();
            this.LABEL_LTestRequired = new System.Windows.Forms.Label();
            this.LABEL_LProjectName = new System.Windows.Forms.Label();
            this.LABEL_LClient = new System.Windows.Forms.Label();
            this.LABEL_LSampleNumber = new System.Windows.Forms.Label();
            this.LABEL_LProjectNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LABEL_LTestsRequiredList = new System.Windows.Forms.Label();
            this.CHECKBOX_PrintLabel = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_samplenumber = new System.Windows.Forms.Button();
            this.BUTTON_CoolGuy = new System.Windows.Forms.PictureBox();
            this.picture_clifton = new System.Windows.Forms.PictureBox();
            this.btnPreviewAdmit = new System.Windows.Forms.Button();
            this.Form_Header.SuspendLayout();
            this.panel_projectdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lock_fields)).BeginInit();
            this.panel_testlist.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_sampledata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lock_fields1)).BeginInit();
            this.panel_admitdata.SuspendLayout();
            this.LABEL_labelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTON_CoolGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clifton)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(1139, 35);
            this.Form_Header.TabIndex = 1;
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
            this.button_exitform.Location = new System.Drawing.Point(1034, 0);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(105, 35);
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
            this.FormName.Location = new System.Drawing.Point(15, 7);
            this.FormName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(178, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = " SampleNote Data Form";
            // 
            // panel_projectdata
            // 
            this.panel_projectdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.panel_projectdata.Controls.Add(this.lock_fields);
            this.panel_projectdata.Controls.Add(this.dtp_time);
            this.panel_projectdata.Controls.Add(this.dtp_date);
            this.panel_projectdata.Controls.Add(this.checkbox_datenow);
            this.panel_projectdata.Controls.Add(this.label_daterecieved);
            this.panel_projectdata.Controls.Add(this.textbox_clientname);
            this.panel_projectdata.Controls.Add(this.label_clientname);
            this.panel_projectdata.Controls.Add(this.textbox_projectlocation);
            this.panel_projectdata.Controls.Add(this.textbox_projectname);
            this.panel_projectdata.Controls.Add(this.label_projectlocation);
            this.panel_projectdata.Controls.Add(this.label_projectname);
            this.panel_projectdata.Controls.Add(this.textbox_projectnumber);
            this.panel_projectdata.Controls.Add(this.label_projectnumber);
            this.panel_projectdata.Location = new System.Drawing.Point(13, 51);
            this.panel_projectdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_projectdata.Name = "panel_projectdata";
            this.panel_projectdata.Size = new System.Drawing.Size(339, 305);
            this.panel_projectdata.TabIndex = 2;
            // 
            // lock_fields
            // 
            this.lock_fields.Image = global::SampleNote.Main.Properties.Resources.Unlocked;
            this.lock_fields.Location = new System.Drawing.Point(301, 6);
            this.lock_fields.Name = "lock_fields";
            this.lock_fields.Size = new System.Drawing.Size(25, 25);
            this.lock_fields.TabIndex = 12;
            this.lock_fields.TabStop = false;
            this.ToolTip.SetToolTip(this.lock_fields, "Prevent fields from being cleared");
            // 
            // dtp_time
            // 
            this.dtp_time.CustomFormat = "hh:mm tt";
            this.dtp_time.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_time.Enabled = false;
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(186, 263);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.ShowUpDown = true;
            this.dtp_time.Size = new System.Drawing.Size(140, 26);
            this.dtp_time.TabIndex = 11;
            this.dtp_time.Tag = "F";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd/MMM/yyyy";
            this.dtp_date.Enabled = false;
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(8, 263);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(172, 26);
            this.dtp_date.TabIndex = 10;
            this.dtp_date.Tag = "F";
            // 
            // checkbox_datenow
            // 
            this.checkbox_datenow.AutoSize = true;
            this.checkbox_datenow.Checked = true;
            this.checkbox_datenow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_datenow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_datenow.Location = new System.Drawing.Point(126, 241);
            this.checkbox_datenow.Name = "checkbox_datenow";
            this.checkbox_datenow.Size = new System.Drawing.Size(51, 21);
            this.checkbox_datenow.TabIndex = 9;
            this.checkbox_datenow.Text = "now";
            this.checkbox_datenow.UseVisualStyleBackColor = true;
            this.checkbox_datenow.CheckedChanged += new System.EventHandler(this.checkbox_datenow_CheckedChanged);
            // 
            // label_daterecieved
            // 
            this.label_daterecieved.AutoSize = true;
            this.label_daterecieved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_daterecieved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_daterecieved.Location = new System.Drawing.Point(4, 238);
            this.label_daterecieved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_daterecieved.Name = "label_daterecieved";
            this.label_daterecieved.Size = new System.Drawing.Size(108, 21);
            this.label_daterecieved.TabIndex = 8;
            this.label_daterecieved.Text = "Date Recieved";
            // 
            // textbox_clientname
            // 
            this.textbox_clientname.BackColor = System.Drawing.Color.White;
            this.textbox_clientname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_clientname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_clientname.Location = new System.Drawing.Point(8, 197);
            this.textbox_clientname.Name = "textbox_clientname";
            this.textbox_clientname.Size = new System.Drawing.Size(318, 26);
            this.textbox_clientname.TabIndex = 7;
            this.textbox_clientname.Tag = "E";
            // 
            // label_clientname
            // 
            this.label_clientname.AutoSize = true;
            this.label_clientname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clientname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_clientname.Location = new System.Drawing.Point(4, 172);
            this.label_clientname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_clientname.Name = "label_clientname";
            this.label_clientname.Size = new System.Drawing.Size(96, 21);
            this.label_clientname.TabIndex = 6;
            this.label_clientname.Text = "Client Name";
            // 
            // textbox_projectlocation
            // 
            this.textbox_projectlocation.BackColor = System.Drawing.Color.White;
            this.textbox_projectlocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_projectlocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_projectlocation.Location = new System.Drawing.Point(8, 143);
            this.textbox_projectlocation.Name = "textbox_projectlocation";
            this.textbox_projectlocation.Size = new System.Drawing.Size(318, 26);
            this.textbox_projectlocation.TabIndex = 5;
            this.textbox_projectlocation.Tag = "D";
            // 
            // textbox_projectname
            // 
            this.textbox_projectname.BackColor = System.Drawing.Color.White;
            this.textbox_projectname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_projectname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_projectname.Location = new System.Drawing.Point(8, 89);
            this.textbox_projectname.Name = "textbox_projectname";
            this.textbox_projectname.Size = new System.Drawing.Size(318, 26);
            this.textbox_projectname.TabIndex = 4;
            this.textbox_projectname.Tag = "C";
            // 
            // label_projectlocation
            // 
            this.label_projectlocation.AutoSize = true;
            this.label_projectlocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectlocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_projectlocation.Location = new System.Drawing.Point(4, 118);
            this.label_projectlocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectlocation.Name = "label_projectlocation";
            this.label_projectlocation.Size = new System.Drawing.Size(121, 21);
            this.label_projectlocation.TabIndex = 3;
            this.label_projectlocation.Text = "Project Location";
            // 
            // label_projectname
            // 
            this.label_projectname.AutoSize = true;
            this.label_projectname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_projectname.Location = new System.Drawing.Point(4, 64);
            this.label_projectname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectname.Name = "label_projectname";
            this.label_projectname.Size = new System.Drawing.Size(104, 21);
            this.label_projectname.TabIndex = 2;
            this.label_projectname.Text = "Project Name";
            // 
            // textbox_projectnumber
            // 
            this.textbox_projectnumber.BackColor = System.Drawing.Color.White;
            this.textbox_projectnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_projectnumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_projectnumber.Location = new System.Drawing.Point(8, 35);
            this.textbox_projectnumber.Name = "textbox_projectnumber";
            this.textbox_projectnumber.Size = new System.Drawing.Size(318, 26);
            this.textbox_projectnumber.TabIndex = 1;
            this.textbox_projectnumber.Tag = "B";
            // 
            // label_projectnumber
            // 
            this.label_projectnumber.AutoSize = true;
            this.label_projectnumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_projectnumber.Location = new System.Drawing.Point(4, 10);
            this.label_projectnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectnumber.Name = "label_projectnumber";
            this.label_projectnumber.Size = new System.Drawing.Size(120, 21);
            this.label_projectnumber.TabIndex = 0;
            this.label_projectnumber.Text = "Project Number";
            // 
            // panel_testlist
            // 
            this.panel_testlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_testlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_testlist.Controls.Add(this.button_clearform);
            this.panel_testlist.Controls.Add(this.listbox_testlist);
            this.panel_testlist.Controls.Add(this.panel3);
            this.panel_testlist.Controls.Add(this.label_testlist);
            this.panel_testlist.Location = new System.Drawing.Point(363, 51);
            this.panel_testlist.Margin = new System.Windows.Forms.Padding(0);
            this.panel_testlist.Name = "panel_testlist";
            this.panel_testlist.Size = new System.Drawing.Size(387, 639);
            this.panel_testlist.TabIndex = 4;
            // 
            // button_clearform
            // 
            this.button_clearform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button_clearform.FlatAppearance.BorderSize = 0;
            this.button_clearform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearform.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.button_clearform.Location = new System.Drawing.Point(277, 9);
            this.button_clearform.Name = "button_clearform";
            this.button_clearform.Size = new System.Drawing.Size(102, 27);
            this.button_clearform.TabIndex = 36;
            this.button_clearform.Text = "Clear Form";
            this.button_clearform.UseVisualStyleBackColor = false;
            this.button_clearform.Click += new System.EventHandler(this.button_clear_clicked);
            // 
            // listbox_testlist
            // 
            this.listbox_testlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listbox_testlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_testlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listbox_testlist.ForeColor = System.Drawing.Color.White;
            this.listbox_testlist.FormattingEnabled = true;
            this.listbox_testlist.ItemHeight = 22;
            this.listbox_testlist.Items.AddRange(new object[] {
            "loading items"});
            this.listbox_testlist.Location = new System.Drawing.Point(0, 52);
            this.listbox_testlist.Margin = new System.Windows.Forms.Padding(0);
            this.listbox_testlist.Name = "listbox_testlist";
            this.listbox_testlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox_testlist.Size = new System.Drawing.Size(387, 550);
            this.listbox_testlist.TabIndex = 7;
            this.listbox_testlist.Tag = "M";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.textbox_filtersearch);
            this.panel3.Controls.Add(this.label_filtersearch);
            this.panel3.Controls.Add(this.label_itemcount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 37);
            this.panel3.TabIndex = 6;
            // 
            // textbox_filtersearch
            // 
            this.textbox_filtersearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_filtersearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_filtersearch.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.textbox_filtersearch.Location = new System.Drawing.Point(223, 7);
            this.textbox_filtersearch.Name = "textbox_filtersearch";
            this.textbox_filtersearch.Size = new System.Drawing.Size(156, 21);
            this.textbox_filtersearch.TabIndex = 3;
            // 
            // label_filtersearch
            // 
            this.label_filtersearch.AutoSize = true;
            this.label_filtersearch.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label_filtersearch.Location = new System.Drawing.Point(125, 10);
            this.label_filtersearch.Name = "label_filtersearch";
            this.label_filtersearch.Size = new System.Drawing.Size(92, 18);
            this.label_filtersearch.TabIndex = 2;
            this.label_filtersearch.Text = "Filter Search:";
            // 
            // label_itemcount
            // 
            this.label_itemcount.AutoSize = true;
            this.label_itemcount.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label_itemcount.Location = new System.Drawing.Point(6, 10);
            this.label_itemcount.Name = "label_itemcount";
            this.label_itemcount.Size = new System.Drawing.Size(74, 18);
            this.label_itemcount.TabIndex = 1;
            this.label_itemcount.Text = "0 Selected";
            // 
            // label_testlist
            // 
            this.label_testlist.AutoSize = true;
            this.label_testlist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_testlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_testlist.Location = new System.Drawing.Point(4, 12);
            this.label_testlist.Name = "label_testlist";
            this.label_testlist.Size = new System.Drawing.Size(77, 25);
            this.label_testlist.TabIndex = 0;
            this.label_testlist.Text = "Test List";
            this.ToolTip.SetToolTip(this.label_testlist, "Click to open text editor");
            this.label_testlist.Click += new System.EventHandler(this.label_testlist_Click);
            this.label_testlist.MouseEnter += new System.EventHandler(this.label_testlist_MouseEnter);
            this.label_testlist.MouseLeave += new System.EventHandler(this.label_testlist_MouseLeave);
            // 
            // panel_sampledata
            // 
            this.panel_sampledata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.panel_sampledata.Controls.Add(this.lock_fields1);
            this.panel_sampledata.Controls.Add(this.textbox_sampledby);
            this.panel_sampledata.Controls.Add(this.label_sampledby);
            this.panel_sampledata.Controls.Add(this.textbox_suppliedby);
            this.panel_sampledata.Controls.Add(this.textbox_samplelocation);
            this.panel_sampledata.Controls.Add(this.label_suppliedby);
            this.panel_sampledata.Controls.Add(this.label_samplelocation);
            this.panel_sampledata.Controls.Add(this.textbox_sampledescription);
            this.panel_sampledata.Controls.Add(this.label_sampledescription);
            this.panel_sampledata.Location = new System.Drawing.Point(13, 366);
            this.panel_sampledata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_sampledata.Name = "panel_sampledata";
            this.panel_sampledata.Size = new System.Drawing.Size(339, 226);
            this.panel_sampledata.TabIndex = 12;
            // 
            // lock_fields1
            // 
            this.lock_fields1.Image = global::SampleNote.Main.Properties.Resources.Unlocked;
            this.lock_fields1.Location = new System.Drawing.Point(301, 4);
            this.lock_fields1.Name = "lock_fields1";
            this.lock_fields1.Size = new System.Drawing.Size(25, 25);
            this.lock_fields1.TabIndex = 13;
            this.lock_fields1.TabStop = false;
            this.ToolTip.SetToolTip(this.lock_fields1, "Prevent fields from being cleared");
            // 
            // textbox_sampledby
            // 
            this.textbox_sampledby.BackColor = System.Drawing.Color.White;
            this.textbox_sampledby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sampledby.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sampledby.Location = new System.Drawing.Point(186, 187);
            this.textbox_sampledby.Name = "textbox_sampledby";
            this.textbox_sampledby.Size = new System.Drawing.Size(140, 26);
            this.textbox_sampledby.TabIndex = 7;
            this.textbox_sampledby.Tag = "J";
            // 
            // label_sampledby
            // 
            this.label_sampledby.AutoSize = true;
            this.label_sampledby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sampledby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_sampledby.Location = new System.Drawing.Point(8, 187);
            this.label_sampledby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sampledby.Name = "label_sampledby";
            this.label_sampledby.Size = new System.Drawing.Size(92, 21);
            this.label_sampledby.TabIndex = 6;
            this.label_sampledby.Text = "Sampled By";
            // 
            // textbox_suppliedby
            // 
            this.textbox_suppliedby.BackColor = System.Drawing.Color.White;
            this.textbox_suppliedby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_suppliedby.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_suppliedby.Location = new System.Drawing.Point(8, 143);
            this.textbox_suppliedby.Name = "textbox_suppliedby";
            this.textbox_suppliedby.Size = new System.Drawing.Size(318, 26);
            this.textbox_suppliedby.TabIndex = 5;
            this.textbox_suppliedby.Tag = "I";
            // 
            // textbox_samplelocation
            // 
            this.textbox_samplelocation.BackColor = System.Drawing.Color.White;
            this.textbox_samplelocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_samplelocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_samplelocation.Location = new System.Drawing.Point(8, 89);
            this.textbox_samplelocation.Name = "textbox_samplelocation";
            this.textbox_samplelocation.Size = new System.Drawing.Size(318, 26);
            this.textbox_samplelocation.TabIndex = 4;
            this.textbox_samplelocation.Tag = "H";
            // 
            // label_suppliedby
            // 
            this.label_suppliedby.AutoSize = true;
            this.label_suppliedby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_suppliedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_suppliedby.Location = new System.Drawing.Point(4, 118);
            this.label_suppliedby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_suppliedby.Name = "label_suppliedby";
            this.label_suppliedby.Size = new System.Drawing.Size(92, 21);
            this.label_suppliedby.TabIndex = 3;
            this.label_suppliedby.Text = "Supplied By";
            // 
            // label_samplelocation
            // 
            this.label_samplelocation.AutoSize = true;
            this.label_samplelocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_samplelocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_samplelocation.Location = new System.Drawing.Point(4, 64);
            this.label_samplelocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_samplelocation.Name = "label_samplelocation";
            this.label_samplelocation.Size = new System.Drawing.Size(125, 21);
            this.label_samplelocation.TabIndex = 2;
            this.label_samplelocation.Text = "Sample Location";
            // 
            // textbox_sampledescription
            // 
            this.textbox_sampledescription.BackColor = System.Drawing.Color.White;
            this.textbox_sampledescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sampledescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sampledescription.Location = new System.Drawing.Point(8, 35);
            this.textbox_sampledescription.Name = "textbox_sampledescription";
            this.textbox_sampledescription.Size = new System.Drawing.Size(318, 26);
            this.textbox_sampledescription.TabIndex = 1;
            this.textbox_sampledescription.Tag = "G";
            // 
            // label_sampledescription
            // 
            this.label_sampledescription.AutoSize = true;
            this.label_sampledescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sampledescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_sampledescription.Location = new System.Drawing.Point(4, 10);
            this.label_sampledescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sampledescription.Name = "label_sampledescription";
            this.label_sampledescription.Size = new System.Drawing.Size(145, 21);
            this.label_sampledescription.TabIndex = 0;
            this.label_sampledescription.Text = "Sample Description";
            // 
            // panel_admitdata
            // 
            this.panel_admitdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.panel_admitdata.Controls.Add(this.btnPreviewAdmit);
            this.panel_admitdata.Controls.Add(this.textbox_admittedby);
            this.panel_admitdata.Controls.Add(this.label_admittedby);
            this.panel_admitdata.Location = new System.Drawing.Point(13, 602);
            this.panel_admitdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_admitdata.Name = "panel_admitdata";
            this.panel_admitdata.Size = new System.Drawing.Size(339, 88);
            this.panel_admitdata.TabIndex = 13;
            // 
            // textbox_admittedby
            // 
            this.textbox_admittedby.BackColor = System.Drawing.Color.White;
            this.textbox_admittedby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_admittedby.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_admittedby.Location = new System.Drawing.Point(186, 12);
            this.textbox_admittedby.Name = "textbox_admittedby";
            this.textbox_admittedby.Size = new System.Drawing.Size(140, 26);
            this.textbox_admittedby.TabIndex = 7;
            this.textbox_admittedby.Tag = "K";
            // 
            // label_admittedby
            // 
            this.label_admittedby.AutoSize = true;
            this.label_admittedby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admittedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label_admittedby.Location = new System.Drawing.Point(5, 15);
            this.label_admittedby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_admittedby.Name = "label_admittedby";
            this.label_admittedby.Size = new System.Drawing.Size(95, 21);
            this.label_admittedby.TabIndex = 6;
            this.label_admittedby.Text = "Admitted By";
            // 
            // label_samplenumberheader
            // 
            this.label_samplenumberheader.AutoSize = true;
            this.label_samplenumberheader.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.label_samplenumberheader.Location = new System.Drawing.Point(777, 56);
            this.label_samplenumberheader.Name = "label_samplenumberheader";
            this.label_samplenumberheader.Size = new System.Drawing.Size(190, 29);
            this.label_samplenumberheader.TabIndex = 14;
            this.label_samplenumberheader.Text = "Sample Number:";
            // 
            // LABEL_labelView
            // 
            this.LABEL_labelView.BackColor = System.Drawing.Color.White;
            this.LABEL_labelView.Controls.Add(this.LABEL_LTestRequired);
            this.LABEL_labelView.Controls.Add(this.LABEL_LProjectName);
            this.LABEL_labelView.Controls.Add(this.LABEL_LClient);
            this.LABEL_labelView.Controls.Add(this.LABEL_LSampleNumber);
            this.LABEL_labelView.Controls.Add(this.LABEL_LProjectNumber);
            this.LABEL_labelView.Controls.Add(this.label4);
            this.LABEL_labelView.Controls.Add(this.LABEL_LTestsRequiredList);
            this.LABEL_labelView.Location = new System.Drawing.Point(758, 427);
            this.LABEL_labelView.Name = "LABEL_labelView";
            this.LABEL_labelView.Size = new System.Drawing.Size(369, 209);
            this.LABEL_labelView.TabIndex = 32;
            // 
            // LABEL_LTestRequired
            // 
            this.LABEL_LTestRequired.AutoSize = true;
            this.LABEL_LTestRequired.BackColor = System.Drawing.Color.White;
            this.LABEL_LTestRequired.Font = new System.Drawing.Font("Arial", 10.5F);
            this.LABEL_LTestRequired.ForeColor = System.Drawing.Color.Black;
            this.LABEL_LTestRequired.Location = new System.Drawing.Point(14, 75);
            this.LABEL_LTestRequired.Name = "LABEL_LTestRequired";
            this.LABEL_LTestRequired.Size = new System.Drawing.Size(100, 16);
            this.LABEL_LTestRequired.TabIndex = 6;
            this.LABEL_LTestRequired.Text = "Test Required:";
            // 
            // LABEL_LProjectName
            // 
            this.LABEL_LProjectName.AutoSize = true;
            this.LABEL_LProjectName.BackColor = System.Drawing.Color.White;
            this.LABEL_LProjectName.Font = new System.Drawing.Font("Arial", 10.5F);
            this.LABEL_LProjectName.ForeColor = System.Drawing.Color.Black;
            this.LABEL_LProjectName.Location = new System.Drawing.Point(14, 41);
            this.LABEL_LProjectName.Name = "LABEL_LProjectName";
            this.LABEL_LProjectName.Size = new System.Drawing.Size(114, 16);
            this.LABEL_LProjectName.TabIndex = 2;
            this.LABEL_LProjectName.Text = "PROJECT NAME";
            // 
            // LABEL_LClient
            // 
            this.LABEL_LClient.BackColor = System.Drawing.Color.White;
            this.LABEL_LClient.Font = new System.Drawing.Font("Arial", 10.5F);
            this.LABEL_LClient.ForeColor = System.Drawing.Color.Black;
            this.LABEL_LClient.Location = new System.Drawing.Point(213, 41);
            this.LABEL_LClient.Name = "LABEL_LClient";
            this.LABEL_LClient.Size = new System.Drawing.Size(134, 16);
            this.LABEL_LClient.TabIndex = 3;
            this.LABEL_LClient.Text = "CLIENT";
            this.LABEL_LClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LABEL_LSampleNumber
            // 
            this.LABEL_LSampleNumber.BackColor = System.Drawing.Color.White;
            this.LABEL_LSampleNumber.Font = new System.Drawing.Font("Arial", 15.5F);
            this.LABEL_LSampleNumber.ForeColor = System.Drawing.Color.Black;
            this.LABEL_LSampleNumber.Location = new System.Drawing.Point(177, 14);
            this.LABEL_LSampleNumber.Name = "LABEL_LSampleNumber";
            this.LABEL_LSampleNumber.Size = new System.Drawing.Size(170, 24);
            this.LABEL_LSampleNumber.TabIndex = 1;
            this.LABEL_LSampleNumber.Text = "Sample #";
            this.LABEL_LSampleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LABEL_LProjectNumber
            // 
            this.LABEL_LProjectNumber.AutoSize = true;
            this.LABEL_LProjectNumber.BackColor = System.Drawing.Color.White;
            this.LABEL_LProjectNumber.Font = new System.Drawing.Font("Arial", 15.5F);
            this.LABEL_LProjectNumber.ForeColor = System.Drawing.Color.Black;
            this.LABEL_LProjectNumber.Location = new System.Drawing.Point(13, 14);
            this.LABEL_LProjectNumber.Name = "LABEL_LProjectNumber";
            this.LABEL_LProjectNumber.Size = new System.Drawing.Size(94, 24);
            this.LABEL_LProjectNumber.TabIndex = 0;
            this.LABEL_LProjectNumber.Text = "Project #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.5F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "___________________________";
            // 
            // LABEL_LTestsRequiredList
            // 
            this.LABEL_LTestsRequiredList.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_LTestsRequiredList.Font = new System.Drawing.Font("Arial", 8F);
            this.LABEL_LTestsRequiredList.ForeColor = System.Drawing.Color.Black;
            this.LABEL_LTestsRequiredList.Location = new System.Drawing.Point(129, 75);
            this.LABEL_LTestsRequiredList.Name = "LABEL_LTestsRequiredList";
            this.LABEL_LTestsRequiredList.Size = new System.Drawing.Size(218, 122);
            this.LABEL_LTestsRequiredList.TabIndex = 7;
            // 
            // CHECKBOX_PrintLabel
            // 
            this.CHECKBOX_PrintLabel.AutoSize = true;
            this.CHECKBOX_PrintLabel.Checked = true;
            this.CHECKBOX_PrintLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHECKBOX_PrintLabel.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.CHECKBOX_PrintLabel.Location = new System.Drawing.Point(769, 642);
            this.CHECKBOX_PrintLabel.Name = "CHECKBOX_PrintLabel";
            this.CHECKBOX_PrintLabel.Size = new System.Drawing.Size(103, 25);
            this.CHECKBOX_PrintLabel.TabIndex = 33;
            this.CHECKBOX_PrintLabel.Text = "Print Label";
            this.CHECKBOX_PrintLabel.UseVisualStyleBackColor = true;
            this.CHECKBOX_PrintLabel.CheckedChanged += new System.EventHandler(this.CHECKBOX_PrintLabel_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(191)))));
            this.button_submit.FlatAppearance.BorderSize = 0;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Location = new System.Drawing.Point(892, 648);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(235, 34);
            this.button_submit.TabIndex = 34;
            this.button_submit.Text = "Submit Form";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.submitbutton_clicked);
            // 
            // button_samplenumber
            // 
            this.button_samplenumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_samplenumber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_samplenumber.FlatAppearance.BorderSize = 0;
            this.button_samplenumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_samplenumber.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.button_samplenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.button_samplenumber.Location = new System.Drawing.Point(961, 49);
            this.button_samplenumber.Margin = new System.Windows.Forms.Padding(0);
            this.button_samplenumber.Name = "button_samplenumber";
            this.button_samplenumber.Size = new System.Drawing.Size(164, 39);
            this.button_samplenumber.TabIndex = 38;
            this.button_samplenumber.Tag = "A";
            this.button_samplenumber.Text = "L0000";
            this.button_samplenumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.button_samplenumber, "Double Click to Clear");
            this.button_samplenumber.UseVisualStyleBackColor = true;
            this.button_samplenumber.Click += new System.EventHandler(this.button_samplenumber_Click);
            // 
            // BUTTON_CoolGuy
            // 
            this.BUTTON_CoolGuy.Location = new System.Drawing.Point(756, 88);
            this.BUTTON_CoolGuy.Name = "BUTTON_CoolGuy";
            this.BUTTON_CoolGuy.Size = new System.Drawing.Size(369, 333);
            this.BUTTON_CoolGuy.TabIndex = 35;
            this.BUTTON_CoolGuy.TabStop = false;
            this.BUTTON_CoolGuy.Tag = "Ken";
            // 
            // picture_clifton
            // 
            this.picture_clifton.Image = global::SampleNote.Main.Properties.Resources.CliftonLogo_235;
            this.picture_clifton.Location = new System.Drawing.Point(834, 140);
            this.picture_clifton.Name = "picture_clifton";
            this.picture_clifton.Size = new System.Drawing.Size(235, 235);
            this.picture_clifton.TabIndex = 37;
            this.picture_clifton.TabStop = false;
            // 
            // btnPreviewAdmit
            // 
            this.btnPreviewAdmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(131)))));
            this.btnPreviewAdmit.FlatAppearance.BorderSize = 0;
            this.btnPreviewAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewAdmit.ForeColor = System.Drawing.Color.White;
            this.btnPreviewAdmit.Location = new System.Drawing.Point(6, 52);
            this.btnPreviewAdmit.Name = "btnPreviewAdmit";
            this.btnPreviewAdmit.Size = new System.Drawing.Size(320, 28);
            this.btnPreviewAdmit.TabIndex = 9;
            this.btnPreviewAdmit.Text = "Preview Admittance Form";
            this.btnPreviewAdmit.UseVisualStyleBackColor = false;
            this.btnPreviewAdmit.Click += new System.EventHandler(this.btnPreviewAdmit_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1139, 704);
            this.Controls.Add(this.button_samplenumber);
            this.Controls.Add(this.picture_clifton);
            this.Controls.Add(this.BUTTON_CoolGuy);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.CHECKBOX_PrintLabel);
            this.Controls.Add(this.LABEL_labelView);
            this.Controls.Add(this.label_samplenumberheader);
            this.Controls.Add(this.panel_admitdata);
            this.Controls.Add(this.panel_sampledata);
            this.Controls.Add(this.panel_testlist);
            this.Controls.Add(this.panel_projectdata);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Data";
            this.ShowInTaskbar = false;
            this.Text = "Data";
            this.TopMost = true;
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.panel_projectdata.ResumeLayout(false);
            this.panel_projectdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lock_fields)).EndInit();
            this.panel_testlist.ResumeLayout(false);
            this.panel_testlist.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_sampledata.ResumeLayout(false);
            this.panel_sampledata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lock_fields1)).EndInit();
            this.panel_admitdata.ResumeLayout(false);
            this.panel_admitdata.PerformLayout();
            this.LABEL_labelView.ResumeLayout(false);
            this.LABEL_labelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTON_CoolGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clifton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Panel panel_projectdata;
        private System.Windows.Forms.Label label_projectnumber;
        private System.Windows.Forms.Panel panel_testlist;
        private System.Windows.Forms.Label label_testlist;
        private System.Windows.Forms.ListBox listbox_testlist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_itemcount;
        private System.Windows.Forms.Label label_filtersearch;
        private System.Windows.Forms.TextBox textbox_filtersearch;
        private System.Windows.Forms.TextBox textbox_projectnumber;
        private System.Windows.Forms.Label label_projectname;
        private System.Windows.Forms.TextBox textbox_projectname;
        private System.Windows.Forms.Label label_projectlocation;
        private System.Windows.Forms.TextBox textbox_clientname;
        private System.Windows.Forms.Label label_clientname;
        private System.Windows.Forms.TextBox textbox_projectlocation;
        private System.Windows.Forms.CheckBox checkbox_datenow;
        private System.Windows.Forms.Label label_daterecieved;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Panel panel_sampledata;
        private System.Windows.Forms.TextBox textbox_sampledby;
        private System.Windows.Forms.Label label_sampledby;
        private System.Windows.Forms.TextBox textbox_suppliedby;
        private System.Windows.Forms.TextBox textbox_samplelocation;
        private System.Windows.Forms.Label label_suppliedby;
        private System.Windows.Forms.Label label_samplelocation;
        private System.Windows.Forms.TextBox textbox_sampledescription;
        private System.Windows.Forms.Label label_sampledescription;
        private System.Windows.Forms.Panel panel_admitdata;
        private System.Windows.Forms.TextBox textbox_admittedby;
        private System.Windows.Forms.Label label_admittedby;
        private System.Windows.Forms.Label label_samplenumberheader;
        private System.Windows.Forms.Panel LABEL_labelView;
        private System.Windows.Forms.Label LABEL_LTestRequired;
        private System.Windows.Forms.Label LABEL_LProjectName;
        private System.Windows.Forms.Label LABEL_LClient;
        private System.Windows.Forms.Label LABEL_LSampleNumber;
        private System.Windows.Forms.Label LABEL_LProjectNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LABEL_LTestsRequiredList;
        private System.Windows.Forms.CheckBox CHECKBOX_PrintLabel;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.PictureBox BUTTON_CoolGuy;
        private System.Windows.Forms.Button button_clearform;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.PictureBox lock_fields;
        private System.Windows.Forms.PictureBox lock_fields1;
        private System.Windows.Forms.PictureBox picture_clifton;
        private System.Windows.Forms.Button button_samplenumber;
        private System.Windows.Forms.Button btnPreviewAdmit;
    }
}