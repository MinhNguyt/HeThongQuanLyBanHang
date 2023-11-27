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
    public partial class fmNguyenLieu : Form
    {
        BindingSource DSNguyenLieu = new BindingSource();
        public fmNguyenLieu()
        {
            InitializeComponent();
            dataNguyenLieu.DataSource = DSNguyenLieu;
            TaiNguyenLieu();
            ThemrangbuocMA();
        }
        void TaiNguyenLieu()
        {
            DSNguyenLieu.DataSource = NguyenLieuDAO.Instance.LayDSNguyenlieu();
        }
        #region Methods
        void ThemrangbuocMA()
        {
            txtTenNL.DataBindings.Add(new Binding("Text", dataNguyenLieu.DataSource, "TenNL", true, DataSourceUpdateMode.Never));
            txtMaNL.DataBindings.Add(new Binding("Text", dataNguyenLieu.DataSource, "MaNL", true, DataSourceUpdateMode.Never));
            txtDVT.DataBindings.Add(new Binding("Text", dataNguyenLieu.DataSource, "DVT", true, DataSourceUpdateMode.Never));
            numericDonGia.DataBindings.Add(new Binding("Value", dataNguyenLieu.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }
        List<NguyenLieu> TimNguyenLieutheoTen(string tenNL)
        {
            List<NguyenLieu> DSNguyenLieu = NguyenLieuDAO.Instance.TimnguyenlieutheoTen(tenNL);
            return DSNguyenLieu;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DSNguyenLieu.DataSource = TimNguyenLieutheoTen(tbNL.Text);
        }

        #endregion

        private void ThemNL_Click(object sender, EventArgs e)
        {
            string tenNL = txtTenNL.Text;
            string dvt = txtDVT.Text;
            decimal donGia = (decimal)numericDonGia.Value;

            if (NguyenLieuDAO.Instance.ThemNguyenLieu(tenNL,dvt, donGia))
            {
                MessageBox.Show("Thêm nguyên liệu thành công.");
                TaiNguyenLieu();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nguyên liệu!!!");
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string tenNL = txtTenNL.Text;
            string dvt = txtDVT.Text;
            decimal donGia = (decimal)numericDonGia.Value;
            string maNL = txtMaNL.Text;

            if (NguyenLieuDAO.Instance.SuaNguyenLieu(maNL, tenNL,dvt, donGia))
            {
                MessageBox.Show("Sửa nguyên liệu thành công.");
                TaiNguyenLieu();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nguyên liệu!!!");
            }
        }
    }
}
