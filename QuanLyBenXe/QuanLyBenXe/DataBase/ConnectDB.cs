using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenXe.DataBase
{
    class ConnectDB
    {
        private string connectionString = @"Data Source=DESKTOP-116K21P; Initial Catalog= QuanLyBenXe; Integrated Security=True;";
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ConnectDB()
        {
            con = new SqlConnection(connectionString);
        }
        public SqlConnection open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public SqlConnection close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
        public DataTable truyvan(string sql)
        {
            open();
            dt = new DataTable();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }
         //Truy vấn lấy 1 trg dữ liệu
        public DataTable truyvan_onefiels(string tenbang, string tencot, string giatricot)
        {
            DataTable dtT = new DataTable();
            string sql = "select * from " + tenbang + " where " + tencot + " =" + giatricot + ";";
            open();
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dtT);
            close();
            return dtT;
        }

        public DataTable select_procedure(string ten_procedure)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand(ten_procedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        #region NhanVien
        public SqlCommand add_NhanVien(string MaNV, string HoTen, string NgaySinh, string GioiTinh, string Cmt,string QueQuan,double Sdt, string MatKhau, string ChucVu, string TienLuong, string Phong, DateTime Lancuoicapnhat, string NguoiCapNhat)
        {
            open();
            cmd = new SqlCommand("add_QuanLyNhanVien", con);
            cmd.Parameters.Add(new SqlParameter("@manhanvien", MaNV));
            cmd.Parameters.Add(new SqlParameter("@hoten", HoTen));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@cmt", Cmt));
            cmd.Parameters.Add(new SqlParameter("@quequan", QueQuan));
            cmd.Parameters.Add(new SqlParameter("@sdt", Sdt));
            cmd.Parameters.Add(new SqlParameter("@matkhau", MatKhau));
            cmd.Parameters.Add(new SqlParameter("@chucvu", ChucVu));
            cmd.Parameters.Add(new SqlParameter("@tienluong", TienLuong));
            cmd.Parameters.Add(new SqlParameter("@phong", Phong));
            cmd.Parameters.Add(new SqlParameter("@lancuoicapnhat", Lancuoicapnhat));
            cmd.Parameters.Add(new SqlParameter("@nguoicapnhat", NguoiCapNhat));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand update_NhanVien(string MaNV, string HoTen, string NgaySinh, string GioiTinh, string Cmt, string QueQuan, double Sdt, string ChucVu, string Phong, DateTime Lancuoicapnhat, string NguoiCapNhat)
        {
            open();
            cmd = new SqlCommand("update_QuanLyNhanVien", con);
            cmd.Parameters.Add(new SqlParameter("@manhanvien", MaNV));
            cmd.Parameters.Add(new SqlParameter("@hoten", HoTen));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@cmt", Cmt));
            cmd.Parameters.Add(new SqlParameter("@quequan", QueQuan));
            cmd.Parameters.Add(new SqlParameter("@sdt", Sdt));
            cmd.Parameters.Add(new SqlParameter("@chucvu", ChucVu));
            cmd.Parameters.Add(new SqlParameter("@phong", Phong));
            cmd.Parameters.Add(new SqlParameter("@lancuoicapnhat", Lancuoicapnhat));
            cmd.Parameters.Add(new SqlParameter("@nguoicapnhat", NguoiCapNhat));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand delete_NhanVien(string MaNhanVien)
        {
            open();
            cmd = new SqlCommand("delete_QuanLyNhanVien", con);
            cmd.Parameters.Add(new SqlParameter("@manhanvien", MaNhanVien));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public DataTable search_NhanVien(string chuoitimkiem)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("search_QuanLyNhanVien", con);
            cmd.Parameters.Add(new SqlParameter("@chuoitimkiem", chuoitimkiem));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }
        public DataTable available_NhanVien(string MaNhanVien, string CMT)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("available_QuanLyNhanVien", con);
            cmd.Parameters.Add(new SqlParameter("@manhanvien",MaNhanVien));
            cmd.Parameters.Add(new SqlParameter("@cmt", CMT));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }
        #endregion

# region QuanLyXe
        //LẤy thông tin 1 trường chủ xe

#endregion
        public void Load_Combobox(ComboBox tenCombobox, string tentable, string cotten, string cotma)
        {
            dt = new DataTable();
            dt = truyvan("select * from " + tentable);
            tenCombobox.DataSource = dt;
            tenCombobox.DisplayMember = cotten;
            tenCombobox.ValueMember = cotma;
        }
    }
}
