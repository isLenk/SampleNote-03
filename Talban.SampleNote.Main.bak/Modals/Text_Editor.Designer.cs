namespace SampleNote.Main.Modals
{
    partial class Text_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text_Editor));
            this.Form_Header = new System.Windows.Forms.Panel();
            this.FormName = new System.Windows.Forms.Label();
            this.textbox_textdata = new System.Windows.Forms.RichTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel_filepath = new System.Windows.Forms.Panel();
            this.label_filepath = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.checkbox_backup = new System.Windows.Forms.CheckBox();
            this.Form_Header.SuspendLayout();
            this.panel_filepath.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(747, 30);
            this.Form_Header.TabIndex = 1;
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName.ForeColor = System.Drawing.Color.White;
            this.FormName.Location = new System.Drawing.Point(13, 5);
            this.FormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(184, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = " SampleNote Text Editor";
            // 
            // textbox_textdata
            // 
            this.textbox_textdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textbox_textdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_textdata.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textbox_textdata.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_textdata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textbox_textdata.Location = new System.Drawing.Point(12, 47);
            this.textbox_textdata.Name = "textbox_textdata";
            this.textbox_textdata.Size = new System.Drawing.Size(718, 336);
            this.textbox_textdata.TabIndex = 2;
            this.textbox_textdata.Text = "";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(638, 389);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 30);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Location = new System.Drawing.Point(540, 389);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(92, 30);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_filepath
            // 
            this.panel_filepath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_filepath.Controls.Add(this.label_filepath);
            this.panel_filepath.Location = new System.Drawing.Point(12, 383);
            this.panel_filepath.Name = "panel_filepath";
            this.panel_filepath.Size = new System.Drawing.Size(269, 36);
            this.panel_filepath.TabIndex = 6;
            // 
            // label_filepath
            // 
            this.label_filepath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_filepath.ForeColor = System.Drawing.Color.White;
            this.label_filepath.Location = new System.Drawing.Point(0, 0);
            this.label_filepath.Name = "label_filepath";
            this.label_filepath.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_filepath.Size = new System.Drawing.Size(269, 36);
            this.label_filepath.TabIndex = 0;
            this.label_filepath.Text = "File Path.txt";
            this.label_filepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.button_reset.FlatAppearance.BorderSize = 0;
            this.button_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Location = new System.Drawing.Point(287, 386);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(73, 30);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // checkbox_backup
            // 
            this.checkbox_backup.AutoSize = true;
            this.checkbox_backup.Checked = true;
            this.checkbox_backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_backup.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.checkbox_backup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.checkbox_backup.Location = new System.Drawing.Point(366, 389);
            this.checkbox_backup.Name = "checkbox_backup";
            this.checkbox_backup.Size = new System.Drawing.Size(72, 22);
            this.checkbox_backup.TabIndex = 8;
            this.checkbox_backup.Text = "Backup";
            this.checkbox_backup.UseVisualStyleBackColor = true;
            // 
            // Text_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(747, 426);
            this.Controls.Add(this.checkbox_backup);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.panel_filepath);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textbox_textdata);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Text_Editor";
            this.Text = "Text_Editor";
            this.TopMost = true;
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.panel_filepath.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.RichTextBox textbox_textdata;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel_filepath;
        private System.Windows.Forms.Label label_filepath;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.CheckBox checkbox_backup;
    }
}