using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class TaikhoanDAO
    {
        private static TaikhoanDAO instance;
        public static TaikhoanDAO Instance
        {
            get {if (instance == null) instance = new TaikhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaikhoanDAO () { }

        public bool DangNhap(string tenTK, string matkhau)
        {
            string query = "USP_DANGNHAP @tenTk , @matkhau";
            DataTable result = dataProvider.Instance.ExecuteQuery(query, new object[] { tenTK, matkhau });
            return result.Rows.Count > 0;
        }
        public List<TaiKhoan> XuatDuLieu()
        {
            List<TaiKhoan> DSTaiKhoan = new List<TaiKhoan>();

            string query = "Select * from TAIKHOAN where TenTK ='TK01'";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoan tk = new TaiKhoan(item);
                DSTaiKhoan.Add(tk);
            }
            return DSTaiKhoan;
        }
    }
}

