
namespace NugetPublisher
{
    partial class NugetPublisher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NugetPublisher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPackPackage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtProjectFile = new System.Windows.Forms.TextBox();
            this.btnPack = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbConfig = new System.Windows.Forms.ComboBox();
            this.chbSymbols = new System.Windows.Forms.CheckBox();
            this.chbNoPackageAnalysis = new System.Windows.Forms.CheckBox();
            this.chbNonInteractive = new System.Windows.Forms.CheckBox();
            this.chbNoDefaultExcludes = new System.Windows.Forms.CheckBox();
            this.chbIncludeReferencedProjects = new System.Windows.Forms.CheckBox();
            this.chbForceEnglishOutput = new System.Windows.Forms.CheckBox();
            this.chbExcludeEmptyDirectories = new System.Windows.Forms.CheckBox();
            this.chbBuild = new System.Windows.Forms.CheckBox();
            this.tabPushPackage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPackageBrowse = new System.Windows.Forms.Button();
            this.txtPackagePath = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNugetSource = new System.Windows.Forms.TextBox();
            this.chbNoSymbols = new System.Windows.Forms.CheckBox();
            this.chbNonInteractive1 = new System.Windows.Forms.CheckBox();
            this.chbSkipDuplicate = new System.Windows.Forms.CheckBox();
            this.chbNoServiceEndpoint = new System.Windows.Forms.CheckBox();
            this.chbForceEnglishOutput1 = new System.Windows.Forms.CheckBox();
            this.chbDisableBuffering = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPackPackage.SuspendLayout();
            this.tabPushPackage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 920);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(17, 500);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(833, 400);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 37);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(810, 351);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(833, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Input";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPackPackage);
            this.tabControl1.Controls.Add(this.tabPushPackage);
            this.tabControl1.Location = new System.Drawing.Point(9, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 433);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPackPackage
            // 
            this.tabPackPackage.Controls.Add(this.label1);
            this.tabPackPackage.Controls.Add(this.btnBrowse);
            this.tabPackPackage.Controls.Add(this.txtProjectFile);
            this.tabPackPackage.Controls.Add(this.btnPack);
            this.tabPackPackage.Controls.Add(this.txtVersion);
            this.tabPackPackage.Controls.Add(this.label4);
            this.tabPackPackage.Controls.Add(this.label3);
            this.tabPackPackage.Controls.Add(this.txtOutputPath);
            this.tabPackPackage.Controls.Add(this.btnOutputBrowse);
            this.tabPackPackage.Controls.Add(this.label2);
            this.tabPackPackage.Controls.Add(this.cmbConfig);
            this.tabPackPackage.Controls.Add(this.chbSymbols);
            this.tabPackPackage.Controls.Add(this.chbNoPackageAnalysis);
            this.tabPackPackage.Controls.Add(this.chbNonInteractive);
            this.tabPackPackage.Controls.Add(this.chbNoDefaultExcludes);
            this.tabPackPackage.Controls.Add(this.chbIncludeReferencedProjects);
            this.tabPackPackage.Controls.Add(this.chbForceEnglishOutput);
            this.tabPackPackage.Controls.Add(this.chbExcludeEmptyDirectories);
            this.tabPackPackage.Controls.Add(this.chbBuild);
            this.tabPackPackage.Location = new System.Drawing.Point(4, 34);
            this.tabPackPackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPackPackage.Name = "tabPackPackage";
            this.tabPackPackage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPackPackage.Size = new System.Drawing.Size(808, 395);
            this.tabPackPackage.TabIndex = 0;
            this.tabPackPackage.Text = "Create Package";
            this.tabPackPackage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Project File Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(677, 42);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(117, 38);
            this.btnBrowse.TabIndex = 30;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtProjectFile
            // 
            this.txtProjectFile.Location = new System.Drawing.Point(14, 43);
            this.txtProjectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectFile.Name = "txtProjectFile";
            this.txtProjectFile.Size = new System.Drawing.Size(655, 31);
            this.txtProjectFile.TabIndex = 29;
            // 
            // btnPack
            // 
            this.btnPack.Location = new System.Drawing.Point(14, 337);
            this.btnPack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(117, 38);
            this.btnPack.TabIndex = 28;
            this.btnPack.Text = "Pack";
            this.btnPack.UseMnemonic = false;
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(250, 215);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVersion.Mask = "#.#.#.#####";
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(130, 31);
            this.txtVersion.TabIndex = 27;
            this.txtVersion.Text = "1001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Output Path";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(14, 288);
            this.txtOutputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(653, 31);
            this.txtOutputPath.TabIndex = 17;
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Location = new System.Drawing.Point(673, 288);
            this.btnOutputBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(117, 38);
            this.btnOutputBrowse.TabIndex = 20;
            this.btnOutputBrowse.Text = "Browse";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Configuration:";
            // 
            // cmbConfig
            // 
            this.cmbConfig.FormattingEnabled = true;
            this.cmbConfig.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.cmbConfig.Location = new System.Drawing.Point(14, 215);
            this.cmbConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbConfig.Name = "cmbConfig";
            this.cmbConfig.Size = new System.Drawing.Size(171, 33);
            this.cmbConfig.TabIndex = 24;
            // 
            // chbSymbols
            // 
            this.chbSymbols.AutoSize = true;
            this.chbSymbols.Location = new System.Drawing.Point(570, 148);
            this.chbSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbSymbols.Name = "chbSymbols";
            this.chbSymbols.Size = new System.Drawing.Size(106, 29);
            this.chbSymbols.TabIndex = 23;
            this.chbSymbols.Text = "Symbols";
            this.chbSymbols.UseVisualStyleBackColor = true;
            // 
            // chbNoPackageAnalysis
            // 
            this.chbNoPackageAnalysis.AutoSize = true;
            this.chbNoPackageAnalysis.Location = new System.Drawing.Point(373, 148);
            this.chbNoPackageAnalysis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbNoPackageAnalysis.Name = "chbNoPackageAnalysis";
            this.chbNoPackageAnalysis.Size = new System.Drawing.Size(200, 29);
            this.chbNoPackageAnalysis.TabIndex = 22;
            this.chbNoPackageAnalysis.Text = "No Package Analysis";
            this.chbNoPackageAnalysis.UseVisualStyleBackColor = true;
            // 
            // chbNonInteractive
            // 
            this.chbNonInteractive.AutoSize = true;
            this.chbNonInteractive.Location = new System.Drawing.Point(211, 148);
            this.chbNonInteractive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbNonInteractive.Name = "chbNonInteractive";
            this.chbNonInteractive.Size = new System.Drawing.Size(158, 29);
            this.chbNonInteractive.TabIndex = 21;
            this.chbNonInteractive.Text = "Non Interactive";
            this.chbNonInteractive.UseVisualStyleBackColor = true;
            // 
            // chbNoDefaultExcludes
            // 
            this.chbNoDefaultExcludes.AutoSize = true;
            this.chbNoDefaultExcludes.Location = new System.Drawing.Point(14, 148);
            this.chbNoDefaultExcludes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbNoDefaultExcludes.Name = "chbNoDefaultExcludes";
            this.chbNoDefaultExcludes.Size = new System.Drawing.Size(196, 29);
            this.chbNoDefaultExcludes.TabIndex = 19;
            this.chbNoDefaultExcludes.Text = "No Default Excludes";
            this.chbNoDefaultExcludes.UseVisualStyleBackColor = true;
            // 
            // chbIncludeReferencedProjects
            // 
            this.chbIncludeReferencedProjects.AutoSize = true;
            this.chbIncludeReferencedProjects.Location = new System.Drawing.Point(544, 92);
            this.chbIncludeReferencedProjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbIncludeReferencedProjects.Name = "chbIncludeReferencedProjects";
            this.chbIncludeReferencedProjects.Size = new System.Drawing.Size(254, 29);
            this.chbIncludeReferencedProjects.TabIndex = 16;
            this.chbIncludeReferencedProjects.Text = "Include Referenced Projects";
            this.chbIncludeReferencedProjects.UseVisualStyleBackColor = true;
            // 
            // chbForceEnglishOutput
            // 
            this.chbForceEnglishOutput.AutoSize = true;
            this.chbForceEnglishOutput.Location = new System.Drawing.Point(340, 92);
            this.chbForceEnglishOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbForceEnglishOutput.Name = "chbForceEnglishOutput";
            this.chbForceEnglishOutput.Size = new System.Drawing.Size(204, 29);
            this.chbForceEnglishOutput.TabIndex = 15;
            this.chbForceEnglishOutput.Text = "Force English Output";
            this.chbForceEnglishOutput.UseVisualStyleBackColor = true;
            // 
            // chbExcludeEmptyDirectories
            // 
            this.chbExcludeEmptyDirectories.AutoSize = true;
            this.chbExcludeEmptyDirectories.Location = new System.Drawing.Point(99, 92);
            this.chbExcludeEmptyDirectories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbExcludeEmptyDirectories.Name = "chbExcludeEmptyDirectories";
            this.chbExcludeEmptyDirectories.Size = new System.Drawing.Size(242, 29);
            this.chbExcludeEmptyDirectories.TabIndex = 14;
            this.chbExcludeEmptyDirectories.Text = "Exclude Empty Directories";
            this.chbExcludeEmptyDirectories.UseVisualStyleBackColor = true;
            // 
            // chbBuild
            // 
            this.chbBuild.AutoSize = true;
            this.chbBuild.Location = new System.Drawing.Point(14, 92);
            this.chbBuild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbBuild.Name = "chbBuild";
            this.chbBuild.Size = new System.Drawing.Size(77, 29);
            this.chbBuild.TabIndex = 13;
            this.chbBuild.Text = "Build";
            this.chbBuild.UseVisualStyleBackColor = true;
            // 
            // tabPushPackage
            // 
            this.tabPushPackage.Controls.Add(this.label6);
            this.tabPushPackage.Controls.Add(this.txtAPIKey);
            this.tabPushPackage.Controls.Add(this.label5);
            this.tabPushPackage.Controls.Add(this.btnPackageBrowse);
            this.tabPushPackage.Controls.Add(this.txtPackagePath);
            this.tabPushPackage.Controls.Add(this.btnPush);
            this.tabPushPackage.Controls.Add(this.label7);
            this.tabPushPackage.Controls.Add(this.txtNugetSource);
            this.tabPushPackage.Controls.Add(this.chbNoSymbols);
            this.tabPushPackage.Controls.Add(this.chbNonInteractive1);
            this.tabPushPackage.Controls.Add(this.chbSkipDuplicate);
            this.tabPushPackage.Controls.Add(this.chbNoServiceEndpoint);
            this.tabPushPackage.Controls.Add(this.chbForceEnglishOutput1);
            this.tabPushPackage.Controls.Add(this.chbDisableBuffering);
            this.tabPushPackage.Location = new System.Drawing.Point(4, 34);
            this.tabPushPackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPushPackage.Name = "tabPushPackage";
            this.tabPushPackage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPushPackage.Size = new System.Drawing.Size(808, 395);
            this.tabPushPackage.TabIndex = 1;
            this.tabPushPackage.Text = "Push Package";
            this.tabPushPackage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "API Key";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(136, 207);
            this.txtAPIKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(650, 31);
            this.txtAPIKey.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Package File Path:";
            // 
            // btnPackageBrowse
            // 
            this.btnPackageBrowse.Location = new System.Drawing.Point(677, 40);
            this.btnPackageBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPackageBrowse.Name = "btnPackageBrowse";
            this.btnPackageBrowse.Size = new System.Drawing.Size(117, 38);
            this.btnPackageBrowse.TabIndex = 49;
            this.btnPackageBrowse.Text = "Browse";
            this.btnPackageBrowse.UseVisualStyleBackColor = true;
            this.btnPackageBrowse.Click += new System.EventHandler(this.btnPackageBrowse_Click);
            // 
            // txtPackagePath
            // 
            this.txtPackagePath.Location = new System.Drawing.Point(14, 42);
            this.txtPackagePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPackagePath.Name = "txtPackagePath";
            this.txtPackagePath.Size = new System.Drawing.Size(655, 31);
            this.txtPackagePath.TabIndex = 48;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(14, 335);
            this.btnPush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(117, 38);
            this.btnPush.TabIndex = 47;
            this.btnPush.Text = "Push";
            this.btnPush.UseMnemonic = false;
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nuget Source";
            // 
            // txtNugetSource
            // 
            this.txtNugetSource.Location = new System.Drawing.Point(136, 273);
            this.txtNugetSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNugetSource.Name = "txtNugetSource";
            this.txtNugetSource.Size = new System.Drawing.Size(650, 31);
            this.txtNugetSource.TabIndex = 36;
            // 
            // chbNoSymbols
            // 
            this.chbNoSymbols.AutoSize = true;
            this.chbNoSymbols.Location = new System.Drawing.Point(167, 147);
            this.chbNoSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbNoSymbols.Name = "chbNoSymbols";
            this.chbNoSymbols.Size = new System.Drawing.Size(135, 29);
            this.chbNoSymbols.TabIndex = 42;
            this.chbNoSymbols.Text = "No Symbols";
            this.chbNoSymbols.UseVisualStyleBackColor = true;
            // 
            // chbNonInteractive1
            // 
            this.chbNonInteractive1.AutoSize = true;
            this.chbNonInteractive1.Location = new System.Drawing.Point(189, 90);
            this.chbNonInteractive1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbNonInteractive1.Name = "chbNonInteractive1";
            this.chbNonInteractive1.Size = new System.Drawing.Size(158, 29);
            this.chbNonInteractive1.TabIndex = 40;
            this.chbNonInteractive1.Text = "Non Interactive";
            this.chbNonInteractive1.UseVisualStyleBackColor = true;
            // 
            // chbSkipDuplicate
            // 
            this.chbSkipDuplicate.AutoSize = true;
            this.chbSkipDuplicate.Location = new System.Drawing.Point(14, 147);
            this.chbSkipDuplicate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbSkipDuplicate.Name = "chbSkipDuplicate";
            this.chbSkipDuplicate.Size = new System.Drawing.Size(151, 29);
            this.chbSkipDuplicate.TabIndex = 38;
            this.chbSkipDuplicate.Text = "Skip Duplicate";
            this.chbSkipDuplicate.UseVisualStyleBackColor = true;
            // 
            // chbNoServiceEndpoint
            // 
            this.chbNoServiceEndpoint.AutoSize = true;
            this.chbNoServiceEndpoint.Location = new System.Drawing.Point(561, 88);
            this.chbNoServiceEndpoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbNoServiceEndpoint.Name = "chbNoServiceEndpoint";
            this.chbNoServiceEndpoint.Size = new System.Drawing.Size(199, 29);
            this.chbNoServiceEndpoint.TabIndex = 35;
            this.chbNoServiceEndpoint.Text = "No Service Endpoint";
            this.chbNoServiceEndpoint.UseVisualStyleBackColor = true;
            // 
            // chbForceEnglishOutput1
            // 
            this.chbForceEnglishOutput1.AutoSize = true;
            this.chbForceEnglishOutput1.Location = new System.Drawing.Point(357, 88);
            this.chbForceEnglishOutput1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbForceEnglishOutput1.Name = "chbForceEnglishOutput1";
            this.chbForceEnglishOutput1.Size = new System.Drawing.Size(204, 29);
            this.chbForceEnglishOutput1.TabIndex = 34;
            this.chbForceEnglishOutput1.Text = "Force English Output";
            this.chbForceEnglishOutput1.UseVisualStyleBackColor = true;
            // 
            // chbDisableBuffering
            // 
            this.chbDisableBuffering.AutoSize = true;
            this.chbDisableBuffering.Location = new System.Drawing.Point(14, 90);
            this.chbDisableBuffering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbDisableBuffering.Name = "chbDisableBuffering";
            this.chbDisableBuffering.Size = new System.Drawing.Size(173, 29);
            this.chbDisableBuffering.TabIndex = 32;
            this.chbDisableBuffering.Text = "Disable Buffering";
            this.chbDisableBuffering.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NugetPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 920);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "NugetPublisher";
            this.Text = "Nuget Package Publisher";
            this.Load += new System.EventHandler(this.NugetPublisher_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPackPackage.ResumeLayout(false);
            this.tabPackPackage.PerformLayout();
            this.tabPushPackage.ResumeLayout(false);
            this.tabPushPackage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPushPackage;
        private System.Windows.Forms.TabPage tabPackPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtProjectFile;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.MaskedTextBox txtVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnOutputBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbConfig;
        private System.Windows.Forms.CheckBox chbSymbols;
        private System.Windows.Forms.CheckBox chbNoPackageAnalysis;
        private System.Windows.Forms.CheckBox chbNonInteractive;
        private System.Windows.Forms.CheckBox chbNoDefaultExcludes;
        private System.Windows.Forms.CheckBox chbIncludeReferencedProjects;
        private System.Windows.Forms.CheckBox chbForceEnglishOutput;
        private System.Windows.Forms.CheckBox chbExcludeEmptyDirectories;
        private System.Windows.Forms.CheckBox chbBuild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPackageBrowse;
        private System.Windows.Forms.TextBox txtPackagePath;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNugetSource;
        private System.Windows.Forms.CheckBox chbNoSymbols;
        private System.Windows.Forms.CheckBox chbNonInteractive1;
        private System.Windows.Forms.CheckBox chbSkipDuplicate;
        private System.Windows.Forms.CheckBox chbNoServiceEndpoint;
        private System.Windows.Forms.CheckBox chbForceEnglishOutput1;
        private System.Windows.Forms.CheckBox chbDisableBuffering;
    }
}

