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
    public partial class frmQuanLyNhanVien : Form
    {
        ConnectDB connection = new ConnectDB();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvQuanLyNhanVien.DataSource = connection.select_procedure("select_QuanLyNhanVien");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            
        }
    }
}
