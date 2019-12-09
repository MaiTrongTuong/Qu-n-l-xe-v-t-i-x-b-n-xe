using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenXe;
using QuanLyBenXe.DataBase;
using System.Data.SqlClient;

namespace QuanLyBenXe.ChuXe
{
    public partial class MainChuXe : Form
    {
        ConnectDB connection = new ConnectDB();
        DataTable dt = new DataTable();

        private byte[] byteconvert;

        public MainChuXe()
        {
            InitializeComponent();
            btnAdd1.Show();
            btnDel1.Hide();
        }

        public void LoadTaiXe()
        {
            dgvTaiXe.DataSource = connection.truyvan("select * from select_TaiXe");

            dt = connection.select_procedure("select_AllTaiXe");
        }
        public void LoadDangTai()
        {
            dgvTuyenDuong.DataSource = connection.truyvan("select * from select_TuyenDuong");

            dgvDangTai.DataSource = connection.truyvan("select * from select_PhieuDangTai");

            dgv_LenhXe.DataSource = connection.selectfl_ChuXe(frmDangNhap.DR["MaChuXe"].ToString(), "select_XeChuaLenTuyen");
        }

        private void MainChuXe_Load(object sender, EventArgs e)
        {
            lblTenChuXe.Text = frmDangNhap.DR["HoTen"].ToString();

            connection.Load_Combobox(cbbXe, "Xe", "MaXe", "MaXe","ChuXe", frmDangNhap.DR["MaChuXe"].ToString());

            LoadTaiXe();

            LoadDangTai();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFilePath(ref filePath);

            if (filePath != "")
            {
                if (picAnhDaiDien.Image != null)
                    picAnhDaiDien.Image.Dispose();

                picAnhDaiDien.Image = Image.FromFile(filePath);
                btnAdd1.Hide();
                btnDel1.Show();
            }
        }
        private void OpenFilePath(ref string FilePath)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFile.FileName;
            }
        }
        private byte[] converImgToByte(string filePath)
        {
            FileStream fs;
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnTaiXe_Sua_Click(object sender, EventArgs e)
        {
            MemoryStream anh1 = new MemoryStream();
            if (picAnhDaiDien.Image != null)
            {
                picAnhDaiDien.Image.Save(anh1, ImageFormat.Jpeg);
            }

            connection.update_TaiXe(TaiXe_CMT.Text, TaiXe_HovaTen.Text, cbbXe.SelectedValue.ToString(), anh1.ToArray());
            LoadTaiXe();
        }

        private void dgvTaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if(r>=0 && r<dgvTaiXe.Rows.Count)
            { 
            TaiXe_CMT.Text = dgvTaiXe.Rows[r].Cells[0].Value.ToString();
            TaiXe_HovaTen.Text = dgvTaiXe.Rows[r].Cells[1].Value.ToString();
            cbbXe.SelectedValue = dgvTaiXe.Rows[r].Cells[2].Value;

            byteconvert = (byte[])(dt.Rows[r]["AnhChanDung"]);
                if (byteconvert != null)
                {
                    MemoryStream anh1 = new MemoryStream(byteconvert.ToArray());

                    if (anh1 != null)
                    {
                        Image img1 = Image.FromStream(anh1);
                        picAnhDaiDien.Image = img1;

                        btnAdd1.Hide();
                        btnDel1.Show();
                    }
                }
            }
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            btnDel1.Hide();
            btnAdd1.Show();
            picAnhDaiDien.Image = null;
        }

        private void dgvTuyenDuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if(r>=0 && r<dgvTuyenDuong.Rows.Count)
            {
                txtTuyen_MaTuyen.Text = dgvTuyenDuong.Rows[r].Cells[0].Value.ToString();
            }
        }

        private void dgv_LenhXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && r < dgv_LenhXe.Rows.Count)
            {
                txtTuyen_MaXe.Text = dgv_LenhXe.Rows[r].Cells[0].Value.ToString();
            }
        }

        private void btnThemTuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTuyen_MaTuyen.Text=="" || txtTuyen_MaXe.Text=="")
                {
                    MessageBox.Show("Nội dung trống, không thể đăng tải");
                    return;
                }
                connection.add_PhieuDangTai(txtTuyen_MaTuyen.Text, txtTuyen_MaXe.Text, DateTime.Now);

                LoadDangTai();
            }
            catch(SqlException)
            {
                MessageBox.Show("Loi them");
            }
        }

        private void dgvDangTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && r < dgvDangTai.Rows.Count)
            {
                txtTuyen_MaTuyen.Text = dgvDangTai.Rows[r].Cells[0].Value.ToString();

                txtTuyen_MaXe.Text = dgvDangTai.Rows[r].Cells[1].Value.ToString();
            }
        }

        private void btnHuyTuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTuyen_MaTuyen.Text == "" || txtTuyen_MaXe.Text == "")
                {
                    MessageBox.Show("Nội dung trống, không thể xóa");
                    return;
                }
                connection.delete_PhieuDangTai(txtTuyen_MaXe.Text);

                LoadDangTai();
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi them");
            }
        }
    }
}
