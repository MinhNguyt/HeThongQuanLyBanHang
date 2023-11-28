using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DTO
{
    public class DonViNhap
    {
        public DonViNhap(string madv, string tendvn, string diaChiNH)
        {
            this.MaDV = madv;
            this.TenDVN = tendvn;
            this.DiaChiNH = diaChiNH;
        }
        public DonViNhap(DataRow row)
        {
            this.MaDV = row["MaDV"].ToString();
            this.TenDVN = row["TenDVNH"].ToString();
            this.DiaChiNH = row["DiaChiNH"].ToString();
        }

        private string maDV;
        private string tenDVN;
        private string diaChiNH;


        public string MaDV
        {
            get { return maDV; }
            set { maDV = value; }
        }

        public string TenDVN
        {
            get { return tenDVN; }
            set { tenDVN = value; }
        }
        public string DiaChiNH
        {
            get { return diaChiNH; }
            set { diaChiNH = value; }
        }
    }
}
