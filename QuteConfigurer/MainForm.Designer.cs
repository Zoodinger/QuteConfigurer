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
            this.btnHelpQt = new System.Windows.Forms.Button();
            this.btnHelpBuildConfig = new System.Windows.Forms.Button();
            this.btnHelpVS = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.grpBuildConfig = new System.Windows.Forms.GroupBox();
            this.spEditorOrDevelop = new System.Windows.Forms.SplitContainer();
            this.chkShipEd = new System.Windows.Forms.CheckBox();
            this.chkDevEd = new System.Windows.Forms.CheckBox();
            this.chkDebugEd = new System.Windows.Forms.CheckBox();
            this.chkShipStand = new System.Windows.Forms.CheckBox();
            this.chkDebugStand = new System.Windows.Forms.CheckBox();
            this.chkDevStand = new System.Windows.Forms.CheckBox();
            this.grpQtProjFiles = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            lblQtPath = new System.Windows.Forms.Label();
            lblQtBuildKit = new System.Windows.Forms.Label();
            lblProject = new System.Windows.Forms.Label();
            lblUEPath = new System.Windows.Forms.Label();
            this.generalConfigGroup.SuspendLayout();
            this.projectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.grpBuildConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spEditorOrDevelop)).BeginInit();
            this.spEditorOrDevelop.Panel1.SuspendLayout();
            this.spEditorOrDevelop.Panel2.SuspendLayout();
            this.spEditorOrDevelop.SuspendLayout();
            this.grpQtProjFiles.SuspendLayout();
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
            // browseQt
            // 
            this.browseQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseQt.AutoSize = true;
            this.browseQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseQt.Enabled = false;
            this.browseQt.Location = new System.Drawing.Point(625, 30);
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
            this.txtQtPath.Enabled = false;
            this.txtQtPath.ForeColor = System.Drawing.Color.Black;
            this.txtQtPath.Location = new System.Drawing.Point(6, 32);
            this.txtQtPath.Name = "txtQtPath";
            this.txtQtPath.Size = new System.Drawing.Size(613, 20);
            this.txtQtPath.TabIndex = 2;
            this.txtQtPath.TextChanged += new System.EventHandler(this.txtQtPath_TextChanged);
            // 
            // btnQtFiles
            // 
            this.btnQtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQtFiles.AutoSize = true;
            this.btnQtFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQtFiles.Location = new System.Drawing.Point(307, 97);
            this.btnQtFiles.Name = "btnQtFiles";
            this.btnQtFiles.Size = new System.Drawing.Size(64, 23);
            this.btnQtFiles.TabIndex = 3;
            this.btnQtFiles.Text = "Generate!";
            this.btnQtFiles.UseVisualStyleBackColor = true;
            this.btnQtFiles.Click += new System.EventHandler(this.btnQtFiles_Click);
            // 
            // btnDetectQt
            // 
            this.btnDetectQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectQt.AutoSize = true;
            this.btnDetectQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectQt.Enabled = false;
            this.btnDetectQt.Location = new System.Drawing.Point(657, 30);
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
            this.comboKits.Size = new System.Drawing.Size(613, 21);
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
            this.btnKitReadMe.Location = new System.Drawing.Point(624, 71);
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
            this.txtProjectPath.Size = new System.Drawing.Size(621, 20);
            this.txtProjectPath.TabIndex = 9;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProject.AutoSize = true;
            this.btnBrowseProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseProject.Location = new System.Drawing.Point(679, 19);
            this.btnBrowseProject.Name = "btnBrowseProject";
            this.btnBrowseProject.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseProject.TabIndex = 11;
            this.btnBrowseProject.Text = "...";
            this.btnBrowseProject.UseVisualStyleBackColor = true;
            this.btnBrowseProject.Click += new System.EventHandler(this.btnBrowseProject_Click);
            // 
            // btnBuildConfig
            // 
            this.btnBuildConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildConfig.AutoSize = true;
            this.btnBuildConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuildConfig.Location = new System.Drawing.Point(260, 97);
            this.btnBuildConfig.Name = "btnBuildConfig";
            this.btnBuildConfig.Size = new System.Drawing.Size(64, 23);
            this.btnBuildConfig.TabIndex = 12;
            this.btnBuildConfig.Text = "Generate!";
            this.btnBuildConfig.UseVisualStyleBackColor = true;
            this.btnBuildConfig.Click += new System.EventHandler(this.btnBuildConfig_Click);
            // 
            // btnDetectUEPath
            // 
            this.btnDetectUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectUEPath.AutoSize = true;
            this.btnDetectUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectUEPath.Location = new System.Drawing.Point(657, 109);
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
            this.txtUEPath.Size = new System.Drawing.Size(613, 20);
            this.txtUEPath.TabIndex = 15;
            this.txtUEPath.TextChanged += new System.EventHandler(this.txtUEPath_TextChanged);
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseUEPath.AutoSize = true;
            this.btnBrowseUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseUEPath.Location = new System.Drawing.Point(625, 109);
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
            this.generalConfigGroup.Location = new System.Drawing.Point(12, 12);
            this.generalConfigGroup.Name = "generalConfigGroup";
            this.generalConfigGroup.Size = new System.Drawing.Size(712, 137);
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
            this.projectGroup.Location = new System.Drawing.Point(12, 155);
            this.projectGroup.Name = "projectGroup";
            this.projectGroup.Size = new System.Drawing.Size(711, 50);
            this.projectGroup.TabIndex = 18;
            this.projectGroup.TabStop = false;
            // 
            // btnVSFiles
            // 
            this.btnVSFiles.AutoSize = true;
            this.btnVSFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVSFiles.Enabled = false;
            this.btnVSFiles.Location = new System.Drawing.Point(6, 19);
            this.btnVSFiles.Name = "btnVSFiles";
            this.btnVSFiles.Size = new System.Drawing.Size(129, 23);
            this.btnVSFiles.TabIndex = 19;
            this.btnVSFiles.Text = "Update VS Project Files";
            this.btnVSFiles.UseVisualStyleBackColor = true;
            this.btnVSFiles.Click += new System.EventHandler(this.btnGenVSFiles_Click);
            // 
            // btnHelpQt
            // 
            this.btnHelpQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpQt.AutoSize = true;
            this.btnHelpQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpQt.Location = new System.Drawing.Point(277, 97);
            this.btnHelpQt.Name = "btnHelpQt";
            this.btnHelpQt.Size = new System.Drawing.Size(24, 23);
            this.btnHelpQt.TabIndex = 20;
            this.btnHelpQt.Text = "?";
            this.btnHelpQt.UseVisualStyleBackColor = true;
            this.btnHelpQt.Click += new System.EventHandler(this.btnHelpQt_Click);
            // 
            // btnHelpBuildConfig
            // 
            this.btnHelpBuildConfig.AutoSize = true;
            this.btnHelpBuildConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpBuildConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpBuildConfig.Location = new System.Drawing.Point(141, 18);
            this.btnHelpBuildConfig.Name = "btnHelpBuildConfig";
            this.btnHelpBuildConfig.Size = new System.Drawing.Size(24, 23);
            this.btnHelpBuildConfig.TabIndex = 14;
            this.btnHelpBuildConfig.Text = "?";
            this.btnHelpBuildConfig.UseVisualStyleBackColor = true;
            this.btnHelpBuildConfig.Click += new System.EventHandler(this.btnHelpBuildConfig_Click);
            // 
            // btnHelpVS
            // 
            this.btnHelpVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpVS.AutoSize = true;
            this.btnHelpVS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpVS.Location = new System.Drawing.Point(230, 97);
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
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Green;
            this.txtLog.HideSelection = false;
            this.txtLog.Location = new System.Drawing.Point(12, 343);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(712, 156);
            this.txtLog.TabIndex = 21;
            this.txtLog.Text = "";
            // 
            // spContainer
            // 
            this.spContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spContainer.IsSplitterFixed = true;
            this.spContainer.Location = new System.Drawing.Point(12, 211);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.grpBuildConfig);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.grpQtProjFiles);
            this.spContainer.Size = new System.Drawing.Size(711, 126);
            this.spContainer.SplitterDistance = 330;
            this.spContainer.TabIndex = 22;
            // 
            // grpBuildConfig
            // 
            this.grpBuildConfig.Controls.Add(this.spEditorOrDevelop);
            this.grpBuildConfig.Controls.Add(this.btnBuildConfig);
            this.grpBuildConfig.Controls.Add(this.btnHelpVS);
            this.grpBuildConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBuildConfig.Location = new System.Drawing.Point(0, 0);
            this.grpBuildConfig.Name = "grpBuildConfig";
            this.grpBuildConfig.Size = new System.Drawing.Size(330, 126);
            this.grpBuildConfig.TabIndex = 0;
            this.grpBuildConfig.TabStop = false;
            this.grpBuildConfig.Text = "Build Configurations";
            // 
            // spEditorOrDevelop
            // 
            this.spEditorOrDevelop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spEditorOrDevelop.Location = new System.Drawing.Point(3, 19);
            this.spEditorOrDevelop.Name = "spEditorOrDevelop";
            // 
            // spEditorOrDevelop.Panel1
            // 
            this.spEditorOrDevelop.Panel1.Controls.Add(this.chkShipEd);
            this.spEditorOrDevelop.Panel1.Controls.Add(this.chkDevEd);
            this.spEditorOrDevelop.Panel1.Controls.Add(this.chkDebugEd);
            // 
            // spEditorOrDevelop.Panel2
            // 
            this.spEditorOrDevelop.Panel2.Controls.Add(this.chkShipStand);
            this.spEditorOrDevelop.Panel2.Controls.Add(this.chkDebugStand);
            this.spEditorOrDevelop.Panel2.Controls.Add(this.chkDevStand);
            this.spEditorOrDevelop.Size = new System.Drawing.Size(324, 73);
            this.spEditorOrDevelop.SplitterDistance = 160;
            this.spEditorOrDevelop.SplitterWidth = 1;
            this.spEditorOrDevelop.TabIndex = 13;
            // 
            // chkShipEd
            // 
            this.chkShipEd.AutoSize = true;
            this.chkShipEd.Checked = true;
            this.chkShipEd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShipEd.Location = new System.Drawing.Point(3, 49);
            this.chkShipEd.Name = "chkShipEd";
            this.chkShipEd.Size = new System.Drawing.Size(97, 17);
            this.chkShipEd.TabIndex = 2;
            this.chkShipEd.Text = "Shipping Editor";
            this.chkShipEd.UseVisualStyleBackColor = true;
            // 
            // chkDevEd
            // 
            this.chkDevEd.AutoSize = true;
            this.chkDevEd.Checked = true;
            this.chkDevEd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDevEd.Location = new System.Drawing.Point(3, 26);
            this.chkDevEd.Name = "chkDevEd";
            this.chkDevEd.Size = new System.Drawing.Size(119, 17);
            this.chkDevEd.TabIndex = 1;
            this.chkDevEd.Text = "Development Editor";
            this.chkDevEd.UseVisualStyleBackColor = true;
            // 
            // chkDebugEd
            // 
            this.chkDebugEd.AutoSize = true;
            this.chkDebugEd.Checked = true;
            this.chkDebugEd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDebugEd.Location = new System.Drawing.Point(3, 3);
            this.chkDebugEd.Name = "chkDebugEd";
            this.chkDebugEd.Size = new System.Drawing.Size(88, 17);
            this.chkDebugEd.TabIndex = 0;
            this.chkDebugEd.Text = "Debug Editor";
            this.chkDebugEd.UseVisualStyleBackColor = true;
            // 
            // chkShipStand
            // 
            this.chkShipStand.AutoSize = true;
            this.chkShipStand.Checked = true;
            this.chkShipStand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShipStand.Location = new System.Drawing.Point(3, 49);
            this.chkShipStand.Name = "chkShipStand";
            this.chkShipStand.Size = new System.Drawing.Size(124, 17);
            this.chkShipStand.TabIndex = 5;
            this.chkShipStand.Text = "Shipping Standalone";
            this.chkShipStand.UseVisualStyleBackColor = true;
            // 
            // chkDebugStand
            // 
            this.chkDebugStand.AutoSize = true;
            this.chkDebugStand.Checked = true;
            this.chkDebugStand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDebugStand.Location = new System.Drawing.Point(3, 3);
            this.chkDebugStand.Name = "chkDebugStand";
            this.chkDebugStand.Size = new System.Drawing.Size(115, 17);
            this.chkDebugStand.TabIndex = 3;
            this.chkDebugStand.Text = "Debug Standalone";
            this.chkDebugStand.UseVisualStyleBackColor = true;
            // 
            // chkDevStand
            // 
            this.chkDevStand.AutoSize = true;
            this.chkDevStand.Checked = true;
            this.chkDevStand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDevStand.Location = new System.Drawing.Point(3, 26);
            this.chkDevStand.Name = "chkDevStand";
            this.chkDevStand.Size = new System.Drawing.Size(146, 17);
            this.chkDevStand.TabIndex = 4;
            this.chkDevStand.Text = "Development Standalone";
            this.chkDevStand.UseVisualStyleBackColor = true;
            // 
            // grpQtProjFiles
            // 
            this.grpQtProjFiles.Controls.Add(this.checkBox1);
            this.grpQtProjFiles.Controls.Add(this.btnHelpQt);
            this.grpQtProjFiles.Controls.Add(this.btnHelpBuildConfig);
            this.grpQtProjFiles.Controls.Add(this.btnQtFiles);
            this.grpQtProjFiles.Controls.Add(this.btnVSFiles);
            this.grpQtProjFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpQtProjFiles.Location = new System.Drawing.Point(0, 0);
            this.grpQtProjFiles.Name = "grpQtProjFiles";
            this.grpQtProjFiles.Size = new System.Drawing.Size(377, 126);
            this.grpQtProjFiles.TabIndex = 0;
            this.grpQtProjFiles.TabStop = false;
            this.grpQtProjFiles.Text = "Qt Project Files";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(170, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Scan for additional source files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 49);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(97, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Shipping Editor";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 26);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(146, 17);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Development Standalone";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(115, 17);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Text = "Debug Standalone";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 511);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.projectGroup);
            this.Controls.Add(this.generalConfigGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(752, 550);
            this.Name = "MainForm";
            this.Text = "Qute Configurer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.generalConfigGroup.ResumeLayout(false);
            this.generalConfigGroup.PerformLayout();
            this.projectGroup.ResumeLayout(false);
            this.projectGroup.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.grpBuildConfig.ResumeLayout(false);
            this.grpBuildConfig.PerformLayout();
            this.spEditorOrDevelop.Panel1.ResumeLayout(false);
            this.spEditorOrDevelop.Panel1.PerformLayout();
            this.spEditorOrDevelop.Panel2.ResumeLayout(false);
            this.spEditorOrDevelop.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spEditorOrDevelop)).EndInit();
            this.spEditorOrDevelop.ResumeLayout(false);
            this.grpQtProjFiles.ResumeLayout(false);
            this.grpQtProjFiles.PerformLayout();
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
        private System.Windows.Forms.Button btnHelpVS;
        private System.Windows.Forms.Button btnHelpQt;
        private System.Windows.Forms.Button btnHelpBuildConfig;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.GroupBox grpBuildConfig;
        private System.Windows.Forms.GroupBox grpQtProjFiles;
        private System.Windows.Forms.SplitContainer spEditorOrDevelop;
        private System.Windows.Forms.CheckBox chkShipEd;
        private System.Windows.Forms.CheckBox chkDevEd;
        private System.Windows.Forms.CheckBox chkDebugEd;
        private System.Windows.Forms.CheckBox chkShipStand;
        private System.Windows.Forms.CheckBox chkDebugStand;
        private System.Windows.Forms.CheckBox chkDevStand;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
    }
}

