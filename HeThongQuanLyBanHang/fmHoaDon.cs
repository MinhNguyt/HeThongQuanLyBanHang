using HeThongQuanLyBanHang.DAO;
using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            XemDSHoaDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fmThemHoaDonChiTiet t = new fmThemHoaDonChiTiet();
            t.Show();
        }
        void XemDSHoaDon()
        {
            string query = "SELECT MaHD, ThoiGian, MaBan from HOADON WHERE TrangThai = 0";
            dataProvider provider = new dataProvider();
            dtgHoaDon.DataSource = provider.ExecuteQuery(query);
        }
    }
}
