namespace HeThongQuanLyBanHang
{
    partial class fmMonAn
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataMonAn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btThemMon = new System.Windows.Forms.Button();
            this.btSuaMon = new System.Windows.Forms.Button();
            this.btXoaMon = new System.Windows.Forms.Button();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.numericDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(331, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÓN ĂN";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(327, 109);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 35);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbMon
            // 
            this.tbMon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbMon.Location = new System.Drawing.Point(129, 109);
            this.tbMon.Multiline = true;
            this.tbMon.Name = "tbMon";
            this.tbMon.Size = new System.Drawing.Size(180, 35);
            this.tbMon.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // dataMonAn
            // 
            this.dataMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMonAn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMonAn.Location = new System.Drawing.Point(25, 162);
            this.dataMonAn.Name = "dataMonAn";
            this.dataMonAn.RowHeadersWidth = 51;
            this.dataMonAn.RowTemplate.Height = 24;
            this.dataMonAn.Size = new System.Drawing.Size(415, 239);
            this.dataMonAn.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(446, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Món:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(446, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên Món:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(446, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Đơn Giá:";
            // 
            // btThemMon
            // 
            this.btThemMon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.Location = new System.Drawing.Point(522, 112);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(76, 35);
            this.btThemMon.TabIndex = 20;
            this.btThemMon.Text = "Thêm";
            this.btThemMon.UseVisualStyleBackColor = false;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // btSuaMon
            // 
            this.btSuaMon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaMon.Location = new System.Drawing.Point(614, 112);
            this.btSuaMon.Name = "btSuaMon";
            this.btSuaMon.Size = new System.Drawing.Size(71, 35);
            this.btSuaMon.TabIndex = 21;
            this.btSuaMon.Text = "Sửa";
            this.btSuaMon.UseVisualStyleBackColor = false;
            this.btSuaMon.Click += new System.EventHandler(this.btSuaMon_Click);
            // 
            // btXoaMon
            // 
            this.btXoaMon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaMon.Location = new System.Drawing.Point(700, 112);
            this.btXoaMon.Name = "btXoaMon";
            this.btXoaMon.Size = new System.Drawing.Size(75, 35);
            this.btXoaMon.TabIndex = 22;
            this.btXoaMon.Text = "Xóa";
            this.btXoaMon.UseVisualStyleBackColor = false;
            this.btXoaMon.Click += new System.EventHandler(this.btXoaMon_Click);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(549, 257);
            this.txtTenMon.Multiline = true;
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(226, 25);
            this.txtTenMon.TabIndex = 23;
            // 
            // numericDonGia
            // 
            this.numericDonGia.Location = new System.Drawing.Point(549, 320);
            this.numericDonGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericDonGia.Name = "numericDonGia";
            this.numericDonGia.Size = new System.Drawing.Size(226, 22);
            this.numericDonGia.TabIndex = 24;
            // 
            // txtMaMon
            // 
            this.txtMaMon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaMon.Location = new System.Drawing.Point(549, 193);
            this.txtMaMon.Multiline = true;
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.Size = new System.Drawing.Size(226, 25);
            this.txtMaMon.TabIndex = 25;
            // 
            // fmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.numericDonGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.btXoaMon);
            this.Controls.Add(this.btSuaMon);
            this.Controls.Add(this.btThemMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataMonAn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmMonAn";
            this.Text = "fmMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.dataMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.Button btSuaMon;
        private System.Windows.Forms.Button btXoaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.NumericUpDown numericDonGia;
        private System.Windows.Forms.TextBox txtMaMon;
    }
}