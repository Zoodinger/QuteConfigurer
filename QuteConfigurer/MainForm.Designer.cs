namespace Qute
{
    partial class MainForm
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
            System.Windows.Forms.Label lblQtPath;
            System.Windows.Forms.Label lblQtBuildKit;
            System.Windows.Forms.Label lblProject;
            System.Windows.Forms.Label lblUEPath;
            System.Windows.Forms.Label lblStep3;
            System.Windows.Forms.Label lblStep1;
            System.Windows.Forms.Label lblStep2;
            this.browseQt = new System.Windows.Forms.Button();
            this.txtQtPath = new System.Windows.Forms.TextBox();
            this.btnQtFiles = new System.Windows.Forms.Button();
            this.btnDetectQt = new System.Windows.Forms.Button();
            this.comboKits = new System.Windows.Forms.ComboBox();
            this.btnKitReadMe = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.btnBuildConfig = new System.Windows.Forms.Button();
            this.btnDetectUEPath = new System.Windows.Forms.Button();
            this.txtUEPath = new System.Windows.Forms.TextBox();
            this.btnBrowseUEPath = new System.Windows.Forms.Button();
            this.generalConfigGroup = new System.Windows.Forms.GroupBox();
            this.projectGroup = new System.Windows.Forms.GroupBox();
            this.btnVSFiles = new System.Windows.Forms.Button();
            this.generateGroup = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnHelpQt = new System.Windows.Forms.Button();
            this.btnHelpBuildConfig = new System.Windows.Forms.Button();
            this.btnHelpVS = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            lblQtPath = new System.Windows.Forms.Label();
            lblQtBuildKit = new System.Windows.Forms.Label();
            lblProject = new System.Windows.Forms.Label();
            lblUEPath = new System.Windows.Forms.Label();
            lblStep3 = new System.Windows.Forms.Label();
            lblStep1 = new System.Windows.Forms.Label();
            lblStep2 = new System.Windows.Forms.Label();
            this.generalConfigGroup.SuspendLayout();
            this.projectGroup.SuspendLayout();
            this.generateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQtPath
            // 
            lblQtPath.AutoSize = true;
            lblQtPath.Location = new System.Drawing.Point(6, 16);
            lblQtPath.Name = "lblQtPath";
            lblQtPath.Size = new System.Drawing.Size(43, 13);
            lblQtPath.TabIndex = 0;
            lblQtPath.Text = "Qt Path";
            // 
            // lblQtBuildKit
            // 
            lblQtBuildKit.AutoSize = true;
            lblQtBuildKit.Location = new System.Drawing.Point(6, 55);
            lblQtBuildKit.Name = "lblQtBuildKit";
            lblQtBuildKit.Size = new System.Drawing.Size(59, 13);
            lblQtBuildKit.TabIndex = 7;
            lblQtBuildKit.Text = "Qt Build Kit";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new System.Drawing.Point(6, 24);
            lblProject.Name = "lblProject";
            lblProject.Size = new System.Drawing.Size(40, 13);
            lblProject.TabIndex = 10;
            lblProject.Text = "Project";
            // 
            // lblUEPath
            // 
            lblUEPath.AutoSize = true;
            lblUEPath.Location = new System.Drawing.Point(6, 95);
            lblUEPath.Name = "lblUEPath";
            lblUEPath.Size = new System.Drawing.Size(99, 13);
            lblUEPath.TabIndex = 13;
            lblUEPath.Text = "Unreal Engine Path";
            // 
            // lblStep3
            // 
            lblStep3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblStep3.AutoSize = true;
            lblStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStep3.Location = new System.Drawing.Point(307, 82);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new System.Drawing.Size(38, 13);
            lblStep3.TabIndex = 21;
            lblStep3.Text = "Step 3";
            // 
            // lblStep1
            // 
            lblStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblStep1.AutoSize = true;
            lblStep1.Enabled = false;
            lblStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStep1.Location = new System.Drawing.Point(307, 24);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new System.Drawing.Size(38, 13);
            lblStep1.TabIndex = 0;
            lblStep1.Text = "Step 1";
            // 
            // lblStep2
            // 
            lblStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblStep2.AutoSize = true;
            lblStep2.Enabled = false;
            lblStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStep2.Location = new System.Drawing.Point(307, 53);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new System.Drawing.Size(38, 13);
            lblStep2.TabIndex = 13;
            lblStep2.Text = "Step 2";
            // 
            // browseQt
            // 
            this.browseQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseQt.AutoSize = true;
            this.browseQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseQt.Location = new System.Drawing.Point(453, 30);
            this.browseQt.Name = "browseQt";
            this.browseQt.Size = new System.Drawing.Size(26, 23);
            this.browseQt.TabIndex = 1;
            this.browseQt.Text = "...";
            this.browseQt.UseVisualStyleBackColor = true;
            this.browseQt.Click += new System.EventHandler(this.browseQt_Click);
            // 
            // txtQtPath
            // 
            this.txtQtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtPath.BackColor = System.Drawing.Color.White;
            this.txtQtPath.ForeColor = System.Drawing.Color.Black;
            this.txtQtPath.Location = new System.Drawing.Point(6, 32);
            this.txtQtPath.Name = "txtQtPath";
            this.txtQtPath.Size = new System.Drawing.Size(441, 20);
            this.txtQtPath.TabIndex = 2;
            this.txtQtPath.TextChanged += new System.EventHandler(this.txtQtPath_TextChanged);
            // 
            // btnQtFiles
            // 
            this.btnQtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQtFiles.Location = new System.Drawing.Point(351, 77);
            this.btnQtFiles.Name = "btnQtFiles";
            this.btnQtFiles.Size = new System.Drawing.Size(152, 23);
            this.btnQtFiles.TabIndex = 3;
            this.btnQtFiles.Text = "Generate Qt Project Files";
            this.btnQtFiles.UseVisualStyleBackColor = true;
            this.btnQtFiles.Click += new System.EventHandler(this.btnQtFiles_Click);
            // 
            // btnDetectQt
            // 
            this.btnDetectQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectQt.AutoSize = true;
            this.btnDetectQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectQt.Location = new System.Drawing.Point(485, 30);
            this.btnDetectQt.Name = "btnDetectQt";
            this.btnDetectQt.Size = new System.Drawing.Size(49, 23);
            this.btnDetectQt.TabIndex = 4;
            this.btnDetectQt.Text = "Detect";
            this.btnDetectQt.UseVisualStyleBackColor = true;
            this.btnDetectQt.Click += new System.EventHandler(this.btnDetectQt_Click);
            // 
            // comboKits
            // 
            this.comboKits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboKits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKits.FormattingEnabled = true;
            this.comboKits.Location = new System.Drawing.Point(6, 71);
            this.comboKits.Name = "comboKits";
            this.comboKits.Size = new System.Drawing.Size(441, 21);
            this.comboKits.Sorted = true;
            this.comboKits.TabIndex = 6;
            // 
            // btnKitReadMe
            // 
            this.btnKitReadMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitReadMe.AutoSize = true;
            this.btnKitReadMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKitReadMe.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKitReadMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitReadMe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKitReadMe.Location = new System.Drawing.Point(452, 69);
            this.btnKitReadMe.Name = "btnKitReadMe";
            this.btnKitReadMe.Size = new System.Drawing.Size(82, 23);
            this.btnKitReadMe.TabIndex = 8;
            this.btnKitReadMe.Text = "Read me first!";
            this.btnKitReadMe.UseVisualStyleBackColor = false;
            this.btnKitReadMe.Click += new System.EventHandler(this.btnKitReadMe_Click);
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectPath.BackColor = System.Drawing.Color.White;
            this.txtProjectPath.ForeColor = System.Drawing.Color.Black;
            this.txtProjectPath.Location = new System.Drawing.Point(52, 21);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(449, 20);
            this.txtProjectPath.TabIndex = 9;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProject.AutoSize = true;
            this.btnBrowseProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseProject.Location = new System.Drawing.Point(507, 19);
            this.btnBrowseProject.Name = "btnBrowseProject";
            this.btnBrowseProject.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseProject.TabIndex = 11;
            this.btnBrowseProject.Text = "...";
            this.btnBrowseProject.UseVisualStyleBackColor = true;
            this.btnBrowseProject.Click += new System.EventHandler(this.btnBrowseProject_Click);
            // 
            // btnBuildConfig
            // 
            this.btnBuildConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildConfig.AutoSize = true;
            this.btnBuildConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuildConfig.Enabled = false;
            this.btnBuildConfig.Location = new System.Drawing.Point(351, 19);
            this.btnBuildConfig.Name = "btnBuildConfig";
            this.btnBuildConfig.Size = new System.Drawing.Size(152, 23);
            this.btnBuildConfig.TabIndex = 12;
            this.btnBuildConfig.Text = "Generate Build Configuration";
            this.btnBuildConfig.UseVisualStyleBackColor = true;
            this.btnBuildConfig.Click += new System.EventHandler(this.btnBuildConfig_Click);
            // 
            // btnDetectUEPath
            // 
            this.btnDetectUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectUEPath.AutoSize = true;
            this.btnDetectUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectUEPath.Location = new System.Drawing.Point(485, 108);
            this.btnDetectUEPath.Name = "btnDetectUEPath";
            this.btnDetectUEPath.Size = new System.Drawing.Size(49, 23);
            this.btnDetectUEPath.TabIndex = 16;
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
            this.txtUEPath.Location = new System.Drawing.Point(6, 111);
            this.txtUEPath.Name = "txtUEPath";
            this.txtUEPath.Size = new System.Drawing.Size(441, 20);
            this.txtUEPath.TabIndex = 15;
            this.txtUEPath.TextChanged += new System.EventHandler(this.txtUEPath_TextChanged);
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseUEPath.AutoSize = true;
            this.btnBrowseUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseUEPath.Location = new System.Drawing.Point(453, 108);
            this.btnBrowseUEPath.Name = "btnBrowseUEPath";
            this.btnBrowseUEPath.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseUEPath.TabIndex = 14;
            this.btnBrowseUEPath.Text = "...";
            this.btnBrowseUEPath.UseVisualStyleBackColor = true;
            this.btnBrowseUEPath.Click += new System.EventHandler(this.btnBrowseUEPath_Click);
            // 
            // generalConfigGroup
            // 
            this.generalConfigGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConfigGroup.Controls.Add(lblQtPath);
            this.generalConfigGroup.Controls.Add(this.btnDetectUEPath);
            this.generalConfigGroup.Controls.Add(this.browseQt);
            this.generalConfigGroup.Controls.Add(this.txtUEPath);
            this.generalConfigGroup.Controls.Add(this.txtQtPath);
            this.generalConfigGroup.Controls.Add(this.btnBrowseUEPath);
            this.generalConfigGroup.Controls.Add(this.btnDetectQt);
            this.generalConfigGroup.Controls.Add(lblUEPath);
            this.generalConfigGroup.Controls.Add(this.comboKits);
            this.generalConfigGroup.Controls.Add(lblQtBuildKit);
            this.generalConfigGroup.Controls.Add(this.btnKitReadMe);
            this.generalConfigGroup.Enabled = false;
            this.generalConfigGroup.Location = new System.Drawing.Point(12, 12);
            this.generalConfigGroup.Name = "generalConfigGroup";
            this.generalConfigGroup.Size = new System.Drawing.Size(540, 144);
            this.generalConfigGroup.TabIndex = 17;
            this.generalConfigGroup.TabStop = false;
            // 
            // projectGroup
            // 
            this.projectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectGroup.Controls.Add(this.txtProjectPath);
            this.projectGroup.Controls.Add(lblProject);
            this.projectGroup.Controls.Add(this.btnBrowseProject);
            this.projectGroup.Location = new System.Drawing.Point(12, 162);
            this.projectGroup.Name = "projectGroup";
            this.projectGroup.Size = new System.Drawing.Size(539, 51);
            this.projectGroup.TabIndex = 18;
            this.projectGroup.TabStop = false;
            // 
            // btnVSFiles
            // 
            this.btnVSFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVSFiles.AutoSize = true;
            this.btnVSFiles.Enabled = false;
            this.btnVSFiles.Location = new System.Drawing.Point(351, 48);
            this.btnVSFiles.Name = "btnVSFiles";
            this.btnVSFiles.Size = new System.Drawing.Size(152, 23);
            this.btnVSFiles.TabIndex = 19;
            this.btnVSFiles.Text = "Generate VS Project Files";
            this.btnVSFiles.UseVisualStyleBackColor = true;
            this.btnVSFiles.Click += new System.EventHandler(this.btnGenVSFiles_Click);
            // 
            // generateGroup
            // 
            this.generateGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateGroup.Controls.Add(this.lblInfo);
            this.generateGroup.Controls.Add(lblStep3);
            this.generateGroup.Controls.Add(this.btnHelpQt);
            this.generateGroup.Controls.Add(this.btnHelpBuildConfig);
            this.generateGroup.Controls.Add(this.btnVSFiles);
            this.generateGroup.Controls.Add(this.btnBuildConfig);
            this.generateGroup.Controls.Add(lblStep1);
            this.generateGroup.Controls.Add(lblStep2);
            this.generateGroup.Controls.Add(this.btnHelpVS);
            this.generateGroup.Controls.Add(this.btnQtFiles);
            this.generateGroup.Location = new System.Drawing.Point(12, 219);
            this.generateGroup.Name = "generateGroup";
            this.generateGroup.Size = new System.Drawing.Size(540, 111);
            this.generateGroup.TabIndex = 20;
            this.generateGroup.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(296, 84);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Not implemented features are currently disabled.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHelpQt
            // 
            this.btnHelpQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpQt.AutoSize = true;
            this.btnHelpQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpQt.Location = new System.Drawing.Point(509, 77);
            this.btnHelpQt.Name = "btnHelpQt";
            this.btnHelpQt.Size = new System.Drawing.Size(24, 23);
            this.btnHelpQt.TabIndex = 20;
            this.btnHelpQt.Text = "?";
            this.btnHelpQt.UseVisualStyleBackColor = true;
            this.btnHelpQt.Click += new System.EventHandler(this.btnHelpQt_Click);
            // 
            // btnHelpBuildConfig
            // 
            this.btnHelpBuildConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpBuildConfig.AutoSize = true;
            this.btnHelpBuildConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpBuildConfig.Enabled = false;
            this.btnHelpBuildConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpBuildConfig.Location = new System.Drawing.Point(509, 19);
            this.btnHelpBuildConfig.Name = "btnHelpBuildConfig";
            this.btnHelpBuildConfig.Size = new System.Drawing.Size(24, 23);
            this.btnHelpBuildConfig.TabIndex = 14;
            this.btnHelpBuildConfig.Text = "?";
            this.btnHelpBuildConfig.UseVisualStyleBackColor = true;
            this.btnHelpBuildConfig.Click += new System.EventHandler(this.btnHelpBuildConfig_Click);
            // 
            // btnHelpVS
            // 
            this.btnHelpVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpVS.AutoSize = true;
            this.btnHelpVS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpVS.Enabled = false;
            this.btnHelpVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpVS.Location = new System.Drawing.Point(509, 48);
            this.btnHelpVS.Name = "btnHelpVS";
            this.btnHelpVS.Size = new System.Drawing.Size(24, 23);
            this.btnHelpVS.TabIndex = 2;
            this.btnHelpVS.Text = "?";
            this.btnHelpVS.UseVisualStyleBackColor = true;
            this.btnHelpVS.Click += new System.EventHandler(this.btnHelpVS_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.HideSelection = false;
            this.txtLog.Location = new System.Drawing.Point(12, 336);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(540, 163);
            this.txtLog.TabIndex = 21;
            this.txtLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 511);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.generateGroup);
            this.Controls.Add(this.projectGroup);
            this.Controls.Add(this.generalConfigGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 550);
            this.Name = "MainForm";
            this.Text = "Qute Configurer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.generalConfigGroup.ResumeLayout(false);
            this.generalConfigGroup.PerformLayout();
            this.projectGroup.ResumeLayout(false);
            this.projectGroup.PerformLayout();
            this.generateGroup.ResumeLayout(false);
            this.generateGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseQt;
        private System.Windows.Forms.TextBox txtQtPath;
        private System.Windows.Forms.Button btnQtFiles;
        private System.Windows.Forms.Button btnDetectQt;
        private System.Windows.Forms.ComboBox comboKits;
        private System.Windows.Forms.Button btnKitReadMe;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.Button btnBuildConfig;
        private System.Windows.Forms.Button btnDetectUEPath;
        private System.Windows.Forms.TextBox txtUEPath;
        private System.Windows.Forms.Button btnBrowseUEPath;
        private System.Windows.Forms.GroupBox generalConfigGroup;
        private System.Windows.Forms.GroupBox projectGroup;
        private System.Windows.Forms.Button btnVSFiles;
        private System.Windows.Forms.GroupBox generateGroup;
        private System.Windows.Forms.Button btnHelpVS;
        private System.Windows.Forms.Button btnHelpQt;
        private System.Windows.Forms.Button btnHelpBuildConfig;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblInfo;
    }
}

