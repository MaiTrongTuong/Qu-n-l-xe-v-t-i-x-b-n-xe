using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe.ThuNgan
{
    public partial class MainThuNgan : Form
    {
        public MainThuNgan()
        {
            InitializeComponent();
        }

        private void MainThuNgan_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = frmDangNhap.DR["HoTen"].ToString();
        }
    }
}
