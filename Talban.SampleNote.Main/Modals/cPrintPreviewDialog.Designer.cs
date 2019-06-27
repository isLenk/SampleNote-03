namespace SampleNote.Main.Modals
{
    partial class cPrintPreviewDialog
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
            this.Form_Header = new System.Windows.Forms.Panel();
            this.button_exitform = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.DocumentPreview = new System.Windows.Forms.PrintPreviewControl();
            this.panel_PrintControl = new System.Windows.Forms.Panel();
            this.lbl_Notice = new System.Windows.Forms.Label();
            this.btnPrintDocument = new System.Windows.Forms.Button();
            this.lblDocumentZoom = new System.Windows.Forms.Label();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lblReportName = new System.Windows.Forms.Label();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.btnPromptDirectoryDialog = new System.Windows.Forms.Button();
            this.lblPdfDirectory = new System.Windows.Forms.Label();
            this.panel_directoryunderline = new System.Windows.Forms.Panel();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Form_Header.SuspendLayout();
            this.panel_PrintControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Header
            // 
            this.Form_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.Form_Header.Controls.Add(this.button_exitform);
            this.Form_Header.Controls.Add(this.FormName);
            this.Form_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Header.Location = new System.Drawing.Point(0, 0);
            this.Form_Header.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Form_Header.Name = "Form_Header";
            this.Form_Header.Size = new System.Drawing.Size(912, 34);
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
            this.button_exitform.Location = new System.Drawing.Point(807, 0);
            this.button_exitform.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_exitform.Name = "button_exitform";
            this.button_exitform.Size = new System.Drawing.Size(105, 34);
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
            this.FormName.Location = new System.Drawing.Point(13, 6);
            this.FormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(107, 22);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "Print Preview";
            // 
            // DocumentPreview
            // 
            this.DocumentPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DocumentPreview.Location = new System.Drawing.Point(12, 44);
            this.DocumentPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocumentPreview.Name = "DocumentPreview";
            this.DocumentPreview.Size = new System.Drawing.Size(599, 596);
            this.DocumentPreview.TabIndex = 8;
            // 
            // panel_PrintControl
            // 
            this.panel_PrintControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PrintControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_PrintControl.Controls.Add(this.panel_directoryunderline);
            this.panel_PrintControl.Controls.Add(this.lblPdfDirectory);
            this.panel_PrintControl.Controls.Add(this.btnPromptDirectoryDialog);
            this.panel_PrintControl.Controls.Add(this.lbl_Notice);
            this.panel_PrintControl.Controls.Add(this.btnPrintDocument);
            this.panel_PrintControl.Controls.Add(this.lblDocumentZoom);
            this.panel_PrintControl.Controls.Add(this.btnZoomOut);
            this.panel_PrintControl.Controls.Add(this.btnZoomIn);
            this.panel_PrintControl.Controls.Add(this.lblReportName);
            this.panel_PrintControl.Location = new System.Drawing.Point(617, 44);
            this.panel_PrintControl.Name = "panel_PrintControl";
            this.panel_PrintControl.Size = new System.Drawing.Size(283, 596);
            this.panel_PrintControl.TabIndex = 9;
            // 
            // lbl_Notice
            // 
            this.lbl_Notice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Notice.AutoSize = true;
            this.lbl_Notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbl_Notice.Location = new System.Drawing.Point(3, 542);
            this.lbl_Notice.Name = "lbl_Notice";
            this.lbl_Notice.Size = new System.Drawing.Size(185, 16);
            this.lbl_Notice.TabIndex = 5;
            this.lbl_Notice.Text = "* Data is stored in \"/reports\" folder";
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnPrintDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrintDocument.FlatAppearance.BorderSize = 0;
            this.btnPrintDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDocument.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btnPrintDocument.ForeColor = System.Drawing.Color.White;
            this.btnPrintDocument.Location = new System.Drawing.Point(0, 561);
            this.btnPrintDocument.Name = "btnPrintDocument";
            this.btnPrintDocument.Size = new System.Drawing.Size(283, 35);
            this.btnPrintDocument.TabIndex = 4;
            this.btnPrintDocument.Text = "Save and Print Document";
            this.btnPrintDocument.UseVisualStyleBackColor = false;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // lblDocumentZoom
            // 
            this.lblDocumentZoom.AutoSize = true;
            this.lblDocumentZoom.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.lblDocumentZoom.ForeColor = System.Drawing.Color.White;
            this.lblDocumentZoom.Location = new System.Drawing.Point(14, 58);
            this.lblDocumentZoom.Name = "lblDocumentZoom";
            this.lblDocumentZoom.Size = new System.Drawing.Size(124, 20);
            this.lblDocumentZoom.TabIndex = 3;
            this.lblDocumentZoom.Text = "Document Zoom:";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btnZoomOut.ForeColor = System.Drawing.Color.White;
            this.btnZoomOut.Location = new System.Drawing.Point(211, 54);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(50, 30);
            this.btnZoomOut.TabIndex = 2;
            this.btnZoomOut.Text = "Out";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(171)))));
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(191)))));
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btnZoomIn.ForeColor = System.Drawing.Color.White;
            this.btnZoomIn.Location = new System.Drawing.Point(155, 54);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(50, 30);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.Text = "In";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // lblReportName
            // 
            this.lblReportName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReportName.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblReportName.ForeColor = System.Drawing.Color.White;
            this.lblReportName.Location = new System.Drawing.Point(0, 0);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(283, 32);
            this.lblReportName.TabIndex = 0;
            this.lblReportName.Text = "label1";
            this.lblReportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // btnPromptDirectoryDialog
            // 
            this.btnPromptDirectoryDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPromptDirectoryDialog.FlatAppearance.BorderSize = 0;
            this.btnPromptDirectoryDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromptDirectoryDialog.ForeColor = System.Drawing.Color.White;
            this.btnPromptDirectoryDialog.Location = new System.Drawing.Point(18, 151);
            this.btnPromptDirectoryDialog.Name = "btnPromptDirectoryDialog";
            this.btnPromptDirectoryDialog.Size = new System.Drawing.Size(243, 23);
            this.btnPromptDirectoryDialog.TabIndex = 6;
            this.btnPromptDirectoryDialog.Text = "C:\\\\DIRECTORY";
            this.btnPromptDirectoryDialog.UseVisualStyleBackColor = false;
            this.btnPromptDirectoryDialog.Click += new System.EventHandler(this.btnPromptDirectoryDialog_Click);
            // 
            // lblPdfDirectory
            // 
            this.lblPdfDirectory.AutoSize = true;
            this.lblPdfDirectory.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.lblPdfDirectory.ForeColor = System.Drawing.Color.White;
            this.lblPdfDirectory.Location = new System.Drawing.Point(14, 128);
            this.lblPdfDirectory.Name = "lblPdfDirectory";
            this.lblPdfDirectory.Size = new System.Drawing.Size(106, 20);
            this.lblPdfDirectory.TabIndex = 7;
            this.lblPdfDirectory.Text = "PDF Directory:";
            // 
            // panel_directoryunderline
            // 
            this.panel_directoryunderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel_directoryunderline.Location = new System.Drawing.Point(18, 175);
            this.panel_directoryunderline.Name = "panel_directoryunderline";
            this.panel_directoryunderline.Size = new System.Drawing.Size(243, 3);
            this.panel_directoryunderline.TabIndex = 8;
            // 
            // cPrintPreviewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(912, 653);
            this.Controls.Add(this.panel_PrintControl);
            this.Controls.Add(this.DocumentPreview);
            this.Controls.Add(this.Form_Header);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cPrintPreviewDialog";
            this.Text = "cPrintPreviewDialog";
            this.Form_Header.ResumeLayout(false);
            this.Form_Header.PerformLayout();
            this.panel_PrintControl.ResumeLayout(false);
            this.panel_PrintControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Form_Header;
        private System.Windows.Forms.Button button_exitform;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.PrintPreviewControl DocumentPreview;
        private System.Windows.Forms.Panel panel_PrintControl;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label lblDocumentZoom;
        private System.Windows.Forms.Button btnPrintDocument;
        private System.Windows.Forms.Label lbl_Notice;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.Label lblPdfDirectory;
        private System.Windows.Forms.Button btnPromptDirectoryDialog;
        private System.Windows.Forms.Panel panel_directoryunderline;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.ToolTip Tooltip;
    }
}