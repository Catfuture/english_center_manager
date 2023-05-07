using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;
namespace DAL_QLTT
{
    public class DAL_NGUOIDAMHO : DAL_Connect
    {
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDSNguoidamho()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatNGUOIDAMHO";
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
        public int Them(ET_NGUOIDAMHO et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemNGUOIDAMHO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MANGH", et.Manguoidamho));
                cmd.Parameters.Add(new SqlParameter("@HOVATEN", et.Hovaten));
                cmd.Parameters.Add(new SqlParameter("@QUANHE", et.Quanhe));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));

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
        public int Xoa(string mandh)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "XoaNGUOIDAMHO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MANGH", mandh));

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
        public int Sua(ET_NGUOIDAMHO et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaNGUOIDAMHO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MANGH", et.Manguoidamho));
                cmd.Parameters.Add(new SqlParameter("@HOVATEN", et.Hovaten));
                cmd.Parameters.Add(new SqlParameter("@QUANHE", et.Quanhe));
                cmd.Parameters.Add(new SqlParameter("@LIENHE", et.Lienhe));
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
