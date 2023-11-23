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
            return (-1).ToString(); 
        }
        public void TraHoaDon(string maHD)
        {
            string query = "exec USP_SuaHoaDon '" + maHD+"'";
            dataProvider.Instance.ExecuteNonQuery(query);
        }
        public void ThemHoaDon(string maBan) 
        {
            dataProvider.Instance.ExecuteNonQuery("exec USP_ThemHoaDon @MaBan",new object[]{maBan});
        }
        public string LayHoaDonLonNhat()
        {
            try
            {
                return dataProvider.Instance.ExecuteScalar("select max(MaHD) from HOADON").ToString();
            }
            catch
            {
                return "HD0001";
            }
        }
       
    }
}
