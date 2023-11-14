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
    public partial class fmHoaDon : Form
    {
        public fmHoaDon()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fmThemHoaDonChiTiet t = new fmThemHoaDonChiTiet();
            t.Show();
        }
    }
}
