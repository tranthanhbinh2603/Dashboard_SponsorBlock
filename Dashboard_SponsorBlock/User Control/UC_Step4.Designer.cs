namespace Dashboard_SponsorBlock.User_Control
{
    partial class UC_Step4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbNameNamevideo = new System.Windows.Forms.Label();
            this.lbNameVideo = new System.Windows.Forms.Label();
            this.lbLongVideo = new System.Windows.Forms.Label();
            this.gbAllSegmentVideo = new System.Windows.Forms.GroupBox();
            this.cbChooseTimeVideo = new System.Windows.Forms.ComboBox();
            this.lbChooseTime = new System.Windows.Forms.Label();
            this.cbNotFoundFolder = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dgvSubmissions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvcSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStartSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEndSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNameLongVideo = new System.Windows.Forms.Label();
            this.btDeleteFilter = new System.Windows.Forms.Button();
            this.btCopyEndSeaTB = new System.Windows.Forms.Button();
            this.btCopyStartSeaTB = new System.Windows.Forms.Button();
            this.tbNumberSearch = new System.Windows.Forms.TextBox();
            this.lbNumberSearch = new System.Windows.Forms.Label();
            this.btNextVideo = new System.Windows.Forms.Button();
            this.btNextVideoandProcessing = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.lbOutputStep3 = new System.Windows.Forms.Label();
            this.lbProfileSelenium = new System.Windows.Forms.Label();
            this.tbOutputStep3 = new System.Windows.Forms.TextBox();
            this.lbListVideo = new System.Windows.Forms.Label();
            this.tbProfileSelenium = new System.Windows.Forms.TextBox();
            this.tbPathListVideo = new System.Windows.Forms.TextBox();
            this.btChooseOutoutStep3 = new System.Windows.Forms.Button();
            this.btChooseListVideo = new System.Windows.Forms.Button();
            this.btCopyProfile = new System.Windows.Forms.Button();
            this.btChooseProfileSele = new System.Windows.Forms.Button();
            this.gbAllSegmentVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameNamevideo
            // 
            this.lbNameNamevideo.AutoSize = true;
            this.lbNameNamevideo.Location = new System.Drawing.Point(7, 25);
            this.lbNameNamevideo.Name = "lbNameNamevideo";
            this.lbNameNamevideo.Size = new System.Drawing.Size(154, 16);
            this.lbNameNamevideo.TabIndex = 0;
            this.lbNameNamevideo.Text = "Đang đánh giá cho video:\r\n";
            // 
            // lbNameVideo
            // 
            this.lbNameVideo.AutoSize = true;
            this.lbNameVideo.Location = new System.Drawing.Point(167, 25);
            this.lbNameVideo.Name = "lbNameVideo";
            this.lbNameVideo.Size = new System.Drawing.Size(76, 16);
            this.lbNameVideo.TabIndex = 0;
            this.lbNameVideo.Text = "<Tên video>";
            // 
            // lbLongVideo
            // 
            this.lbLongVideo.AutoSize = true;
            this.lbLongVideo.Location = new System.Drawing.Point(935, 25);
            this.lbLongVideo.Name = "lbLongVideo";
            this.lbLongVideo.Size = new System.Drawing.Size(59, 16);
            this.lbLongVideo.TabIndex = 0;
            this.lbLongVideo.Text = "<Độ dài>";
            // 
            // gbAllSegmentVideo
            // 
            this.gbAllSegmentVideo.Controls.Add(this.cbChooseTimeVideo);
            this.gbAllSegmentVideo.Controls.Add(this.lbChooseTime);
            this.gbAllSegmentVideo.Controls.Add(this.cbNotFoundFolder);
            this.gbAllSegmentVideo.Controls.Add(this.dgvSubmissions);
            this.gbAllSegmentVideo.Controls.Add(this.lbLongVideo);
            this.gbAllSegmentVideo.Controls.Add(this.lbNameLongVideo);
            this.gbAllSegmentVideo.Controls.Add(this.lbNameVideo);
            this.gbAllSegmentVideo.Controls.Add(this.btDeleteFilter);
            this.gbAllSegmentVideo.Controls.Add(this.lbNameNamevideo);
            this.gbAllSegmentVideo.Controls.Add(this.btCopyEndSeaTB);
            this.gbAllSegmentVideo.Controls.Add(this.btCopyStartSeaTB);
            this.gbAllSegmentVideo.Controls.Add(this.tbNumberSearch);
            this.gbAllSegmentVideo.Controls.Add(this.lbNumberSearch);
            this.gbAllSegmentVideo.Location = new System.Drawing.Point(9, 107);
            this.gbAllSegmentVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAllSegmentVideo.Name = "gbAllSegmentVideo";
            this.gbAllSegmentVideo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAllSegmentVideo.Size = new System.Drawing.Size(994, 348);
            this.gbAllSegmentVideo.TabIndex = 1;
            this.gbAllSegmentVideo.TabStop = false;
            this.gbAllSegmentVideo.Text = "Danh sách các phân đoạn đã tách";
            // 
            // cbChooseTimeVideo
            // 
            this.cbChooseTimeVideo.FormattingEnabled = true;
            this.cbChooseTimeVideo.Location = new System.Drawing.Point(753, 19);
            this.cbChooseTimeVideo.Name = "cbChooseTimeVideo";
            this.cbChooseTimeVideo.Size = new System.Drawing.Size(121, 24);
            this.cbChooseTimeVideo.TabIndex = 8;
            // 
            // lbChooseTime
            // 
            this.lbChooseTime.AutoSize = true;
            this.lbChooseTime.Location = new System.Drawing.Point(685, 25);
            this.lbChooseTime.Name = "lbChooseTime";
            this.lbChooseTime.Size = new System.Drawing.Size(62, 16);
            this.lbChooseTime.TabIndex = 7;
            this.lbChooseTime.Text = "Tên Folder";
            // 
            // cbNotFoundFolder
            // 
            this.cbNotFoundFolder.AutoSize = true;
            this.cbNotFoundFolder.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNotFoundFolder.CheckedState.BorderRadius = 2;
            this.cbNotFoundFolder.CheckedState.BorderThickness = 0;
            this.cbNotFoundFolder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNotFoundFolder.Location = new System.Drawing.Point(649, 50);
            this.cbNotFoundFolder.Name = "cbNotFoundFolder";
            this.cbNotFoundFolder.Size = new System.Drawing.Size(189, 20);
            this.cbNotFoundFolder.TabIndex = 6;
            this.cbNotFoundFolder.Text = "Thông báo khi folder không có";
            this.cbNotFoundFolder.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbNotFoundFolder.UncheckedState.BorderRadius = 2;
            this.cbNotFoundFolder.UncheckedState.BorderThickness = 0;
            this.cbNotFoundFolder.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbNotFoundFolder.UseVisualStyleBackColor = true;
            // 
            // dgvSubmissions
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvSubmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSubmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmissions.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubmissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubmissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubmissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSubmissions.ColumnHeadersHeight = 22;
            this.dgvSubmissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcSTT,
            this.dgvcStartSecond,
            this.dgvcStartHour,
            this.dgvcEndSecond,
            this.dgvcEndHour});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubmissions.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSubmissions.EnableHeadersVisualStyles = false;
            this.dgvSubmissions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSubmissions.Location = new System.Drawing.Point(10, 79);
            this.dgvSubmissions.Name = "dgvSubmissions";
            this.dgvSubmissions.RowHeadersVisible = false;
            this.dgvSubmissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubmissions.Size = new System.Drawing.Size(978, 262);
            this.dgvSubmissions.TabIndex = 5;
            this.dgvSubmissions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSubmissions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubmissions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSubmissions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubmissions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubmissions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubmissions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubmissions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSubmissions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSubmissions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSubmissions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubmissions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSubmissions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSubmissions.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvSubmissions.ThemeStyle.ReadOnly = false;
            this.dgvSubmissions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubmissions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubmissions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubmissions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSubmissions.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSubmissions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSubmissions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvcSTT
            // 
            this.dgvcSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcSTT.Frozen = true;
            this.dgvcSTT.HeaderText = "STT";
            this.dgvcSTT.Name = "dgvcSTT";
            this.dgvcSTT.ReadOnly = true;
            this.dgvcSTT.Width = 50;
            // 
            // dgvcStartSecond
            // 
            this.dgvcStartSecond.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcStartSecond.Frozen = true;
            this.dgvcStartSecond.HeaderText = "Điểm đầu phân đoạn (Second)";
            this.dgvcStartSecond.Name = "dgvcStartSecond";
            this.dgvcStartSecond.ReadOnly = true;
            this.dgvcStartSecond.Width = 220;
            // 
            // dgvcStartHour
            // 
            this.dgvcStartHour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcStartHour.Frozen = true;
            this.dgvcStartHour.HeaderText = "Điểm đầu phân đoạn (Hour - Minute)";
            this.dgvcStartHour.Name = "dgvcStartHour";
            this.dgvcStartHour.ReadOnly = true;
            this.dgvcStartHour.Width = 240;
            // 
            // dgvcEndSecond
            // 
            this.dgvcEndSecond.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcEndSecond.Frozen = true;
            this.dgvcEndSecond.HeaderText = "Điểm cuối phân đoan (Second)";
            this.dgvcEndSecond.Name = "dgvcEndSecond";
            this.dgvcEndSecond.ReadOnly = true;
            this.dgvcEndSecond.Width = 205;
            // 
            // dgvcEndHour
            // 
            this.dgvcEndHour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcEndHour.Frozen = true;
            this.dgvcEndHour.HeaderText = "Điểm cuối phân đoạn (Hour - Minute)";
            this.dgvcEndHour.Name = "dgvcEndHour";
            this.dgvcEndHour.ReadOnly = true;
            this.dgvcEndHour.Width = 260;
            // 
            // lbNameLongVideo
            // 
            this.lbNameLongVideo.AutoSize = true;
            this.lbNameLongVideo.Location = new System.Drawing.Point(880, 25);
            this.lbNameLongVideo.Name = "lbNameLongVideo";
            this.lbNameLongVideo.Size = new System.Drawing.Size(48, 16);
            this.lbNameLongVideo.TabIndex = 0;
            this.lbNameLongVideo.Text = "Độ dài:";
            // 
            // btDeleteFilter
            // 
            this.btDeleteFilter.Location = new System.Drawing.Point(556, 44);
            this.btDeleteFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDeleteFilter.Name = "btDeleteFilter";
            this.btDeleteFilter.Size = new System.Drawing.Size(87, 28);
            this.btDeleteFilter.TabIndex = 2;
            this.btDeleteFilter.Text = "Xoá lọc";
            this.btDeleteFilter.UseVisualStyleBackColor = true;
            this.btDeleteFilter.Click += new System.EventHandler(this.btDeleteFilter_Click);
            // 
            // btCopyEndSeaTB
            // 
            this.btCopyEndSeaTB.Location = new System.Drawing.Point(440, 44);
            this.btCopyEndSeaTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCopyEndSeaTB.Name = "btCopyEndSeaTB";
            this.btCopyEndSeaTB.Size = new System.Drawing.Size(110, 28);
            this.btCopyEndSeaTB.TabIndex = 2;
            this.btCopyEndSeaTB.Text = "Copy điểm cuối";
            this.btCopyEndSeaTB.UseVisualStyleBackColor = true;
            this.btCopyEndSeaTB.Click += new System.EventHandler(this.btCopyEndSeaTB_Click);
            // 
            // btCopyStartSeaTB
            // 
            this.btCopyStartSeaTB.Location = new System.Drawing.Point(330, 44);
            this.btCopyStartSeaTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCopyStartSeaTB.Name = "btCopyStartSeaTB";
            this.btCopyStartSeaTB.Size = new System.Drawing.Size(104, 28);
            this.btCopyStartSeaTB.TabIndex = 2;
            this.btCopyStartSeaTB.Text = "Copy điểm đầu";
            this.btCopyStartSeaTB.UseVisualStyleBackColor = true;
            this.btCopyStartSeaTB.Click += new System.EventHandler(this.btCopyStartSeaTB_Click);
            // 
            // tbNumberSearch
            // 
            this.tbNumberSearch.Location = new System.Drawing.Point(171, 50);
            this.tbNumberSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumberSearch.Name = "tbNumberSearch";
            this.tbNumberSearch.Size = new System.Drawing.Size(153, 21);
            this.tbNumberSearch.TabIndex = 1;
            this.tbNumberSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumberSearch_KeyDown);
            // 
            // lbNumberSearch
            // 
            this.lbNumberSearch.AutoSize = true;
            this.lbNumberSearch.Location = new System.Drawing.Point(7, 50);
            this.lbNumberSearch.Name = "lbNumberSearch";
            this.lbNumberSearch.Size = new System.Drawing.Size(154, 16);
            this.lbNumberSearch.TabIndex = 0;
            this.lbNumberSearch.Text = "Nhập số phân đoạn để lọc";
            // 
            // btNextVideo
            // 
            this.btNextVideo.Location = new System.Drawing.Point(668, 465);
            this.btNextVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNextVideo.Name = "btNextVideo";
            this.btNextVideo.Size = new System.Drawing.Size(87, 28);
            this.btNextVideo.TabIndex = 2;
            this.btNextVideo.Text = "Next > ";
            this.btNextVideo.UseVisualStyleBackColor = true;
            // 
            // btNextVideoandProcessing
            // 
            this.btNextVideoandProcessing.Location = new System.Drawing.Point(762, 465);
            this.btNextVideoandProcessing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNextVideoandProcessing.Name = "btNextVideoandProcessing";
            this.btNextVideoandProcessing.Size = new System.Drawing.Size(147, 28);
            this.btNextVideoandProcessing.TabIndex = 2;
            this.btNextVideoandProcessing.Text = "Next nhưng đang xử lí";
            this.btNextVideoandProcessing.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(915, 465);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 28);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(575, 465);
            this.btRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(87, 28);
            this.btRun.TabIndex = 2;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(482, 465);
            this.btHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(87, 28);
            this.btHelp.TabIndex = 2;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = true;
            // 
            // lbOutputStep3
            // 
            this.lbOutputStep3.AutoSize = true;
            this.lbOutputStep3.Location = new System.Drawing.Point(3, 14);
            this.lbOutputStep3.Name = "lbOutputStep3";
            this.lbOutputStep3.Size = new System.Drawing.Size(184, 16);
            this.lbOutputStep3.TabIndex = 0;
            this.lbOutputStep3.Text = "Đường dẫn Output phân đoạn: ";
            // 
            // lbProfileSelenium
            // 
            this.lbProfileSelenium.AutoSize = true;
            this.lbProfileSelenium.Location = new System.Drawing.Point(3, 42);
            this.lbProfileSelenium.Name = "lbProfileSelenium";
            this.lbProfileSelenium.Size = new System.Drawing.Size(154, 16);
            this.lbProfileSelenium.TabIndex = 0;
            this.lbProfileSelenium.Text = "Đường dẫn profile Chrome:";
            // 
            // tbOutputStep3
            // 
            this.tbOutputStep3.Location = new System.Drawing.Point(192, 10);
            this.tbOutputStep3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOutputStep3.Name = "tbOutputStep3";
            this.tbOutputStep3.Size = new System.Drawing.Size(629, 21);
            this.tbOutputStep3.TabIndex = 1;
            // 
            // lbListVideo
            // 
            this.lbListVideo.AutoSize = true;
            this.lbListVideo.Location = new System.Drawing.Point(6, 71);
            this.lbListVideo.Name = "lbListVideo";
            this.lbListVideo.Size = new System.Drawing.Size(173, 16);
            this.lbListVideo.TabIndex = 0;
            this.lbListVideo.Text = "Đường dẫn danh sách video: ";
            // 
            // tbProfileSelenium
            // 
            this.tbProfileSelenium.Location = new System.Drawing.Point(192, 38);
            this.tbProfileSelenium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProfileSelenium.Name = "tbProfileSelenium";
            this.tbProfileSelenium.Size = new System.Drawing.Size(629, 21);
            this.tbProfileSelenium.TabIndex = 1;
            // 
            // tbPathListVideo
            // 
            this.tbPathListVideo.Location = new System.Drawing.Point(192, 68);
            this.tbPathListVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPathListVideo.Name = "tbPathListVideo";
            this.tbPathListVideo.Size = new System.Drawing.Size(629, 21);
            this.tbPathListVideo.TabIndex = 1;
            // 
            // btChooseOutoutStep3
            // 
            this.btChooseOutoutStep3.Location = new System.Drawing.Point(827, 10);
            this.btChooseOutoutStep3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChooseOutoutStep3.Name = "btChooseOutoutStep3";
            this.btChooseOutoutStep3.Size = new System.Drawing.Size(182, 28);
            this.btChooseOutoutStep3.TabIndex = 2;
            this.btChooseOutoutStep3.Text = "Chọn";
            this.btChooseOutoutStep3.UseVisualStyleBackColor = true;
            this.btChooseOutoutStep3.Click += new System.EventHandler(this.btChooseOutoutStep3_Click);
            // 
            // btChooseListVideo
            // 
            this.btChooseListVideo.Location = new System.Drawing.Point(827, 71);
            this.btChooseListVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChooseListVideo.Name = "btChooseListVideo";
            this.btChooseListVideo.Size = new System.Drawing.Size(182, 28);
            this.btChooseListVideo.TabIndex = 2;
            this.btChooseListVideo.Text = "Chọn";
            this.btChooseListVideo.UseVisualStyleBackColor = true;
            this.btChooseListVideo.Click += new System.EventHandler(this.btChooseListVideo_Click);
            // 
            // btCopyProfile
            // 
            this.btCopyProfile.Location = new System.Drawing.Point(922, 41);
            this.btCopyProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCopyProfile.Name = "btCopyProfile";
            this.btCopyProfile.Size = new System.Drawing.Size(87, 28);
            this.btCopyProfile.TabIndex = 2;
            this.btCopyProfile.Text = "Copy mẫu";
            this.btCopyProfile.UseVisualStyleBackColor = true;
            this.btCopyProfile.Click += new System.EventHandler(this.btCopyProfile_Click);
            // 
            // btChooseProfileSele
            // 
            this.btChooseProfileSele.Location = new System.Drawing.Point(827, 41);
            this.btChooseProfileSele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChooseProfileSele.Name = "btChooseProfileSele";
            this.btChooseProfileSele.Size = new System.Drawing.Size(82, 28);
            this.btChooseProfileSele.TabIndex = 2;
            this.btChooseProfileSele.Text = "Chọn";
            this.btChooseProfileSele.UseVisualStyleBackColor = true;
            this.btChooseProfileSele.Click += new System.EventHandler(this.btChooseProfileSele_Click);
            // 
            // UC_Step4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllSegmentVideo);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbProfileSelenium);
            this.Controls.Add(this.lbOutputStep3);
            this.Controls.Add(this.lbListVideo);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btNextVideoandProcessing);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbPathListVideo);
            this.Controls.Add(this.tbProfileSelenium);
            this.Controls.Add(this.btChooseListVideo);
            this.Controls.Add(this.btCopyProfile);
            this.Controls.Add(this.btChooseProfileSele);
            this.Controls.Add(this.btChooseOutoutStep3);
            this.Controls.Add(this.tbOutputStep3);
            this.Controls.Add(this.btNextVideo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Step4";
            this.Size = new System.Drawing.Size(1012, 495);
            this.gbAllSegmentVideo.ResumeLayout(false);
            this.gbAllSegmentVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameNamevideo;
        private System.Windows.Forms.Label lbNameVideo;
        private System.Windows.Forms.Label lbLongVideo;
        private System.Windows.Forms.GroupBox gbAllSegmentVideo;
        private System.Windows.Forms.Button btCopyStartSeaTB;
        private System.Windows.Forms.TextBox tbNumberSearch;
        private System.Windows.Forms.Label lbNumberSearch;
        private System.Windows.Forms.Label lbNameLongVideo;
        private System.Windows.Forms.Button btNextVideo;
        private System.Windows.Forms.Button btNextVideoandProcessing;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCopyEndSeaTB;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Label lbOutputStep3;
        private System.Windows.Forms.Label lbProfileSelenium;
        private System.Windows.Forms.TextBox tbOutputStep3;
        private System.Windows.Forms.Label lbListVideo;
        private System.Windows.Forms.TextBox tbProfileSelenium;
        private System.Windows.Forms.TextBox tbPathListVideo;
        private System.Windows.Forms.Button btChooseOutoutStep3;
        private System.Windows.Forms.Button btChooseListVideo;
        private System.Windows.Forms.Button btCopyProfile;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSubmissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStartSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEndSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEndHour;
        private Guna.UI2.WinForms.Guna2CheckBox cbNotFoundFolder;
        private System.Windows.Forms.ComboBox cbChooseTimeVideo;
        private System.Windows.Forms.Label lbChooseTime;
        private System.Windows.Forms.Button btDeleteFilter;
        private System.Windows.Forms.Button btChooseProfileSele;
    }
}
