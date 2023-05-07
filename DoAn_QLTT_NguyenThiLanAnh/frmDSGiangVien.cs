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
    public partial class frmDSGiangVien : Form
    {
        public frmDSGiangVien()
        {
            InitializeComponent();
        }

        private void frmDSGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát !", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
