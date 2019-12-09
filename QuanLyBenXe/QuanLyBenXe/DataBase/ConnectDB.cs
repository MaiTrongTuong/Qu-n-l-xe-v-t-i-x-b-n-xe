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

        #region QuanLyXe

        //Thêm Xe
        public SqlCommand add_Xe(string MaXe, string BienSo, string HieuXe, string LoaiXe, string ChuXe, string ChatLuong, string TrangThaiHD)
        {
            open();
            cmd = new SqlCommand("add_Xe", con);
            cmd.Parameters.Add(new SqlParameter("@maxe", MaXe));
            cmd.Parameters.Add(new SqlParameter("@bienso", BienSo));
            cmd.Parameters.Add(new SqlParameter("@hieuxe", HieuXe));
            cmd.Parameters.Add(new SqlParameter("@loaixe", LoaiXe));
            cmd.Parameters.Add(new SqlParameter("@chuxe", ChuXe));
            cmd.Parameters.Add(new SqlParameter("@chatluong", ChatLuong));
            cmd.Parameters.Add(new SqlParameter("@trangthaihoatdong", TrangThaiHD));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }

        public SqlCommand update_Xe(string MaXe, string BienSo, string HieuXe, string LoaiXe, string ChuXe, string ChatLuong, string TrangThaiHD)
        {
            open();
            cmd = new SqlCommand("update_Xe", con);
            cmd.Parameters.Add(new SqlParameter("@maxe", MaXe));
            cmd.Parameters.Add(new SqlParameter("@bienso", BienSo));
            cmd.Parameters.Add(new SqlParameter("@hieuxe", HieuXe));
            cmd.Parameters.Add(new SqlParameter("@loaixe", LoaiXe));
            cmd.Parameters.Add(new SqlParameter("@chuxe", ChuXe));
            cmd.Parameters.Add(new SqlParameter("@chatluong", ChatLuong));
            cmd.Parameters.Add(new SqlParameter("@trangthaihoatdong", TrangThaiHD));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand delete_Xe(string MaXe)
        {
            open();
            cmd = new SqlCommand("delete_Xe", con);
            cmd.Parameters.Add(new SqlParameter("@maxe", MaXe));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public DataTable search_Xe(string chuoitimkiem)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("search_Xe", con);
            cmd.Parameters.Add(new SqlParameter("@chuoitimkiem", chuoitimkiem));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        public DataTable available_Xe(string MaXe)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("available_Xe", con);
            cmd.Parameters.Add(new SqlParameter("@maxe",MaXe));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }
        #endregion

        #region QuanLyChuXe
        public DataTable ThongTin_ChuXe(string machuxe)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand("take_onerows", con);
            cmd.Parameters.Add(new SqlParameter("@machuxe", machuxe));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        public SqlCommand add_ChuXe(string MaChuXe, string HoTen, string MatKhau, string CMT, string DiaChi, string SoDienThoai)
        {
            open();
            cmd = new SqlCommand("add_ChuXe", con);
            cmd.Parameters.Add(new SqlParameter("@machuxe", MaChuXe));
            cmd.Parameters.Add(new SqlParameter("@hoten", HoTen));
            cmd.Parameters.Add(new SqlParameter("@matkhau", MatKhau));
            cmd.Parameters.Add(new SqlParameter("@cmt", CMT));
            cmd.Parameters.Add(new SqlParameter("@diachi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", SoDienThoai));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }

        public SqlCommand update_ChuXe(string MaChuXe, string HoTen, string CMT, string DiaChi, string SoDienThoai)
        {
            open();
            cmd = new SqlCommand("update_ChuXe", con);
            cmd.Parameters.Add(new SqlParameter("@machuxe", MaChuXe));
            cmd.Parameters.Add(new SqlParameter("@hoten", HoTen));
            cmd.Parameters.Add(new SqlParameter("@cmt", CMT));
            cmd.Parameters.Add(new SqlParameter("@diachi", DiaChi));
            cmd.Parameters.Add(new SqlParameter("@sodienthoai", SoDienThoai));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand delete_ChuXe(string MaChuXe)
        {
            open();
            cmd = new SqlCommand("delete_ChuXe", con);
            cmd.Parameters.Add(new SqlParameter("@machuxe", MaChuXe));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        #endregion
        #region TaiXe
        public SqlCommand update_TaiXe(string CMT, string HovaTen, string MaXe,byte[] AnhChanDung)
        {
            open();
            cmd = new SqlCommand("update_TaiXe", con);
            cmd.Parameters.Add(new SqlParameter("cmt",CMT));
            cmd.Parameters.Add(new SqlParameter("@hovaten", HovaTen));
            cmd.Parameters.Add(new SqlParameter("@maxe", MaXe));
            cmd.Parameters.Add(new SqlParameter("@anhchandung", AnhChanDung));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        #endregion
        #region GeneralMethod
        public DataTable search(string chuoitimkiem, string ProcedureName)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand(ProcedureName, con);
            cmd.Parameters.Add(new SqlParameter("@chuoitimkiem", chuoitimkiem));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
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
        public void Load_Combobox(ComboBox tenCombobox, string tentable, string cotten, string cotma,string DieuKien, string NoiDung)
        {
            dt = new DataTable();
            dt = truyvan("select * from " + tentable+" where " + DieuKien +" = '"+NoiDung+"';");
            tenCombobox.DataSource = dt;
            tenCombobox.DisplayMember = cotten;
            tenCombobox.ValueMember = cotma;
        }
        #endregion

        #region QuyenChuXe
        public DataTable selectfl_ChuXe(string MaChuXe, string ProcedureName)
        {
            dt = new DataTable();
            open();
            cmd = new SqlCommand(ProcedureName, con);
            cmd.Parameters.Add(new SqlParameter("@machuxe",MaChuXe));
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            close();
            return dt;
        }

        //Them Tuyen
        public SqlCommand add_PhieuDangTai(string MaTuyen, string MaXe, DateTime ThoiGian)
        {
            open();
            cmd = new SqlCommand("add_PhieuDangTai", con);
            cmd.Parameters.Add(new SqlParameter("@matuyen", MaTuyen));
            cmd.Parameters.Add(new SqlParameter("@maxe", MaXe));
            cmd.Parameters.Add(new SqlParameter("@thoigian", ThoiGian));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        public SqlCommand delete_PhieuDangTai(string MaXe)
        {
            open();
            cmd = new SqlCommand("delete_PhieuDangTai", con);
            cmd.Parameters.Add(new SqlParameter("@maxe", MaXe));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            close();
            return cmd;
        }
        #endregion
    }
}
