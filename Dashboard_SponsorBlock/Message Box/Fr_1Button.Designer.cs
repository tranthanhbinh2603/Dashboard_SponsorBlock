namespace Dashboard_SponsorBlock.Message_Box
{
    partial class Fr_1Button
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.lbContent = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnContent.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.lbContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnContent.Location = new System.Drawing.Point(0, 38);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(437, 102);
            this.pnContent.TabIndex = 2;
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.Location = new System.Drawing.Point(12, 13);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(0, 21);
            this.lbContent.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.Control;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(306, 0);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(119, 38);
            this.bt1.TabIndex = 1;
            this.bt1.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 21);
            this.lbTitle.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.ForeColor = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.ShadowDecoration.Parent = this.panelTitle;
            this.panelTitle.Size = new System.Drawing.Size(437, 38);
            this.panelTitle.TabIndex = 3;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.bt1);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButton.Location = new System.Drawing.Point(0, 140);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(437, 38);
            this.pnButton.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // Fr_1Button
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 183);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fr_1Button";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fr_1Button";
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnContent;
        public System.Windows.Forms.Label lbContent;
        public System.Windows.Forms.Button bt1;
        public System.Windows.Forms.Label lbTitle;
        public Guna.UI2.WinForms.Guna2Panel panelTitle;
        public System.Windows.Forms.Panel pnButton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}