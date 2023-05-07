using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ET_QLTT;

namespace DAL_QLTT
{
   public class DAL_Connect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QUANLYTRUNGTAM;Integrated Security=True");
    }
}
