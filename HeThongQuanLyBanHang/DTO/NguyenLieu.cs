using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class NguyenLieu
    {
        public NguyenLieu(string maNL, string tenNL,string dvt,decimal donGia)
        {
            this.MaNL = maNL;
            this.MaNL = maNL;
            this.DVT = dvt;
            this.DonGia = donGia;
        }
        public NguyenLieu(DataRow row)
        {
            this.MaNL = row["MaNL"].ToString();
            this.TenNL = row["TenNL"].ToString();
            this.DVT = row["DVT"].ToString();
            this.DonGia = (decimal)row["DonGiaNL"];
        }

        private decimal donGia;
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private string dvt;
        public string DVT
        {
            get { return dvt; }
            set { dvt = value; }
        }

        private string tenNL;
        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }

        private string maNL;
        public string MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }
    }
}
