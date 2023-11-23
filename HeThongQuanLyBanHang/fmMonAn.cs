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
        public fmMonAn()
        {
            InitializeComponent();
            TaiMonAn();
        }
        public void TaiMonAn()
        {
            dataMonAn.DataSource = MonAnDAO.Instance.LayDSMonAn();
        }
        #region Methods
        List<MonAn> TimMonAntheoTen(string tenMon)
        {
            List<MonAn> DSMonAn = MonAnDAO.Instance.TImMonAntheoTen(tenMon);
            return DSMonAn;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            dataMonAn.DataSource=TimMonAntheoTen(tbMon.Text);
        }
        #endregion
    }
}
