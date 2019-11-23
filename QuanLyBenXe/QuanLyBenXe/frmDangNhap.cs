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
using QuanLyBenXe.QuanLy;
using QuanLyBenXe.ThuNgan;
using QuanLyBenXe.BaoVe;
using QuanLyBenXe.ChuXe;

namespace QuanLyBenXe
{
    public partial class frmDangNhap : Form
    {
        public static DataRow DR;
        ConnectDB connecton = new ConnectDB();
        DataTable dt = new DataTable();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text=="" && txtMatKhau.Text=="")
            {
                MessageBox.Show("Nội dung đăng nhập không được bỏ trống!");
                txtTenDangNhap.BackColor = Color.Red;
                txtMatKhau.BackColor = Color.Red;
                return;
            }
            if(txtTenDangNhap.Text=="")
            {
                MessageBox.Show("Nội dung Tên đăng nhập không được bỏ trống!");
                txtTenDangNhap.BackColor = Color.Red;
                return;
            }
            if(txtMatKhau.Text=="")
            {
                MessageBox.Show("Nội dung Mật khẩu không được để trống!");
                txtMatKhau.BackColor = Color.Red;
            }
            if (rdbNhanVien.Checked == true)
            {
                dt = connecton.truyvan("select * from NhanVien where MaNhanVien =N'" + txtTenDangNhap.Text + "' and MatKhau=N'" + txtMatKhau.Text + "'");
                if(dt.Rows.Count>0)
                {
                    DR = dt.Rows[0];
                    if(DR["ChucVu"].ToString().Substring(0,2)=="QL")
                    {
                        MainQuanLy quanly = new MainQuanLy();
                        this.Hide();
                        quanly.ShowDialog();
                        this.Close();
                    }
                    else if (DR["ChucVu"].ToString().Substring(0, 2) == "TN")
                    {
                        MainThuNgan thungan = new MainThuNgan();
                        this.Hide();
                        thungan.ShowDialog();
                        this.Close();
                    }
                    else if (DR["ChucVu"].ToString().Substring(0, 2) == "BV")
                    {
                        MainBaoVe baove = new MainBaoVe();
                        this.Hide();
                        baove.ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mặt khẩu không đúng!");
                    txtMatKhau.Clear();
                }
            }
            else if(rdbChuXe.Checked==true)
            {
                dt = connecton.truyvan("select * from ChuXe where MaChuXe =N'" + txtTenDangNhap.Text + "' and MatKhau=N'" + txtMatKhau.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    DR = dt.Rows[0];
                    MainChuXe chuxe = new MainChuXe();
                    this.Hide();
                    chuxe.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    txtMatKhau.Clear();
                }
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.BackColor = Color.White;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.BackColor= Color.White;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
