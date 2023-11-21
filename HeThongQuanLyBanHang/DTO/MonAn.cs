using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class MonAn
    {
        public MonAn(string maMon, string tenMon, decimal donGia)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.DonGia = donGia;
        }
        public MonAn(DataRow row) 
        {
            this.MaMon = row["MaMA"].ToString();
            this.TenMon = row["TenMon"].ToString();
            this.DonGia = (decimal)row["DonGia"];
        }

        private decimal donGia;
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private string tenMon;
        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }

        private string maMon;
        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }
    }
}
