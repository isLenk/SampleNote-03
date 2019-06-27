namespace SampleNote.Main.Forms
{
    partial class User_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Control));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_opendataform = new System.Windows.Forms.Button();
            this.button_exitform = new System.Windows.Forms.Button();
            this.BORDER = new System.Windows.Forms.PictureBox();
            this.panel_menubutton = new System.Windows.Forms.Panel();
            this.panel_menuUnderline = new System.Windows.Forms.Panel();
            this.FormName = new System.Windows.Forms.Label();
            this.panel_contents = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.Label();
            this.panel_columns = new System.Windows.Forms.Panel();
            this.panel_usercontrol = new System.Windows.Forms.Panel();
            this.button_showhistory = new System.Windows.Forms.Button();
            this.button_safeExit = new System.Windows.Forms.Button();
            this.panel_menuborder = new System.Windows.Forms.Panel();
            this.button_customization = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_formlhelp = new System.Windows.Forms.Button();
            this.button_generalhelp = new System.Windows.Forms.Button();
            this.groupbox_data = new System.Windows.Forms.GroupBox();
            this.button_quickbackup = new System.Windows.Forms.Button();
            this.button_createbackup = new System.Windows.Forms.Button();
            this.groupbox_forms = new System.Windows.Forms.GroupBox();
            this.button_openmonitor = new System.Windows.Forms.Button();
            this.button_createsamplelog = new System.Windows.Forms.Button();
            this.panel_usercontrolHeader = new System.Windows.Forms.Panel();
            this.label_menu = new System.Windows.Forms.Label();
            this.DataExpansionTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Dialog_BakFile = new System.Windows.Forms.SaveFileDialog();
            this.Form_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER)).BeginInit();
            this.panel_menubutton.SuspendLayout();
            this.panel_contents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_columns.SuspendLayout();
            this.panel_usercontrol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupbox_data.SuspendLayout();
            this.groupbox_forms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.button_opendataform);
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.BORDER);
            this.Form_Header.Controls.Add(this.panel_menubutton);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(1303, 39);
            this.Form_Header.TabIndex = 1;
            // 
            // button_opendataform
            // 
            this.button_opendataform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(108)))), ((int)(((byte)(171)))));
            this.button_opendataform.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_opendataform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_opendataform.FlatAppearance.BorderSize = 0;
            this.button_opendataform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_opendataform.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.button_opendataform.ForeColor = System.Drawing.Color.White;
            this.button_opendataform.Location = new System.Drawing.Point(1023, 0);
            this.button_opendataform.Name = "button_opendataform";
            this.button_opendataform.Size = new System.Drawing.Size(175, 39);
            this.button_opendataform.TabIndex = 5;
            this.button_opendataform.Text = "+ WRITE SAMPLE";
            this.button_opendataform.UseVisualStyleBackColor = false;
            this.button_opendataform.Click += new System.EventHandler(this.button_opendataform_Click);
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
            this.button_exitform.Location = new System.Drawing.Point(1198, 0);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(105, 39);
            this.button_exitform.TabIndex = 4;
            this.button_exitform.Text = "Exit";
            this.button_exitform.UseVisualStyleBackColor = false;
            this.button_exitform.Click += new System.EventHandler(this.button_exitform_Click);
            // 
            // BORDER
            // 
            this.BORDER.Dock = System.Windows.Forms.DockStyle.Left;
            this.BORDER.Enabled = false;
            this.BORDER.Image = global::SampleNote.Main.Properties.Resources.Half_Triangle;
            this.BORDER.Location = new System.Drawing.Point(226, 0);
            this.BORDER.Name = "BORDER";
            this.BORDER.Size = new System.Drawing.Size(35, 39);
            this.BORDER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BORDER.TabIndex = 3;
            this.BORDER.TabStop = false;
            // 
            // panel_menubutton
            // 
            this.panel_menubutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(201)))));
            this.panel_menubutton.Controls.Add(this.panel_menuUnderline);
            this.panel_menubutton.Controls.Add(this.FormName);
            this.panel_menubutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menubutton.Location = new System.Drawing.Point(0, 0);
            this.panel_menubutton.Name = "panel_menubutton";
            this.panel_menubutton.Size = new System.Drawing.Size(226, 39);
            this.panel_menubutton.TabIndex = 2;
            // 
            // panel_menuUnderline
            // 
            this.panel_menuUnderline.BackColor = System.Drawing.Color.Black;
            this.panel_menuUnderline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_menuUnderline.Location = new System.Drawing.Point(0, 36);
            this.panel_menuUnderline.Name = "panel_menuUnderline";
            this.panel_menuUnderline.Size = new System.Drawing.Size(226, 3);
            this.panel_menuUnderline.TabIndex = 3;
            this.panel_menuUnderline.Visible = false;
            // 
            // FormName
            // 
            this.FormName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.ForeColor = System.Drawing.Color.White;
            this.FormName.Location = new System.Drawing.Point(-1, 0);
            this.FormName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(227, 39);
            this.FormName.TabIndex = 0;
            this.FormName.Text = " SampleNote User Control";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormName_MouseDown);
            this.FormName.MouseEnter += new System.EventHandler(this.FormName_MouseEnter);
            this.FormName.MouseLeave += new System.EventHandler(this.FormName_MouseLeave);
            // 
            // panel_contents
            // 
            this.panel_contents.AutoScroll = true;
            this.panel_contents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_contents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel_contents.Controls.Add(this.panel2);
            this.panel_contents.Controls.Add(this.panel3);
            this.panel_contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_contents.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.panel_contents.Location = new System.Drawing.Point(0, 84);
            this.panel_contents.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel_contents.Name = "panel_contents";
            this.panel_contents.Size = new System.Drawing.Size(1303, 513);
            this.panel_contents.TabIndex = 4;
            this.panel_contents.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 60);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(904, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 57);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button5.Location = new System.Drawing.Point(84, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(531, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(204, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "HEREREERE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "12312";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "L0001";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1300, 60);
            this.panel3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(202, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "12312";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(100, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "12312";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.label10.Location = new System.Drawing.Point(3, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "L0001";
            // 
            // A
            // 
            this.A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(9, 17);
            this.A.Margin = new System.Windows.Forms.Padding(0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(73, 16);
            this.A.TabIndex = 1;
            this.A.Tag = "Sample Number";
            this.A.Text = "Sample #";
            // 
            // B
            // 
            this.B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(104, 17);
            this.B.Margin = new System.Windows.Forms.Padding(0);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(69, 16);
            this.B.TabIndex = 2;
            this.B.Tag = "Project Number";
            this.B.Text = "Project #";
            // 
            // C
            // 
            this.C.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.Color.White;
            this.C.Location = new System.Drawing.Point(206, 17);
            this.C.Margin = new System.Windows.Forms.Padding(0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(102, 16);
            this.C.TabIndex = 3;
            this.C.Tag = "Project Name";
            this.C.Text = "Project Name";
            // 
            // E
            // 
            this.E.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.E.AutoSize = true;
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.ForeColor = System.Drawing.Color.White;
            this.E.Location = new System.Drawing.Point(384, 17);
            this.E.Margin = new System.Windows.Forms.Padding(0);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(92, 16);
            this.E.TabIndex = 4;
            this.E.Tag = "Client Name";
            this.E.Text = "Client Name";
            // 
            // F
            // 
            this.F.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.ForeColor = System.Drawing.Color.White;
            this.F.Location = new System.Drawing.Point(531, 17);
            this.F.Margin = new System.Windows.Forms.Padding(0);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(112, 16);
            this.F.TabIndex = 5;
            this.F.Tag = "Date Recieved";
            this.F.Text = "Date Recieved";
            // 
            // G
            // 
            this.G.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.G.AutoSize = true;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.ForeColor = System.Drawing.Color.White;
            this.G.Location = new System.Drawing.Point(692, 17);
            this.G.Margin = new System.Windows.Forms.Padding(0);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(144, 16);
            this.G.TabIndex = 6;
            this.G.Tag = "Samp. Description";
            this.G.Text = "Sample Description";
            // 
            // M
            // 
            this.M.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.ForeColor = System.Drawing.Color.White;
            this.M.Location = new System.Drawing.Point(917, 17);
            this.M.Margin = new System.Windows.Forms.Padding(0);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(125, 16);
            this.M.TabIndex = 7;
            this.M.Tag = "Tests Required";
            this.M.Text = "Test(s) Required";
            // 
            // panel_columns
            // 
            this.panel_columns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_columns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.panel_columns.Controls.Add(this.M);
            this.panel_columns.Controls.Add(this.G);
            this.panel_columns.Controls.Add(this.F);
            this.panel_columns.Controls.Add(this.E);
            this.panel_columns.Controls.Add(this.C);
            this.panel_columns.Controls.Add(this.B);
            this.panel_columns.Controls.Add(this.A);
            this.panel_columns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_columns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_columns.ForeColor = System.Drawing.Color.White;
            this.panel_columns.Location = new System.Drawing.Point(0, 39);
            this.panel_columns.Name = "panel_columns";
            this.panel_columns.Size = new System.Drawing.Size(1303, 45);
            this.panel_columns.TabIndex = 3;
            // 
            // panel_usercontrol
            // 
            this.panel_usercontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel_usercontrol.Controls.Add(this.button_showhistory);
            this.panel_usercontrol.Controls.Add(this.button_safeExit);
            this.panel_usercontrol.Controls.Add(this.panel_menuborder);
            this.panel_usercontrol.Controls.Add(this.button_customization);
            this.panel_usercontrol.Controls.Add(this.groupBox1);
            this.panel_usercontrol.Controls.Add(this.groupbox_data);
            this.panel_usercontrol.Controls.Add(this.groupbox_forms);
            this.panel_usercontrol.Controls.Add(this.panel_usercontrolHeader);
            this.panel_usercontrol.Controls.Add(this.label_menu);
            this.panel_usercontrol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_usercontrol.ForeColor = System.Drawing.Color.White;
            this.panel_usercontrol.Location = new System.Drawing.Point(0, 84);
            this.panel_usercontrol.Name = "panel_usercontrol";
            this.panel_usercontrol.Size = new System.Drawing.Size(3, 513);
            this.panel_usercontrol.TabIndex = 5;
            // 
            // button_showhistory
            // 
            this.button_showhistory.BackColor = System.Drawing.Color.White;
            this.button_showhistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_showhistory.FlatAppearance.BorderSize = 0;
            this.button_showhistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_showhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showhistory.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_showhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.button_showhistory.Location = new System.Drawing.Point(21, 407);
            this.button_showhistory.Name = "button_showhistory";
            this.button_showhistory.Size = new System.Drawing.Size(80, 34);
            this.button_showhistory.TabIndex = 10;
            this.button_showhistory.Text = "History";
            this.button_showhistory.UseVisualStyleBackColor = false;
            this.button_showhistory.Click += new System.EventHandler(this.button_showhistory_Click);
            // 
            // button_safeExit
            // 
            this.button_safeExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_safeExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.button_safeExit.FlatAppearance.BorderSize = 0;
            this.button_safeExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(131)))));
            this.button_safeExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.button_safeExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_safeExit.Location = new System.Drawing.Point(0, 477);
            this.button_safeExit.Name = "button_safeExit";
            this.button_safeExit.Size = new System.Drawing.Size(0, 36);
            this.button_safeExit.TabIndex = 9;
            this.button_safeExit.Text = "Safe Exit App";
            this.button_safeExit.UseVisualStyleBackColor = true;
            // 
            // panel_menuborder
            // 
            this.panel_menuborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.panel_menuborder.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_menuborder.Location = new System.Drawing.Point(0, 3);
            this.panel_menuborder.Name = "panel_menuborder";
            this.panel_menuborder.Size = new System.Drawing.Size(3, 510);
            this.panel_menuborder.TabIndex = 8;
            // 
            // button_customization
            // 
            this.button_customization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_customization.Enabled = false;
            this.button_customization.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_customization.FlatAppearance.BorderSize = 0;
            this.button_customization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.button_customization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customization.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_customization.ForeColor = System.Drawing.Color.White;
            this.button_customization.Location = new System.Drawing.Point(107, 407);
            this.button_customization.Name = "button_customization";
            this.button_customization.Size = new System.Drawing.Size(178, 34);
            this.button_customization.TabIndex = 6;
            this.button_customization.Text = "Customization";
            this.button_customization.UseVisualStyleBackColor = false;
            this.button_customization.Click += new System.EventHandler(this.button_customization_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_formlhelp);
            this.groupBox1.Controls.Add(this.button_generalhelp);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HELP";
            // 
            // button_formlhelp
            // 
            this.button_formlhelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_formlhelp.BackColor = System.Drawing.Color.White;
            this.button_formlhelp.FlatAppearance.BorderSize = 0;
            this.button_formlhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_formlhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_formlhelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.button_formlhelp.Location = new System.Drawing.Point(9, 62);
            this.button_formlhelp.Name = "button_formlhelp";
            this.button_formlhelp.Size = new System.Drawing.Size(264, 34);
            this.button_formlhelp.TabIndex = 5;
            this.button_formlhelp.Text = "Form Help";
            this.button_formlhelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_formlhelp.UseVisualStyleBackColor = false;
            // 
            // button_generalhelp
            // 
            this.button_generalhelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_generalhelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_generalhelp.FlatAppearance.BorderSize = 0;
            this.button_generalhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generalhelp.ForeColor = System.Drawing.Color.White;
            this.button_generalhelp.Location = new System.Drawing.Point(9, 22);
            this.button_generalhelp.Name = "button_generalhelp";
            this.button_generalhelp.Size = new System.Drawing.Size(264, 34);
            this.button_generalhelp.TabIndex = 3;
            this.button_generalhelp.Text = "General Help";
            this.button_generalhelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_generalhelp.UseVisualStyleBackColor = false;
            this.button_generalhelp.Click += new System.EventHandler(this.button_generalhelp_Click);
            // 
            // groupbox_data
            // 
            this.groupbox_data.Controls.Add(this.button_quickbackup);
            this.groupbox_data.Controls.Add(this.button_createbackup);
            this.groupbox_data.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.groupbox_data.Location = new System.Drawing.Point(12, 172);
            this.groupbox_data.Name = "groupbox_data";
            this.groupbox_data.Size = new System.Drawing.Size(285, 113);
            this.groupbox_data.TabIndex = 6;
            this.groupbox_data.TabStop = false;
            this.groupbox_data.Text = "DATA";
            // 
            // button_quickbackup
            // 
            this.button_quickbackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_quickbackup.BackColor = System.Drawing.Color.White;
            this.button_quickbackup.FlatAppearance.BorderSize = 0;
            this.button_quickbackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_quickbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quickbackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.button_quickbackup.Location = new System.Drawing.Point(9, 62);
            this.button_quickbackup.Name = "button_quickbackup";
            this.button_quickbackup.Size = new System.Drawing.Size(264, 34);
            this.button_quickbackup.TabIndex = 5;
            this.button_quickbackup.Text = "+ Create Quick Backup";
            this.button_quickbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_quickbackup.UseVisualStyleBackColor = false;
            this.button_quickbackup.Click += new System.EventHandler(this.button_quickbackup_Click);
            // 
            // button_createbackup
            // 
            this.button_createbackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_createbackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_createbackup.FlatAppearance.BorderSize = 0;
            this.button_createbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createbackup.ForeColor = System.Drawing.Color.White;
            this.button_createbackup.Location = new System.Drawing.Point(9, 22);
            this.button_createbackup.Name = "button_createbackup";
            this.button_createbackup.Size = new System.Drawing.Size(264, 34);
            this.button_createbackup.TabIndex = 4;
            this.button_createbackup.Text = "+ Create Local Backup";
            this.button_createbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_createbackup.UseVisualStyleBackColor = false;
            this.button_createbackup.Click += new System.EventHandler(this.button_createbackup_Click);
            // 
            // groupbox_forms
            // 
            this.groupbox_forms.BackColor = System.Drawing.Color.Transparent;
            this.groupbox_forms.Controls.Add(this.button_openmonitor);
            this.groupbox_forms.Controls.Add(this.button_createsamplelog);
            this.groupbox_forms.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_forms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.groupbox_forms.Location = new System.Drawing.Point(12, 60);
            this.groupbox_forms.Name = "groupbox_forms";
            this.groupbox_forms.Size = new System.Drawing.Size(285, 106);
            this.groupbox_forms.TabIndex = 5;
            this.groupbox_forms.TabStop = false;
            this.groupbox_forms.Text = "FORMS";
            // 
            // button_openmonitor
            // 
            this.button_openmonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openmonitor.BackColor = System.Drawing.Color.White;
            this.button_openmonitor.FlatAppearance.BorderSize = 0;
            this.button_openmonitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_openmonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openmonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.button_openmonitor.Location = new System.Drawing.Point(9, 60);
            this.button_openmonitor.Name = "button_openmonitor";
            this.button_openmonitor.Size = new System.Drawing.Size(264, 34);
            this.button_openmonitor.TabIndex = 4;
            this.button_openmonitor.Text = "+ Open Monitor";
            this.button_openmonitor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_openmonitor.UseVisualStyleBackColor = false;
            this.button_openmonitor.Click += new System.EventHandler(this.button_openmonitor_Click);
            // 
            // button_createsamplelog
            // 
            this.button_createsamplelog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_createsamplelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_createsamplelog.FlatAppearance.BorderSize = 0;
            this.button_createsamplelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createsamplelog.ForeColor = System.Drawing.Color.White;
            this.button_createsamplelog.Location = new System.Drawing.Point(9, 22);
            this.button_createsamplelog.Name = "button_createsamplelog";
            this.button_createsamplelog.Size = new System.Drawing.Size(264, 34);
            this.button_createsamplelog.TabIndex = 3;
            this.button_createsamplelog.Text = "+ Create Sample Log";
            this.button_createsamplelog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_createsamplelog.UseVisualStyleBackColor = false;
            this.button_createsamplelog.Click += new System.EventHandler(this.button_createsamplelog_Click);
            // 
            // panel_usercontrolHeader
            // 
            this.panel_usercontrolHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.panel_usercontrolHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_usercontrolHeader.Location = new System.Drawing.Point(0, 0);
            this.panel_usercontrolHeader.Name = "panel_usercontrolHeader";
            this.panel_usercontrolHeader.Size = new System.Drawing.Size(3, 3);
            this.panel_usercontrolHeader.TabIndex = 2;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.label_menu.Location = new System.Drawing.Point(12, 17);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(61, 24);
            this.label_menu.TabIndex = 0;
            this.label_menu.Text = "MENU";
            // 
            // DataExpansionTooltip
            // 
            this.DataExpansionTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.DataExpansionTooltip.ForeColor = System.Drawing.Color.White;
            // 
            // Dialog_BakFile
            // 
            this.Dialog_BakFile.Title = "Save Backup File To";
            // 
            // User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1303, 597);
            this.Controls.Add(this.panel_usercontrol);
            this.Controls.Add(this.panel_contents);
            this.Controls.Add(this.panel_columns);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User_Control";
            this.Text = "User_Control";
            this.Form_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BORDER)).EndInit();
            this.panel_menubutton.ResumeLayout(false);
            this.panel_contents.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_columns.ResumeLayout(false);
            this.panel_columns.PerformLayout();
            this.panel_usercontrol.ResumeLayout(false);
            this.panel_usercontrol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupbox_data.ResumeLayout(false);
            this.groupbox_forms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.FlowLayoutPanel panel_contents;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Panel panel_columns;
        private System.Windows.Forms.Panel panel_menubutton;
        private System.Windows.Forms.Panel panel_usercontrol;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Panel panel_usercontrolHeader;
        private System.Windows.Forms.Panel panel_menuUnderline;
        private System.Windows.Forms.Button button_createsamplelog;
        private System.Windows.Forms.Button button_openmonitor;
        private System.Windows.Forms.GroupBox groupbox_forms;
        private System.Windows.Forms.GroupBox groupbox_data;
        private System.Windows.Forms.Button button_createbackup;
        private System.Windows.Forms.ToolTip DataExpansionTooltip;
        private System.Windows.Forms.PictureBox BORDER;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_opendataform;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.SaveFileDialog Dialog_BakFile;
        private System.Windows.Forms.Button button_quickbackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_formlhelp;
        private System.Windows.Forms.Button button_generalhelp;
        private System.Windows.Forms.Button button_customization;
        private System.Windows.Forms.Button button_safeExit;
        private System.Windows.Forms.Panel panel_menuborder;
        private System.Windows.Forms.Button button_showhistory;
    }
}