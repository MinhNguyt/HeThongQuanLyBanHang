using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class HoaDonChiTietDAO
    {
        private static HoaDonChiTietDAO instance;

        public static HoaDonChiTietDAO Instance
        {
            get { if (instance == null) instance = new HoaDonChiTietDAO(); return HoaDonChiTietDAO.instance; }
            private set { HoaDonChiTietDAO.instance = value; }
        }
        private HoaDonChiTietDAO() { }

        public List<HoaDonChiTiet> LayDSHoaDonChoTiet(string maHD)
        {
            List<HoaDonChiTiet> DSHoaDonChiTiet = new List<HoaDonChiTiet>();
            DataTable data = dataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADONCHITIET WHERE MaHD=" + maHD);
            foreach (DataRow item in data.Rows) 
            { 
                HoaDonChiTiet chitiet = new HoaDonChiTiet(item);
                DSHoaDonChiTiet.Add(chitiet);
            }
            return DSHoaDonChiTiet;
        }
    }
}
