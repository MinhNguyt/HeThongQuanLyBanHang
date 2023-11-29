using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class NhapHangDAO
    {

        private static NhapHangDAO instance;

        public static NhapHangDAO Instance
        {
            get { if (instance == null) instance = new NhapHangDAO(); return NhapHangDAO.instance; }
            private set { NhapHangDAO.instance = value; }

        }

        private NhapHangDAO() { }

        public List<NhapHang> LayDSNhapHangTheoMaDV(string maDV)
        {
            List<NhapHang> nhaphang = new List<NhapHang>();

            DataTable data = dataProvider.Instance.ExecuteQuery("exec  USP_LayDSNhapHangTheoDV @madv=" + maDV);

            foreach (DataRow item in data.Rows)
            {
                NhapHang chitiet = new NhapHang(item);
                nhaphang.Add(chitiet);
            }
            return nhaphang;
        }
        public void ThemNguyenLieu(string madv, string manl, int soluong)
        {
            dataProvider.Instance.ExecuteNonQuery("exec USP_THEMNGUYENLIEU @MADV , @MANL , @SOLUONG ", new object[] { madv, manl, soluong });
        }
    }
}
