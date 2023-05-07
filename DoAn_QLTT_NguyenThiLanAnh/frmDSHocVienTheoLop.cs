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
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.CSharp;

namespace DoAn_QLTT_NguyenThiLanAnh
{
    public partial class frmDSHocVienTheoLop : Form
    {
        public frmDSHocVienTheoLop()
        {
            InitializeComponent();
        }
        BUS_LOPHOC loph = new BUS_LOPHOC();
        private void btnApDungLopHV_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"F:\DoAn_QLTT_NguyenThiLanAnh\DoAn_QLTT_NguyenThiLanAnh\repDanhSachHocVienTheoLop.rpt");

            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbMaLop.Text;
            crParameterFieldDefinitions = repDanhSachHocVienTheoLop3.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["@LOP"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;
            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }
        void setmalop()
        {
            try
            {
                DataTable malop = loph.LayDSMaLop();
                foreach (DataRow row in malop.Rows)
                {
                    cbMaLop.Items.Add(row["MALOP"]);
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void frmDSHocVienTheoLop_Load(object sender, EventArgs e)
        {
           
        }

        private void frmDSHocVienTheoLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát !", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
