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
            System.Windows.Forms.Label lblQtBuildKit;
            System.Windows.Forms.Label lblProject;
            System.Windows.Forms.Label lblUEPath;
            this.btnQtFiles = new System.Windows.Forms.Button();
            this.comboKits = new System.Windows.Forms.ComboBox();
            this.btnKitReadMe = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.btnBuildConfig = new System.Windows.Forms.Button();
            this.btnDetectUEPath = new System.Windows.Forms.Button();
            this.txtUEPath = new System.Windows.Forms.TextBox();
            this.btnBrowseUEPath = new System.Windows.Forms.Button();
            this.generalConfigGroup = new System.Windows.Forms.GroupBox();
            this.btnProjInfo = new System.Windows.Forms.Button();
            this.btnVSFiles = new System.Windows.Forms.Button();
            this.btnHelpQt = new System.Windows.Forms.Button();
            this.btnHelpBuildConfig = new System.Windows.Forms.Button();
            this.btnHelpVS = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.grpConfigurations = new System.Windows.Forms.GroupBox();
            this.spBuildRun = new System.Windows.Forms.SplitContainer();
            this.grpBuild = new System.Windows.Forms.GroupBox();
            this.listBuild = new System.Windows.Forms.CheckedListBox();
            this.grpRun = new System.Windows.Forms.GroupBox();
            this.listRun = new System.Windows.Forms.CheckedListBox();
            this.grpProjFiles = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            lblQtBuildKit = new System.Windows.Forms.Label();
            lblProject = new System.Windows.Forms.Label();
            lblUEPath = new System.Windows.Forms.Label();
            this.generalConfigGroup.SuspendLayout();
            this.grpConfigurations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spBuildRun)).BeginInit();
            this.spBuildRun.Panel1.SuspendLayout();
            this.spBuildRun.Panel2.SuspendLayout();
            this.spBuildRun.SuspendLayout();
            this.grpBuild.SuspendLayout();
            this.grpRun.SuspendLayout();
            this.grpProjFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQtBuildKit
            // 
            lblQtBuildKit.AutoSize = true;
            lblQtBuildKit.Location = new System.Drawing.Point(6, 24);
            lblQtBuildKit.Name = "lblQtBuildKit";
            lblQtBuildKit.Size = new System.Drawing.Size(33, 13);
            lblQtBuildKit.TabIndex = 7;
            lblQtBuildKit.Text = "Qt Kit";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new System.Drawing.Point(6, 55);
            lblProject.Name = "lblProject";
            lblProject.Size = new System.Drawing.Size(40, 13);
            lblProject.TabIndex = 10;
            lblProject.Text = "Project";
            // 
            // lblUEPath
            // 
            lblUEPath.AutoSize = true;
            lblUEPath.Location = new System.Drawing.Point(3, 16);
            lblUEPath.Name = "lblUEPath";
            lblUEPath.Size = new System.Drawing.Size(99, 13);
            lblUEPath.TabIndex = 13;
            lblUEPath.Text = "Unreal Engine Path";
            // 
            // btnQtFiles
            // 
            this.btnQtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQtFiles.AutoSize = true;
            this.btnQtFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQtFiles.Location = new System.Drawing.Point(126, 185);
            this.btnQtFiles.Name = "btnQtFiles";
            this.btnQtFiles.Size = new System.Drawing.Size(64, 23);
            this.btnQtFiles.TabIndex = 3;
            this.btnQtFiles.Text = "Generate!";
            this.btnQtFiles.UseVisualStyleBackColor = true;
            this.btnQtFiles.Click += new System.EventHandler(this.btnQtFiles_Click);
            // 
            // comboKits
            // 
            this.comboKits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboKits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKits.FormattingEnabled = true;
            this.comboKits.Location = new System.Drawing.Point(45, 19);
            this.comboKits.Name = "comboKits";
            this.comboKits.Size = new System.Drawing.Size(238, 21);
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
            this.btnKitReadMe.Location = new System.Drawing.Point(289, 19);
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
            this.txtProjectPath.Location = new System.Drawing.Point(6, 71);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(475, 20);
            this.txtProjectPath.TabIndex = 9;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProject.AutoSize = true;
            this.btnBrowseProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseProject.Location = new System.Drawing.Point(487, 69);
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
            this.btnBuildConfig.Location = new System.Drawing.Point(304, 185);
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
            this.btnDetectUEPath.Location = new System.Drawing.Point(518, 30);
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
            this.txtUEPath.Location = new System.Drawing.Point(6, 32);
            this.txtUEPath.Name = "txtUEPath";
            this.txtUEPath.Size = new System.Drawing.Size(475, 20);
            this.txtUEPath.TabIndex = 15;
            this.txtUEPath.TextChanged += new System.EventHandler(this.txtUEPath_TextChanged);
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseUEPath.AutoSize = true;
            this.btnBrowseUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseUEPath.Location = new System.Drawing.Point(487, 30);
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
            this.generalConfigGroup.Controls.Add(lblProject);
            this.generalConfigGroup.Controls.Add(this.btnDetectUEPath);
            this.generalConfigGroup.Controls.Add(this.txtUEPath);
            this.generalConfigGroup.Controls.Add(this.btnBrowseUEPath);
            this.generalConfigGroup.Controls.Add(this.txtProjectPath);
            this.generalConfigGroup.Controls.Add(this.btnProjInfo);
            this.generalConfigGroup.Controls.Add(this.btnBrowseProject);
            this.generalConfigGroup.Controls.Add(lblUEPath);
            this.generalConfigGroup.Location = new System.Drawing.Point(12, 12);
            this.generalConfigGroup.Name = "generalConfigGroup";
            this.generalConfigGroup.Size = new System.Drawing.Size(574, 102);
            this.generalConfigGroup.TabIndex = 17;
            this.generalConfigGroup.TabStop = false;
            // 
            // btnProjInfo
            // 
            this.btnProjInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProjInfo.Location = new System.Drawing.Point(518, 69);
            this.btnProjInfo.Name = "btnProjInfo";
            this.btnProjInfo.Size = new System.Drawing.Size(49, 23);
            this.btnProjInfo.TabIndex = 17;
            this.btnProjInfo.Text = "Info";
            this.btnProjInfo.UseVisualStyleBackColor = true;
            this.btnProjInfo.Click += new System.EventHandler(this.btnProjInfo_Click);
            // 
            // btnVSFiles
            // 
            this.btnVSFiles.AutoSize = true;
            this.btnVSFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVSFiles.Enabled = false;
            this.btnVSFiles.Location = new System.Drawing.Point(36, 19);
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
            this.btnHelpQt.Location = new System.Drawing.Point(96, 185);
            this.btnHelpQt.Name = "btnHelpQt";
            this.btnHelpQt.Size = new System.Drawing.Size(24, 23);
            this.btnHelpQt.TabIndex = 20;
            this.btnHelpQt.Text = "?";
            this.btnHelpQt.UseVisualStyleBackColor = true;
            this.btnHelpQt.Click += new System.EventHandler(this.btnHelpQt_Click);
            // 
            // btnHelpBuildConfig
            // 
            this.btnHelpBuildConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpBuildConfig.AutoSize = true;
            this.btnHelpBuildConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpBuildConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpBuildConfig.Location = new System.Drawing.Point(274, 185);
            this.btnHelpBuildConfig.Name = "btnHelpBuildConfig";
            this.btnHelpBuildConfig.Size = new System.Drawing.Size(24, 23);
            this.btnHelpBuildConfig.TabIndex = 14;
            this.btnHelpBuildConfig.Text = "?";
            this.btnHelpBuildConfig.UseVisualStyleBackColor = true;
            this.btnHelpBuildConfig.Click += new System.EventHandler(this.btnHelpBuildConfig_Click);
            // 
            // btnHelpVS
            // 
            this.btnHelpVS.AutoSize = true;
            this.btnHelpVS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelpVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpVS.Location = new System.Drawing.Point(6, 19);
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
            this.txtLog.Location = new System.Drawing.Point(12, 340);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(574, 148);
            this.txtLog.TabIndex = 21;
            this.txtLog.Text = "";
            // 
            // grpConfigurations
            // 
            this.grpConfigurations.Controls.Add(this.spBuildRun);
            this.grpConfigurations.Controls.Add(this.btnBuildConfig);
            this.grpConfigurations.Controls.Add(this.btnHelpBuildConfig);
            this.grpConfigurations.Controls.Add(lblQtBuildKit);
            this.grpConfigurations.Controls.Add(this.comboKits);
            this.grpConfigurations.Controls.Add(this.btnKitReadMe);
            this.grpConfigurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfigurations.Location = new System.Drawing.Point(0, 0);
            this.grpConfigurations.Name = "grpConfigurations";
            this.grpConfigurations.Size = new System.Drawing.Size(374, 214);
            this.grpConfigurations.TabIndex = 0;
            this.grpConfigurations.TabStop = false;
            this.grpConfigurations.Text = "Configurations";
            // 
            // spBuildRun
            // 
            this.spBuildRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spBuildRun.Location = new System.Drawing.Point(3, 48);
            this.spBuildRun.Name = "spBuildRun";
            // 
            // spBuildRun.Panel1
            // 
            this.spBuildRun.Panel1.Controls.Add(this.grpBuild);
            // 
            // spBuildRun.Panel2
            // 
            this.spBuildRun.Panel2.Controls.Add(this.grpRun);
            this.spBuildRun.Size = new System.Drawing.Size(368, 131);
            this.spBuildRun.SplitterDistance = 183;
            this.spBuildRun.SplitterWidth = 1;
            this.spBuildRun.TabIndex = 13;
            // 
            // grpBuild
            // 
            this.grpBuild.Controls.Add(this.listBuild);
            this.grpBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBuild.Location = new System.Drawing.Point(0, 0);
            this.grpBuild.Name = "grpBuild";
            this.grpBuild.Size = new System.Drawing.Size(183, 131);
            this.grpBuild.TabIndex = 0;
            this.grpBuild.TabStop = false;
            this.grpBuild.Text = "Build";
            // 
            // listBuild
            // 
            this.listBuild.CheckOnClick = true;
            this.listBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBuild.FormattingEnabled = true;
            this.listBuild.Items.AddRange(new object[] {
            "Debug Editor",
            "Debug",
            "Development Editor",
            "Development"});
            this.listBuild.Location = new System.Drawing.Point(3, 16);
            this.listBuild.Name = "listBuild";
            this.listBuild.Size = new System.Drawing.Size(177, 112);
            this.listBuild.TabIndex = 0;
            this.listBuild.SelectedIndexChanged += new System.EventHandler(this.listBuild_SelectedIndexChanged);
            // 
            // grpRun
            // 
            this.grpRun.Controls.Add(this.listRun);
            this.grpRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRun.Location = new System.Drawing.Point(0, 0);
            this.grpRun.Name = "grpRun";
            this.grpRun.Size = new System.Drawing.Size(184, 131);
            this.grpRun.TabIndex = 0;
            this.grpRun.TabStop = false;
            this.grpRun.Text = "Run";
            // 
            // listRun
            // 
            this.listRun.CheckOnClick = true;
            this.listRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRun.FormattingEnabled = true;
            this.listRun.Items.AddRange(new object[] {
            "Debug Editor",
            "Debug",
            "Debug In New Window",
            "Development Editor",
            "Development",
            "Development In New Window"});
            this.listRun.Location = new System.Drawing.Point(3, 16);
            this.listRun.Name = "listRun";
            this.listRun.Size = new System.Drawing.Size(178, 112);
            this.listRun.TabIndex = 1;
            this.listRun.SelectedIndexChanged += new System.EventHandler(this.listRun_SelectedIndexChanged);
            // 
            // grpProjFiles
            // 
            this.grpProjFiles.Controls.Add(this.label1);
            this.grpProjFiles.Controls.Add(this.checkBox1);
            this.grpProjFiles.Controls.Add(this.radioButton2);
            this.grpProjFiles.Controls.Add(this.radioButton1);
            this.grpProjFiles.Controls.Add(this.btnHelpQt);
            this.grpProjFiles.Controls.Add(this.btnHelpVS);
            this.grpProjFiles.Controls.Add(this.btnQtFiles);
            this.grpProjFiles.Controls.Add(this.btnVSFiles);
            this.grpProjFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProjFiles.Location = new System.Drawing.Point(0, 0);
            this.grpProjFiles.Name = "grpProjFiles";
            this.grpProjFiles.Size = new System.Drawing.Size(196, 214);
            this.grpProjFiles.TabIndex = 0;
            this.grpProjFiles.TabStop = false;
            this.grpProjFiles.Text = "Project Files";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 68);
            this.label1.TabIndex = 24;
            this.label1.Text = "These options are currently not supported.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Scan for additional files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(6, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.Text = "Only update source code";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Generate everything";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // spContainer
            // 
            this.spContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spContainer.IsSplitterFixed = true;
            this.spContainer.Location = new System.Drawing.Point(12, 120);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.grpConfigurations);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.grpProjFiles);
            this.spContainer.Size = new System.Drawing.Size(574, 214);
            this.spContainer.SplitterDistance = 374;
            this.spContainer.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 500);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.generalConfigGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Qute Configurer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.generalConfigGroup.ResumeLayout(false);
            this.generalConfigGroup.PerformLayout();
            this.grpConfigurations.ResumeLayout(false);
            this.grpConfigurations.PerformLayout();
            this.spBuildRun.Panel1.ResumeLayout(false);
            this.spBuildRun.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spBuildRun)).EndInit();
            this.spBuildRun.ResumeLayout(false);
            this.grpBuild.ResumeLayout(false);
            this.grpRun.ResumeLayout(false);
            this.grpProjFiles.ResumeLayout(false);
            this.grpProjFiles.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQtFiles;
        private System.Windows.Forms.ComboBox comboKits;
        private System.Windows.Forms.Button btnKitReadMe;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.Button btnBuildConfig;
        private System.Windows.Forms.Button btnDetectUEPath;
        private System.Windows.Forms.TextBox txtUEPath;
        private System.Windows.Forms.Button btnBrowseUEPath;
        private System.Windows.Forms.GroupBox generalConfigGroup;
        private System.Windows.Forms.Button btnVSFiles;
        private System.Windows.Forms.Button btnHelpVS;
        private System.Windows.Forms.Button btnHelpQt;
        private System.Windows.Forms.Button btnHelpBuildConfig;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.GroupBox grpConfigurations;
        private System.Windows.Forms.GroupBox grpProjFiles;
        private System.Windows.Forms.SplitContainer spBuildRun;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button btnProjInfo;
        private System.Windows.Forms.GroupBox grpBuild;
        private System.Windows.Forms.GroupBox grpRun;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.CheckedListBox listBuild;
        private System.Windows.Forms.CheckedListBox listRun;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

