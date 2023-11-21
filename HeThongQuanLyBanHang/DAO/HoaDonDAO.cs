using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance 
        {
            get {if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO() { }

        // thành công maHD
        // thất bại -1 
        public string TraHoaDonTheoBanChuaThanhToan(string maBan)
        {
            DataTable data = dataProvider.Instance.ExecuteQuery("SELECT * from HOADON WHERE MaBan = '" + maBan + "' AND TrangThai = 0");
            if (data.Rows.Count >0)
            {
                HoaDon hoaDon = new HoaDon(data.Rows[0]);
                return hoaDon.MaHD;
            }
            return ("").ToString(); 
        }
        public void ThemHoaDon(string maBan) 
        {
            dataProvider.Instance.ExecuteNonQuery("exec USP_ThemHoaDon @MaBan",new object[]{maBan});
        }
    }
}
