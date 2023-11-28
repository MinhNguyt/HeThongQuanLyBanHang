using HeThongQuanLyBanHang.DAO;
using HeThongQuanLyBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeThongQuanLyBanHang
{
    public partial class fmTaiKhoan : Form
    {
        private string TenTK;
        public fmTaiKhoan()
        {
            InitializeComponent();
            TaiDuLieu();
        }
        public void TaiDuLieu()
        {
            List<TaiKhoan> DSTK = TaikhoanDAO.Instance.XuatDuLieu();
            //đổi tên chức vụ
            Binding chucVuBinding = new Binding("Text", DSTK, "ChucVu", true, DataSourceUpdateMode.Never);
            chucVuBinding.Format += txtChucVu_TextChanged;
            txtChucVu.DataBindings.Add(chucVuBinding);

            txtTenTK.DataBindings.Add(new Binding("Text", DSTK, "TenTK", true, DataSourceUpdateMode.Never));
            txtMatKhau.DataBindings.Add(new Binding("Text", DSTK, "MatKhau", true, DataSourceUpdateMode.Never));
        }
        private void txtChucVu_TextChanged(object sender, ConvertEventArgs e)
        {
            // Chuyển đổi giá trị bool sang chuỗi tương ứng
            if (e.Value is bool)
            {
                bool chucVuValue = (bool)e.Value;
                e.Value = chucVuValue ? "Quản lý" : "Nhân viên";
            }
        }


    }
}
