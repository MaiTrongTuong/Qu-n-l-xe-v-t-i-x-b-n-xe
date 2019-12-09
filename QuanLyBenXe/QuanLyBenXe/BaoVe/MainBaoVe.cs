using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenXe.DataBase;

namespace QuanLyBenXe.BaoVe
{
    public partial class MainBaoVe : Form
    {
        ConnectDB conncetion = new ConnectDB();
        DataTable dt;

        public MainBaoVe()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dt = new DataTable();
            dt = conncetion.search(txtTimKiem.Text, "search_BaoVe");
        }
        private void MainBaoVe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
            if(dt.Rows.Count>0)
            {
                lblTrangThai.Text = "Tìm Thấy";
                lblMaXe.Text = dt.Rows[0]["MaXe"].ToString();
                lblBienSo.Text = dt.Rows[0]["BienSo"].ToString().ToUpper();
                lblGioRa.Text = dt.Rows[0]["GioRa"].ToString();
                lblHieuXe.Text = dt.Rows[0]["LoaiXe"].ToString();
                lblChatLuong.Text = dt.Rows[0]["ChatLuong"].ToString();
                lblHoTen.Text = dt.Rows[0]["HovaTen"].ToString();
                lblCMT.Text = dt.Rows[0]["CMT"].ToString();
                byte[] byteconvert;
                try
                {
                    byteconvert = (byte[])(dt.Rows[0]["AnhChanDung"]);
                }
                catch
                {
                    return;
                }
                MemoryStream anh1 = new MemoryStream(byteconvert.ToArray());

                if (anh1 != null)
                {
                    Image img1 = Image.FromStream(anh1);
                    picAnhDaiDien.Image = img1;
                }
            }
        }
    }
}
