using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;

namespace DAL_QLTT
{
   public class DAL_LUONGGIANGVIEN : DAL_Connect
    {
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDSLuong(DateTime ngay)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatLUONG";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NGAY", ngay));
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
        public int Them(ET_LUONGGIANGVIEN et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemLUONG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAGV", et.Magv));
                cmd.Parameters.Add(new SqlParameter("@NGAY", et.Ngaynhanluong));
                cmd.Parameters.Add(new SqlParameter("@SOGIO", et.Sogioday));
                cmd.Parameters.Add(new SqlParameter("@LUONG", et.Luong));

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
        public int Xoa(string magv, DateTime ngay)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "XoaLUONG";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAGV", magv));
                cmd.Parameters.Add(new SqlParameter("@NGAY", ngay));

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
        public int Sua(ET_LUONGGIANGVIEN et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAGV", et.Magv));
                cmd.Parameters.Add(new SqlParameter("@NGAY", et.Ngaynhanluong));
                cmd.Parameters.Add(new SqlParameter("@SOGIO", et.Sogioday));
                cmd.Parameters.Add(new SqlParameter("@LUONG", et.Luong));

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
