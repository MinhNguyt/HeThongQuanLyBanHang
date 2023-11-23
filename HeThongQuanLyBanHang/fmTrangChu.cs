using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyBanHang
{
    public partial class fmTrangChu : Form
    {
        public fmTrangChu()
        {
            InitializeComponent();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmMonAn m = new fmMonAn();
            m.Show();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNguyenLieu n = new fmNguyenLieu();
            n.Show();
        }

        private void đơnVịNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDonViNhap d = new fmDonViNhap();
            d.Show();
        }

        private void doanhThuThuầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTaiKhoan t = new fmTaiKhoan();
            t.Show();
        }

        private void hóaĐơnChiTiếtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fmThemHoaDonChiTiet th = new fmThemHoaDonChiTiet();
            th.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmHoaDon hd = new fmHoaDon();
            hd.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNhapHang nh = new fmNhapHang();
            nh.Show();
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmDoanhThu dt = new fmDoanhThu();
            dt.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
