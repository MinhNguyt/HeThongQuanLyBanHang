namespace HeThongQuanLyBanHang
{
    partial class fmTrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnVịNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuThuầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHàngToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.doanhThuThuầnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mónĂnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.bánHàngToolStripMenuItem.Text = "Bán Hàng";
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.mónĂnToolStripMenuItem.Text = "Món Ăn";
            this.mónĂnToolStripMenuItem.Click += new System.EventHandler(this.mónĂnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyênLiệuToolStripMenuItem,
            this.đơnVịNhậpToolStripMenuItem});
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập Hàng";
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            this.nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            this.nguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nguyênLiệuToolStripMenuItem.Text = "Nguyên Liệu";
            this.nguyênLiệuToolStripMenuItem.Click += new System.EventHandler(this.nguyênLiệuToolStripMenuItem_Click);
            // 
            // đơnVịNhậpToolStripMenuItem
            // 
            this.đơnVịNhậpToolStripMenuItem.Name = "đơnVịNhậpToolStripMenuItem";
            this.đơnVịNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đơnVịNhậpToolStripMenuItem.Text = "Đơn Vị Nhập";
            this.đơnVịNhậpToolStripMenuItem.Click += new System.EventHandler(this.đơnVịNhậpToolStripMenuItem_Click);
            // 
            // doanhThuThuầnToolStripMenuItem
            // 
            this.doanhThuThuầnToolStripMenuItem.Name = "doanhThuThuầnToolStripMenuItem";
            this.doanhThuThuầnToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.doanhThuThuầnToolStripMenuItem.Text = "Doanh Thu Thuần";
            // 
            // fmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmTrangChu";
            this.Text = "fmTrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnVịNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuThuầnToolStripMenuItem;
    }
}