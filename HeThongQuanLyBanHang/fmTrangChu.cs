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

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmKhachHang k = new fmKhachHang();
            k.Show();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmNguyenLieu n = new fmNguyenLieu();
            n.Show();
        }

        private void đơnVịNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDonViTinh d = new fmDonViTinh();
            d.Show();
        }
    }
}
