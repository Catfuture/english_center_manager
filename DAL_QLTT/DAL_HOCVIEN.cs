using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;

namespace DAL_QLTT
{
    public class DAL_HOCVIEN : DAL_Connect
    {
        //connection
        SqlDataAdapter dal;
        SqlCommand cmd;
        DataTable dt;

        //method
        public DataTable LayDSHocvien()
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatHOCVIEN";
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
        public int Them(ET_HOCVIEN et)
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
        public int Xoa(string mahv)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "XoaHOCVIEN";
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
        public int Sua(ET_HOCVIEN et)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaHOCVIEN";
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
        public int Sualop(string mahv,string lop)
        {
            try
            {
                _con.Open();
                cmd.CommandText = "SuaLOPHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.Add(new SqlParameter("@MAHV", mahv));
                cmd.Parameters.Add(new SqlParameter("@LOP", lop));

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
        public DataTable TimkiemmaHOCVIEN(string mahv)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemmaHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MAHV", mahv));

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
        public DataTable TimkiemtenHOCVIEN(string tenhv)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemtenHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENGV", tenhv));

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
        public DataTable TimkiemlopHOCVIEN(string lophv)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemlopHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LOP", lophv));

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
        public DataTable TimkiemcapHOCVIEN(string capdo)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "TimkiemlopHOCVIEN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CAPDO", capdo));

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
        public DataSet ThongKeHocPhiTheoLop()
        {
            DataSet dts = new DataSet();
            try
            {
                _con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "XuatTKHOCPHITUNGLOP";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                dal = new SqlDataAdapter(cmd);
                
                dal.Fill(dts);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _con.Close();
            }
            return dts;
        }
    }
}
