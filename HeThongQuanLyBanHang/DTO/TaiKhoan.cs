using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(string tenTk, string matKhau, bool chucVu)
        {
            this.TenTK = tenTk;
            this.MatKhau = matKhau;
            this.ChucVu = chucVu;
        }
        public TaiKhoan(DataRow row)
        {
            this.TenTK = row["TenTK"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.ChucVu = (bool)row["ChucVu"];
        }

        private bool chucVu;
        public bool ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string tenTK;
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
    }
}
