namespace Qute
{
    partial class SetQtPathDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtQtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetectQtPath = new System.Windows.Forms.Button();
            this.btnBrowseQtPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQtPath
            // 
            this.txtQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtPath.Location = new System.Drawing.Point(12, 25);
            this.txtQtPath.Name = "txtQtPath";
            this.txtQtPath.Size = new System.Drawing.Size(375, 20);
            this.txtQtPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the path Qt is installed in:";
            // 
            // btnDetectQtPath
            // 
            this.btnDetectQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectQtPath.AutoSize = true;
            this.btnDetectQtPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectQtPath.Location = new System.Drawing.Point(424, 23);
            this.btnDetectQtPath.Name = "btnDetectQtPath";
            this.btnDetectQtPath.Size = new System.Drawing.Size(49, 23);
            this.btnDetectQtPath.TabIndex = 18;
            this.btnDetectQtPath.Text = "Detect";
            this.btnDetectQtPath.UseVisualStyleBackColor = true;
            this.btnDetectQtPath.Click += new System.EventHandler(this.btnDetectQtPath_Click);
            // 
            // btnBrowseQtPath
            // 
            this.btnBrowseQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseQtPath.AutoSize = true;
            this.btnBrowseQtPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseQtPath.Location = new System.Drawing.Point(392, 23);
            this.btnBrowseQtPath.Name = "btnBrowseQtPath";
            this.btnBrowseQtPath.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseQtPath.TabIndex = 17;
            this.btnBrowseQtPath.Text = "...";
            this.btnBrowseQtPath.UseVisualStyleBackColor = true;
            this.btnBrowseQtPath.Click += new System.EventHandler(this.btnBrowseQtPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(312, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(398, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetQtPathDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(485, 92);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDetectQtPath);
            this.Controls.Add(this.btnBrowseQtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetQtPathDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Qt Creator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SetQtPathDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetectQtPath;
        private System.Windows.Forms.Button btnBrowseQtPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}