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
            string query = "Select * from TAIKHOAN where TenTK ='"+tenTK+"' and MatKhau ='"+ matkhau+ "'";
            DataTable result = dataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}

