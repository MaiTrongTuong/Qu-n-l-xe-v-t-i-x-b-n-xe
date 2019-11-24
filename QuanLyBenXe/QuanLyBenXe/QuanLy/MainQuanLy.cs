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
        private void BindingDaTa()
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

            dtpLanCuoiCapNhat.Text = dgvQuanLyNhanVien.Rows[0].Cells[9].Value.ToString();
            txtNguoiCapNhat.Text = dgvQuanLyNhanVien.Rows[0].Cells[10].Value.ToString();

        }

        private void MainQuanLy_Load(object sender, EventArgs e)
        {
            lblTenQuanLy.Text = frmDangNhap.DR["HoTen"].ToString();
            txtMaNhanVien.Enabled = false;

            connection.Load_Combobox(cbbChucVu, "ChucVu", "ChucVu", "MaChucVu");
            connection.Load_Combobox(cbbPhong, "PhongBan", "TenPhongBan", "MaPhongBan");

            LoadDataNhanVien();
            BindingDaTa();
            pnlInfo.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtNguoiCapNhat.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

            dtpLanCuoiCapNhat.Text = dgvQuanLyNhanVien.Rows[r].Cells[9].Value.ToString();
            txtNguoiCapNhat.Text = dgvQuanLyNhanVien.Rows[r].Cells[10].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlInfo.Enabled = true;
            txtMaNhanVien.Enabled = true;

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
            connection.add_NhanVien(txtMaNhanVien.Text, txtHoTen.Text, dtpNgaySinh.Text, "True", txtCMT.Text,txtQueQuan.Text,double.Parse(txtDienThoai.Text), "MatKhau", cbbChucVu.SelectedValue.ToString(), "", cbbPhong.SelectedValue.ToString(), DateTime.Now, frmDangNhap.DR["ChucVu"].ToString());
            LoadDataNhanVien();
        }
    }
}
