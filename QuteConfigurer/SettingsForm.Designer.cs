namespace Qute
{
    partial class SettingsForm
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
            System.Windows.Forms.Label lblUEPath;
            System.Windows.Forms.Label label1;
            this.btnDetectUEPath = new System.Windows.Forms.Button();
            this.txtUEPath = new System.Windows.Forms.TextBox();
            this.btnBrowseUEPath = new System.Windows.Forms.Button();
            this.btnDetectQtPath = new System.Windows.Forms.Button();
            this.txtQtPath = new System.Windows.Forms.TextBox();
            this.btnBrowseQtPath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            lblUEPath = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUEPath
            // 
            lblUEPath.AutoSize = true;
            lblUEPath.Location = new System.Drawing.Point(12, 9);
            lblUEPath.Name = "lblUEPath";
            lblUEPath.Size = new System.Drawing.Size(125, 13);
            lblUEPath.TabIndex = 17;
            lblUEPath.Text = "Unreal Engine Root Path";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 13);
            label1.TabIndex = 21;
            label1.Text = "Qt Creator Path";
            // 
            // btnDetectUEPath
            // 
            this.btnDetectUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectUEPath.AutoSize = true;
            this.btnDetectUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectUEPath.Location = new System.Drawing.Point(448, 23);
            this.btnDetectUEPath.Name = "btnDetectUEPath";
            this.btnDetectUEPath.Size = new System.Drawing.Size(49, 23);
            this.btnDetectUEPath.TabIndex = 20;
            this.btnDetectUEPath.Text = "Detect";
            this.btnDetectUEPath.UseVisualStyleBackColor = true;
            this.btnDetectUEPath.Click += new System.EventHandler(this.btnDetectUEPath_Click);
            // 
            // txtUEPath
            // 
            this.txtUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUEPath.BackColor = System.Drawing.Color.White;
            this.txtUEPath.ForeColor = System.Drawing.Color.Black;
            this.txtUEPath.Location = new System.Drawing.Point(15, 25);
            this.txtUEPath.Name = "txtUEPath";
            this.txtUEPath.Size = new System.Drawing.Size(396, 20);
            this.txtUEPath.TabIndex = 19;
            this.txtUEPath.TextChanged += new System.EventHandler(this.txtUEPath_TextChanged);
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseUEPath.AutoSize = true;
            this.btnBrowseUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseUEPath.Location = new System.Drawing.Point(417, 23);
            this.btnBrowseUEPath.Name = "btnBrowseUEPath";
            this.btnBrowseUEPath.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseUEPath.TabIndex = 18;
            this.btnBrowseUEPath.Text = "...";
            this.btnBrowseUEPath.UseVisualStyleBackColor = true;
            this.btnBrowseUEPath.Click += new System.EventHandler(this.btnBrowseUEPath_Click);
            // 
            // btnDetectQtPath
            // 
            this.btnDetectQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectQtPath.AutoSize = true;
            this.btnDetectQtPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectQtPath.Location = new System.Drawing.Point(448, 62);
            this.btnDetectQtPath.Name = "btnDetectQtPath";
            this.btnDetectQtPath.Size = new System.Drawing.Size(49, 23);
            this.btnDetectQtPath.TabIndex = 24;
            this.btnDetectQtPath.Text = "Detect";
            this.btnDetectQtPath.UseVisualStyleBackColor = true;
            this.btnDetectQtPath.Click += new System.EventHandler(this.btnDetectQtPath_Click);
            // 
            // txtQtPath
            // 
            this.txtQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtPath.BackColor = System.Drawing.Color.White;
            this.txtQtPath.ForeColor = System.Drawing.Color.Black;
            this.txtQtPath.Location = new System.Drawing.Point(15, 64);
            this.txtQtPath.Name = "txtQtPath";
            this.txtQtPath.Size = new System.Drawing.Size(396, 20);
            this.txtQtPath.TabIndex = 23;
            this.txtQtPath.TextChanged += new System.EventHandler(this.txtQtPath_TextChanged);
            // 
            // btnBrowseQtPath
            // 
            this.btnBrowseQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseQtPath.AutoSize = true;
            this.btnBrowseQtPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseQtPath.Location = new System.Drawing.Point(417, 62);
            this.btnBrowseQtPath.Name = "btnBrowseQtPath";
            this.btnBrowseQtPath.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseQtPath.TabIndex = 22;
            this.btnBrowseQtPath.Text = "...";
            this.btnBrowseQtPath.UseVisualStyleBackColor = true;
            this.btnBrowseQtPath.Click += new System.EventHandler(this.btnBrowseQtPath_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(423, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(342, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(510, 140);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDetectQtPath);
            this.Controls.Add(this.txtQtPath);
            this.Controls.Add(this.btnBrowseQtPath);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnDetectUEPath);
            this.Controls.Add(this.txtUEPath);
            this.Controls.Add(this.btnBrowseUEPath);
            this.Controls.Add(lblUEPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetectUEPath;
        private System.Windows.Forms.TextBox txtUEPath;
        private System.Windows.Forms.Button btnBrowseUEPath;
        private System.Windows.Forms.Button btnDetectQtPath;
        private System.Windows.Forms.TextBox txtQtPath;
        private System.Windows.Forms.Button btnBrowseQtPath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}