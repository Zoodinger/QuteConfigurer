namespace QtConfigurator
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
            System.Windows.Forms.Label lblPath;
            this.browseQt = new System.Windows.Forms.Button();
            this.txtQtPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDetectQt = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.comboKits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetectUEPath = new System.Windows.Forms.Button();
            this.txtUEPath = new System.Windows.Forms.TextBox();
            this.btnBrowseUEPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            lblPath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new System.Drawing.Point(6, 16);
            lblPath.Name = "lblPath";
            lblPath.Size = new System.Drawing.Size(43, 13);
            lblPath.TabIndex = 0;
            lblPath.Text = "Qt Path";
            lblPath.Click += new System.EventHandler(this.lblPath_Click);
            // 
            // browseQt
            // 
            this.browseQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseQt.AutoSize = true;
            this.browseQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseQt.Location = new System.Drawing.Point(410, 30);
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
            this.txtQtPath.Location = new System.Drawing.Point(6, 32);
            this.txtQtPath.Name = "txtQtPath";
            this.txtQtPath.Size = new System.Drawing.Size(398, 20);
            this.txtQtPath.TabIndex = 2;
            this.txtQtPath.TextChanged += new System.EventHandler(this.txtQtPath_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(434, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDetectQt
            // 
            this.btnDetectQt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectQt.AutoSize = true;
            this.btnDetectQt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectQt.Location = new System.Drawing.Point(442, 30);
            this.btnDetectQt.Name = "btnDetectQt";
            this.btnDetectQt.Size = new System.Drawing.Size(49, 23);
            this.btnDetectQt.TabIndex = 4;
            this.btnDetectQt.Text = "Detect";
            this.btnDetectQt.UseVisualStyleBackColor = true;
            this.btnDetectQt.Click += new System.EventHandler(this.btnDetectQt_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(12, 270);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(497, 174);
            this.txtLog.TabIndex = 5;
            // 
            // comboKits
            // 
            this.comboKits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboKits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKits.FormattingEnabled = true;
            this.comboKits.Location = new System.Drawing.Point(6, 71);
            this.comboKits.Name = "comboKits";
            this.comboKits.Size = new System.Drawing.Size(398, 21);
            this.comboKits.Sorted = true;
            this.comboKits.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qt Build Kit";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(409, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Read me first!";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectPath.Location = new System.Drawing.Point(55, 197);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(404, 20);
            this.txtProjectPath.TabIndex = 9;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.txtProjectPath_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Project";
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProject.AutoSize = true;
            this.btnBrowseProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseProject.Location = new System.Drawing.Point(465, 195);
            this.btnBrowseProject.Name = "btnBrowseProject";
            this.btnBrowseProject.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseProject.TabIndex = 11;
            this.btnBrowseProject.Text = "...";
            this.btnBrowseProject.UseVisualStyleBackColor = true;
            this.btnBrowseProject.Click += new System.EventHandler(this.btnBrowseProject_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(276, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Generate Build Configuration";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Unreal Engine Path";
            // 
            // btnDetectUEPath
            // 
            this.btnDetectUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectUEPath.AutoSize = true;
            this.btnDetectUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetectUEPath.Location = new System.Drawing.Point(442, 108);
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
            this.txtUEPath.Location = new System.Drawing.Point(6, 111);
            this.txtUEPath.Name = "txtUEPath";
            this.txtUEPath.Size = new System.Drawing.Size(398, 20);
            this.txtUEPath.TabIndex = 15;
            this.txtUEPath.TextChanged += new System.EventHandler(this.txtUEPath_TextChanged);
            // 
            // btnBrowseUEPath
            // 
            this.btnBrowseUEPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseUEPath.AutoSize = true;
            this.btnBrowseUEPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseUEPath.Location = new System.Drawing.Point(410, 108);
            this.btnBrowseUEPath.Name = "btnBrowseUEPath";
            this.btnBrowseUEPath.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseUEPath.TabIndex = 14;
            this.btnBrowseUEPath.Text = "...";
            this.btnBrowseUEPath.UseVisualStyleBackColor = true;
            this.btnBrowseUEPath.Click += new System.EventHandler(this.btnBrowseUEPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(lblPath);
            this.groupBox1.Controls.Add(this.btnDetectUEPath);
            this.groupBox1.Controls.Add(this.btnBrowseProject);
            this.groupBox1.Controls.Add(this.browseQt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProjectPath);
            this.groupBox1.Controls.Add(this.txtUEPath);
            this.groupBox1.Controls.Add(this.txtQtPath);
            this.groupBox1.Controls.Add(this.btnBrowseUEPath);
            this.groupBox1.Controls.Add(this.btnDetectQt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboKits);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Qt Configurator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseQt;
        private System.Windows.Forms.TextBox txtQtPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDetectQt;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox comboKits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetectUEPath;
        private System.Windows.Forms.TextBox txtUEPath;
        private System.Windows.Forms.Button btnBrowseUEPath;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

