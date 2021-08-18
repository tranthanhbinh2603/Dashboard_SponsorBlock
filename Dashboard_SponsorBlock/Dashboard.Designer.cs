namespace Dashboard_SponsorBlock
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbIconSponsorBlock = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTab = new System.Windows.Forms.Panel();
            this.btSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btStep4 = new Guna.UI2.WinForms.Guna2Button();
            this.btStep3 = new Guna.UI2.WinForms.Guna2Button();
            this.btStep2 = new Guna.UI2.WinForms.Guna2Button();
            this.btStep1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSponsorBlock)).BeginInit();
            this.pnTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(68)))));
            this.pnTitle.Controls.Add(this.pictureBox2);
            this.pnTitle.Controls.Add(this.pictureBox1);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Controls.Add(this.pbIconSponsorBlock);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1012, 70);
            this.pnTitle.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dashboard_SponsorBlock.Properties.Resources.icons8_minimize_window_50px_11;
            this.pictureBox2.Location = new System.Drawing.Point(913, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard_SponsorBlock.Properties.Resources.icons8_delete_48px1;
            this.pictureBox1.Location = new System.Drawing.Point(964, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(81, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(384, 22);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Quản lí các video đánh giá SponsorBlock";
            // 
            // pbIconSponsorBlock
            // 
            this.pbIconSponsorBlock.Image = ((System.Drawing.Image)(resources.GetObject("pbIconSponsorBlock.Image")));
            this.pbIconSponsorBlock.Location = new System.Drawing.Point(0, 0);
            this.pbIconSponsorBlock.Name = "pbIconSponsorBlock";
            this.pbIconSponsorBlock.Size = new System.Drawing.Size(75, 70);
            this.pbIconSponsorBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconSponsorBlock.TabIndex = 0;
            this.pbIconSponsorBlock.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.AllowDrop = true;
            this.pnMain.AutoScroll = true;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(0, 140);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1012, 495);
            this.pnMain.TabIndex = 0;
            // 
            // pnTab
            // 
            this.pnTab.Controls.Add(this.btSettings);
            this.pnTab.Controls.Add(this.btStep4);
            this.pnTab.Controls.Add(this.btStep3);
            this.pnTab.Controls.Add(this.btStep2);
            this.pnTab.Controls.Add(this.btStep1);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTab.Location = new System.Drawing.Point(0, 70);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(1012, 70);
            this.pnTab.TabIndex = 0;
            // 
            // btSettings
            // 
            this.btSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btSettings.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btSettings.CheckedState.FillColor = System.Drawing.Color.White;
            this.btSettings.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btSettings.CheckedState.Parent = this.btSettings;
            this.btSettings.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btSettings.CustomImages.Parent = this.btSettings;
            this.btSettings.FillColor = System.Drawing.Color.White;
            this.btSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSettings.ForeColor = System.Drawing.Color.Black;
            this.btSettings.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btSettings.HoverState.Parent = this.btSettings;
            this.btSettings.Location = new System.Drawing.Point(620, 0);
            this.btSettings.Name = "btSettings";
            this.btSettings.ShadowDecoration.Parent = this.btSettings;
            this.btSettings.Size = new System.Drawing.Size(149, 70);
            this.btSettings.TabIndex = 0;
            this.btSettings.Text = "Cài đặt";
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btStep4
            // 
            this.btStep4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btStep4.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep4.CheckedState.FillColor = System.Drawing.Color.White;
            this.btStep4.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btStep4.CheckedState.Parent = this.btStep4;
            this.btStep4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btStep4.CustomImages.Parent = this.btStep4;
            this.btStep4.FillColor = System.Drawing.Color.White;
            this.btStep4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStep4.ForeColor = System.Drawing.Color.Black;
            this.btStep4.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep4.HoverState.Parent = this.btStep4;
            this.btStep4.Location = new System.Drawing.Point(465, 0);
            this.btStep4.Name = "btStep4";
            this.btStep4.ShadowDecoration.Parent = this.btStep4;
            this.btStep4.Size = new System.Drawing.Size(149, 70);
            this.btStep4.TabIndex = 0;
            this.btStep4.Text = "Bước 4: Thực thi tạo phân đoạn";
            this.btStep4.Click += new System.EventHandler(this.btStep4_Click);
            // 
            // btStep3
            // 
            this.btStep3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btStep3.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep3.CheckedState.FillColor = System.Drawing.Color.White;
            this.btStep3.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btStep3.CheckedState.Parent = this.btStep3;
            this.btStep3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btStep3.CustomImages.Parent = this.btStep3;
            this.btStep3.FillColor = System.Drawing.Color.White;
            this.btStep3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStep3.ForeColor = System.Drawing.Color.Black;
            this.btStep3.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep3.HoverState.Parent = this.btStep3;
            this.btStep3.Location = new System.Drawing.Point(310, 0);
            this.btStep3.Name = "btStep3";
            this.btStep3.ShadowDecoration.Parent = this.btStep3;
            this.btStep3.Size = new System.Drawing.Size(149, 70);
            this.btStep3.TabIndex = 0;
            this.btStep3.Text = "Bước 3: Phân tích hình ảnh";
            this.btStep3.Click += new System.EventHandler(this.btStep3_Click);
            // 
            // btStep2
            // 
            this.btStep2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btStep2.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep2.CheckedState.FillColor = System.Drawing.Color.White;
            this.btStep2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btStep2.CheckedState.Parent = this.btStep2;
            this.btStep2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btStep2.CustomImages.Parent = this.btStep2;
            this.btStep2.FillColor = System.Drawing.Color.White;
            this.btStep2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStep2.ForeColor = System.Drawing.Color.Black;
            this.btStep2.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep2.HoverState.Parent = this.btStep2;
            this.btStep2.Location = new System.Drawing.Point(155, 0);
            this.btStep2.Name = "btStep2";
            this.btStep2.ShadowDecoration.Parent = this.btStep2;
            this.btStep2.Size = new System.Drawing.Size(149, 70);
            this.btStep2.TabIndex = 0;
            this.btStep2.Text = "Bước 2: Tải video";
            this.btStep2.Click += new System.EventHandler(this.btStep2_Click);
            // 
            // btStep1
            // 
            this.btStep1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btStep1.Checked = true;
            this.btStep1.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep1.CheckedState.FillColor = System.Drawing.Color.White;
            this.btStep1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btStep1.CheckedState.Parent = this.btStep1;
            this.btStep1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btStep1.CustomImages.Parent = this.btStep1;
            this.btStep1.FillColor = System.Drawing.Color.White;
            this.btStep1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStep1.ForeColor = System.Drawing.Color.Black;
            this.btStep1.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btStep1.HoverState.Parent = this.btStep1;
            this.btStep1.Location = new System.Drawing.Point(0, 0);
            this.btStep1.Name = "btStep1";
            this.btStep1.ShadowDecoration.Parent = this.btStep1;
            this.btStep1.Size = new System.Drawing.Size(149, 70);
            this.btStep1.TabIndex = 0;
            this.btStep1.Text = "Bước 1: Quét Video";
            this.btStep1.Click += new System.EventHandler(this.btStep1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnTitle;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 637);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSponsorBlock)).EndInit();
            this.pnTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbIconSponsorBlock;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Guna.UI2.WinForms.Guna2Button btStep4;
        public Guna.UI2.WinForms.Guna2Button btStep3;
        public Guna.UI2.WinForms.Guna2Button btStep2;
        public Guna.UI2.WinForms.Guna2Button btSettings;
        protected internal Guna.UI2.WinForms.Guna2Button btStep1;
        public System.Windows.Forms.Panel pnMain;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

