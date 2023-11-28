using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;
        public static MonAnDAO Instance
        { 
            get { if (instance == null) instance = new MonAnDAO(); return MonAnDAO.instance; } 
            private set { MonAnDAO.instance = value; }
        }
        private MonAnDAO() { }

        public List<HeThongQuanLyBanHang.DTO.MonAn> LayDSMonAn()
        {
            List<HeThongQuanLyBanHang.DTO.MonAn> DSMonAn = new List<HeThongQuanLyBanHang.DTO.MonAn>();
            string query = "Select * from MONAN where Trangthai = 0";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) 
            {
                MonAn ma = new MonAn(item);
                DSMonAn.Add(ma);
            }
            return DSMonAn;
        }

        public List<MonAn> TImMonAntheoTen(string TenMon)
        {
            List<MonAn> DSMonAn = new List<MonAn>();

            string query = "Select * from MONAN where TenMon like N'%"+ TenMon+ "%' and Trangthai = 0";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MonAn ma = new MonAn(item);
                DSMonAn.Add(ma);
            }
            return DSMonAn;
        }
        
        public bool ThemMon(string tenMon, decimal donGia)
        {
            string query = string.Format("Insert into MONAN(MaMA,TenMon,DonGia)values(dbo.fmaMon(),N'{0}',{1} )", tenMon, donGia);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaMon(string maMon,string tenMon, decimal donGia)
        {
            string query = string.Format("update MONAN set TenMon =N'{0}', DonGia = {1} where MaMA = '{2}'", tenMon, donGia, maMon);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaMon(string maMon)
        {
            string query = string.Format("update MONAN set TrangThai = 9 where MaMA = '{0}'", maMon);
            int result = dataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
