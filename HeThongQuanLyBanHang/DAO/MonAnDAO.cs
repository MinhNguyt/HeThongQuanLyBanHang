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
            string query = "Select * from MONAN";
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

            string query = "Select * from MONAN where TenMon like N'%"+ TenMon+"%'";
            DataTable data = dataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MonAn ma = new MonAn(item);
                DSMonAn.Add(ma);
            }
            return DSMonAn;
        }
        

    }
}
