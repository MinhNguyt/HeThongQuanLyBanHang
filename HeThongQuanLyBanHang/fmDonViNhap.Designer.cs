namespace HeThongQuanLyBanHang
{
    partial class fmDonViNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDVN = new System.Windows.Forms.TextBox();
            this.txtTenDVN = new System.Windows.Forms.TextBox();
            this.XoaDVN = new System.Windows.Forms.Button();
            this.SuaDVN = new System.Windows.Forms.Button();
            this.ThemDVN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDVN = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbDVN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChiDVN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDVN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(304, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐƠN VỊ NHẬP";
            // 
            // txtMaDVN
            // 
            this.txtMaDVN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaDVN.Location = new System.Drawing.Point(548, 188);
            this.txtMaDVN.Multiline = true;
            this.txtMaDVN.Name = "txtMaDVN";
            this.txtMaDVN.ReadOnly = true;
            this.txtMaDVN.Size = new System.Drawing.Size(226, 25);
            this.txtMaDVN.TabIndex = 38;
            // 
            // txtTenDVN
            // 
            this.txtTenDVN.Location = new System.Drawing.Point(548, 252);
            this.txtTenDVN.Multiline = true;
            this.txtTenDVN.Name = "txtTenDVN";
            this.txtTenDVN.Size = new System.Drawing.Size(226, 25);
            this.txtTenDVN.TabIndex = 36;
            // 
            // XoaDVN
            // 
            this.XoaDVN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.XoaDVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaDVN.Location = new System.Drawing.Point(699, 107);
            this.XoaDVN.Name = "XoaDVN";
            this.XoaDVN.Size = new System.Drawing.Size(75, 35);
            this.XoaDVN.TabIndex = 35;
            this.XoaDVN.Text = "Xóa";
            this.XoaDVN.UseVisualStyleBackColor = false;
            this.XoaDVN.Click += new System.EventHandler(this.XoaDVN_Click);
            // 
            // SuaDVN
            // 
            this.SuaDVN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SuaDVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaDVN.Location = new System.Drawing.Point(613, 107);
            this.SuaDVN.Name = "SuaDVN";
            this.SuaDVN.Size = new System.Drawing.Size(71, 35);
            this.SuaDVN.TabIndex = 34;
            this.SuaDVN.Text = "Sửa";
            this.SuaDVN.UseVisualStyleBackColor = false;
            this.SuaDVN.Click += new System.EventHandler(this.SuaDVN_Click);
            // 
            // ThemDVN
            // 
            this.ThemDVN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThemDVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemDVN.Location = new System.Drawing.Point(521, 107);
            this.ThemDVN.Name = "ThemDVN";
            this.ThemDVN.Size = new System.Drawing.Size(76, 35);
            this.ThemDVN.TabIndex = 33;
            this.ThemDVN.Text = "Thêm";
            this.ThemDVN.UseVisualStyleBackColor = false;
            this.ThemDVN.Click += new System.EventHandler(this.ThemDVN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(445, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(445, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên ĐVN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(445, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã ĐVN:";
            // 
            // dataDVN
            // 
            this.dataDVN.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataDVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDVN.Location = new System.Drawing.Point(24, 157);
            this.dataDVN.Name = "dataDVN";
            this.dataDVN.RowHeadersWidth = 51;
            this.dataDVN.RowTemplate.Height = 24;
            this.dataDVN.Size = new System.Drawing.Size(415, 239);
            this.dataDVN.TabIndex = 29;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(326, 104);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 35);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbDVN
            // 
            this.tbDVN.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbDVN.Location = new System.Drawing.Point(128, 104);
            this.tbDVN.Multiline = true;
            this.tbDVN.Name = "tbDVN";
            this.tbDVN.Size = new System.Drawing.Size(180, 35);
            this.tbDVN.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtDiaChiDVN
            // 
            this.txtDiaChiDVN.Location = new System.Drawing.Point(548, 312);
            this.txtDiaChiDVN.Multiline = true;
            this.txtDiaChiDVN.Name = "txtDiaChiDVN";
            this.txtDiaChiDVN.Size = new System.Drawing.Size(226, 25);
            this.txtDiaChiDVN.TabIndex = 39;
            // 
            // fmDonViNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiaChiDVN);
            this.Controls.Add(this.txtMaDVN);
            this.Controls.Add(this.txtTenDVN);
            this.Controls.Add(this.XoaDVN);
            this.Controls.Add(this.SuaDVN);
            this.Controls.Add(this.ThemDVN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataDVN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbDVN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmDonViNhap";
            this.Text = "fmDonViTinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataDVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDVN;
        private System.Windows.Forms.TextBox txtTenDVN;
        private System.Windows.Forms.Button XoaDVN;
        private System.Windows.Forms.Button SuaDVN;
        private System.Windows.Forms.Button ThemDVN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataDVN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbDVN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChiDVN;
    }
}