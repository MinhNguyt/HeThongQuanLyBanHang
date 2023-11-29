using HeThongQuanLyBanHang.DAO;
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
    public partial class fmNhapHang : Form
    {
        public fmNhapHang()
        {
            InitializeComponent();
            XemDSNhapHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fmSuaNguyenLieuNhap snl = new fmSuaNguyenLieuNhap();
            snl.Show();
        }
        void XemDSNhapHang()
        {
            string query = "select MaNH,FORMAT(thoigian,'yyyy-MM-dd') as ThoiGian,SoLuong,TenNL, TenDVNH from NHAPHANG, NGUYENLIEU, DONVINHAP where Nhaphang.MaNL = NGUYENLIEU.MaNL and NHAPHANG.MaDV = DONVINHAP.MaDV";
            dataProvider provider = new dataProvider();
            dataNhapHangHD.DataSource = provider.ExecuteQuery(query);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tenDVN = txtTim.Text;
            string query = "select MaNH,FORMAT(thoigian,'yyyy-MM-dd'),SoLuong,TenNL, TenDVNH from NHAPHANG, NGUYENLIEU, DONVINHAP where Nhaphang.MaNL = NGUYENLIEU.MaNL and NHAPHANG.MaDV = DONVINHAP.MaDV and TenDVNH LIKE N'%"+tenDVN+"%'";
            dataProvider provider = new dataProvider();
            dataNhapHangHD.DataSource = provider.ExecuteQuery(query);
        }
    }
}
