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
    }
}

