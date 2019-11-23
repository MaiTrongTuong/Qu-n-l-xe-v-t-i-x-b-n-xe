using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenXe.ChuXe
{
    public partial class MainChuXe : Form
    {
        public MainChuXe()
        {
            InitializeComponent();
        }

        private void MainChuXe_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = frmDangNhap.DR["HoTen"].ToString();
        }
    }
}
