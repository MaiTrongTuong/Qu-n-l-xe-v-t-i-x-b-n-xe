using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenXe.DataBase;

namespace QuanLyBenXe.QuanLy
{
    public partial class MainQuanLy : Form
    {
        ConnectDB connection = new ConnectDB();
        public MainQuanLy()
        {
            InitializeComponent();
            
        }
        private void LoadDataNhanVien()
        {
            dgvQuanLyNhanVien.DataSource = connection.select_procedure("select_QuanLyNhanVien");
        }
        private void LoadDataQuanLyXe()
        {
            dgvQuanLyXe.DataSource = connection.select_procedure("select_QuanLyXe");
        }
        private int CheckHopLe()
        {
            if(txtMaNhanVien.Text=="")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống!");
                txtMaNhanVien.BackColor = Color.Red;
                return 0;
            }
            if(txtHoTen.Text=="")
            {
                MessageBox.Show("Họ tên không được bỏ trống!");
                txtHoTen.BackColor = Color.Red;
                return 0;
                
            }
            if(txtCMT.Text=="")
            {
                MessageBox.Show("CMT không được bỏ trống!");
                txtCMT.BackColor = Color.Red;
                return 0;
            }
            return 1;
        }
         private void BindingDaTaNhanVien()
        {
            txtMaNhanVien.Text = dgvQuanLyNhanVien.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvQuanLyNhanVien.Rows[0].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvQuanLyNhanVien.Rows[0].Cells[2].Value.ToString();
            if (dgvQuanLyNhanVien.Rows[0].Cells[3].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtCMT.Text = dgvQuanLyNhanVien.Rows[0].Cells[4].Value.ToString();
            txtQueQuan.Text = dgvQuanLyNhanVien.Rows[0].Cells[5].Value.ToString();
            txtDienThoai.Text = dgvQuanLyNhanVien.Rows[0].Cells[6].Value.ToString();

            cbbChucVu.SelectedValue = dgvQuanLyNhanVien.Rows[0].Cells[7].Value;
            cbbPhong.SelectedValue = dgvQuanLyNhanVien.Rows[0].Cells[8].Value;

            txtLAnCuoiCapNhat.Text = dgvQuanLyNhanVien.Rows[0].Cells[9].Value.ToString();
            txtNguoiCapNhat.Text = dgvQuanLyNhanVien.Rows[0].Cells[10].Value.ToString();

        }

        private void BindingDataXe()
        {
            txtQuanLyXe_MaXe.Text = dgvQuanLyXe.Rows[0].Cells[0].Value.ToString();
            txtQuanLyXe_BienSo.Text= dgvQuanLyXe.Rows[0].Cells[1].Value.ToString();
            txtQuanLyXe_HieuXe.Text= dgvQuanLyXe.Rows[0].Cells[2].Value.ToString();
            txtQuanLyXe_LoaiXe.Text= dgvQuanLyXe.Rows[0].Cells[3].Value.ToString();
            

            cbbQuanLyXe_ChuXe.SelectedValue= dgvQuanLyXe.Rows[0].Cells[4].Value;
            cbbQuanLyXe_ChatLuong.SelectedValue = dgvQuanLyXe.Rows[0].Cells[5].Value;
            txtQuanLyXe_TTHD.Text= dgvQuanLyXe.Rows[0].Cells[6].Value.ToString();
            txtQuanLyXe_TaiXeChinh.Text = dgvQuanLyXe.Rows[0].Cells[7].Value.ToString();
        }

        private void BindingDataQLXe_ChuXe(string GiaTriCanBinding)
        {
            //connection.truyvan_onefiels("ChuXe", "MaChuXe", GiaTriCanBinding);
            //lblQuanLyXe_MaChuXe.Text = dt[0].ToString();
            //lblQuanLyXe_HoTen.Text = dt[1].ToString();
            //lblQuanLyXe_CMT.Text = dt[3].ToString();
            //lblQuanLyXe_DiaChi.Text = dt[4].ToString();
            //lblQuanLyXe_SDT.Text = dt[5].ToString();
        }

        private void MainQuanLy_Load(object sender, EventArgs e)
        {
            lblTenQuanLy.Text = frmDangNhap.DR["HoTen"].ToString();

            connection.Load_Combobox(cbbChucVu, "ChucVu", "ChucVu", "MaChucVu");
            connection.Load_Combobox(cbbPhong, "PhongBan", "TenPhongBan", "MaPhongBan");

            connection.Load_Combobox(cbbQuanLyXe_ChuXe,"ChuXe","HoTen","MaChuXe");
            connection.Load_Combobox(cbbQuanLyXe_ChatLuong, "ChatLuong", "ChatLuong", "MaChatLuong");

            LoadDataNhanVien();
            LoadDataQuanLyXe();

            BindingDaTaNhanVien();
            BindingDataXe();
          

            pnlInfo.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCMT.Enabled = false;
            txtMaNhanVien.Enabled = false;
            int r = e.RowIndex;
            txtMaNhanVien.Text = dgvQuanLyNhanVien.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvQuanLyNhanVien.Rows[r].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvQuanLyNhanVien.Rows[r].Cells[2].Value.ToString();
            if (dgvQuanLyNhanVien.Rows[r].Cells[3].Value.ToString() == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtCMT.Text = dgvQuanLyNhanVien.Rows[r].Cells[4].Value.ToString();
            txtQueQuan.Text = dgvQuanLyNhanVien.Rows[r].Cells[5].Value.ToString();
            txtDienThoai.Text = dgvQuanLyNhanVien.Rows[r].Cells[6].Value.ToString();

            cbbChucVu.SelectedValue = dgvQuanLyNhanVien.Rows[r].Cells[7].Value;
            cbbPhong.SelectedValue = dgvQuanLyNhanVien.Rows[r].Cells[8].Value;

            txtLAnCuoiCapNhat.Text = dgvQuanLyNhanVien.Rows[r].Cells[9].Value.ToString();
            txtNguoiCapNhat.Text = dgvQuanLyNhanVien.Rows[r].Cells[10].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlInfo.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtCMT.Enabled = true;


            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            rdbNam.Checked = true;
            txtCMT.Clear();
            txtQueQuan.Clear();
            txtDienThoai.Clear();

            txtNguoiCapNhat.Text = frmDangNhap.DR["NguoiCapNhat"].ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Sử lí lương theo chức vụ
            string Luong = "";

         
            if (CheckHopLe() == 0)
                return;

            if(connection.available_NhanVien(txtMaNhanVien.Text,txtCMT.Text).Rows.Count>0)
            {
                MessageBox.Show("Mã nhân viên hoặc CMT này đã tồn tại!");
                dgvQuanLyNhanVien.DataSource = connection.available_NhanVien(txtMaNhanVien.Text, txtCMT.Text);
                return;
            }
            
            connection.add_NhanVien(txtMaNhanVien.Text, txtHoTen.Text, dtpNgaySinh.Text, "True", txtCMT.Text,txtQueQuan.Text,double.Parse(txtDienThoai.Text), txtMaNhanVien.Text , cbbChucVu.SelectedValue.ToString(), "ML00", cbbPhong.SelectedValue.ToString(), DateTime.Now, frmDangNhap.DR["ChucVu"].ToString());
            LoadDataNhanVien();

            pnlInfo.Enabled = true;
            txtMaNhanVien.Enabled = true;

            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            rdbNam.Checked = true;
            txtCMT.Clear();
            txtQueQuan.Clear();
            txtDienThoai.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtCMT.Enabled = false;
            
            if(MessageBox.Show("Xóa dữ liệu nhân viên: "+txtMaNhanVien.Text,"Thông Báo!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                connection.delete_NhanVien(txtMaNhanVien.Text);
                LoadDataNhanVien();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckHopLe() == 0)
                return;
            txtMaNhanVien.Enabled = false;
            txtCMT.Enabled = false;

            connection.update_NhanVien(txtMaNhanVien.Text, txtHoTen.Text, dtpNgaySinh.Text, "True", txtCMT.Text, txtQueQuan.Text, double.Parse(txtDienThoai.Text), cbbChucVu.SelectedValue.ToString(), cbbPhong.SelectedValue.ToString(), DateTime.Now, frmDangNhap.DR["ChucVu"].ToString());
            LoadDataNhanVien();
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            dgvQuanLyNhanVien.DataSource = connection.search_NhanVien(txtTimKiemNV.Text);
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            txtMaNhanVien.BackColor = Color.White;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            txtHoTen.BackColor = Color.White;
        }

        private void txtCMT_TextChanged(object sender, EventArgs e)
        {
            txtCMT.BackColor = Color.White;
        }

        private void cbbChucVu_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbQuanLyXe_ChuXe_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingDataQLXe_ChuXe(cbbQuanLyXe_ChuXe.SelectedValue.ToString());
        }
    }
}
