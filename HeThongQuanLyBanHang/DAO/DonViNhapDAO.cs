using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static int tableWidth = 180;
        public static int tableHeight = 25;

        public List<DonViNhap> LayDSDonViNhap()
        {
            List<DonViNhap> DSDVN = new List<DonViNhap>();
            string query = "Select * from DONVINHAP where Trangthai = 0";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DonViNhap ma = new DonViNhap(item);
                DSDVN.Add(ma);
            }
            return DSDVN;
        }
        public List<DonViNhap> TaiDSDVNhap()
        {
            List<DonViNhap> DSDonViNhap = new List<DonViNhap>();

            DataTable data = dataProvider.Instance.ExecuteQuery("exec USP_LayDSDonViNhap");

            foreach (DataRow item in data.Rows)
            {
                DonViNhap donViNhap = new DonViNhap(item);
                DSDonViNhap.Add(donViNhap);
            }

            return DSDonViNhap;
        }


        public List<DonViNhap> TimDVNtheoTen(string TenDVN)
        {
            List<DonViNhap> DSDVN = new List<DonViNhap>();

            string query = "Select * from DONVINHAP where TenDVNH like N'%" + TenDVN + "%' and Trangthai = 0";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DonViNhap dvt = new DonViNhap(item);
                DSDVN.Add(dvt);
            }
            return DSDVN;
        }
        public bool ThemDVN(string tenDVN, string diachiNH)
        {
            string query = string.Format("Insert into DONVINHAP(MaDV,TenDVNH,DiaChiNH)values(dbo.fmaDVN(),N'{0}',N'{1}')", tenDVN, diachiNH);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaDVN(string maDV, string tenDVN, string diachiNH)
        {
            string query = string.Format("UPDATE DONVINHAP set TenDVNH =N'{0}',DiaChiNH = N'{1}' where MaDV ='{2}'", tenDVN, diachiNH,maDV);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaDVN(string maDV)
        {
            string query = string.Format("UPDATE DONVINHAP set TrangThai = 9 where MaDV ='{0}'", maDV);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
