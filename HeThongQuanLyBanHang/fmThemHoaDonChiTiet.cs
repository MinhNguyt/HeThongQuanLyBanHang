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
            listView1.Items.Clear();
            List<HeThongQuanLyBanHang.DTO.Menu> DSHoaDonChiTiet = MenuDAO.Instance.LayDSMenuTheoBan(MaBan);
            foreach(HeThongQuanLyBanHang.DTO.Menu item in DSHoaDonChiTiet)
            {
                ListViewItem listItem = new ListViewItem(item.TenMA.ToString());
                listItem.SubItems.Add(item.SoLuong.ToString());
                listItem.SubItems.Add(item.DonGia.ToString());
                listItem.SubItems.Add(item.ThanhTien.ToString());

                listView1.Items.Add(listItem);
            }
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
