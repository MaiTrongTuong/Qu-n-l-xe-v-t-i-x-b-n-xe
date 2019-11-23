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

        public SqlCommand add_hocsinh(string Mahocsinh, string tenhocsinh, string Malop, DateTime ngaysinh, string gioitinh, double sdt)
        {
            open();
            cmd = new SqlCommand("add_hocsinh", con);
            cmd.Parameters.Add(new SqlParameter("@mahocsinh", Mahocsinh));
            cmd.Parameters.Add(new SqlParameter("@tenhocsinh", tenhocsinh));
            cmd.Parameters.Add(new SqlParameter("@malop", Malop));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand update_hocsinh(string Mahocsinh, string tenhocsinh, string Malop, DateTime ngaysinh, string gioitinh, double sdt)
        {
            open();
            cmd = new SqlCommand("update_hocsinh", con);
            cmd.Parameters.Add(new SqlParameter("@mahocsinh", Mahocsinh));
            cmd.Parameters.Add(new SqlParameter("@tenhocsinh", tenhocsinh));
            cmd.Parameters.Add(new SqlParameter("@malop", Malop));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand delete_hocsinh(string Mahocsinh)
        {
            open();
            cmd = new SqlCommand("delete_hocsinh", con);
            cmd.Parameters.Add(new SqlParameter("@mahocsinh", Mahocsinh));
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public DataTable search_hocsinh(string chuoitimkiem)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("search_hocsinh", con);
            cmd.Parameters.Add(new SqlParameter("@chuoitimkiem", chuoitimkiem));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter();
            da.Fill(dt);
            close();
            return dt;
        }
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
