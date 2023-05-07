using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;
namespace DAL_QLTT
{
    public class DAL_DIEMDAUVAO : DAL_Connect
    {
        //connection
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDS()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatDIEM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                dal = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dal.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _con.Close();
            }
            return dt;
        }
        public int Them(ET_DIEMDAUVAO et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemDIEM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAHV", et.Mahocvien));
                cmd.Parameters.Add(new SqlParameter("@HOVATENDEM", et.Hovatendem));
                cmd.Parameters.Add(new SqlParameter("@TENHV", et.Tenhocvien));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", et.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@PHAI", et.Phai));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", et.Diachi));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));
                cmd.Parameters.Add(new SqlParameter("@DIEM", et.Diem));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return 1;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                _con.Close();
            }
            return 0;
        }
        public int Xoa(string mahv)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "XoaDIEM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAHV", mahv));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return 1;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                _con.Close();
            }
            return 0;
        }
        public int Sua(ET_DIEMDAUVAO et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaDIEM";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAHV", et.Mahocvien));
                cmd.Parameters.Add(new SqlParameter("@HOVATENDEM", et.Hovatendem));
                cmd.Parameters.Add(new SqlParameter("@TENHV", et.Tenhocvien));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", et.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@PHAI", et.Phai));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", et.Diachi));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));
                cmd.Parameters.Add(new SqlParameter("@DIEM", et.Diem));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return 1;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                _con.Close();
            }
            return 0;
        }
        public int ThemHocVienTuDiemDauVao(ET_HOCVIEN et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAHV", et.Mahocvien));
                cmd.Parameters.Add(new SqlParameter("@HOVATENDEM", et.Hovatendem));
                cmd.Parameters.Add(new SqlParameter("@TENHV", et.Tenhocvien));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", et.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@PHAI", et.Phai));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", et.Diachi));
                cmd.Parameters.Add(new SqlParameter("@NGUOIDAMHO", et.Nguoidamho));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));
                cmd.Parameters.Add(new SqlParameter("@CAPDO", et.Capdo));
                cmd.Parameters.Add(new SqlParameter("@LOP", et.Lophoc));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return 1;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                _con.Close();
            }
            return 0;
        }
    }
}
