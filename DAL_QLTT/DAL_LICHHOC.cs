using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;

namespace DAL_QLTT
{
    public class DAL_LICHHOC : DAL_Connect
    {
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDSLichhoc(int tuan)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatLICHHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TUAN", tuan));
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
        public int Them(ET_LỊCHHOC et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemLICHHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MALOP", et.Malop));
                cmd.Parameters.Add(new SqlParameter("@MAGV", et.Magiangvien));
                cmd.Parameters.Add(new SqlParameter("@LICHHOCVACA", et.Lichhoc));
                cmd.Parameters.Add(new SqlParameter("@PHONG", et.Phong));
                cmd.Parameters.Add(new SqlParameter("@TUAN", et.Tuan));

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
        public int Xoa(string malop)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "XoaLICHHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MALOP", malop));

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
        public int Sua(ET_LỊCHHOC et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaLICHHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MALOP", et.Malop));
                cmd.Parameters.Add(new SqlParameter("@MAGV", et.Magiangvien));
                cmd.Parameters.Add(new SqlParameter("@LICHHOC", et.Lichhoc));
                cmd.Parameters.Add(new SqlParameter("@PHONG", et.Phong));
                cmd.Parameters.Add(new SqlParameter("@TUAN", et.Tuan));
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
        public DataTable TimkiemmaLICHHOC(string malop)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemmaHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MALOP", malop));

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
    }
}
