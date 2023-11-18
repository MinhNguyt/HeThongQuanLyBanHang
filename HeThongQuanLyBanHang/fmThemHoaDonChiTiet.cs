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
           Console.WriteLine("Number of tables: " + dsBan.Count);
            foreach (Ban item in dsBan) 
            {
                Console.WriteLine("Tạo nút cho bàn: " + item.MaBan);
                Button btn = new Button(){ Width = BanDAO.BanWidth, Height = BanDAO.BanHeight };
                btn.Text = item.MaBan + Environment.NewLine + item.TrangThai;
                dataBan.Controls.Add(btn);
            }
        }
       
        #endregion
    }

}
