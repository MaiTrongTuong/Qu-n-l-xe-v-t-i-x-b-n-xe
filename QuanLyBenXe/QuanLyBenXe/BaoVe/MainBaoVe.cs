using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe.BaoVe
{
    public partial class MainBaoVe : Form
    {
        public MainBaoVe()
        {
            InitializeComponent();
        }

        private void MainBaoVe_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = frmDangNhap.DR["HoTen"].ToString();
        }
    }
}
