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
    public partial class fmThemHoaDonChiTiet : Form
    {
        public fmThemHoaDonChiTiet()
        {
            InitializeComponent();
            TaiBan();
        }
        #region Method
        void TaiBan()
        {
           List<Ban> dsBan=  BanDAO.Instance.TaiDSBan();
           foreach (Ban item in dsBan) 
           {
                Button btn = new Button(){ Width = BanDAO.BanWidth, Height = BanDAO.BanHeight };
                btn.Text = item.MaBan + Environment.NewLine + item.TrangThai;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case "Không":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Tomato;
                        break;
                }
                dataBan.Controls.Add(btn);
           }
        }
        void LayHoaDon(string MaBan)
        {
            List<HoaDonChiTiet> DSHoaDonChiTiet = HoaDonChiTietDAO.Instance.LayDSHoaDonChoTiet(HoaDonDAO.Instance.TraHoaDonTheoBanChuaThanhToan(MaBan));
        }
        #endregion

        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            string MaBan =((sender as Button).Tag as Ban).MaBan;
            LayHoaDon(MaBan);
        }
        #endregion
    }

}
