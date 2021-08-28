namespace Dashboard_SponsorBlock.User_Control
{
    partial class UC_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpSettingsSele = new System.Windows.Forms.TabPage();
            this.btRunSetupSelenium = new System.Windows.Forms.Button();
            this.lbChooseOptions = new System.Windows.Forms.Label();
            this.pnOptionsImportSBSettings = new System.Windows.Forms.Panel();
            this.rbImportAllOptions = new System.Windows.Forms.RadioButton();
            this.rbOnlyUserID = new System.Windows.Forms.RadioButton();
            this.btPasteAllOptions = new System.Windows.Forms.Button();
            this.btPasteUserID = new System.Windows.Forms.Button();
            this.btChooseFileAllOptions = new System.Windows.Forms.Button();
            this.btChooseFileUserID = new System.Windows.Forms.Button();
            this.tbAllSettingSBlock = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPathSelenium = new System.Windows.Forms.TextBox();
            this.btChooseFolderSelenium = new System.Windows.Forms.Button();
            this.lbPathProfileSelenium = new System.Windows.Forms.Label();
            this.tpRestore = new System.Windows.Forms.TabPage();
            this.gbResPage = new System.Windows.Forms.GroupBox();
            this.btPastePage = new System.Windows.Forms.Button();
            this.btImportPage = new System.Windows.Forms.Button();
            this.gbResOtherFile = new System.Windows.Forms.GroupBox();
            this.lbRestListSBlocker = new System.Windows.Forms.Label();
            this.lbRestVideoyesSBlock = new System.Windows.Forms.Label();
            this.lbRestFileVideonoSponsor = new System.Windows.Forms.Label();
            this.btPasteRestListSBlocker = new System.Windows.Forms.Button();
            this.btPasteRestVideoyesSBlock = new System.Windows.Forms.Button();
            this.btChooseRestSBlocker = new System.Windows.Forms.Button();
            this.btPasteRestVideonoSBlock = new System.Windows.Forms.Button();
            this.btChooseRestVideoyesSBlock = new System.Windows.Forms.Button();
            this.btPasteRestAllVideo = new System.Windows.Forms.Button();
            this.btChooseRestVideonoSBlock = new System.Windows.Forms.Button();
            this.btChooseRestAllVideo = new System.Windows.Forms.Button();
            this.lbRestListAllVideo = new System.Windows.Forms.Label();
            this.tpBackup = new System.Windows.Forms.TabPage();
            this.gbBackupOther = new System.Windows.Forms.GroupBox();
            this.cbVideoyesSBlock = new System.Windows.Forms.CheckBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.btCopyOther = new System.Windows.Forms.Button();
            this.cbListAllVideo = new System.Windows.Forms.CheckBox();
            this.cbVideonoSBlock = new System.Windows.Forms.CheckBox();
            this.cbListSBlocker = new System.Windows.Forms.CheckBox();
            this.btSendOther = new System.Windows.Forms.Button();
            this.tbPathBackupOtherFile = new System.Windows.Forms.TextBox();
            this.tbMailOther = new System.Windows.Forms.TextBox();
            this.lbMailOther = new System.Windows.Forms.Label();
            this.gbBackupPage = new System.Windows.Forms.GroupBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.btCopyPage = new System.Windows.Forms.Button();
            this.btSavePage = new System.Windows.Forms.Button();
            this.btSendPage = new System.Windows.Forms.Button();
            this.rtbDataPage = new System.Windows.Forms.RichTextBox();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tpSettingsSele.SuspendLayout();
            this.pnOptionsImportSBSettings.SuspendLayout();
            this.tpRestore.SuspendLayout();
            this.gbResPage.SuspendLayout();
            this.gbResOtherFile.SuspendLayout();
            this.tpBackup.SuspendLayout();
            this.gbBackupOther.SuspendLayout();
            this.gbBackupPage.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpSettingsSele
            // 
            this.tpSettingsSele.Controls.Add(this.btRunSetupSelenium);
            this.tpSettingsSele.Controls.Add(this.lbChooseOptions);
            this.tpSettingsSele.Controls.Add(this.pnOptionsImportSBSettings);
            this.tpSettingsSele.Controls.Add(this.tbPathSelenium);
            this.tpSettingsSele.Controls.Add(this.btChooseFolderSelenium);
            this.tpSettingsSele.Controls.Add(this.lbPathProfileSelenium);
            this.tpSettingsSele.Location = new System.Drawing.Point(4, 25);
            this.tpSettingsSele.Name = "tpSettingsSele";
            this.tpSettingsSele.Size = new System.Drawing.Size(1004, 466);
            this.tpSettingsSele.TabIndex = 2;
            this.tpSettingsSele.Text = "Settings Selenium";
            this.tpSettingsSele.UseVisualStyleBackColor = true;
            // 
            // btRunSetupSelenium
            // 
            this.btRunSetupSelenium.Location = new System.Drawing.Point(800, 128);
            this.btRunSetupSelenium.Name = "btRunSetupSelenium";
            this.btRunSetupSelenium.Size = new System.Drawing.Size(201, 23);
            this.btRunSetupSelenium.TabIndex = 10;
            this.btRunSetupSelenium.Text = "Thực thi cài đặt Profile";
            this.btRunSetupSelenium.UseVisualStyleBackColor = true;
            this.btRunSetupSelenium.Click += new System.EventHandler(this.btRunSetupSelenium_Click);
            // 
            // lbChooseOptions
            // 
            this.lbChooseOptions.AutoSize = true;
            this.lbChooseOptions.Location = new System.Drawing.Point(3, 37);
            this.lbChooseOptions.Name = "lbChooseOptions";
            this.lbChooseOptions.Size = new System.Drawing.Size(236, 16);
            this.lbChooseOptions.TabIndex = 8;
            this.lbChooseOptions.Text = "Vui lòng chọn 1 trong 2 tuỳ chọn dưới đây:";
            // 
            // pnOptionsImportSBSettings
            // 
            this.pnOptionsImportSBSettings.Controls.Add(this.rbImportAllOptions);
            this.pnOptionsImportSBSettings.Controls.Add(this.rbOnlyUserID);
            this.pnOptionsImportSBSettings.Controls.Add(this.btPasteAllOptions);
            this.pnOptionsImportSBSettings.Controls.Add(this.btPasteUserID);
            this.pnOptionsImportSBSettings.Controls.Add(this.btChooseFileAllOptions);
            this.pnOptionsImportSBSettings.Controls.Add(this.btChooseFileUserID);
            this.pnOptionsImportSBSettings.Controls.Add(this.tbAllSettingSBlock);
            this.pnOptionsImportSBSettings.Controls.Add(this.tbUserID);
            this.pnOptionsImportSBSettings.Location = new System.Drawing.Point(25, 53);
            this.pnOptionsImportSBSettings.Name = "pnOptionsImportSBSettings";
            this.pnOptionsImportSBSettings.Size = new System.Drawing.Size(976, 69);
            this.pnOptionsImportSBSettings.TabIndex = 9;
            // 
            // rbImportAllOptions
            // 
            this.rbImportAllOptions.AutoSize = true;
            this.rbImportAllOptions.Location = new System.Drawing.Point(3, 27);
            this.rbImportAllOptions.Name = "rbImportAllOptions";
            this.rbImportAllOptions.Size = new System.Drawing.Size(145, 20);
            this.rbImportAllOptions.TabIndex = 0;
            this.rbImportAllOptions.TabStop = true;
            this.rbImportAllOptions.Text = "Nhập toàn bộ cài đặt";
            this.rbImportAllOptions.UseVisualStyleBackColor = true;
            this.rbImportAllOptions.CheckedChanged += new System.EventHandler(this.rbImportAllOptions_CheckedChanged);
            // 
            // rbOnlyUserID
            // 
            this.rbOnlyUserID.AutoSize = true;
            this.rbOnlyUserID.Location = new System.Drawing.Point(3, 4);
            this.rbOnlyUserID.Name = "rbOnlyUserID";
            this.rbOnlyUserID.Size = new System.Drawing.Size(149, 20);
            this.rbOnlyUserID.TabIndex = 0;
            this.rbOnlyUserID.TabStop = true;
            this.rbOnlyUserID.Text = "Chỉ nhập mã ID bí mật";
            this.rbOnlyUserID.UseVisualStyleBackColor = true;
            this.rbOnlyUserID.CheckedChanged += new System.EventHandler(this.rbOnlyUserID_CheckedChanged);
            // 
            // btPasteAllOptions
            // 
            this.btPasteAllOptions.Location = new System.Drawing.Point(820, 32);
            this.btPasteAllOptions.Name = "btPasteAllOptions";
            this.btPasteAllOptions.Size = new System.Drawing.Size(150, 23);
            this.btPasteAllOptions.TabIndex = 2;
            this.btPasteAllOptions.Text = "Paste từ Clipboard";
            this.btPasteAllOptions.UseVisualStyleBackColor = true;
            this.btPasteAllOptions.Click += new System.EventHandler(this.btPasteAllOptions_Click);
            // 
            // btPasteUserID
            // 
            this.btPasteUserID.Location = new System.Drawing.Point(821, 3);
            this.btPasteUserID.Name = "btPasteUserID";
            this.btPasteUserID.Size = new System.Drawing.Size(149, 23);
            this.btPasteUserID.TabIndex = 2;
            this.btPasteUserID.Text = "Paste từ Clipboard";
            this.btPasteUserID.UseVisualStyleBackColor = true;
            this.btPasteUserID.Click += new System.EventHandler(this.btPasteUserID_Click);
            // 
            // btChooseFileAllOptions
            // 
            this.btChooseFileAllOptions.Location = new System.Drawing.Point(739, 32);
            this.btChooseFileAllOptions.Name = "btChooseFileAllOptions";
            this.btChooseFileAllOptions.Size = new System.Drawing.Size(75, 23);
            this.btChooseFileAllOptions.TabIndex = 2;
            this.btChooseFileAllOptions.Text = "Chọn file";
            this.btChooseFileAllOptions.UseVisualStyleBackColor = true;
            this.btChooseFileAllOptions.Click += new System.EventHandler(this.btChooseFileAllOptions_Click);
            // 
            // btChooseFileUserID
            // 
            this.btChooseFileUserID.Location = new System.Drawing.Point(739, 3);
            this.btChooseFileUserID.Name = "btChooseFileUserID";
            this.btChooseFileUserID.Size = new System.Drawing.Size(75, 23);
            this.btChooseFileUserID.TabIndex = 2;
            this.btChooseFileUserID.Text = "Chọn file";
            this.btChooseFileUserID.UseVisualStyleBackColor = true;
            this.btChooseFileUserID.Click += new System.EventHandler(this.btChooseFileUserID_Click);
            // 
            // tbAllSettingSBlock
            // 
            this.tbAllSettingSBlock.Location = new System.Drawing.Point(158, 27);
            this.tbAllSettingSBlock.Name = "tbAllSettingSBlock";
            this.tbAllSettingSBlock.Size = new System.Drawing.Size(575, 21);
            this.tbAllSettingSBlock.TabIndex = 0;
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(158, 3);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(575, 21);
            this.tbUserID.TabIndex = 0;
            // 
            // tbPathSelenium
            // 
            this.tbPathSelenium.Location = new System.Drawing.Point(324, 10);
            this.tbPathSelenium.Name = "tbPathSelenium";
            this.tbPathSelenium.Size = new System.Drawing.Size(561, 21);
            this.tbPathSelenium.TabIndex = 6;
            this.tbPathSelenium.Text = "D:\\Test Dashboard SponsorBlock\\Profile Sele";
            // 
            // btChooseFolderSelenium
            // 
            this.btChooseFolderSelenium.Location = new System.Drawing.Point(891, 10);
            this.btChooseFolderSelenium.Name = "btChooseFolderSelenium";
            this.btChooseFolderSelenium.Size = new System.Drawing.Size(110, 23);
            this.btChooseFolderSelenium.TabIndex = 7;
            this.btChooseFolderSelenium.Text = "Chọn thư mục chứa";
            this.btChooseFolderSelenium.UseVisualStyleBackColor = true;
            this.btChooseFolderSelenium.Click += new System.EventHandler(this.btChooseFolderSelenium_Click);
            // 
            // lbPathProfileSelenium
            // 
            this.lbPathProfileSelenium.AutoSize = true;
            this.lbPathProfileSelenium.Location = new System.Drawing.Point(3, 10);
            this.lbPathProfileSelenium.Name = "lbPathProfileSelenium";
            this.lbPathProfileSelenium.Size = new System.Drawing.Size(315, 16);
            this.lbPathProfileSelenium.TabIndex = 5;
            this.lbPathProfileSelenium.Text = "Vị trí profile (Để trống tạo 1 profile trong thư mục cài đặt): ";
            // 
            // tpRestore
            // 
            this.tpRestore.Controls.Add(this.gbResPage);
            this.tpRestore.Controls.Add(this.gbResOtherFile);
            this.tpRestore.Location = new System.Drawing.Point(4, 25);
            this.tpRestore.Name = "tpRestore";
            this.tpRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tpRestore.Size = new System.Drawing.Size(1004, 466);
            this.tpRestore.TabIndex = 1;
            this.tpRestore.Text = "Restore";
            this.tpRestore.UseVisualStyleBackColor = true;
            // 
            // gbResPage
            // 
            this.gbResPage.Controls.Add(this.btPastePage);
            this.gbResPage.Controls.Add(this.btImportPage);
            this.gbResPage.Location = new System.Drawing.Point(6, 6);
            this.gbResPage.Name = "gbResPage";
            this.gbResPage.Size = new System.Drawing.Size(992, 54);
            this.gbResPage.TabIndex = 1;
            this.gbResPage.TabStop = false;
            this.gbResPage.Text = "Dữ liệu các trang bị đánh giá";
            // 
            // btPastePage
            // 
            this.btPastePage.Location = new System.Drawing.Point(510, 19);
            this.btPastePage.Name = "btPastePage";
            this.btPastePage.Size = new System.Drawing.Size(476, 23);
            this.btPastePage.TabIndex = 1;
            this.btPastePage.Text = "Nhập từ Clipboard";
            this.btPastePage.UseVisualStyleBackColor = true;
            // 
            // btImportPage
            // 
            this.btImportPage.Location = new System.Drawing.Point(6, 19);
            this.btImportPage.Name = "btImportPage";
            this.btImportPage.Size = new System.Drawing.Size(498, 23);
            this.btImportPage.TabIndex = 0;
            this.btImportPage.Text = "Nhập từ file";
            this.btImportPage.UseVisualStyleBackColor = true;
            this.btImportPage.Click += new System.EventHandler(this.btImportPage_Click);
            // 
            // gbResOtherFile
            // 
            this.gbResOtherFile.Controls.Add(this.lbRestListSBlocker);
            this.gbResOtherFile.Controls.Add(this.lbRestVideoyesSBlock);
            this.gbResOtherFile.Controls.Add(this.lbRestFileVideonoSponsor);
            this.gbResOtherFile.Controls.Add(this.btPasteRestListSBlocker);
            this.gbResOtherFile.Controls.Add(this.btPasteRestVideoyesSBlock);
            this.gbResOtherFile.Controls.Add(this.btChooseRestSBlocker);
            this.gbResOtherFile.Controls.Add(this.btPasteRestVideonoSBlock);
            this.gbResOtherFile.Controls.Add(this.btChooseRestVideoyesSBlock);
            this.gbResOtherFile.Controls.Add(this.btPasteRestAllVideo);
            this.gbResOtherFile.Controls.Add(this.btChooseRestVideonoSBlock);
            this.gbResOtherFile.Controls.Add(this.btChooseRestAllVideo);
            this.gbResOtherFile.Controls.Add(this.lbRestListAllVideo);
            this.gbResOtherFile.Location = new System.Drawing.Point(6, 66);
            this.gbResOtherFile.Name = "gbResOtherFile";
            this.gbResOtherFile.Size = new System.Drawing.Size(992, 127);
            this.gbResOtherFile.TabIndex = 2;
            this.gbResOtherFile.TabStop = false;
            this.gbResOtherFile.Text = "Các file khác";
            // 
            // lbRestListSBlocker
            // 
            this.lbRestListSBlocker.AutoSize = true;
            this.lbRestListSBlocker.Location = new System.Drawing.Point(5, 101);
            this.lbRestListSBlocker.Name = "lbRestListSBlocker";
            this.lbRestListSBlocker.Size = new System.Drawing.Size(168, 16);
            this.lbRestListSBlocker.TabIndex = 0;
            this.lbRestListSBlocker.Text = "File csv danh sách người tạo: ";
            // 
            // lbRestVideoyesSBlock
            // 
            this.lbRestVideoyesSBlock.AutoSize = true;
            this.lbRestVideoyesSBlock.Location = new System.Drawing.Point(5, 75);
            this.lbRestVideoyesSBlock.Name = "lbRestVideoyesSBlock";
            this.lbRestVideoyesSBlock.Size = new System.Drawing.Size(219, 16);
            this.lbRestVideoyesSBlock.TabIndex = 0;
            this.lbRestVideoyesSBlock.Text = "File video có phân đoạn SponsorBlock: ";
            // 
            // lbRestFileVideonoSponsor
            // 
            this.lbRestFileVideonoSponsor.AutoSize = true;
            this.lbRestFileVideonoSponsor.Location = new System.Drawing.Point(5, 49);
            this.lbRestFileVideonoSponsor.Name = "lbRestFileVideonoSponsor";
            this.lbRestFileVideonoSponsor.Size = new System.Drawing.Size(239, 16);
            this.lbRestFileVideonoSponsor.TabIndex = 0;
            this.lbRestFileVideonoSponsor.Text = "File video chưa có đánh giá SponsorBlock: ";
            // 
            // btPasteRestListSBlocker
            // 
            this.btPasteRestListSBlocker.Location = new System.Drawing.Point(330, 99);
            this.btPasteRestListSBlocker.Name = "btPasteRestListSBlocker";
            this.btPasteRestListSBlocker.Size = new System.Drawing.Size(129, 23);
            this.btPasteRestListSBlocker.TabIndex = 0;
            this.btPasteRestListSBlocker.Text = "Paste Clipboard";
            this.btPasteRestListSBlocker.UseVisualStyleBackColor = true;
            // 
            // btPasteRestVideoyesSBlock
            // 
            this.btPasteRestVideoyesSBlock.Location = new System.Drawing.Point(330, 73);
            this.btPasteRestVideoyesSBlock.Name = "btPasteRestVideoyesSBlock";
            this.btPasteRestVideoyesSBlock.Size = new System.Drawing.Size(129, 23);
            this.btPasteRestVideoyesSBlock.TabIndex = 0;
            this.btPasteRestVideoyesSBlock.Text = "Paste Clipboard";
            this.btPasteRestVideoyesSBlock.UseVisualStyleBackColor = true;
            // 
            // btChooseRestSBlocker
            // 
            this.btChooseRestSBlocker.Location = new System.Drawing.Point(249, 98);
            this.btChooseRestSBlocker.Name = "btChooseRestSBlocker";
            this.btChooseRestSBlocker.Size = new System.Drawing.Size(75, 23);
            this.btChooseRestSBlocker.TabIndex = 0;
            this.btChooseRestSBlocker.Text = "Chọn file";
            this.btChooseRestSBlocker.UseVisualStyleBackColor = true;
            this.btChooseRestSBlocker.Click += new System.EventHandler(this.btChooseRestSBlocker_Click);
            // 
            // btPasteRestVideonoSBlock
            // 
            this.btPasteRestVideonoSBlock.Location = new System.Drawing.Point(330, 47);
            this.btPasteRestVideonoSBlock.Name = "btPasteRestVideonoSBlock";
            this.btPasteRestVideonoSBlock.Size = new System.Drawing.Size(129, 23);
            this.btPasteRestVideonoSBlock.TabIndex = 0;
            this.btPasteRestVideonoSBlock.Text = "Paste Clipboard";
            this.btPasteRestVideonoSBlock.UseVisualStyleBackColor = true;
            // 
            // btChooseRestVideoyesSBlock
            // 
            this.btChooseRestVideoyesSBlock.Location = new System.Drawing.Point(249, 72);
            this.btChooseRestVideoyesSBlock.Name = "btChooseRestVideoyesSBlock";
            this.btChooseRestVideoyesSBlock.Size = new System.Drawing.Size(75, 23);
            this.btChooseRestVideoyesSBlock.TabIndex = 0;
            this.btChooseRestVideoyesSBlock.Text = "Chọn file";
            this.btChooseRestVideoyesSBlock.UseVisualStyleBackColor = true;
            this.btChooseRestVideoyesSBlock.Click += new System.EventHandler(this.btChooseRestVideoyesSBlock_Click);
            // 
            // btPasteRestAllVideo
            // 
            this.btPasteRestAllVideo.Location = new System.Drawing.Point(330, 21);
            this.btPasteRestAllVideo.Name = "btPasteRestAllVideo";
            this.btPasteRestAllVideo.Size = new System.Drawing.Size(129, 23);
            this.btPasteRestAllVideo.TabIndex = 0;
            this.btPasteRestAllVideo.Text = "Paste Clipboard";
            this.btPasteRestAllVideo.UseVisualStyleBackColor = true;
            // 
            // btChooseRestVideonoSBlock
            // 
            this.btChooseRestVideonoSBlock.Location = new System.Drawing.Point(249, 46);
            this.btChooseRestVideonoSBlock.Name = "btChooseRestVideonoSBlock";
            this.btChooseRestVideonoSBlock.Size = new System.Drawing.Size(75, 23);
            this.btChooseRestVideonoSBlock.TabIndex = 0;
            this.btChooseRestVideonoSBlock.Text = "Chọn file";
            this.btChooseRestVideonoSBlock.UseVisualStyleBackColor = true;
            this.btChooseRestVideonoSBlock.Click += new System.EventHandler(this.btChooseRestVideonoSBlock_Click);
            // 
            // btChooseRestAllVideo
            // 
            this.btChooseRestAllVideo.Location = new System.Drawing.Point(249, 20);
            this.btChooseRestAllVideo.Name = "btChooseRestAllVideo";
            this.btChooseRestAllVideo.Size = new System.Drawing.Size(75, 23);
            this.btChooseRestAllVideo.TabIndex = 0;
            this.btChooseRestAllVideo.Text = "Chọn file";
            this.btChooseRestAllVideo.UseVisualStyleBackColor = true;
            this.btChooseRestAllVideo.Click += new System.EventHandler(this.btChooseRestAllVideo_Click);
            // 
            // lbRestListAllVideo
            // 
            this.lbRestListAllVideo.AutoSize = true;
            this.lbRestListAllVideo.Location = new System.Drawing.Point(5, 23);
            this.lbRestListAllVideo.Name = "lbRestListAllVideo";
            this.lbRestListAllVideo.Size = new System.Drawing.Size(155, 16);
            this.lbRestListAllVideo.TabIndex = 0;
            this.lbRestListAllVideo.Text = "Danh sách toàn bộ video: ";
            // 
            // tpBackup
            // 
            this.tpBackup.Controls.Add(this.gbBackupOther);
            this.tpBackup.Controls.Add(this.gbBackupPage);
            this.tpBackup.Location = new System.Drawing.Point(4, 25);
            this.tpBackup.Name = "tpBackup";
            this.tpBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tpBackup.Size = new System.Drawing.Size(1004, 466);
            this.tpBackup.TabIndex = 0;
            this.tpBackup.Text = "Backup";
            this.tpBackup.UseVisualStyleBackColor = true;
            // 
            // gbBackupOther
            // 
            this.gbBackupOther.Controls.Add(this.cbVideoyesSBlock);
            this.gbBackupOther.Controls.Add(this.lbPath);
            this.gbBackupOther.Controls.Add(this.btCopyOther);
            this.gbBackupOther.Controls.Add(this.cbListAllVideo);
            this.gbBackupOther.Controls.Add(this.cbVideonoSBlock);
            this.gbBackupOther.Controls.Add(this.cbListSBlocker);
            this.gbBackupOther.Controls.Add(this.btSendOther);
            this.gbBackupOther.Controls.Add(this.tbPathBackupOtherFile);
            this.gbBackupOther.Controls.Add(this.tbMailOther);
            this.gbBackupOther.Controls.Add(this.lbMailOther);
            this.gbBackupOther.Location = new System.Drawing.Point(520, 10);
            this.gbBackupOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBackupOther.Name = "gbBackupOther";
            this.gbBackupOther.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBackupOther.Size = new System.Drawing.Size(478, 449);
            this.gbBackupOther.TabIndex = 4;
            this.gbBackupOther.TabStop = false;
            this.gbBackupOther.Text = "Các file khác";
            // 
            // cbVideoyesSBlock
            // 
            this.cbVideoyesSBlock.AutoSize = true;
            this.cbVideoyesSBlock.Location = new System.Drawing.Point(5, 128);
            this.cbVideoyesSBlock.Name = "cbVideoyesSBlock";
            this.cbVideoyesSBlock.Size = new System.Drawing.Size(232, 20);
            this.cbVideoyesSBlock.TabIndex = 12;
            this.cbVideoyesSBlock.Text = "File video có phân đoạn SponsorBlock";
            this.cbVideoyesSBlock.UseVisualStyleBackColor = true;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(2, 52);
            this.lbPath.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(76, 16);
            this.lbPath.TabIndex = 8;
            this.lbPath.Text = "Đường dẫn: ";
            // 
            // btCopyOther
            // 
            this.btCopyOther.Location = new System.Drawing.Point(5, 219);
            this.btCopyOther.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btCopyOther.Name = "btCopyOther";
            this.btCopyOther.Size = new System.Drawing.Size(462, 27);
            this.btCopyOther.TabIndex = 6;
            this.btCopyOther.Text = "Copy vào Clipboard";
            this.btCopyOther.UseVisualStyleBackColor = true;
            // 
            // cbListAllVideo
            // 
            this.cbListAllVideo.AutoSize = true;
            this.cbListAllVideo.Location = new System.Drawing.Point(5, 76);
            this.cbListAllVideo.Name = "cbListAllVideo";
            this.cbListAllVideo.Size = new System.Drawing.Size(168, 20);
            this.cbListAllVideo.TabIndex = 12;
            this.cbListAllVideo.Text = "Danh sách toàn bộ video";
            this.cbListAllVideo.UseVisualStyleBackColor = true;
            // 
            // cbVideonoSBlock
            // 
            this.cbVideonoSBlock.AutoSize = true;
            this.cbVideonoSBlock.Location = new System.Drawing.Point(5, 102);
            this.cbVideonoSBlock.Name = "cbVideonoSBlock";
            this.cbVideonoSBlock.Size = new System.Drawing.Size(252, 20);
            this.cbVideonoSBlock.TabIndex = 12;
            this.cbVideonoSBlock.Text = "File video chưa có đánh giá SponsorBlock";
            this.cbVideonoSBlock.UseVisualStyleBackColor = true;
            // 
            // cbListSBlocker
            // 
            this.cbListSBlocker.AutoSize = true;
            this.cbListSBlocker.Location = new System.Drawing.Point(5, 154);
            this.cbListSBlocker.Name = "cbListSBlocker";
            this.cbListSBlocker.Size = new System.Drawing.Size(181, 20);
            this.cbListSBlocker.TabIndex = 12;
            this.cbListSBlocker.Text = "File csv danh sách người tạo";
            this.cbListSBlocker.UseVisualStyleBackColor = true;
            // 
            // btSendOther
            // 
            this.btSendOther.Location = new System.Drawing.Point(5, 182);
            this.btSendOther.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btSendOther.Name = "btSendOther";
            this.btSendOther.Size = new System.Drawing.Size(462, 27);
            this.btSendOther.TabIndex = 6;
            this.btSendOther.Text = "Gửi mail chứa dữ liệu";
            this.btSendOther.UseVisualStyleBackColor = true;
            // 
            // tbPathBackupOtherFile
            // 
            this.tbPathBackupOtherFile.Location = new System.Drawing.Point(144, 47);
            this.tbPathBackupOtherFile.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbPathBackupOtherFile.Name = "tbPathBackupOtherFile";
            this.tbPathBackupOtherFile.Size = new System.Drawing.Size(325, 21);
            this.tbPathBackupOtherFile.TabIndex = 11;
            // 
            // tbMailOther
            // 
            this.tbMailOther.Location = new System.Drawing.Point(144, 23);
            this.tbMailOther.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbMailOther.Name = "tbMailOther";
            this.tbMailOther.Size = new System.Drawing.Size(325, 21);
            this.tbMailOther.TabIndex = 11;
            // 
            // lbMailOther
            // 
            this.lbMailOther.AutoSize = true;
            this.lbMailOther.Location = new System.Drawing.Point(2, 25);
            this.lbMailOther.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbMailOther.Name = "lbMailOther";
            this.lbMailOther.Size = new System.Drawing.Size(134, 16);
            this.lbMailOther.TabIndex = 10;
            this.lbMailOther.Text = "Địa chỉ mail gửi dữ liệu:";
            // 
            // gbBackupPage
            // 
            this.gbBackupPage.Controls.Add(this.tbMail);
            this.gbBackupPage.Controls.Add(this.lbMail);
            this.gbBackupPage.Controls.Add(this.btCopyPage);
            this.gbBackupPage.Controls.Add(this.btSavePage);
            this.gbBackupPage.Controls.Add(this.btSendPage);
            this.gbBackupPage.Controls.Add(this.rtbDataPage);
            this.gbBackupPage.Location = new System.Drawing.Point(3, 4);
            this.gbBackupPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBackupPage.Name = "gbBackupPage";
            this.gbBackupPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBackupPage.Size = new System.Drawing.Size(511, 455);
            this.gbBackupPage.TabIndex = 3;
            this.gbBackupPage.TabStop = false;
            this.gbBackupPage.Text = "Dữ liệu các trang bị đánh giá";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(144, 359);
            this.tbMail.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(361, 21);
            this.tbMail.TabIndex = 9;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(8, 359);
            this.lbMail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(134, 16);
            this.lbMail.TabIndex = 8;
            this.lbMail.Text = "Địa chỉ mail gửi dữ liệu:";
            // 
            // btCopyPage
            // 
            this.btCopyPage.Location = new System.Drawing.Point(11, 390);
            this.btCopyPage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btCopyPage.Name = "btCopyPage";
            this.btCopyPage.Size = new System.Drawing.Size(131, 27);
            this.btCopyPage.TabIndex = 7;
            this.btCopyPage.Text = "Copy vào Clipboard";
            this.btCopyPage.UseVisualStyleBackColor = true;
            // 
            // btSavePage
            // 
            this.btSavePage.Location = new System.Drawing.Point(144, 390);
            this.btSavePage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btSavePage.Name = "btSavePage";
            this.btSavePage.Size = new System.Drawing.Size(128, 27);
            this.btSavePage.TabIndex = 7;
            this.btSavePage.Text = "Lưu file";
            this.btSavePage.UseVisualStyleBackColor = true;
            this.btSavePage.Click += new System.EventHandler(this.btSavePage_Click);
            // 
            // btSendPage
            // 
            this.btSendPage.Location = new System.Drawing.Point(274, 390);
            this.btSendPage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btSendPage.Name = "btSendPage";
            this.btSendPage.Size = new System.Drawing.Size(231, 27);
            this.btSendPage.TabIndex = 6;
            this.btSendPage.Text = "Gửi mail chứa dữ liệu";
            this.btSendPage.UseVisualStyleBackColor = true;
            // 
            // rtbDataPage
            // 
            this.rtbDataPage.Location = new System.Drawing.Point(7, 23);
            this.rtbDataPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDataPage.Name = "rtbDataPage";
            this.rtbDataPage.Size = new System.Drawing.Size(498, 321);
            this.rtbDataPage.TabIndex = 0;
            this.rtbDataPage.Text = "";
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tpBackup);
            this.tbcSettings.Controls.Add(this.tpRestore);
            this.tbcSettings.Controls.Add(this.tpSettingsSele);
            this.tbcSettings.Location = new System.Drawing.Point(0, 0);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(1012, 495);
            this.tbcSettings.TabIndex = 0;
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcSettings);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1012, 495);
            this.tpSettingsSele.ResumeLayout(false);
            this.tpSettingsSele.PerformLayout();
            this.pnOptionsImportSBSettings.ResumeLayout(false);
            this.pnOptionsImportSBSettings.PerformLayout();
            this.tpRestore.ResumeLayout(false);
            this.gbResPage.ResumeLayout(false);
            this.gbResOtherFile.ResumeLayout(false);
            this.gbResOtherFile.PerformLayout();
            this.tpBackup.ResumeLayout(false);
            this.gbBackupOther.ResumeLayout(false);
            this.gbBackupOther.PerformLayout();
            this.gbBackupPage.ResumeLayout(false);
            this.gbBackupPage.PerformLayout();
            this.tbcSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpSettingsSele;
        private System.Windows.Forms.Button btRunSetupSelenium;
        private System.Windows.Forms.Label lbChooseOptions;
        private System.Windows.Forms.Panel pnOptionsImportSBSettings;
        private System.Windows.Forms.RadioButton rbImportAllOptions;
        private System.Windows.Forms.RadioButton rbOnlyUserID;
        private System.Windows.Forms.Button btPasteAllOptions;
        private System.Windows.Forms.Button btPasteUserID;
        private System.Windows.Forms.Button btChooseFileAllOptions;
        private System.Windows.Forms.Button btChooseFileUserID;
        private System.Windows.Forms.TextBox tbAllSettingSBlock;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPathSelenium;
        private System.Windows.Forms.Button btChooseFolderSelenium;
        private System.Windows.Forms.Label lbPathProfileSelenium;
        private System.Windows.Forms.TabPage tpRestore;
        private System.Windows.Forms.GroupBox gbResPage;
        private System.Windows.Forms.Button btPastePage;
        private System.Windows.Forms.Button btImportPage;
        private System.Windows.Forms.TabPage tpBackup;
        private System.Windows.Forms.GroupBox gbBackupOther;
        private System.Windows.Forms.CheckBox cbVideoyesSBlock;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btCopyOther;
        private System.Windows.Forms.CheckBox cbListAllVideo;
        private System.Windows.Forms.CheckBox cbVideonoSBlock;
        private System.Windows.Forms.CheckBox cbListSBlocker;
        private System.Windows.Forms.Button btSendOther;
        private System.Windows.Forms.TextBox tbPathBackupOtherFile;
        private System.Windows.Forms.TextBox tbMailOther;
        private System.Windows.Forms.Label lbMailOther;
        private System.Windows.Forms.GroupBox gbBackupPage;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Button btCopyPage;
        private System.Windows.Forms.Button btSavePage;
        private System.Windows.Forms.Button btSendPage;
        private System.Windows.Forms.RichTextBox rtbDataPage;
        private System.Windows.Forms.TabControl tbcSettings;
        private System.Windows.Forms.GroupBox gbResOtherFile;
        private System.Windows.Forms.Label lbRestListSBlocker;
        private System.Windows.Forms.Label lbRestVideoyesSBlock;
        private System.Windows.Forms.Label lbRestFileVideonoSponsor;
        private System.Windows.Forms.Button btPasteRestListSBlocker;
        private System.Windows.Forms.Button btPasteRestVideoyesSBlock;
        private System.Windows.Forms.Button btChooseRestSBlocker;
        private System.Windows.Forms.Button btPasteRestVideonoSBlock;
        private System.Windows.Forms.Button btChooseRestVideoyesSBlock;
        private System.Windows.Forms.Button btPasteRestAllVideo;
        private System.Windows.Forms.Button btChooseRestVideonoSBlock;
        private System.Windows.Forms.Button btChooseRestAllVideo;
        private System.Windows.Forms.Label lbRestListAllVideo;
    }
}
