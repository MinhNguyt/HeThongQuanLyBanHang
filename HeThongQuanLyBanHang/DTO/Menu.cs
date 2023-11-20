using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class Menu
    {
        public Menu(string tenMA, int soLuong, decimal donGia, decimal thanhTien)
        {
            this.TenMA= tenMA;
            this.SoLuong = soLuong;
            this.DonGia= donGia;
            this.ThanhTien= thanhTien;

        }
        public Menu(DataRow row)
        {
            this.TenMA = row["TenMon"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.DonGia = (decimal)row["DonGia"];
            this.ThanhTien = (decimal)row["ThanhTien"];
        }

        private decimal thanhTien;

        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string tenMA;

        public string TenMA
        {
            get { return tenMA; }
            set { tenMA = value; }
        }
    }
}
