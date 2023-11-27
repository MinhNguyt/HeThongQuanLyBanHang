using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    internal class NguyenLieuDAO
    {
        private static NguyenLieuDAO instance;
        public static NguyenLieuDAO Instance
        {
            get { if (instance == null) instance = new NguyenLieuDAO(); return NguyenLieuDAO.instance; }
            private set { NguyenLieuDAO.instance = value; }
        }
        private NguyenLieuDAO() { }

        public List<HeThongQuanLyBanHang.DTO.NguyenLieu> LayDSNguyenlieu()
        {
            List<HeThongQuanLyBanHang.DTO.NguyenLieu> DSnguyenlieu = new List<HeThongQuanLyBanHang.DTO.NguyenLieu>();
            string query = "Select * from NGUYENLIEU";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NguyenLieu ma = new NguyenLieu(item);
                DSnguyenlieu.Add(ma);
            }
            return DSnguyenlieu;
        }

        public List<NguyenLieu> TimnguyenlieutheoTen(string TenNL)
        {
            List<NguyenLieu> DSnguyenlieu = new List<NguyenLieu>();

            string query = "Select * from NGUYENLIEU where TenNL like N'%" + TenNL + "%'";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NguyenLieu nl = new NguyenLieu(item);
                DSnguyenlieu.Add(nl);
            }
            return DSnguyenlieu;
        }

        public bool ThemNguyenLieu(string tenNL,string dvt, decimal donGia)
        {
            string query = string.Format("Insert into NGUYENLIEU(MaNL,TenNL,DVT,DonGiaNL) values(dbo.fmaNL(),N'{0}',N'{1}',{2} )", tenNL,dvt, donGia);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaNguyenLieu(string maNL, string tenNL,string dvt, decimal donGia)
        {
            string query = string.Format("update NGUYENLIEU set TenNL =N'{0}',DVT= N'{1}', DonGiaNL = {2} where MaNL = '{3}'", tenNL,dvt, donGia, maNL);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
