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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblQtBuildKit;
            System.Windows.Forms.Label lblProject;
            this.btnQtFiles = new System.Windows.Forms.Button();
            this.comboKits = new System.Windows.Forms.ComboBox();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.btnBuildConfig = new System.Windows.Forms.Button();
            this.generalConfigGroup = new System.Windows.Forms.GroupBox();
            this.btnProjInfo = new System.Windows.Forms.Button();
            this.btnVSFiles = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.grpConfigurations = new System.Windows.Forms.GroupBox();
            this.listBuild = new System.Windows.Forms.CheckedListBox();
            this.grpProjFiles = new System.Windows.Forms.GroupBox();
            this.btnOpenInQt = new System.Windows.Forms.Button();
            this.QtPathMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetQtPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAlwaysUpdateVS = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpUse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrepareKit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            lblQtBuildKit = new System.Windows.Forms.Label();
            lblProject = new System.Windows.Forms.Label();
            this.generalConfigGroup.SuspendLayout();
            this.grpConfigurations.SuspendLayout();
            this.grpProjFiles.SuspendLayout();
            this.QtPathMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQtBuildKit
            // 
            lblQtBuildKit.AutoSize = true;
            lblQtBuildKit.Location = new System.Drawing.Point(6, 22);
            lblQtBuildKit.Name = "lblQtBuildKit";
            lblQtBuildKit.Size = new System.Drawing.Size(33, 13);
            lblQtBuildKit.TabIndex = 7;
            lblQtBuildKit.Text = "Qt Kit";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new System.Drawing.Point(6, 16);
            lblProject.Name = "lblProject";
            lblProject.Size = new System.Drawing.Size(40, 13);
            lblProject.TabIndex = 10;
            lblProject.Text = "Project";
            // 
            // btnQtFiles
            // 
            this.btnQtFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQtFiles.Location = new System.Drawing.Point(6, 46);
            this.btnQtFiles.Name = "btnQtFiles";
            this.btnQtFiles.Size = new System.Drawing.Size(141, 23);
            this.btnQtFiles.TabIndex = 3;
            this.btnQtFiles.Text = "Generate Qt Project Files";
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
            this.comboKits.Size = new System.Drawing.Size(206, 21);
            this.comboKits.Sorted = true;
            this.comboKits.TabIndex = 6;
            this.comboKits.SelectedIndexChanged += new System.EventHandler(this.comboKits_SelectedIndexChanged);
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectPath.BackColor = System.Drawing.Color.White;
            this.txtProjectPath.ForeColor = System.Drawing.Color.Black;
            this.txtProjectPath.Location = new System.Drawing.Point(6, 32);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(421, 20);
            this.txtProjectPath.TabIndex = 9;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            this.txtProjectPath.Leave += new System.EventHandler(this.txtProjectPath_Leave);
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProject.AutoSize = true;
            this.btnBrowseProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseProject.Location = new System.Drawing.Point(433, 30);
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
            this.btnBuildConfig.Location = new System.Drawing.Point(120, 146);
            this.btnBuildConfig.Name = "btnBuildConfig";
            this.btnBuildConfig.Size = new System.Drawing.Size(131, 23);
            this.btnBuildConfig.TabIndex = 12;
            this.btnBuildConfig.Text = "Generate Configurations";
            this.btnBuildConfig.UseVisualStyleBackColor = true;
            this.btnBuildConfig.Click += new System.EventHandler(this.btnBuildConfig_Click);
            // 
            // generalConfigGroup
            // 
            this.generalConfigGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConfigGroup.Controls.Add(lblProject);
            this.generalConfigGroup.Controls.Add(this.txtProjectPath);
            this.generalConfigGroup.Controls.Add(this.btnProjInfo);
            this.generalConfigGroup.Controls.Add(this.btnBrowseProject);
            this.generalConfigGroup.Location = new System.Drawing.Point(12, 27);
            this.generalConfigGroup.Name = "generalConfigGroup";
            this.generalConfigGroup.Size = new System.Drawing.Size(520, 61);
            this.generalConfigGroup.TabIndex = 17;
            this.generalConfigGroup.TabStop = false;
            // 
            // btnProjInfo
            // 
            this.btnProjInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProjInfo.Location = new System.Drawing.Point(465, 30);
            this.btnProjInfo.Name = "btnProjInfo";
            this.btnProjInfo.Size = new System.Drawing.Size(49, 23);
            this.btnProjInfo.TabIndex = 17;
            this.btnProjInfo.Text = "Info";
            this.btnProjInfo.UseVisualStyleBackColor = true;
            this.btnProjInfo.Click += new System.EventHandler(this.btnProjInfo_Click);
            // 
            // btnVSFiles
            // 
            this.btnVSFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVSFiles.Location = new System.Drawing.Point(6, 17);
            this.btnVSFiles.Name = "btnVSFiles";
            this.btnVSFiles.Size = new System.Drawing.Size(141, 23);
            this.btnVSFiles.TabIndex = 19;
            this.btnVSFiles.Text = "Generate VS Project Files";
            this.btnVSFiles.UseVisualStyleBackColor = true;
            this.btnVSFiles.Click += new System.EventHandler(this.btnVSFiles_Click);
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
            this.txtLog.Location = new System.Drawing.Point(12, 275);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(520, 135);
            this.txtLog.TabIndex = 21;
            this.txtLog.Text = "";
            // 
            // grpConfigurations
            // 
            this.grpConfigurations.Controls.Add(this.listBuild);
            this.grpConfigurations.Controls.Add(this.btnBuildConfig);
            this.grpConfigurations.Controls.Add(lblQtBuildKit);
            this.grpConfigurations.Controls.Add(this.comboKits);
            this.grpConfigurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConfigurations.Location = new System.Drawing.Point(0, 0);
            this.grpConfigurations.Name = "grpConfigurations";
            this.grpConfigurations.Size = new System.Drawing.Size(257, 175);
            this.grpConfigurations.TabIndex = 0;
            this.grpConfigurations.TabStop = false;
            this.grpConfigurations.Text = " ";
            // 
            // listBuild
            // 
            this.listBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBuild.CheckOnClick = true;
            this.listBuild.FormattingEnabled = true;
            this.listBuild.Items.AddRange(new object[] {
            "Debug Editor",
            "Debug Standalone",
            "Development Editor",
            "Development Standalone"});
            this.listBuild.Location = new System.Drawing.Point(6, 46);
            this.listBuild.Name = "listBuild";
            this.listBuild.Size = new System.Drawing.Size(245, 94);
            this.listBuild.TabIndex = 0;
            this.listBuild.SelectedIndexChanged += new System.EventHandler(this.listBuild_SelectedIndexChanged);
            // 
            // grpProjFiles
            // 
            this.grpProjFiles.Controls.Add(this.btnOpenInQt);
            this.grpProjFiles.Controls.Add(this.checkAlwaysUpdateVS);
            this.grpProjFiles.Controls.Add(this.btnQtFiles);
            this.grpProjFiles.Controls.Add(this.btnVSFiles);
            this.grpProjFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProjFiles.Location = new System.Drawing.Point(0, 0);
            this.grpProjFiles.Name = "grpProjFiles";
            this.grpProjFiles.Size = new System.Drawing.Size(259, 175);
            this.grpProjFiles.TabIndex = 0;
            this.grpProjFiles.TabStop = false;
            this.grpProjFiles.Text = "Project Files";
            // 
            // btnOpenInQt
            // 
            this.btnOpenInQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenInQt.AutoSize = true;
            this.btnOpenInQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenInQt.ContextMenuStrip = this.QtPathMenu;
            this.btnOpenInQt.Location = new System.Drawing.Point(148, 146);
            this.btnOpenInQt.Name = "btnOpenInQt";
            this.btnOpenInQt.Size = new System.Drawing.Size(105, 23);
            this.btnOpenInQt.TabIndex = 15;
            this.btnOpenInQt.Text = "Open in Qt Creator";
            this.btnOpenInQt.UseVisualStyleBackColor = true;
            this.btnOpenInQt.Click += new System.EventHandler(this.btnOpenInQt_Click);
            // 
            // QtPathMenu
            // 
            this.QtPathMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetQtPath,
            this.toolStripMenuItem1});
            this.QtPathMenu.Name = "QtPathMenu";
            this.QtPathMenu.Size = new System.Drawing.Size(214, 48);
            // 
            // SetQtPath
            // 
            this.SetQtPath.Name = "SetQtPath";
            this.SetQtPath.Size = new System.Drawing.Size(213, 22);
            this.SetQtPath.Text = "Set Qt Executable";
            this.SetQtPath.Click += new System.EventHandler(this.SetQtPath_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItem1.Text = "Auto-detect Qt Executable";
            // 
            // checkAlwaysUpdateVS
            // 
            this.checkAlwaysUpdateVS.AutoSize = true;
            this.checkAlwaysUpdateVS.Location = new System.Drawing.Point(153, 21);
            this.checkAlwaysUpdateVS.Name = "checkAlwaysUpdateVS";
            this.checkAlwaysUpdateVS.Size = new System.Drawing.Size(59, 17);
            this.checkAlwaysUpdateVS.TabIndex = 21;
            this.checkAlwaysUpdateVS.Text = "Always";
            this.checkAlwaysUpdateVS.UseVisualStyleBackColor = true;
            this.checkAlwaysUpdateVS.CheckedChanged += new System.EventHandler(this.checkAlwaysUpdateVS_CheckedChanged);
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
            this.spContainer.IsSplitterFixed = true;
            this.spContainer.Location = new System.Drawing.Point(12, 94);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.grpConfigurations);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.grpProjFiles);
            this.spContainer.Size = new System.Drawing.Size(520, 175);
            this.spContainer.SplitterDistance = 257;
            this.spContainer.TabIndex = 22;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings,
            this.toolStripSeparator1,
            this.menuSetup,
            this.toolStripSeparator3,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuSettings.Size = new System.Drawing.Size(200, 22);
            this.menuSettings.Text = "&Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // menuSetup
            // 
            this.menuSetup.Name = "menuSetup";
            this.menuSetup.ShortcutKeyDisplayString = "";
            this.menuSetup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuSetup.Size = new System.Drawing.Size(200, 22);
            this.menuSetup.Text = "Setup && Launch";
            this.menuSetup.Click += new System.EventHandler(this.menuSetup_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(200, 22);
            this.menuExit.Text = "&Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpUse,
            this.menuPrepareKit,
            this.toolStripSeparator2,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpUse
            // 
            this.menuHelpUse.Enabled = false;
            this.menuHelpUse.Name = "menuHelpUse";
            this.menuHelpUse.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpUse.Size = new System.Drawing.Size(247, 22);
            this.menuHelpUse.Text = "How to use";
            this.menuHelpUse.Click += new System.EventHandler(this.menuHelpUse_Click);
            // 
            // menuPrepareKit
            // 
            this.menuPrepareKit.Enabled = false;
            this.menuPrepareKit.Name = "menuPrepareKit";
            this.menuPrepareKit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuPrepareKit.Size = new System.Drawing.Size(247, 22);
            this.menuPrepareKit.Text = "How do I prepare Qt Creator?";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(247, 22);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(544, 24);
            this.menuBar.TabIndex = 23;
            this.menuBar.Text = "Menu";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOpenInQt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.generalConfigGroup);
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 318);
            this.Name = "MainForm";
            this.Text = "Qute Configurer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.generalConfigGroup.ResumeLayout(false);
            this.generalConfigGroup.PerformLayout();
            this.grpConfigurations.ResumeLayout(false);
            this.grpConfigurations.PerformLayout();
            this.grpProjFiles.ResumeLayout(false);
            this.grpProjFiles.PerformLayout();
            this.QtPathMenu.ResumeLayout(false);
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQtFiles;
        private System.Windows.Forms.ComboBox comboKits;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.Button btnBuildConfig;
        private System.Windows.Forms.GroupBox generalConfigGroup;
        private System.Windows.Forms.Button btnVSFiles;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.GroupBox grpConfigurations;
        private System.Windows.Forms.GroupBox grpProjFiles;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button btnProjInfo;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.CheckedListBox listBuild;
        private System.Windows.Forms.CheckBox checkAlwaysUpdateVS;
        private System.Windows.Forms.Button btnOpenInQt;
        private System.Windows.Forms.ContextMenuStrip QtPathMenu;
        private System.Windows.Forms.ToolStripMenuItem SetQtPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpUse;
        private System.Windows.Forms.ToolStripMenuItem menuPrepareKit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.MenuStrip menuBar;
    }
}

