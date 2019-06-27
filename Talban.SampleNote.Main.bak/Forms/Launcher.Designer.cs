namespace SampleNote.Main.Forms
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.button_loadfile = new System.Windows.Forms.Button();
            this.button_newfile = new System.Windows.Forms.Button();
            this.panel_filedata = new System.Windows.Forms.Panel();
            this.panel_projectdata = new System.Windows.Forms.Panel();
            this.listbox_changes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdown_selectedApi = new System.Windows.Forms.ComboBox();
            this.label_changes = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_descriptiondata = new System.Windows.Forms.Label();
            this.picture_clifton = new System.Windows.Forms.PictureBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.label_filesize = new System.Windows.Forms.Label();
            this.label_filesizeheader = new System.Windows.Forms.Label();
            this.label_dataheader = new System.Windows.Forms.Label();
            this.label_filepath = new System.Windows.Forms.Label();
            this.label_passwordheader = new System.Windows.Forms.Label();
            this.label_filenpathheader = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.label_filename = new System.Windows.Forms.Label();
            this.checkbox_showpassword = new System.Windows.Forms.CheckBox();
            this.dialog_openFile = new System.Windows.Forms.OpenFileDialog();
            this.dialog_newFile = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listbox_recentFiles = new System.Windows.Forms.ListBox();
            this.panel_dragdropoutside = new System.Windows.Forms.Panel();
            this.panel_dragdropprompt = new System.Windows.Forms.Panel();
            this.picturebox_upload = new System.Windows.Forms.PictureBox();
            this.label_ddafilehere = new System.Windows.Forms.Label();
            this.panel_loadscreen = new System.Windows.Forms.Panel();
            this.label_loading = new System.Windows.Forms.Label();
            this.picturebox_loading = new System.Windows.Forms.PictureBox();
            this.picture_newfile = new System.Windows.Forms.PictureBox();
            this.picture_loadFile = new System.Windows.Forms.PictureBox();
            this.Form_Header.SuspendLayout();
            this.panel_filedata.SuspendLayout();
            this.panel_projectdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clifton)).BeginInit();
            this.panel_dragdropoutside.SuspendLayout();
            this.panel_dragdropprompt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_upload)).BeginInit();
            this.panel_loadscreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_newfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_loadFile)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(776, 30);
            this.Form_Header.TabIndex = 0;
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
            this.button_exitform.Location = new System.Drawing.Point(671, 0);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(105, 30);
            this.button_exitform.TabIndex = 2;
            this.button_exitform.Text = "Exit";
            this.button_exitform.UseVisualStyleBackColor = false;
            this.button_exitform.Click += new System.EventHandler(this.button_exitform_Click);
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.ForeColor = System.Drawing.Color.White;
            this.FormName.Location = new System.Drawing.Point(13, 5);
            this.FormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(169, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = " SampleNote Launcher";
            // 
            // button_loadfile
            // 
            this.button_loadfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_loadfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_loadfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(221)))));
            this.button_loadfile.FlatAppearance.BorderSize = 0;
            this.button_loadfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_loadfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_loadfile.ForeColor = System.Drawing.Color.White;
            this.button_loadfile.Location = new System.Drawing.Point(35, 343);
            this.button_loadfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_loadfile.Name = "button_loadfile";
            this.button_loadfile.Size = new System.Drawing.Size(265, 34);
            this.button_loadfile.TabIndex = 2;
            this.button_loadfile.Text = "Load File";
            this.ToolTip.SetToolTip(this.button_loadfile, "Process a Generated File");
            this.button_loadfile.UseVisualStyleBackColor = false;
            this.button_loadfile.Click += new System.EventHandler(this.button_loadfile_Click);
            // 
            // button_newfile
            // 
            this.button_newfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_newfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_newfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(221)))));
            this.button_newfile.FlatAppearance.BorderSize = 0;
            this.button_newfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_newfile.ForeColor = System.Drawing.Color.White;
            this.button_newfile.Location = new System.Drawing.Point(35, 299);
            this.button_newfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_newfile.Name = "button_newfile";
            this.button_newfile.Size = new System.Drawing.Size(265, 34);
            this.button_newfile.TabIndex = 3;
            this.button_newfile.TabStop = false;
            this.button_newfile.Text = "New File";
            this.ToolTip.SetToolTip(this.button_newfile, "Generate a New File");
            this.button_newfile.UseVisualStyleBackColor = false;
            this.button_newfile.Click += new System.EventHandler(this.button_newfile_Click);
            // 
            // panel_filedata
            // 
            this.panel_filedata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel_filedata.Controls.Add(this.panel_projectdata);
            this.panel_filedata.Controls.Add(this.button_enter);
            this.panel_filedata.Controls.Add(this.label_filesize);
            this.panel_filedata.Controls.Add(this.label_filesizeheader);
            this.panel_filedata.Controls.Add(this.label_dataheader);
            this.panel_filedata.Controls.Add(this.label_filepath);
            this.panel_filedata.Controls.Add(this.label_passwordheader);
            this.panel_filedata.Controls.Add(this.label_filenpathheader);
            this.panel_filedata.Controls.Add(this.input_password);
            this.panel_filedata.Controls.Add(this.button_back);
            this.panel_filedata.Controls.Add(this.label_filename);
            this.panel_filedata.Controls.Add(this.checkbox_showpassword);
            this.panel_filedata.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_filedata.Location = new System.Drawing.Point(332, 30);
            this.panel_filedata.Margin = new System.Windows.Forms.Padding(50);
            this.panel_filedata.Name = "panel_filedata";
            this.panel_filedata.Size = new System.Drawing.Size(444, 376);
            this.panel_filedata.TabIndex = 4;
            // 
            // panel_projectdata
            // 
            this.panel_projectdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_projectdata.Controls.Add(this.listbox_changes);
            this.panel_projectdata.Controls.Add(this.label4);
            this.panel_projectdata.Controls.Add(this.dropdown_selectedApi);
            this.panel_projectdata.Controls.Add(this.label_changes);
            this.panel_projectdata.Controls.Add(this.label_description);
            this.panel_projectdata.Controls.Add(this.label_descriptiondata);
            this.panel_projectdata.Controls.Add(this.picture_clifton);
            this.panel_projectdata.Location = new System.Drawing.Point(0, 0);
            this.panel_projectdata.Name = "panel_projectdata";
            this.panel_projectdata.Size = new System.Drawing.Size(444, 376);
            this.panel_projectdata.TabIndex = 8;
            // 
            // listbox_changes
            // 
            this.listbox_changes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listbox_changes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_changes.ForeColor = System.Drawing.Color.White;
            this.listbox_changes.FormattingEnabled = true;
            this.listbox_changes.ItemHeight = 22;
            this.listbox_changes.Items.AddRange(new object[] {
            "UI Redesign",
            "API Remote",
            "Rewrote Excel API",
            "Custom Text Editor",
            "Created Recent Files List",
            "Various Tweaks to UI",
            "Column Repositioning Added"});
            this.listbox_changes.Location = new System.Drawing.Point(31, 177);
            this.listbox_changes.Name = "listbox_changes";
            this.listbox_changes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listbox_changes.Size = new System.Drawing.Size(232, 110);
            this.listbox_changes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(27, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected API (.dll):";
            this.ToolTip.SetToolTip(this.label4, "Choose which spreadsheet program to use\r\n");
            // 
            // dropdown_selectedApi
            // 
            this.dropdown_selectedApi.BackColor = System.Drawing.Color.White;
            this.dropdown_selectedApi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdown_selectedApi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_selectedApi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dropdown_selectedApi.ForeColor = System.Drawing.Color.Black;
            this.dropdown_selectedApi.FormattingEnabled = true;
            this.dropdown_selectedApi.Location = new System.Drawing.Point(31, 316);
            this.dropdown_selectedApi.Name = "dropdown_selectedApi";
            this.dropdown_selectedApi.Size = new System.Drawing.Size(213, 30);
            this.dropdown_selectedApi.TabIndex = 4;
            // 
            // label_changes
            // 
            this.label_changes.AutoSize = true;
            this.label_changes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label_changes.Location = new System.Drawing.Point(25, 152);
            this.label_changes.Name = "label_changes";
            this.label_changes.Size = new System.Drawing.Size(68, 22);
            this.label_changes.TabIndex = 3;
            this.label_changes.Text = "Changes";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label_description.Location = new System.Drawing.Point(25, 33);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(91, 22);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Description";
            // 
            // label_descriptiondata
            // 
            this.label_descriptiondata.AutoSize = true;
            this.label_descriptiondata.ForeColor = System.Drawing.Color.White;
            this.label_descriptiondata.Location = new System.Drawing.Point(25, 55);
            this.label_descriptiondata.Name = "label_descriptiondata";
            this.label_descriptiondata.Size = new System.Drawing.Size(394, 66);
            this.label_descriptiondata.TabIndex = 0;
            this.label_descriptiondata.Text = "I didn\'t want to relearn how I wrote this project\r\nso I rewrote it again. Everyth" +
    "ing should be somewhat\r\nsimilar";
            // 
            // picture_clifton
            // 
            this.picture_clifton.Image = global::SampleNote.Main.Properties.Resources.Clifton_Logo_Dark_235_psd;
            this.picture_clifton.Location = new System.Drawing.Point(256, 196);
            this.picture_clifton.Name = "picture_clifton";
            this.picture_clifton.Size = new System.Drawing.Size(264, 265);
            this.picture_clifton.TabIndex = 6;
            this.picture_clifton.TabStop = false;
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(191)))));
            this.button_enter.FlatAppearance.BorderSize = 0;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.ForeColor = System.Drawing.Color.White;
            this.button_enter.Location = new System.Drawing.Point(147, 313);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(162, 35);
            this.button_enter.TabIndex = 7;
            this.button_enter.Text = "Access File";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // label_filesize
            // 
            this.label_filesize.AutoSize = true;
            this.label_filesize.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label_filesize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_filesize.Location = new System.Drawing.Point(93, 121);
            this.label_filesize.Name = "label_filesize";
            this.label_filesize.Size = new System.Drawing.Size(30, 18);
            this.label_filesize.TabIndex = 6;
            this.label_filesize.Text = "0kb";
            // 
            // label_filesizeheader
            // 
            this.label_filesizeheader.AutoSize = true;
            this.label_filesizeheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_filesizeheader.Location = new System.Drawing.Point(92, 99);
            this.label_filesizeheader.Name = "label_filesizeheader";
            this.label_filesizeheader.Size = new System.Drawing.Size(71, 22);
            this.label_filesizeheader.TabIndex = 5;
            this.label_filesizeheader.Text = "File Size";
            // 
            // label_dataheader
            // 
            this.label_dataheader.AutoSize = true;
            this.label_dataheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(139)))), ((int)(((byte)(201)))));
            this.label_dataheader.Location = new System.Drawing.Point(92, 33);
            this.label_dataheader.Name = "label_dataheader";
            this.label_dataheader.Size = new System.Drawing.Size(116, 22);
            this.label_dataheader.TabIndex = 4;
            this.label_dataheader.Text = "Excel File Data";
            // 
            // label_filepath
            // 
            this.label_filepath.AutoEllipsis = true;
            this.label_filepath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_filepath.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label_filepath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_filepath.Location = new System.Drawing.Point(92, 196);
            this.label_filepath.Name = "label_filepath";
            this.label_filepath.Size = new System.Drawing.Size(265, 18);
            this.label_filepath.TabIndex = 3;
            this.label_filepath.Text = "\"File Path\"";
            // 
            // label_passwordheader
            // 
            this.label_passwordheader.AutoSize = true;
            this.label_passwordheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_passwordheader.Location = new System.Drawing.Point(91, 252);
            this.label_passwordheader.Name = "label_passwordheader";
            this.label_passwordheader.Size = new System.Drawing.Size(75, 22);
            this.label_passwordheader.TabIndex = 2;
            this.label_passwordheader.Text = "Password";
            // 
            // label_filenpathheader
            // 
            this.label_filenpathheader.AutoSize = true;
            this.label_filenpathheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_filenpathheader.Location = new System.Drawing.Point(91, 174);
            this.label_filenpathheader.Name = "label_filenpathheader";
            this.label_filenpathheader.Size = new System.Drawing.Size(72, 22);
            this.label_filenpathheader.TabIndex = 1;
            this.label_filenpathheader.Text = "File Path";
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(96, 277);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(261, 26);
            this.input_password.TabIndex = 0;
            this.input_password.Text = "Enter Password";
            this.input_password.Click += new System.EventHandler(this.input_password_Click);
            // 
            // button_back
            // 
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Verdana", 10F);
            this.button_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.button_back.Location = new System.Drawing.Point(18, 341);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 29);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "< Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_filename
            // 
            this.label_filename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_filename.Location = new System.Drawing.Point(92, 66);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(265, 22);
            this.label_filename.TabIndex = 10;
            this.label_filename.Text = "File Name";
            this.label_filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkbox_showpassword
            // 
            this.checkbox_showpassword.AutoSize = true;
            this.checkbox_showpassword.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.checkbox_showpassword.ForeColor = System.Drawing.Color.White;
            this.checkbox_showpassword.Location = new System.Drawing.Point(256, 256);
            this.checkbox_showpassword.Name = "checkbox_showpassword";
            this.checkbox_showpassword.Size = new System.Drawing.Size(101, 20);
            this.checkbox_showpassword.TabIndex = 11;
            this.checkbox_showpassword.Text = "Show Password";
            this.checkbox_showpassword.UseVisualStyleBackColor = true;
            this.checkbox_showpassword.CheckedChanged += new System.EventHandler(this.checkbox_showpassword_CheckedChanged);
            // 
            // dialog_openFile
            // 
            this.dialog_openFile.Title = "Load File - Select the formatted file";
            // 
            // dialog_newFile
            // 
            this.dialog_newFile.Title = "New File - Name the file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(65, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "NET Framework 4.6.1 | Excel Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "SampleNote v3";
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 400;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.OwnerDraw = true;
            // 
            // listbox_recentFiles
            // 
            this.listbox_recentFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listbox_recentFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_recentFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listbox_recentFiles.ForeColor = System.Drawing.Color.White;
            this.listbox_recentFiles.FormattingEnabled = true;
            this.listbox_recentFiles.ItemHeight = 22;
            this.listbox_recentFiles.Location = new System.Drawing.Point(35, 66);
            this.listbox_recentFiles.Name = "listbox_recentFiles";
            this.listbox_recentFiles.Size = new System.Drawing.Size(265, 220);
            this.listbox_recentFiles.TabIndex = 9;
            this.ToolTip.SetToolTip(this.listbox_recentFiles, "Double Click to Select");
            this.listbox_recentFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_recentFiles_MouseDoubleClick);
            // 
            // panel_dragdropoutside
            // 
            this.panel_dragdropoutside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_dragdropoutside.Controls.Add(this.panel_dragdropprompt);
            this.panel_dragdropoutside.Location = new System.Drawing.Point(0, 30);
            this.panel_dragdropoutside.Name = "panel_dragdropoutside";
            this.panel_dragdropoutside.Size = new System.Drawing.Size(0, 0);
            this.panel_dragdropoutside.TabIndex = 10;
            this.panel_dragdropoutside.Visible = false;
            // 
            // panel_dragdropprompt
            // 
            this.panel_dragdropprompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel_dragdropprompt.Controls.Add(this.picturebox_upload);
            this.panel_dragdropprompt.Controls.Add(this.label_ddafilehere);
            this.panel_dragdropprompt.Location = new System.Drawing.Point(68, 20);
            this.panel_dragdropprompt.Name = "panel_dragdropprompt";
            this.panel_dragdropprompt.Size = new System.Drawing.Size(637, 328);
            this.panel_dragdropprompt.TabIndex = 3;
            // 
            // picturebox_upload
            // 
            this.picturebox_upload.BackColor = System.Drawing.Color.Transparent;
            this.picturebox_upload.Image = global::SampleNote.Main.Properties.Resources.Upload_Graphic;
            this.picturebox_upload.Location = new System.Drawing.Point(211, 100);
            this.picturebox_upload.Name = "picturebox_upload";
            this.picturebox_upload.Size = new System.Drawing.Size(200, 120);
            this.picturebox_upload.TabIndex = 4;
            this.picturebox_upload.TabStop = false;
            // 
            // label_ddafilehere
            // 
            this.label_ddafilehere.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.label_ddafilehere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_ddafilehere.Location = new System.Drawing.Point(190, 239);
            this.label_ddafilehere.Name = "label_ddafilehere";
            this.label_ddafilehere.Size = new System.Drawing.Size(240, 26);
            this.label_ddafilehere.TabIndex = 3;
            this.label_ddafilehere.Text = "Drag and Drop a file here";
            this.label_ddafilehere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_loadscreen
            // 
            this.panel_loadscreen.Controls.Add(this.label_loading);
            this.panel_loadscreen.Controls.Add(this.picturebox_loading);
            this.panel_loadscreen.Location = new System.Drawing.Point(0, 30);
            this.panel_loadscreen.Name = "panel_loadscreen";
            this.panel_loadscreen.Size = new System.Drawing.Size(0, 0);
            this.panel_loadscreen.TabIndex = 7;
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.ForeColor = System.Drawing.Color.White;
            this.label_loading.Location = new System.Drawing.Point(335, 263);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(114, 22);
            this.label_loading.TabIndex = 7;
            this.label_loading.Text = "Loading File...";
            // 
            // picturebox_loading
            // 
            this.picturebox_loading.BackColor = System.Drawing.Color.Transparent;
            this.picturebox_loading.Image = global::SampleNote.Main.Properties.Resources.Loading_File;
            this.picturebox_loading.Location = new System.Drawing.Point(288, 129);
            this.picturebox_loading.Name = "picturebox_loading";
            this.picturebox_loading.Size = new System.Drawing.Size(200, 120);
            this.picturebox_loading.TabIndex = 6;
            this.picturebox_loading.TabStop = false;
            // 
            // picture_newfile
            // 
            this.picture_newfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.picture_newfile.Enabled = false;
            this.picture_newfile.Image = ((System.Drawing.Image)(resources.GetObject("picture_newfile.Image")));
            this.picture_newfile.Location = new System.Drawing.Point(35, 299);
            this.picture_newfile.Name = "picture_newfile";
            this.picture_newfile.Size = new System.Drawing.Size(45, 34);
            this.picture_newfile.TabIndex = 13;
            this.picture_newfile.TabStop = false;
            // 
            // picture_loadFile
            // 
            this.picture_loadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.picture_loadFile.Enabled = false;
            this.picture_loadFile.Image = global::SampleNote.Main.Properties.Resources.Button_Vector___Load_File_2;
            this.picture_loadFile.Location = new System.Drawing.Point(35, 343);
            this.picture_loadFile.Name = "picture_loadFile";
            this.picture_loadFile.Size = new System.Drawing.Size(45, 34);
            this.picture_loadFile.TabIndex = 14;
            this.picture_loadFile.TabStop = false;
            // 
            // Launcher
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(776, 406);
            this.Controls.Add(this.panel_loadscreen);
            this.Controls.Add(this.panel_dragdropoutside);
            this.Controls.Add(this.listbox_recentFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_filedata);
            this.Controls.Add(this.Form_Header);
            this.Controls.Add(this.picture_newfile);
            this.Controls.Add(this.button_newfile);
            this.Controls.Add(this.picture_loadFile);
            this.Controls.Add(this.button_loadfile);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Launcher";
            this.Text = " ";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Launcher_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Launcher_DragEnter);
            this.DragLeave += new System.EventHandler(this.Launcher_DragLeave);
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.panel_filedata.ResumeLayout(false);
            this.panel_filedata.PerformLayout();
            this.panel_projectdata.ResumeLayout(false);
            this.panel_projectdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clifton)).EndInit();
            this.panel_dragdropoutside.ResumeLayout(false);
            this.panel_dragdropprompt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_upload)).EndInit();
            this.panel_loadscreen.ResumeLayout(false);
            this.panel_loadscreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_newfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_loadFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Button button_loadfile;
        private System.Windows.Forms.Button button_newfile;
        private System.Windows.Forms.Panel panel_filedata;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.OpenFileDialog dialog_openFile;
        private System.Windows.Forms.SaveFileDialog dialog_newFile;
        private System.Windows.Forms.Label label_filepath;
        private System.Windows.Forms.Label label_passwordheader;
        private System.Windows.Forms.Label label_filenpathheader;
        private System.Windows.Forms.Label label_dataheader;
        private System.Windows.Forms.Label label_filesize;
        private System.Windows.Forms.Label label_filesizeheader;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_projectdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_descriptiondata;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_changes;
        private System.Windows.Forms.ComboBox dropdown_selectedApi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.CheckBox checkbox_showpassword;
        private System.Windows.Forms.ListBox listbox_recentFiles;
        private System.Windows.Forms.Panel panel_dragdropoutside;
        private System.Windows.Forms.Panel panel_dragdropprompt;
        private System.Windows.Forms.PictureBox picturebox_upload;
        private System.Windows.Forms.Label label_ddafilehere;
        private System.Windows.Forms.PictureBox picturebox_loading;
        private System.Windows.Forms.Panel panel_loadscreen;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.PictureBox picture_clifton;
        private System.Windows.Forms.PictureBox picture_newfile;
        private System.Windows.Forms.PictureBox picture_loadFile;
        private System.Windows.Forms.ListBox listbox_changes;
    }
}

