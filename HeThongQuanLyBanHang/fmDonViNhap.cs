using HeThongQuanLyBanHang.DAO;
using HeThongQuanLyBanHang.DTO;
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
    public partial class fmDonViNhap : Form
    {
        BindingSource DSDVN = new BindingSource();
        public fmDonViNhap()
        {
            InitializeComponent();
            dataDVN.DataSource = DSDVN;
            TaiDVN();
            ThemrangbuocDVT();
        }
        void TaiDVN()
        {
            DSDVN.DataSource = DonViNhapDAO.Instance.LayDSDonViNhap();
        }
        #region Methods
        void ThemrangbuocDVT()
        {
            txtTenDVN.DataBindings.Add(new Binding("Text", dataDVN.DataSource, "TenDVN", true, DataSourceUpdateMode.Never));
            txtMaDVN.DataBindings.Add(new Binding("Text", dataDVN.DataSource, "MaDV", true, DataSourceUpdateMode.Never));
            txtDiaChiDVN.DataBindings.Add(new Binding("Text", dataDVN.DataSource, "DiaChiNH", true, DataSourceUpdateMode.Never));
        }
        List<DonViNhap> TimDVNtheoTen(string tenDVN)
        {
            List<DonViNhap> DSDVNhap = DonViNhapDAO.Instance.TimDVNtheoTen(tenDVN);
            return DSDVNhap;
        }
        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DSDVN.DataSource = TimDVNtheoTen(tbDVN.Text);
        }

        private void ThemDVN_Click(object sender, EventArgs e)
        {
            string tenDVN = txtTenDVN.Text;
            string diaChiNH = txtDiaChiDVN.Text;

            if (DonViNhapDAO.Instance.ThemDVN(tenDVN,diaChiNH))
            {
                MessageBox.Show("Thêm đơn vị nhập thành công.");
                TaiDVN();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm đơn vị nhập!!!");
            }
        }

        private void SuaDVN_Click(object sender, EventArgs e)
        {
            string tenDVN = txtTenDVN.Text;
            string diaChiNH = txtDiaChiDVN.Text;
            string maDV = txtMaDVN.Text;

            if (DonViNhapDAO.Instance.SuaDVN(maDV,tenDVN, diaChiNH))
            {
                MessageBox.Show("Sửa đơn vị nhập thành công.");
                TaiDVN();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa đơn vị nhập!!!");
            }
        }

        private void XoaDVN_Click(object sender, EventArgs e)
        {
            string maDV = txtMaDVN.Text;

            if (DonViNhapDAO.Instance.XoaDVN(maDV))
            {
                MessageBox.Show("Xóa đơn vị nhập thành công.");
                TaiDVN();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa đơn vị nhập!!!");
            }
        }
    }
}
