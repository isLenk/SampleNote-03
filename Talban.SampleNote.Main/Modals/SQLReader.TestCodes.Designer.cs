namespace SampleNote.Main.Modals
{
    partial class SQLReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLReader));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.tb_Code = new System.Windows.Forms.TextBox();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_TestName = new System.Windows.Forms.Label();
            this.tb_TestName = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.btn_AddRecord = new System.Windows.Forms.Button();
            this.tb_Nickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.NCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(10, 18, 10, 18);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(1154, 35);
            this.Form_Header.TabIndex = 3;
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
            this.button_exitform.Location = new System.Drawing.Point(1029, 0);
            this.button_exitform.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(125, 35);
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
            this.FormName.Location = new System.Drawing.Point(10, 8);
            this.FormName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(224, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = " SampleNote SQL Tests Reader";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCode,
            this.Nickname,
            this.TestName,
            this.Category});
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataGrid.Location = new System.Drawing.Point(15, 45);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.Size = new System.Drawing.Size(1125, 450);
            this.DataGrid.TabIndex = 4;
            // 
            // tb_Code
            // 
            this.tb_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Code.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Code.Location = new System.Drawing.Point(66, 508);
            this.tb_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Size = new System.Drawing.Size(117, 19);
            this.tb_Code.TabIndex = 5;
            // 
            // lbl_Code
            // 
            this.lbl_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.ForeColor = System.Drawing.Color.White;
            this.lbl_Code.Location = new System.Drawing.Point(18, 510);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(42, 18);
            this.lbl_Code.TabIndex = 6;
            this.lbl_Code.Text = "Code:";
            // 
            // lbl_TestName
            // 
            this.lbl_TestName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_TestName.AutoSize = true;
            this.lbl_TestName.ForeColor = System.Drawing.Color.White;
            this.lbl_TestName.Location = new System.Drawing.Point(406, 510);
            this.lbl_TestName.Name = "lbl_TestName";
            this.lbl_TestName.Size = new System.Drawing.Size(74, 18);
            this.lbl_TestName.TabIndex = 7;
            this.lbl_TestName.Text = "Test Name:";
            // 
            // tb_TestName
            // 
            this.tb_TestName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_TestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TestName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TestName.Location = new System.Drawing.Point(486, 509);
            this.tb_TestName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TestName.Name = "tb_TestName";
            this.tb_TestName.Size = new System.Drawing.Size(255, 19);
            this.tb_TestName.TabIndex = 8;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.ForeColor = System.Drawing.Color.White;
            this.lbl_Category.Location = new System.Drawing.Point(747, 510);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(65, 18);
            this.lbl_Category.TabIndex = 9;
            this.lbl_Category.Text = "Category:";
            // 
            // cbx_category
            // 
            this.cbx_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_category.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(818, 505);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(181, 24);
            this.cbx_category.TabIndex = 10;
            // 
            // btn_AddRecord
            // 
            this.btn_AddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btn_AddRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btn_AddRecord.FlatAppearance.BorderSize = 0;
            this.btn_AddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRecord.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btn_AddRecord.ForeColor = System.Drawing.Color.White;
            this.btn_AddRecord.Location = new System.Drawing.Point(1005, 505);
            this.btn_AddRecord.Name = "btn_AddRecord";
            this.btn_AddRecord.Size = new System.Drawing.Size(128, 23);
            this.btn_AddRecord.TabIndex = 11;
            this.btn_AddRecord.Text = "Add Record";
            this.btn_AddRecord.UseVisualStyleBackColor = false;
            this.btn_AddRecord.Click += new System.EventHandler(this.btn_AddRecord_Click);
            // 
            // tb_Nickname
            // 
            this.tb_Nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_Nickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Nickname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nickname.Location = new System.Drawing.Point(269, 509);
            this.tb_Nickname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Nickname.Name = "tb_Nickname";
            this.tb_Nickname.Size = new System.Drawing.Size(131, 19);
            this.tb_Nickname.TabIndex = 13;
            // 
            // lblNickname
            // 
            this.lblNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNickname.AutoSize = true;
            this.lblNickname.ForeColor = System.Drawing.Color.White;
            this.lblNickname.Location = new System.Drawing.Point(193, 510);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(70, 18);
            this.lblNickname.TabIndex = 12;
            this.lblNickname.Text = "Nickname:";
            // 
            // NCode
            // 
            this.NCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NCode.HeaderText = "Code";
            this.NCode.Name = "NCode";
            this.NCode.ReadOnly = true;
            this.NCode.Width = 80;
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            this.Nickname.Width = 250;
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 140;
            // 
            // SQLReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1154, 537);
            this.Controls.Add(this.tb_Nickname);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.btn_AddRecord);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.tb_TestName);
            this.Controls.Add(this.lbl_TestName);
            this.Controls.Add(this.lbl_Code);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SQLReader";
            this.Text = "Test Codes SQL Reader";
            this.TopMost = true;
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.TextBox tb_Code;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_TestName;
        private System.Windows.Forms.TextBox tb_TestName;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Button btn_AddRecord;
        private System.Windows.Forms.TextBox tb_Nickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}