namespace Dashboard_SponsorBlock.User_Control
{
    partial class UC_Step1
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
            this.gbOtherEvent = new System.Windows.Forms.GroupBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btPasteClipboard = new System.Windows.Forms.Button();
            this.btImportFile = new System.Windows.Forms.Button();
            this.gbRestore = new System.Windows.Forms.GroupBox();
            this.btRewriteFilePage = new System.Windows.Forms.Button();
            this.tbMailSendPage = new System.Windows.Forms.TextBox();
            this.lbMailSendPage = new System.Windows.Forms.Label();
            this.btSaveAsFilePage = new System.Windows.Forms.Button();
            this.btSendPageMail = new System.Windows.Forms.Button();
            this.cbBackupFilePage = new System.Windows.Forms.GroupBox();
            this.btCopyListPage = new System.Windows.Forms.Button();
            this.lbPathFileOutput = new System.Windows.Forms.Label();
            this.tbPathOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.btChoosePathOutput = new System.Windows.Forms.Button();
            this.lbChooseOptions = new System.Windows.Forms.Label();
            this.gbListPage = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.npdNumberThread = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbNumberThread = new System.Windows.Forms.Label();
            this.rtbListPage = new System.Windows.Forms.RichTextBox();
            this.rbChooseImportListVideo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbChooseCrawl = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pbOptions = new System.Windows.Forms.Panel();
            this.btGetPathVideo = new System.Windows.Forms.Button();
            this.tbPathVideo = new System.Windows.Forms.TextBox();
            this.lbPathVideo = new System.Windows.Forms.Label();
            this.gbOtherEvent.SuspendLayout();
            this.gbRestore.SuspendLayout();
            this.cbBackupFilePage.SuspendLayout();
            this.gbListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdNumberThread)).BeginInit();
            this.pbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOtherEvent
            // 
            this.gbOtherEvent.Controls.Add(this.btRun);
            this.gbOtherEvent.Controls.Add(this.btExit);
            this.gbOtherEvent.Controls.Add(this.btHelp);
            this.gbOtherEvent.Location = new System.Drawing.Point(696, 357);
            this.gbOtherEvent.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.gbOtherEvent.Name = "gbOtherEvent";
            this.gbOtherEvent.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.gbOtherEvent.Size = new System.Drawing.Size(306, 123);
            this.gbOtherEvent.TabIndex = 11;
            this.gbOtherEvent.TabStop = false;
            this.gbOtherEvent.Text = "Các thao tác khác";
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(9, 24);
            this.btRun.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(292, 27);
            this.btRun.TabIndex = 3;
            this.btRun.Text = "Chạy";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(9, 86);
            this.btExit.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(292, 27);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(9, 57);
            this.btHelp.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(292, 27);
            this.btHelp.TabIndex = 1;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = true;
            // 
            // btPasteClipboard
            // 
            this.btPasteClipboard.Location = new System.Drawing.Point(7, 24);
            this.btPasteClipboard.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btPasteClipboard.Name = "btPasteClipboard";
            this.btPasteClipboard.Size = new System.Drawing.Size(245, 27);
            this.btPasteClipboard.TabIndex = 3;
            this.btPasteClipboard.Text = "Paste từ clipboard";
            this.btPasteClipboard.UseVisualStyleBackColor = true;
            this.btPasteClipboard.Click += new System.EventHandler(this.btPasteClipboard_Click);
            // 
            // btImportFile
            // 
            this.btImportFile.Location = new System.Drawing.Point(7, 53);
            this.btImportFile.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btImportFile.Name = "btImportFile";
            this.btImportFile.Size = new System.Drawing.Size(245, 27);
            this.btImportFile.TabIndex = 0;
            this.btImportFile.Text = "Nhập liệu từ file";
            this.btImportFile.UseVisualStyleBackColor = true;
            this.btImportFile.Click += new System.EventHandler(this.btImportFile_Click);
            // 
            // gbRestore
            // 
            this.gbRestore.Controls.Add(this.btRewriteFilePage);
            this.gbRestore.Controls.Add(this.btPasteClipboard);
            this.gbRestore.Controls.Add(this.btImportFile);
            this.gbRestore.Location = new System.Drawing.Point(422, 357);
            this.gbRestore.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.gbRestore.Name = "gbRestore";
            this.gbRestore.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.gbRestore.Size = new System.Drawing.Size(272, 123);
            this.gbRestore.TabIndex = 10;
            this.gbRestore.TabStop = false;
            this.gbRestore.Text = "Các thao tác cho restore file";
            // 
            // btRewriteFilePage
            // 
            this.btRewriteFilePage.Location = new System.Drawing.Point(7, 86);
            this.btRewriteFilePage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btRewriteFilePage.Name = "btRewriteFilePage";
            this.btRewriteFilePage.Size = new System.Drawing.Size(245, 27);
            this.btRewriteFilePage.TabIndex = 3;
            this.btRewriteFilePage.Text = "Lưu file page lại";
            this.btRewriteFilePage.UseVisualStyleBackColor = true;
            this.btRewriteFilePage.Click += new System.EventHandler(this.btRewriteFilePage_Click);
            // 
            // tbMailSendPage
            // 
            this.tbMailSendPage.Location = new System.Drawing.Point(146, 59);
            this.tbMailSendPage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbMailSendPage.Name = "tbMailSendPage";
            this.tbMailSendPage.Size = new System.Drawing.Size(249, 21);
            this.tbMailSendPage.TabIndex = 5;
            // 
            // lbMailSendPage
            // 
            this.lbMailSendPage.AutoSize = true;
            this.lbMailSendPage.Location = new System.Drawing.Point(1, 64);
            this.lbMailSendPage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbMailSendPage.Name = "lbMailSendPage";
            this.lbMailSendPage.Size = new System.Drawing.Size(134, 16);
            this.lbMailSendPage.TabIndex = 4;
            this.lbMailSendPage.Text = "Địa chỉ mail gửi dữ liệu:";
            // 
            // btSaveAsFilePage
            // 
            this.btSaveAsFilePage.Location = new System.Drawing.Point(7, 25);
            this.btSaveAsFilePage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btSaveAsFilePage.Name = "btSaveAsFilePage";
            this.btSaveAsFilePage.Size = new System.Drawing.Size(189, 27);
            this.btSaveAsFilePage.TabIndex = 3;
            this.btSaveAsFilePage.Text = "Lưu file";
            this.btSaveAsFilePage.UseVisualStyleBackColor = true;
            this.btSaveAsFilePage.Click += new System.EventHandler(this.btSaveAsFilePage_Click);
            // 
            // btSendPageMail
            // 
            this.btSendPageMail.Location = new System.Drawing.Point(7, 89);
            this.btSendPageMail.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btSendPageMail.Name = "btSendPageMail";
            this.btSendPageMail.Size = new System.Drawing.Size(385, 27);
            this.btSendPageMail.TabIndex = 0;
            this.btSendPageMail.Text = "Gửi mail chứa dữ liệu";
            this.btSendPageMail.UseVisualStyleBackColor = true;
            this.btSendPageMail.Click += new System.EventHandler(this.btSendPageMail_Click);
            // 
            // cbBackupFilePage
            // 
            this.cbBackupFilePage.Controls.Add(this.tbMailSendPage);
            this.cbBackupFilePage.Controls.Add(this.lbMailSendPage);
            this.cbBackupFilePage.Controls.Add(this.btCopyListPage);
            this.cbBackupFilePage.Controls.Add(this.btSaveAsFilePage);
            this.cbBackupFilePage.Controls.Add(this.btSendPageMail);
            this.cbBackupFilePage.Location = new System.Drawing.Point(10, 357);
            this.cbBackupFilePage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.cbBackupFilePage.Name = "cbBackupFilePage";
            this.cbBackupFilePage.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.cbBackupFilePage.Size = new System.Drawing.Size(399, 123);
            this.cbBackupFilePage.TabIndex = 9;
            this.cbBackupFilePage.TabStop = false;
            this.cbBackupFilePage.Text = "Các thao tác cho việc backup file";
            // 
            // btCopyListPage
            // 
            this.btCopyListPage.Location = new System.Drawing.Point(203, 25);
            this.btCopyListPage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.btCopyListPage.Name = "btCopyListPage";
            this.btCopyListPage.Size = new System.Drawing.Size(189, 27);
            this.btCopyListPage.TabIndex = 3;
            this.btCopyListPage.Text = "Copy vào Clipboard";
            this.btCopyListPage.UseVisualStyleBackColor = true;
            this.btCopyListPage.Click += new System.EventHandler(this.btCopyListPage_Click);
            // 
            // lbPathFileOutput
            // 
            this.lbPathFileOutput.AutoSize = true;
            this.lbPathFileOutput.Location = new System.Drawing.Point(12, 18);
            this.lbPathFileOutput.Name = "lbPathFileOutput";
            this.lbPathFileOutput.Size = new System.Drawing.Size(134, 16);
            this.lbPathFileOutput.TabIndex = 12;
            this.lbPathFileOutput.Text = "Địa chỉ lưu file kết quả: ";
            // 
            // tbPathOutput
            // 
            this.tbPathOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPathOutput.DefaultText = "D:\\Test Dashboard SponsorBlock";
            this.tbPathOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPathOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPathOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPathOutput.DisabledState.Parent = this.tbPathOutput;
            this.tbPathOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPathOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPathOutput.FocusedState.Parent = this.tbPathOutput;
            this.tbPathOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPathOutput.HoverState.Parent = this.tbPathOutput;
            this.tbPathOutput.Location = new System.Drawing.Point(156, 10);
            this.tbPathOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPathOutput.Name = "tbPathOutput";
            this.tbPathOutput.PasswordChar = '\0';
            this.tbPathOutput.PlaceholderText = "";
            this.tbPathOutput.SelectedText = "";
            this.tbPathOutput.SelectionStart = 30;
            this.tbPathOutput.ShadowDecoration.Parent = this.tbPathOutput;
            this.tbPathOutput.Size = new System.Drawing.Size(760, 31);
            this.tbPathOutput.TabIndex = 13;
            // 
            // btChoosePathOutput
            // 
            this.btChoosePathOutput.Location = new System.Drawing.Point(922, 11);
            this.btChoosePathOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChoosePathOutput.Name = "btChoosePathOutput";
            this.btChoosePathOutput.Size = new System.Drawing.Size(87, 31);
            this.btChoosePathOutput.TabIndex = 14;
            this.btChoosePathOutput.Text = "Choose....";
            this.btChoosePathOutput.UseVisualStyleBackColor = true;
            this.btChoosePathOutput.Click += new System.EventHandler(this.btChoosePathOutput_Click);
            // 
            // lbChooseOptions
            // 
            this.lbChooseOptions.AutoSize = true;
            this.lbChooseOptions.Location = new System.Drawing.Point(12, 47);
            this.lbChooseOptions.Name = "lbChooseOptions";
            this.lbChooseOptions.Size = new System.Drawing.Size(137, 16);
            this.lbChooseOptions.TabIndex = 15;
            this.lbChooseOptions.Text = "Phương thức lấy video: ";
            // 
            // gbListPage
            // 
            this.gbListPage.Controls.Add(this.lbStatus);
            this.gbListPage.Controls.Add(this.npdNumberThread);
            this.gbListPage.Controls.Add(this.lbNumberThread);
            this.gbListPage.Controls.Add(this.rtbListPage);
            this.gbListPage.Location = new System.Drawing.Point(19, 25);
            this.gbListPage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.gbListPage.Name = "gbListPage";
            this.gbListPage.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.gbListPage.Size = new System.Drawing.Size(973, 214);
            this.gbListPage.TabIndex = 8;
            this.gbListPage.TabStop = false;
            this.gbListPage.Text = "Danh sách các trang bị đánh giá";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(4, 178);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(87, 16);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status (Delete)";
            // 
            // npdNumberThread
            // 
            this.npdNumberThread.BackColor = System.Drawing.Color.Transparent;
            this.npdNumberThread.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.npdNumberThread.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.npdNumberThread.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.npdNumberThread.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.npdNumberThread.DisabledState.Parent = this.npdNumberThread;
            this.npdNumberThread.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.npdNumberThread.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.npdNumberThread.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.npdNumberThread.FocusedState.Parent = this.npdNumberThread;
            this.npdNumberThread.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdNumberThread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.npdNumberThread.Location = new System.Drawing.Point(885, 167);
            this.npdNumberThread.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npdNumberThread.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.npdNumberThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdNumberThread.Name = "npdNumberThread";
            this.npdNumberThread.ShadowDecoration.Parent = this.npdNumberThread;
            this.npdNumberThread.Size = new System.Drawing.Size(75, 42);
            this.npdNumberThread.TabIndex = 2;
            this.npdNumberThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumberThread
            // 
            this.lbNumberThread.AutoSize = true;
            this.lbNumberThread.Location = new System.Drawing.Point(817, 178);
            this.lbNumberThread.Name = "lbNumberThread";
            this.lbNumberThread.Size = new System.Drawing.Size(57, 16);
            this.lbNumberThread.TabIndex = 1;
            this.lbNumberThread.Text = "Số luồng:";
            // 
            // rtbListPage
            // 
            this.rtbListPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListPage.Location = new System.Drawing.Point(7, 24);
            this.rtbListPage.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.rtbListPage.Name = "rtbListPage";
            this.rtbListPage.Size = new System.Drawing.Size(953, 134);
            this.rtbListPage.TabIndex = 0;
            this.rtbListPage.Text = "";
            // 
            // rbChooseImportListVideo
            // 
            this.rbChooseImportListVideo.AutoSize = true;
            this.rbChooseImportListVideo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbChooseImportListVideo.CheckedState.BorderThickness = 0;
            this.rbChooseImportListVideo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbChooseImportListVideo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbChooseImportListVideo.CheckedState.InnerOffset = -4;
            this.rbChooseImportListVideo.Location = new System.Drawing.Point(5, 240);
            this.rbChooseImportListVideo.Name = "rbChooseImportListVideo";
            this.rbChooseImportListVideo.Size = new System.Drawing.Size(137, 20);
            this.rbChooseImportListVideo.TabIndex = 4;
            this.rbChooseImportListVideo.Text = "Lấy qua Listvideo txt";
            this.rbChooseImportListVideo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbChooseImportListVideo.UncheckedState.BorderThickness = 2;
            this.rbChooseImportListVideo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbChooseImportListVideo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbChooseImportListVideo.UseVisualStyleBackColor = true;
            this.rbChooseImportListVideo.CheckedChanged += new System.EventHandler(this.rbChooseImportListVideo_CheckedChanged);
            // 
            // rbChooseCrawl
            // 
            this.rbChooseCrawl.AutoSize = true;
            this.rbChooseCrawl.Checked = true;
            this.rbChooseCrawl.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbChooseCrawl.CheckedState.BorderThickness = 0;
            this.rbChooseCrawl.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbChooseCrawl.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbChooseCrawl.CheckedState.InnerOffset = -4;
            this.rbChooseCrawl.Location = new System.Drawing.Point(3, 3);
            this.rbChooseCrawl.Name = "rbChooseCrawl";
            this.rbChooseCrawl.Size = new System.Drawing.Size(185, 20);
            this.rbChooseCrawl.TabIndex = 4;
            this.rbChooseCrawl.TabStop = true;
            this.rbChooseCrawl.Text = "Lấy bằng Automation (Crawl)";
            this.rbChooseCrawl.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbChooseCrawl.UncheckedState.BorderThickness = 2;
            this.rbChooseCrawl.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbChooseCrawl.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbChooseCrawl.UseVisualStyleBackColor = true;
            this.rbChooseCrawl.CheckedChanged += new System.EventHandler(this.rbChooseCrawl_CheckedChanged);
            // 
            // pbOptions
            // 
            this.pbOptions.Controls.Add(this.btGetPathVideo);
            this.pbOptions.Controls.Add(this.tbPathVideo);
            this.pbOptions.Controls.Add(this.rbChooseImportListVideo);
            this.pbOptions.Controls.Add(this.lbPathVideo);
            this.pbOptions.Controls.Add(this.rbChooseCrawl);
            this.pbOptions.Controls.Add(this.gbListPage);
            this.pbOptions.Location = new System.Drawing.Point(10, 66);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(999, 283);
            this.pbOptions.TabIndex = 16;
            // 
            // btGetPathVideo
            // 
            this.btGetPathVideo.Location = new System.Drawing.Point(874, 257);
            this.btGetPathVideo.Name = "btGetPathVideo";
            this.btGetPathVideo.Size = new System.Drawing.Size(113, 23);
            this.btGetPathVideo.TabIndex = 17;
            this.btGetPathVideo.Text = "Choose...";
            this.btGetPathVideo.UseVisualStyleBackColor = true;
            this.btGetPathVideo.Click += new System.EventHandler(this.btGetPathVideo_Click);
            // 
            // tbPathVideo
            // 
            this.tbPathVideo.Location = new System.Drawing.Point(96, 260);
            this.tbPathVideo.Name = "tbPathVideo";
            this.tbPathVideo.Size = new System.Drawing.Size(772, 21);
            this.tbPathVideo.TabIndex = 16;
            // 
            // lbPathVideo
            // 
            this.lbPathVideo.AutoSize = true;
            this.lbPathVideo.Location = new System.Drawing.Point(28, 263);
            this.lbPathVideo.Name = "lbPathVideo";
            this.lbPathVideo.Size = new System.Drawing.Size(70, 16);
            this.lbPathVideo.TabIndex = 15;
            this.lbPathVideo.Text = "Đường dẫn";
            // 
            // UC_Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.lbChooseOptions);
            this.Controls.Add(this.btChoosePathOutput);
            this.Controls.Add(this.tbPathOutput);
            this.Controls.Add(this.lbPathFileOutput);
            this.Controls.Add(this.gbOtherEvent);
            this.Controls.Add(this.gbRestore);
            this.Controls.Add(this.cbBackupFilePage);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Step1";
            this.Size = new System.Drawing.Size(1012, 495);
            this.gbOtherEvent.ResumeLayout(false);
            this.gbRestore.ResumeLayout(false);
            this.cbBackupFilePage.ResumeLayout(false);
            this.cbBackupFilePage.PerformLayout();
            this.gbListPage.ResumeLayout(false);
            this.gbListPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdNumberThread)).EndInit();
            this.pbOptions.ResumeLayout(false);
            this.pbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbOtherEvent;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Label lbMailSendPage;
        private System.Windows.Forms.Label lbPathFileOutput;
        private Guna.UI2.WinForms.Guna2TextBox tbPathOutput;
        private System.Windows.Forms.Button btChoosePathOutput;
        private System.Windows.Forms.Label lbChooseOptions;
        private System.Windows.Forms.GroupBox gbListPage;
        private Guna.UI2.WinForms.Guna2RadioButton rbChooseImportListVideo;
        private System.Windows.Forms.Label lbStatus;
        private Guna.UI2.WinForms.Guna2NumericUpDown npdNumberThread;
        private System.Windows.Forms.Label lbNumberThread;
        private System.Windows.Forms.RichTextBox rtbListPage;
        private Guna.UI2.WinForms.Guna2RadioButton rbChooseCrawl;
        private System.Windows.Forms.Panel pbOptions;
        private System.Windows.Forms.TextBox tbPathVideo;
        private System.Windows.Forms.Label lbPathVideo;
        private System.Windows.Forms.Button btGetPathVideo;
        public System.Windows.Forms.GroupBox gbRestore;
        public System.Windows.Forms.GroupBox cbBackupFilePage;
        public System.Windows.Forms.Button btPasteClipboard;
        public System.Windows.Forms.Button btImportFile;
        public System.Windows.Forms.TextBox tbMailSendPage;
        public System.Windows.Forms.Button btSaveAsFilePage;
        public System.Windows.Forms.Button btSendPageMail;
        public System.Windows.Forms.Button btCopyListPage;
        public System.Windows.Forms.Button btRewriteFilePage;
    }
}
