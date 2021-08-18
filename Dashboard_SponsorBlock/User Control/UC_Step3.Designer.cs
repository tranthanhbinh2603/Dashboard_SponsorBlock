namespace Dashboard_SponsorBlock.User_Control
{
    partial class UC_Step3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btPathOutput = new System.Windows.Forms.Button();
            this.lbPathVideo = new System.Windows.Forms.Label();
            this.lbPathOutput = new System.Windows.Forms.Label();
            this.rbNotAllVideo = new System.Windows.Forms.RadioButton();
            this.rbAllVideo = new System.Windows.Forms.RadioButton();
            this.lbPathTimeVideo = new System.Windows.Forms.Label();
            this.lbNameVideo = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btGetPathTimeVideo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPathTimeVideo = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbInfoVideo = new System.Windows.Forms.GroupBox();
            this.cbAllVideo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btDeleteVideo = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.lbScanChoose = new System.Windows.Forms.Label();
            this.lbTextNameVideo = new System.Windows.Forms.Label();
            this.btGetPathVideo = new System.Windows.Forms.Button();
            this.gbListVideo = new System.Windows.Forms.GroupBox();
            this.dgvListVideo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPathVideo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.btInstallLib = new System.Windows.Forms.Button();
            this.btInstallPythonWin7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btRefreshVideo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbInfoVideo.SuspendLayout();
            this.gbListVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btPathOutput
            // 
            this.btPathOutput.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPathOutput.Location = new System.Drawing.Point(847, 44);
            this.btPathOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPathOutput.Name = "btPathOutput";
            this.btPathOutput.Size = new System.Drawing.Size(162, 28);
            this.btPathOutput.TabIndex = 17;
            this.btPathOutput.Text = "Choose";
            this.btPathOutput.UseVisualStyleBackColor = true;
            this.btPathOutput.Click += new System.EventHandler(this.btPathOutput_Click);
            // 
            // lbPathVideo
            // 
            this.lbPathVideo.AutoSize = true;
            this.lbPathVideo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPathVideo.Location = new System.Drawing.Point(3, 10);
            this.lbPathVideo.Name = "lbPathVideo";
            this.lbPathVideo.Size = new System.Drawing.Size(101, 16);
            this.lbPathVideo.TabIndex = 13;
            this.lbPathVideo.Text = "Path chứa video";
            // 
            // lbPathOutput
            // 
            this.lbPathOutput.AutoSize = true;
            this.lbPathOutput.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPathOutput.Location = new System.Drawing.Point(3, 50);
            this.lbPathOutput.Name = "lbPathOutput";
            this.lbPathOutput.Size = new System.Drawing.Size(77, 16);
            this.lbPathOutput.TabIndex = 14;
            this.lbPathOutput.Text = "Path Output";
            // 
            // rbNotAllVideo
            // 
            this.rbNotAllVideo.AutoSize = true;
            this.rbNotAllVideo.Location = new System.Drawing.Point(108, 4);
            this.rbNotAllVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNotAllVideo.Name = "rbNotAllVideo";
            this.rbNotAllVideo.Size = new System.Drawing.Size(119, 21);
            this.rbNotAllVideo.TabIndex = 6;
            this.rbNotAllVideo.TabStop = true;
            this.rbNotAllVideo.Text = "Một phần video";
            this.rbNotAllVideo.UseVisualStyleBackColor = true;
            // 
            // rbAllVideo
            // 
            this.rbAllVideo.AutoSize = true;
            this.rbAllVideo.Location = new System.Drawing.Point(3, 4);
            this.rbAllVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAllVideo.Name = "rbAllVideo";
            this.rbAllVideo.Size = new System.Drawing.Size(92, 21);
            this.rbAllVideo.TabIndex = 5;
            this.rbAllVideo.TabStop = true;
            this.rbAllVideo.Text = "Toàn video";
            this.rbAllVideo.UseVisualStyleBackColor = true;
            // 
            // lbPathTimeVideo
            // 
            this.lbPathTimeVideo.AutoSize = true;
            this.lbPathTimeVideo.Location = new System.Drawing.Point(3, 38);
            this.lbPathTimeVideo.Name = "lbPathTimeVideo";
            this.lbPathTimeVideo.Size = new System.Drawing.Size(50, 17);
            this.lbPathTimeVideo.TabIndex = 4;
            this.lbPathTimeVideo.Text = "Vị trí file";
            // 
            // lbNameVideo
            // 
            this.lbNameVideo.AutoSize = true;
            this.lbNameVideo.Location = new System.Drawing.Point(83, 33);
            this.lbNameVideo.Name = "lbNameVideo";
            this.lbNameVideo.Size = new System.Drawing.Size(0, 17);
            this.lbNameVideo.TabIndex = 8;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(903, 12);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(87, 28);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btGetPathTimeVideo
            // 
            this.btGetPathTimeVideo.Location = new System.Drawing.Point(883, 27);
            this.btGetPathTimeVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGetPathTimeVideo.Name = "btGetPathTimeVideo";
            this.btGetPathTimeVideo.Size = new System.Drawing.Size(87, 32);
            this.btGetPathTimeVideo.TabIndex = 4;
            this.btGetPathTimeVideo.Text = "Chọn";
            this.btGetPathTimeVideo.UseVisualStyleBackColor = true;
            this.btGetPathTimeVideo.Click += new System.EventHandler(this.btGetPathTimeVideo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPathTimeVideo);
            this.panel1.Controls.Add(this.btGetPathTimeVideo);
            this.panel1.Controls.Add(this.rbNotAllVideo);
            this.panel1.Controls.Add(this.rbAllVideo);
            this.panel1.Controls.Add(this.lbPathTimeVideo);
            this.panel1.Location = new System.Drawing.Point(20, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 70);
            this.panel1.TabIndex = 6;
            // 
            // tbPathTimeVideo
            // 
            this.tbPathTimeVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPathTimeVideo.DefaultText = "";
            this.tbPathTimeVideo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPathTimeVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPathTimeVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPathTimeVideo.DisabledState.Parent = this.tbPathTimeVideo;
            this.tbPathTimeVideo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPathTimeVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPathTimeVideo.FocusedState.Parent = this.tbPathTimeVideo;
            this.tbPathTimeVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPathTimeVideo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPathTimeVideo.HoverState.Parent = this.tbPathTimeVideo;
            this.tbPathTimeVideo.Location = new System.Drawing.Point(76, 27);
            this.tbPathTimeVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPathTimeVideo.Name = "tbPathTimeVideo";
            this.tbPathTimeVideo.PasswordChar = '\0';
            this.tbPathTimeVideo.PlaceholderText = "";
            this.tbPathTimeVideo.SelectedText = "";
            this.tbPathTimeVideo.ShadowDecoration.Parent = this.tbPathTimeVideo;
            this.tbPathTimeVideo.Size = new System.Drawing.Size(801, 32);
            this.tbPathTimeVideo.TabIndex = 23;
            // 
            // gbInfoVideo
            // 
            this.gbInfoVideo.Controls.Add(this.cbAllVideo);
            this.gbInfoVideo.Controls.Add(this.btExit);
            this.gbInfoVideo.Controls.Add(this.lbNameVideo);
            this.gbInfoVideo.Controls.Add(this.btDeleteVideo);
            this.gbInfoVideo.Controls.Add(this.btRun);
            this.gbInfoVideo.Controls.Add(this.btSave);
            this.gbInfoVideo.Controls.Add(this.panel1);
            this.gbInfoVideo.Controls.Add(this.lbScanChoose);
            this.gbInfoVideo.Controls.Add(this.lbTextNameVideo);
            this.gbInfoVideo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoVideo.Location = new System.Drawing.Point(3, 317);
            this.gbInfoVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfoVideo.Name = "gbInfoVideo";
            this.gbInfoVideo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfoVideo.Size = new System.Drawing.Size(1002, 177);
            this.gbInfoVideo.TabIndex = 10;
            this.gbInfoVideo.TabStop = false;
            this.gbInfoVideo.Text = "Thông tin về video";
            // 
            // cbAllVideo
            // 
            this.cbAllVideo.AutoSize = true;
            this.cbAllVideo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAllVideo.CheckedState.BorderRadius = 2;
            this.cbAllVideo.CheckedState.BorderThickness = 0;
            this.cbAllVideo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAllVideo.Location = new System.Drawing.Point(703, 17);
            this.cbAllVideo.Name = "cbAllVideo";
            this.cbAllVideo.Size = new System.Drawing.Size(104, 21);
            this.cbAllVideo.TabIndex = 9;
            this.cbAllVideo.Text = "Xuất hình ảnh";
            this.cbAllVideo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbAllVideo.UncheckedState.BorderRadius = 2;
            this.cbAllVideo.UncheckedState.BorderThickness = 0;
            this.cbAllVideo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbAllVideo.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(903, 137);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(87, 28);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btDeleteVideo
            // 
            this.btDeleteVideo.Location = new System.Drawing.Point(813, 12);
            this.btDeleteVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDeleteVideo.Name = "btDeleteVideo";
            this.btDeleteVideo.Size = new System.Drawing.Size(87, 28);
            this.btDeleteVideo.TabIndex = 5;
            this.btDeleteVideo.Text = "Xoá";
            this.btDeleteVideo.UseVisualStyleBackColor = true;
            // 
            // btRun
            // 
            this.btRun.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(813, 138);
            this.btRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(89, 28);
            this.btRun.TabIndex = 19;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            // 
            // lbScanChoose
            // 
            this.lbScanChoose.AutoSize = true;
            this.lbScanChoose.Location = new System.Drawing.Point(11, 38);
            this.lbScanChoose.Name = "lbScanChoose";
            this.lbScanChoose.Size = new System.Drawing.Size(80, 17);
            this.lbScanChoose.TabIndex = 4;
            this.lbScanChoose.Text = "Chế độ quét";
            // 
            // lbTextNameVideo
            // 
            this.lbTextNameVideo.AutoSize = true;
            this.lbTextNameVideo.Location = new System.Drawing.Point(11, 21);
            this.lbTextNameVideo.Name = "lbTextNameVideo";
            this.lbTextNameVideo.Size = new System.Drawing.Size(66, 17);
            this.lbTextNameVideo.TabIndex = 5;
            this.lbTextNameVideo.Text = "Tên video";
            // 
            // btGetPathVideo
            // 
            this.btGetPathVideo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGetPathVideo.Location = new System.Drawing.Point(847, 4);
            this.btGetPathVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btGetPathVideo.Name = "btGetPathVideo";
            this.btGetPathVideo.Size = new System.Drawing.Size(69, 28);
            this.btGetPathVideo.TabIndex = 18;
            this.btGetPathVideo.Text = "Choose";
            this.btGetPathVideo.UseVisualStyleBackColor = true;
            this.btGetPathVideo.Click += new System.EventHandler(this.btGetPathVideo_Click);
            // 
            // gbListVideo
            // 
            this.gbListVideo.Controls.Add(this.dgvListVideo);
            this.gbListVideo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListVideo.Location = new System.Drawing.Point(3, 114);
            this.gbListVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbListVideo.Name = "gbListVideo";
            this.gbListVideo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbListVideo.Size = new System.Drawing.Size(1006, 195);
            this.gbListVideo.TabIndex = 12;
            this.gbListVideo.TabStop = false;
            this.gbListVideo.Text = "List video";
            // 
            // dgvListVideo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListVideo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListVideo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListVideo.BackgroundColor = System.Drawing.Color.White;
            this.dgvListVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListVideo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListVideo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListVideo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListVideo.ColumnHeadersHeight = 17;
            this.dgvListVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListVideo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListVideo.EnableHeadersVisualStyles = false;
            this.dgvListVideo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListVideo.Location = new System.Drawing.Point(17, 27);
            this.dgvListVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListVideo.Name = "dgvListVideo";
            this.dgvListVideo.RowHeadersVisible = false;
            this.dgvListVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListVideo.Size = new System.Drawing.Size(983, 153);
            this.dgvListVideo.TabIndex = 1;
            this.dgvListVideo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvListVideo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListVideo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListVideo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListVideo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListVideo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListVideo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListVideo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListVideo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListVideo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListVideo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListVideo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListVideo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListVideo.ThemeStyle.HeaderStyle.Height = 17;
            this.dgvListVideo.ThemeStyle.ReadOnly = false;
            this.dgvListVideo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListVideo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListVideo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListVideo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListVideo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListVideo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListVideo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên video";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xuất ra hình ảnh";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quét toàn bộ video";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ file chứa các mốc thời gian";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tbPathVideo
            // 
            this.tbPathVideo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPathVideo.DefaultText = "";
            this.tbPathVideo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPathVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPathVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPathVideo.DisabledState.Parent = this.tbPathVideo;
            this.tbPathVideo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPathVideo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPathVideo.FocusedState.Parent = this.tbPathVideo;
            this.tbPathVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPathVideo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPathVideo.HoverState.Parent = this.tbPathVideo;
            this.tbPathVideo.Location = new System.Drawing.Point(110, 4);
            this.tbPathVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPathVideo.Name = "tbPathVideo";
            this.tbPathVideo.PasswordChar = '\0';
            this.tbPathVideo.PlaceholderText = "";
            this.tbPathVideo.SelectedText = "";
            this.tbPathVideo.ShadowDecoration.Parent = this.tbPathVideo;
            this.tbPathVideo.Size = new System.Drawing.Size(731, 32);
            this.tbPathVideo.TabIndex = 23;
            // 
            // tbOutput
            // 
            this.tbOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput.DefaultText = "";
            this.tbOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOutput.DisabledState.Parent = this.tbOutput;
            this.tbOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOutput.FocusedState.Parent = this.tbOutput;
            this.tbOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOutput.HoverState.Parent = this.tbOutput;
            this.tbOutput.Location = new System.Drawing.Point(110, 44);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.PasswordChar = '\0';
            this.tbOutput.PlaceholderText = "";
            this.tbOutput.SelectedText = "";
            this.tbOutput.ShadowDecoration.Parent = this.tbOutput;
            this.tbOutput.Size = new System.Drawing.Size(731, 32);
            this.tbOutput.TabIndex = 24;
            // 
            // btInstallLib
            // 
            this.btInstallLib.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInstallLib.Location = new System.Drawing.Point(847, 78);
            this.btInstallLib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInstallLib.Name = "btInstallLib";
            this.btInstallLib.Size = new System.Drawing.Size(162, 28);
            this.btInstallLib.TabIndex = 19;
            this.btInstallLib.Text = "Cài đặt thư viện nhanh";
            this.btInstallLib.UseVisualStyleBackColor = true;
            // 
            // btInstallPythonWin7
            // 
            this.btInstallPythonWin7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInstallPythonWin7.Location = new System.Drawing.Point(679, 78);
            this.btInstallPythonWin7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInstallPythonWin7.Name = "btInstallPythonWin7";
            this.btInstallPythonWin7.Size = new System.Drawing.Size(162, 28);
            this.btInstallPythonWin7.TabIndex = 19;
            this.btInstallPythonWin7.Text = "Cài đặt Python windows 7";
            this.btInstallPythonWin7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(429, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "Lên trang chủ cài Python cho windows 10";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btRefreshVideo
            // 
            this.btRefreshVideo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshVideo.Location = new System.Drawing.Point(918, 4);
            this.btRefreshVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRefreshVideo.Name = "btRefreshVideo";
            this.btRefreshVideo.Size = new System.Drawing.Size(91, 28);
            this.btRefreshVideo.TabIndex = 18;
            this.btRefreshVideo.Text = "Refresh";
            this.btRefreshVideo.UseVisualStyleBackColor = true;
            // 
            // UC_Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbPathVideo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btInstallPythonWin7);
            this.Controls.Add(this.btInstallLib);
            this.Controls.Add(this.gbInfoVideo);
            this.Controls.Add(this.btPathOutput);
            this.Controls.Add(this.lbPathVideo);
            this.Controls.Add(this.lbPathOutput);
            this.Controls.Add(this.btRefreshVideo);
            this.Controls.Add(this.btGetPathVideo);
            this.Controls.Add(this.gbListVideo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Step3";
            this.Size = new System.Drawing.Size(1012, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbInfoVideo.ResumeLayout(false);
            this.gbInfoVideo.PerformLayout();
            this.gbListVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPathOutput;
        private System.Windows.Forms.Label lbPathVideo;
        private System.Windows.Forms.Label lbPathOutput;
        private System.Windows.Forms.RadioButton rbNotAllVideo;
        private System.Windows.Forms.RadioButton rbAllVideo;
        private System.Windows.Forms.Label lbPathTimeVideo;
        private System.Windows.Forms.Label lbNameVideo;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btGetPathTimeVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInfoVideo;
        private System.Windows.Forms.Label lbScanChoose;
        private System.Windows.Forms.Label lbTextNameVideo;
        private System.Windows.Forms.Button btGetPathVideo;
        private System.Windows.Forms.GroupBox gbListVideo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2TextBox tbPathVideo;
        private Guna.UI2.WinForms.Guna2TextBox tbOutput;
        private Guna.UI2.WinForms.Guna2TextBox tbPathTimeVideo;
        private System.Windows.Forms.Button btDeleteVideo;
        private System.Windows.Forms.Button btInstallLib;
        private System.Windows.Forms.Button btRun;
        private Guna.UI2.WinForms.Guna2CheckBox cbAllVideo;
        private System.Windows.Forms.Button btInstallPythonWin7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRefreshVideo;
    }
}
