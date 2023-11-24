using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }


        public List<Menu> LayDSMenuTheoBan(string maBan)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "Select ma.TenMon,hdct.SoLuong,ma.DonGia,ma.DonGia*hdct.SoLuong as ThanhTien, hdct.MaHD from dbo.HOADONCHITIET as hdct, dbo.HOADON as hd, dbo.MONAN as ma where hdct.MaHD = hd.MaHD and hdct.MaMA = ma.MaMA and hd.MaBan = '" + maBan + "' and hd.TrangThai = 0";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}