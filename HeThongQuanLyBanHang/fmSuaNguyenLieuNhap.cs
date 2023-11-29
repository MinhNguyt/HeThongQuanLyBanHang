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
    public partial class fmSuaNguyenLieuNhap : Form
    {
        public fmSuaNguyenLieuNhap()
        {
            InitializeComponent();
            TaiDVNhap();
            TaiDSNguyenLieu();
            
        }
        #region method
        void TaiDSNguyenLieu()
        {
            List<NguyenLieu> DSNguyenLieu = NguyenLieuDAO.Instance.LayDSNguyenlieu();
            comboBox2.DataSource = DSNguyenLieu;
            comboBox2.DisplayMember = "TenNL";
        }
        void TaiDVNhap()
        {
            List<DonViNhap> donViNhap = DonViNhapDAO.Instance.TaiDSDVNhap();

            foreach (DonViNhap item in donViNhap)
            {
                Button btn = new Button() { Width = DonViNhapDAO.tableWidth, Height = DonViNhapDAO.tableHeight };
                btn.Text = item.TenDVN;
                btn.Click += btn_Click;
                btn.Tag = item;

                dataDonViNhap.Controls.Add(btn);
            }
        }
        void HienThiNguyenLieuTheoDV(string maDV)
        {
            listView1.Items.Clear();
            List<NhapHang> DSNhapHang = NhapHangDAO.Instance.LayDSNhapHangTheoMaDV(maDV);
            if (DSNhapHang != null && DSNhapHang.Count > 0)
            {
                foreach (NhapHang item in DSNhapHang)
                {
                    ListViewItem lsvIteam = new ListViewItem(item.TenNL);
                    lsvIteam.SubItems.Add(item.SoLuong.ToString());
                    lsvIteam.SubItems.Add(item.DonGia.ToString());
                    lsvIteam.SubItems.Add(item.ThanhTien.ToString());

                    listView1.Items.Add(lsvIteam);
                }
            }
        }
        #endregion

        #region events
        public string madv;
        void btn_Click(object sender, EventArgs e)
        {
            madv = ((sender as Button).Tag as DonViNhap).MaDV;
            Console.WriteLine(madv);
            HienThiNguyenLieuTheoDV(madv);

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string maNL = (comboBox2.SelectedItem as NguyenLieu).MaNL;
            int soluong = (int)numericFood.Value;

            NhapHangDAO.Instance.ThemNguyenLieu(madv, maNL, soluong);
            HienThiNguyenLieuTheoDV(madv);

        }
        #endregion

    }
}
