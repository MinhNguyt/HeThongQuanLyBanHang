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
    }
}
