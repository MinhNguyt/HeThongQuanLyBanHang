using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class HoaDon
    {
        public HoaDon( string maHD, DateTime? thoiGian, bool trangThai )
        {
            this.MaHD = maHD;
            this.thoiGian = thoiGian;
            this.trangThai = trangThai;

        }

        public HoaDon(DataRow row) 
        {
            this.MaHD = row["MaHD"].ToString();
            this.thoiGian =(DateTime?)row["ThoiGian"];
            this.trangThai = (bool)row["TrangThai"];
        }

        private bool trangThai;
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value;}
        }
        private DateTime? thoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

        private string maHD;

        public string MaHD
        { 
            get { return maHD; }
            set { maHD = value; }
        }
    }
}
