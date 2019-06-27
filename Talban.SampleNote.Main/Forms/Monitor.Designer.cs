namespace SampleNote.Main.Forms
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.BORDER = new System.Windows.Forms.PictureBox();
            this.label_clock = new System.Windows.Forms.Label();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.panel_columns = new System.Windows.Forms.Panel();
            this.H = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
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
            this.DataExpansionTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Form_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER)).BeginInit();
            this.panel_columns.SuspendLayout();
            this.panel_contents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.BORDER);
            this.Form_Header.Controls.Add(this.label_clock);
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(1162, 39);
            this.Form_Header.TabIndex = 3;
            // 
            // BORDER
            // 
            this.BORDER.Dock = System.Windows.Forms.DockStyle.Left;
            this.BORDER.Enabled = false;
            this.BORDER.Image = global::SampleNote.Main.Properties.Resources.Half_Triangle;
            this.BORDER.Location = new System.Drawing.Point(221, 0);
            this.BORDER.Name = "BORDER";
            this.BORDER.Size = new System.Drawing.Size(35, 39);
            this.BORDER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BORDER.TabIndex = 5;
            this.BORDER.TabStop = false;
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Location = new System.Drawing.Point(383, 9);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(38, 22);
            this.label_clock.TabIndex = 4;
            this.label_clock.Text = "DTP";
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
            this.button_exitform.Location = new System.Drawing.Point(1057, 0);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(105, 39);
            this.button_exitform.TabIndex = 3;
            this.button_exitform.Text = "Exit";
            this.button_exitform.UseVisualStyleBackColor = false;
            this.button_exitform.Click += new System.EventHandler(this.button_exitform_Click);
            // 
            // FormName
            // 
            this.FormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(138)))), ((int)(((byte)(201)))));
            this.FormName.Dock = System.Windows.Forms.DockStyle.Left;
            this.FormName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.ForeColor = System.Drawing.Color.White;
            this.FormName.Location = new System.Drawing.Point(0, 0);
            this.FormName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(221, 39);
            this.FormName.TabIndex = 0;
            this.FormName.Text = " SampleNote Monitor";
            this.FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_columns
            // 
            this.panel_columns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_columns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.panel_columns.Controls.Add(this.H);
            this.panel_columns.Controls.Add(this.M);
            this.panel_columns.Controls.Add(this.G);
            this.panel_columns.Controls.Add(this.F);
            this.panel_columns.Controls.Add(this.E);
            this.panel_columns.Controls.Add(this.C);
            this.panel_columns.Controls.Add(this.label2);
            this.panel_columns.Controls.Add(this.A);
            this.panel_columns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_columns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_columns.ForeColor = System.Drawing.Color.White;
            this.panel_columns.Location = new System.Drawing.Point(0, 39);
            this.panel_columns.Name = "panel_columns";
            this.panel_columns.Size = new System.Drawing.Size(1162, 45);
            this.panel_columns.TabIndex = 6;
            // 
            // H
            // 
            this.H.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.ForeColor = System.Drawing.Color.White;
            this.H.Location = new System.Drawing.Point(858, 17);
            this.H.Margin = new System.Windows.Forms.Padding(0);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(124, 16);
            this.H.TabIndex = 7;
            this.H.Tag = "Samp. Location";
            this.H.Text = "Sample Location";
            // 
            // M
            // 
            this.M.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.ForeColor = System.Drawing.Color.White;
            this.M.Location = new System.Drawing.Point(1016, 17);
            this.M.Margin = new System.Windows.Forms.Padding(0);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(125, 16);
            this.M.TabIndex = 8;
            this.M.Tag = "Tests Required";
            this.M.Text = "Test(s) Required";
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
            // C
            // 
            this.C.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.C.AutoSize = true;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Project Number";
            this.label2.Text = "Project #";
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
            this.panel_contents.Size = new System.Drawing.Size(1162, 594);
            this.panel_contents.TabIndex = 7;
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
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(135)))));
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
            // DataExpansionTooltip
            // 
            this.DataExpansionTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.DataExpansionTooltip.ForeColor = System.Drawing.Color.White;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1162, 678);
            this.Controls.Add(this.panel_contents);
            this.Controls.Add(this.panel_columns);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BORDER)).EndInit();
            this.panel_columns.ResumeLayout(false);
            this.panel_columns.PerformLayout();
            this.panel_contents.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.PictureBox BORDER;
        private System.Windows.Forms.Panel panel_columns;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.FlowLayoutPanel panel_contents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip DataExpansionTooltip;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label M;
    }
}