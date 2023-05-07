using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;

namespace DAL_QLTT
{
    public class DAL_LOPHOC : DAL_Connect
    {
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDSLophoc()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatLOPHOC";
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
        public int Them(ET_LOPHOC et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "ThemLOPHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MALOP", et.Malop));
                cmd.Parameters.Add(new SqlParameter("@TENLOP", et.Tenlop));
                cmd.Parameters.Add(new SqlParameter("@CAPDO", et.Capdo));
                cmd.Parameters.Add(new SqlParameter("@NGAYBATDAU", et.Ngaybatdau));
                cmd.Parameters.Add(new SqlParameter("@NGAYKETTHUC", et.Ngayketthuc));

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
                cmd.CommandText = "XoaLOPHOC";
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
        public int Sua(ET_LOPHOC et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaLOPHOC";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MALOP", et.Malop));
                cmd.Parameters.Add(new SqlParameter("@TENLOP", et.Tenlop));
                cmd.Parameters.Add(new SqlParameter("@CAPDO", et.Capdo));
                cmd.Parameters.Add(new SqlParameter("@NGAYBATDAU", et.Ngaybatdau));
                cmd.Parameters.Add(new SqlParameter("@NGAYKETTHUC", et.Ngayketthuc));
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
        public DataTable LayDSMaLop()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatMALOPHOC";
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
