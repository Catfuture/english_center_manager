using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTT_NguyenThiLanAnh
{
    public partial class FDanghap : Form
    {
        /// <summary>
        /// KET NOI DATABASE
        /// </summary>
       
        
        public FDanghap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QUANLYTRUNGTAM;Integrated Security=True");
                _con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "TimkiemQUANLY";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _con;

                cmd.Parameters.AddWithValue("@TENTAIKHOAN", txtUserName.Text);
                cmd.Parameters.AddWithValue("@MATKHAU", txtPass.Text);

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    Form home = new FMain();
                    this.Hide();
                    home.ShowDialog();
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Text = "";
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }
                _con.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Co loi xay ra !!!");
            }
            finally
            {
                
            }
        }
         
        private void FDanghap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát !", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void FDanghap_Load(object sender, EventArgs e)
        {
            Form splash = new Splash();
            splash.ShowDialog();
        }

        private void chkHienMatKhua_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhua.Checked)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
