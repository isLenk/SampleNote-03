namespace SampleNote.Main.Modals
{
    partial class LogDeletionConfirmation
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
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.lblPasswordRequired = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblSampleNumber = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Form_Header.SuspendLayout();
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
            this.Form_Header.Size = new System.Drawing.Size(476, 34);
            this.Form_Header.TabIndex = 4;
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
            this.button_exitform.Location = new System.Drawing.Point(369, 0);
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
            this.FormName.Size = new System.Drawing.Size(251, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "Permission Required: Log Remove";
            // 
            // lblPasswordRequired
            // 
            this.lblPasswordRequired.AutoSize = true;
            this.lblPasswordRequired.ForeColor = System.Drawing.Color.White;
            this.lblPasswordRequired.Location = new System.Drawing.Point(27, 87);
            this.lblPasswordRequired.Name = "lblPasswordRequired";
            this.lblPasswordRequired.Size = new System.Drawing.Size(149, 22);
            this.lblPasswordRequired.TabIndex = 5;
            this.lblPasswordRequired.Text = "Password Required:";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(182, 83);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(270, 26);
            this.tbx_Password.TabIndex = 6;
            this.tbx_Password.UseSystemPasswordChar = true;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.ForeColor = System.Drawing.Color.White;
            this.lblNotice.Location = new System.Drawing.Point(178, 47);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(274, 22);
            this.lblNotice.TabIndex = 7;
            this.lblNotice.Text = "| Password Required to DELETE a log";
            // 
            // lblSampleNumber
            // 
            this.lblSampleNumber.AutoSize = true;
            this.lblSampleNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(221)))));
            this.lblSampleNumber.Location = new System.Drawing.Point(27, 47);
            this.lblSampleNumber.Name = "lblSampleNumber";
            this.lblSampleNumber.Size = new System.Drawing.Size(58, 22);
            this.lblSampleNumber.TabIndex = 8;
            this.lblSampleNumber.Text = "L00001";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirm.Location = new System.Drawing.Point(346, 124);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 31);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "DELETE";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // LogDeletionConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(476, 176);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSampleNumber);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.lblPasswordRequired);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogDeletionConfirmation";
            this.Text = "LogDeletionConfirmation";
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Label lblPasswordRequired;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblSampleNumber;
        private System.Windows.Forms.Button btnConfirm;
    }
}