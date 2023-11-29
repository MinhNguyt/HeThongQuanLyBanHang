using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class NhapHang
    {
        public NhapHang(string tennl, int soluong, decimal dongia, decimal thanhtien)
        {
            this.TenNL = tennl;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }

        public NhapHang(DataRow row)
        {

            this.TenNL = row["TenNL"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.DonGia = (decimal)row["DonGia"];
            this.ThanhTien = (decimal)row["ThanhTien"];
        }

        private string tenNL;

        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
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

    }
}

