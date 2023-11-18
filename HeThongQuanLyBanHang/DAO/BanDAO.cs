using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyBanHang.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance 
        { 
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; }
        }

        public static int BanWidth = 65;
        public static int BanHeight = 65;

        private BanDAO() { }

        public List<Ban> TaiDSBan ()
        {
            List<Ban> DSBan = new List<Ban>();
            DataTable data = dataProvider.Instance.ExecuteQuery("USP_LayDSBan");
            foreach (DataRow item in data.Rows) 
            {
                Ban ban = new Ban(item);
                DSBan.Add(ban);
            }
            return DSBan;
        }

    }
}
