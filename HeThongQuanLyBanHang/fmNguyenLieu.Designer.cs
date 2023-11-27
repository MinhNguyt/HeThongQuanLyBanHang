namespace HeThongQuanLyBanHang
{
    partial class fmNguyenLieu
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
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.numericDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.ThemNL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataNguyenLieu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbNL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(283, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "NGUYÊN LIỆU";
            // 
            // txtMaNL
            // 
            this.txtMaNL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaNL.Location = new System.Drawing.Point(549, 175);
            this.txtMaNL.Multiline = true;
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.ReadOnly = true;
            this.txtMaNL.Size = new System.Drawing.Size(226, 25);
            this.txtMaNL.TabIndex = 38;
            // 
            // numericDonGia
            // 
            this.numericDonGia.Location = new System.Drawing.Point(549, 350);
            this.numericDonGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericDonGia.Name = "numericDonGia";
            this.numericDonGia.Size = new System.Drawing.Size(226, 22);
            this.numericDonGia.TabIndex = 37;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(549, 233);
            this.txtTenNL.Multiline = true;
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(226, 25);
            this.txtTenNL.TabIndex = 36;
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(700, 102);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 35);
            this.Xoa.TabIndex = 35;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(614, 102);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(71, 35);
            this.Sua.TabIndex = 34;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // ThemNL
            // 
            this.ThemNL.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ThemNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemNL.Location = new System.Drawing.Point(522, 102);
            this.ThemNL.Name = "ThemNL";
            this.ThemNL.Size = new System.Drawing.Size(76, 35);
            this.ThemNL.TabIndex = 33;
            this.ThemNL.Text = "Thêm";
            this.ThemNL.UseVisualStyleBackColor = false;
            this.ThemNL.Click += new System.EventHandler(this.ThemNL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(446, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Đơn Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(446, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên NL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(446, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã NL:";
            // 
            // dataNguyenLieu
            // 
            this.dataNguyenLieu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNguyenLieu.Location = new System.Drawing.Point(25, 152);
            this.dataNguyenLieu.Name = "dataNguyenLieu";
            this.dataNguyenLieu.RowHeadersWidth = 51;
            this.dataNguyenLieu.RowTemplate.Height = 24;
            this.dataNguyenLieu.Size = new System.Drawing.Size(415, 239);
            this.dataNguyenLieu.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(327, 99);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 35);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Tìm Kiếm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbNL
            // 
            this.tbNL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbNL.Location = new System.Drawing.Point(129, 99);
            this.tbNL.Multiline = true;
            this.tbNL.Name = "tbNL";
            this.tbNL.Size = new System.Drawing.Size(180, 35);
            this.tbNL.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(549, 290);
            this.txtDVT.Multiline = true;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(226, 25);
            this.txtDVT.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(446, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Đơn vị tính:";
            // 
            // fmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNL);
            this.Controls.Add(this.numericDonGia);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.ThemNL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataNguyenLieu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmNguyenLieu";
            this.Text = "fmNguyenLieu";
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.NumericUpDown numericDonGia;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button ThemNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataNguyenLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label6;
    }
}