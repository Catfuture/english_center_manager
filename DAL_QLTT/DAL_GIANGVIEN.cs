using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;

namespace DAL_QLTT
{
    public class DAL_GIANGVIEN : DAL_Connect
    {
        //connection
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDSGiangvien()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatGIANGVIEN";
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
        public int Them(ET_GIANGVIEN et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAGV", et.Magiangvien));
                cmd.Parameters.Add(new SqlParameter("@HOVATENDEM", et.Hovatendem));
                cmd.Parameters.Add(new SqlParameter("@TENGV", et.Tengiangvien));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", et.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@PHAI", et.Phai));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", et.Diachi));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));
                cmd.Parameters.Add(new SqlParameter("@LUONGCOBAN", et.Luongcoban));

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
        public int Xoa(string magv)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "XoaGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAGV", magv));

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
        public int Sua(ET_GIANGVIEN et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAGV", et.Magiangvien));
                cmd.Parameters.Add(new SqlParameter("@HOVATENDEM", et.Hovatendem));
                cmd.Parameters.Add(new SqlParameter("@TENGV", et.Tengiangvien));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", et.Ngaysinh));
                cmd.Parameters.Add(new SqlParameter("@PHAI", et.Phai));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", et.Diachi));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));
                cmd.Parameters.Add(new SqlParameter("@LUONGCOBAN", et.Luongcoban));

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
        public DataTable TimkiemmaGIANGVIEN(string magv)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemmaGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAGV", magv));

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
        public DataTable TimkiemTENGIANGVIEN(string tengv)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemtenGIANGVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENGV", tengv));

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
        public DataTable LayMaGiangvien()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatMAGIANGVIEN";
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
    }
}
