using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTT_NguyenThiLanAnh
{
    public partial class frmDSLichHocTheoTuan : Form
    {
        public frmDSLichHocTheoTuan()
        {
            InitializeComponent();
        }

        private void frmDSLichHocTheoTuan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát !", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
