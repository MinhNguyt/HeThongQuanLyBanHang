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
    public partial class fmDoanhThu : Form
    {
        public fmDoanhThu()
        {
            InitializeComponent();
            TaiDSHoaDonTheoNgay(dateTimePicker1.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region methods
        void TaiDSHoaDonTheoNgay(DateTime thoigian)
        {
            dataGridView1.DataSource = HoaDonDAO.Instance.LayDSHoaDonTheoNgay(thoigian);
        }
        #endregion
        #region events
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TaiDSHoaDonTheoNgay(dateTimePicker1.Value);

        }
        #endregion
    }
}
