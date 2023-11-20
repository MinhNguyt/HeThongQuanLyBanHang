using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class HoaDonChiTiet
    {
        public HoaDonChiTiet(string maHDCT, string maMA, int soLuong, string maHD)
        {
            this.MaHDCT = maHDCT;
            this.MaMA = maMA;
            this.SoLuong = soLuong;
            this.MaHD = maHD;

        }
        public HoaDonChiTiet(DataRow row)
        {
            this.MaHDCT = row["MaHDCT"].ToString();
            this.MaMA = row["MaMA"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.MaHD = row["MaHD"].ToString();
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string maMA;

        public string MaMA
        {
            get { return maMA; }
            set { maMA = value; }
        }
        private string maHD;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        private string maHDCT;

        public string MaHDCT
        {
            get { return maHDCT; }
            set { maHDCT = value; }
        }
    }
}
