using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class DonViNhapDAO
    {
        private static DonViNhapDAO instance;
        public static DonViNhapDAO Instance
        {
            get { if (instance == null) instance = new DonViNhapDAO(); return DonViNhapDAO.instance; }
            private set { DonViNhapDAO.instance = value; }
        }
        private DonViNhapDAO() { }
    }
}
