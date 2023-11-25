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
    public partial class fmMonAn : Form
    {
        BindingSource DSMon = new BindingSource();
        public fmMonAn()
        {
            InitializeComponent();
            dataMonAn.DataSource = DSMon;
            TaiMonAn();
            ThemrangbuocMA();
        }
        #region Methods
        void TaiMonAn()
        {
            DSMon.DataSource = MonAnDAO.Instance.LayDSMonAn();
        }

        void ThemrangbuocMA()
        {
            txtTenMon.DataBindings.Add(new Binding("Text", dataMonAn.DataSource, "TenMon",true,DataSourceUpdateMode.Never));
            txtMaMon.DataBindings.Add(new Binding("Text", dataMonAn.DataSource, "MaMon", true, DataSourceUpdateMode.Never));
            numericDonGia.DataBindings.Add(new Binding("Value", dataMonAn.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }

        List<MonAn> TimMonAntheoTen(string tenMon)
        {
            List<MonAn> DSMonAn = MonAnDAO.Instance.TImMonAntheoTen(tenMon);
            return DSMonAn;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DSMon.DataSource=TimMonAntheoTen(tbMon.Text);
        }
        #endregion

        private void btThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text;
            decimal donGia = (decimal)numericDonGia.Value;

            if (MonAnDAO.Instance.ThemMon(tenMon,donGia))
            {
                MessageBox.Show("Thêm món thành công.");
                TaiMonAn();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món!!!");
            }
        }

        private void btSuaMon_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text;
            decimal donGia = (decimal)numericDonGia.Value;
            string maMon = txtMaMon.Text;

            if (MonAnDAO.Instance.SuaMon(maMon,tenMon, donGia))
            {
                MessageBox.Show("Sửa món thành công.");
                TaiMonAn();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món!!!");
            }
        }
    }
}
