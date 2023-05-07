using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLTT;
using ET_QLTT;

namespace DoAn_QLTT_NguyenThiLanAnh
{
    public partial class FNguoidamho : Form
    {
        public FNguoidamho()
        {
            InitializeComponent();
        }
        BUS_NGUOIDAMHO dh = new BUS_NGUOIDAMHO();
        private void FNguoidamho_Load(object sender, EventArgs e)
        {
            datagvDSNDH.DataSource = dh.LayDS();
        }

        private void datagvDSNDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNDH.Text = datagvDSNDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHovaTenNDH.Text = datagvDSNDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuanhe.Text = datagvDSNDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLienHeNDH.Text = datagvDSNDH.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void btnthemNDH_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NGUOIDAMHO et = new ET_NGUOIDAMHO(txtMaNDH.Text, txtHovaTenNDH.Text, txtQuanhe.Text,int.Parse(txtLienHeNDH.Text));
                if (dh.Them(et)==1)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
