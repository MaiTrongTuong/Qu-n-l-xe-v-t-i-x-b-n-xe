using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe.QuanLy
{
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            lblMaNhanVien.Text = frmDangNhap.DR["MaNhanVien"].ToString();
            lblHoTen.Text = frmDangNhap.DR["HoTen"].ToString();
            lblNgaySinh.Text = frmDangNhap.DR["NgaySinh"].ToString();
            lblQueQuan.Text = frmDangNhap.DR["QueQuan"].ToString();
            lblSDT.Text = frmDangNhap.DR["DienThoai"].ToString();
            lblChucVu.Text = frmDangNhap.DR["ChucVu"].ToString();
            lblPhongBan.Text = frmDangNhap.DR["Phong"].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
