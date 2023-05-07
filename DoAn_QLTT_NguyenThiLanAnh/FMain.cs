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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        SqlConnection _con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QUANLYTRUNGTAM;Integrated Security=True");
        ///khai bao bus
        BUS_GIANGVIEN gv = new BUS_GIANGVIEN();
        BUS_HOCVIEN hv = new BUS_HOCVIEN();
        BUS_LICHHOC lh = new BUS_LICHHOC();
        BUS_LOPHOC loph = new BUS_LOPHOC();
        BUS_DIEMDAUVAO diem = new BUS_DIEMDAUVAO();
        BUS_LUONGGIANGVIEN luong = new BUS_LUONGGIANGVIEN();

        ///kiem tra nhap
        void kiemtraGV()
        {
            
            if (txtMaGiangVien.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtMaGiangVien, "You must enter Your name");
            }
            else if (txtHovaTenGiangVien.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtHovaTenGiangVien, "You must enter Your name");
            }
            else if (txtTenGiangVien.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtTenGiangVien, "You must enter Your name");
            }
            else if (txtDiachGiangVien.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtDiachGiangVien, "You must enter Your name");
            }
            else
            {
                this.errorProvider1.Clear();
            }
                
        }
        void kiemtraHV()
        {

            if (txtMaHV.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtMaHV, "You must enter Your name");
            }
            else if (txtHovaTenDemHV.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtHovaTenDemHV, "You must enter Your name");
            }
            else if (txtTenhv.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtTenhv, "You must enter Your name");
            }
            else if (txtDiachihocvien.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtDiachihocvien, "You must enter Your name");
            }
            else
            {
                this.errorProvider1.Clear();
            }

        }
        void kiemtraLH()
        {

            if (txtMalop.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtMalop, "You must enter Your name");
            }
            else if (txtTenLop.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtTenLop, "You must enter Your name");
            }
            else
            {
                this.errorProvider1.Clear();
            }

        }
        string Gioitinh()
        {
            if (radNam.Checked == true || raNamHV.Checked == true || radNamDDV.Checked == true)
            {
                return "Nam";
            }
            else if (radNu.Checked==true || raNuHV.Checked == true || rabNuDDV.Checked == true)
            {
                return "Nu";
            }
            return "Khac";
        }
        string CapDo(string cd)
        {
            cd = cd.Trim();
            if (cd.Length==2)
            {
                if (cd == "CB")
                {
                    return "Cơ bản";
                }
                else if (cd == "TC")
                {
                    return "Trung cấp";
                }
                else if (cd == "LT")
                {
                    return "thi chứng chỉ";
                }
            }
            else
            {
                if (cd == "Cơ bản")
                {
                    return "CB";
                }
                else if (cd == "Trung cấp")
                {
                    return "TC";
                }
                else if (cd == "thi chứng chỉ")
                {
                    return "LT";
                }
            }
            return "";
        }
        DateTime suLyNgayThangNam(string str)
        {
            str = str.Substring(0, 10);
            string[] arr = str.Split('-');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 2)
                {
                    if (arr[i].Substring(0, 1) == "0")
                    {
                        arr[i] = arr[i].Substring(1, 1);
                    }
                }
            }
            int ngay = int.Parse(arr[0]);
            int thang = int.Parse(arr[1]);
            int nam = int.Parse(arr[2]);
            DateTime kq = new DateTime(nam, thang, ngay, 0, 0, 0, 0);
            return kq;
        }
        /// <summary>
        /// Custum code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void fillChart()
        {
            try
            {
                ChartThongKeDoanhThuTheoLop.DataSource = hv.thongKeHocPhiTheoLop();
                ChartThongKeDoanhThuTheoLop.Series["Lớp học"].XValueMember = "LOP";
                ChartThongKeDoanhThuTheoLop.Series["Lớp học"].YValueMembers = "DOANHTHU";
                ChartThongKeDoanhThuTheoLop.Titles.Add("Thống kê học phí theo lớp học (Khóa 22)");
                ChartThongKeDoanhThuTheoLop.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                _con.Close();
            }
            catch (Exception)
            {


            }

        }
        private void imgdiemthi_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void imgdiemthi_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void pnTaiKhoan_MouseHover(object sender, EventArgs e)
        {
            imgTaikhoan.Size = new System.Drawing.Size(95,75);
        }

        private void imgTaikhoan_MouseLeave(object sender, EventArgs e)
        {
            imgTaikhoan.Size = new System.Drawing.Size(90, 70);
        }

        private void imgGiangvien_MouseHover(object sender, EventArgs e)
        {
            imgGiangvien.Size = new System.Drawing.Size(95, 75);
        }

        private void imgGiangvien_MouseLeave(object sender, EventArgs e)
        {
            imgGiangvien.Size = new System.Drawing.Size(90, 70);
        }

        private void imgHocVien_MouseHover(object sender, EventArgs e)
        {
            imgHocVien.Size = new System.Drawing.Size(95, 75);
        }

        private void imgHocVien_MouseLeave(object sender, EventArgs e)
        {
            imgHocVien.Size = new System.Drawing.Size(90, 70);
        }

        private void imgLopHoc_MouseHover(object sender, EventArgs e)
        {
            imgLopHoc.Size = new System.Drawing.Size(95, 75);
        }

        private void imgLopHoc_MouseLeave(object sender, EventArgs e)
        {
            imgLopHoc.Size = new System.Drawing.Size(90, 70);
        }

        private void imgLichHoc_MouseHover(object sender, EventArgs e)
        {
            imgLichHoc.Size = new System.Drawing.Size(95, 75);
        }

        private void imgLichHoc_MouseLeave(object sender, EventArgs e)
        {
            imgLichHoc.Size = new System.Drawing.Size(90, 70);
        }

        private void imgDiemdauvao_MouseHover(object sender, EventArgs e)
        {
            imgDiemdauvao.Size = new System.Drawing.Size(95, 75);
        }

        private void imgDiemdauvao_MouseLeave(object sender, EventArgs e)
        {
            imgDiemdauvao.Size = new System.Drawing.Size(90, 70);
        }

        private void imgTaikhoan_Click(object sender, EventArgs e)
        {
            Form taikhoan = new TaiKhoan();
            taikhoan.ShowDialog();
        }

        private void imgGiangvien_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 1;
        }

        private void imgHocVien_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 2;
        }

        private void imgLopHoc_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 3;
        }

        private void imgLichHoc_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 4;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 5;
        }
        private void Trangchu_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 0;
        }
        private void imgdiemthi_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 8;
        }
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 1;
        }

        private void họcVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 2;
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 3;
        }

        private void lịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 4;
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 5;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 6;
        }
        private void imgDiemdauvao_Click(object sender, EventArgs e)
        {
            tabctThongTin.SelectedIndex = 7;
        }
        private void PnDiemThiDauVao_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// End Custum code
        /// </summary>

        /// <summary>
        /// function
        /// </summary>
        /// GIANG VIEN
        
        private void FMain_Load(object sender, EventArgs e)
        {
            fillChart();
            datagvDSGiangVien.DataSource = gv.LayDS();
            datagvDSHOCVIEN.DataSource = hv.LayDS();
            datagvDSLOPHOC.DataSource = loph.LayDS(); 
            datagvDSLICHHOC.DataSource = lh.LayDS(1);
            datagvDSDiemDauVao.DataSource = diem.LayDS();
            datagvDSLUONGGV.DataSource = luong.LayDS(ngaynhanluong);
            //
            setCBLophoc();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form dangnhap = new Dangnhap2();
            dangnhap.Show();
        }

        private void thoátToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát !", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            
        }
        private void btnThemGV_Click(object sender, EventArgs e)
        {
            kiemtraGV();
            try
            {
                int lienhe = int.Parse(txtLienHeGiangVien.Text);
                int luong = int.Parse(txtLuongCoBan.Text);
                ET_GIANGVIEN et = new ET_GIANGVIEN(txtMaGiangVien.Text, txtHovaTenGiangVien.Text,
                    txtTenGiangVien.Text, datNgaysinh.Text, Gioitinh(),
                    txtDiachGiangVien.Text, lienhe, luong);
                if (gv.Them(et) == 1)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                lamMoiGV();
                datagvDSGiangVien.DataSource = gv.LayDS();
            }
            catch (Exception)
            {

            }
            
        }
        void lamMoiGV()
        {
            txtMaGiangVien.Text = "";
            txtHovaTenGiangVien.Text = "";
            txtTenGiangVien.Text = "";
            datNgaysinh.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            if (radNu.Checked == true)
            {
                radNu.Checked = false;
            }
            else
            {
                radNam.Checked = false;
            }
            txtDiachGiangVien.Text = "";
            txtLienHeGiangVien.Text = "";
            txtLuongCoBan.Text = "";
            datagvDSGiangVien.DataSource = gv.LayDS();
        }
        private void btnLamMoiGV_Click(object sender, EventArgs e)
        {
            lamMoiGV();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            kiemtraGV();
            try
            {
                int lienhe = int.Parse(txtLienHeGiangVien.Text);
                int luong = int.Parse(txtLuongCoBan.Text);
                ET_GIANGVIEN et = new ET_GIANGVIEN(txtMaGiangVien.Text, txtHovaTenGiangVien.Text,
                    txtTenGiangVien.Text, datNgaysinh.Text, Gioitinh(),
                    txtDiachGiangVien.Text,
                   lienhe, luong);
                if (gv.Sua(et) == 1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                datagvDSGiangVien.DataSource = gv.LayDS();
                lamMoiGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTimMa_Click(object sender, EventArgs e)
        {
            try
            {
                datagvDSGiangVien.DataSource = gv.TimkiemMaGV(txtTimKiemMaGV.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            try
            {
                datagvDSGiangVien.DataSource = gv.TimkiemTENGV(txtTimKiemTenGV.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            kiemtraGV();
            try
            {
                DialogResult res = MessageBox.Show("Bạn có muốn Xóa !", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.OK)
                {
                    if (gv.Xoa(txtMaGiangVien.Text) == 1)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong thanh cong");
                    }
                    lamMoiGV();
                    datagvDSGiangVien.DataSource = gv.LayDS();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        private void datagvDSGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaGiangVien.Text = datagvDSGiangVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHovaTenGiangVien.Text = datagvDSGiangVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenGiangVien.Text = datagvDSGiangVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                datNgaysinh.Value = suLyNgayThangNam(datagvDSGiangVien.Rows[e.RowIndex].Cells[3].Value.ToString());
                string gioitinh = datagvDSGiangVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (gioitinh.Trim() == "Nu" || gioitinh.Trim() == "NU")
                {
                    radNu.Checked = true;
                }
                else
                {
                    radNam.Checked = true;
                }
                txtDiachGiangVien.Text = datagvDSGiangVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLienHeGiangVien.Text = datagvDSGiangVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtLuongCoBan.Text = datagvDSGiangVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// HOC VIEN
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            kiemtraHV();
            try
            {
                int lienhe = int.Parse(txtlienhehocvien.Text.Replace("-",""));
                ET_HOCVIEN et = new ET_HOCVIEN(txtMaHV.Text, txtHovaTenDemHV.Text,
                    txtTenhv.Text, DatepNgaysinh.Text, Gioitinh(),
                   txtDiachihocvien.Text, txtMaNDH.Text, lienhe,
                   CapDo(cbCapDoHV.Text), cbLopHV.Text);
                if (hv.Them(et) == 1)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                lamMoiHV();
                datagvDSHOCVIEN.DataSource = hv.LayDS();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnThemNguoiDamHo_Click(object sender, EventArgs e)
        {
            Form ndh = new FNguoidamho();
            ndh.ShowDialog();
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            kiemtraHV();
            try
            {
                int lienhe = int.Parse(txtlienhehocvien.Text.Replace("-", ""));
                ET_HOCVIEN et = new ET_HOCVIEN(txtMaHV.Text, txtHovaTenDemHV.Text,
                    txtTenhv.Text, DatepNgaysinh.Text, Gioitinh(),
                   txtDiachihocvien.Text, txtMaNDH.Text, lienhe,
                   CapDo(cbCapDoHV.Text), cbLopHV.Text);
                if (hv.Sua(et) == 1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                lamMoiHV();
                datagvDSHOCVIEN.DataSource = hv.LayDS();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            kiemtraHV();
            try
            {
                DialogResult res = MessageBox.Show("Bạn có muốn Xóa !", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.OK)
                {
                    if (hv.Xoa(txtMaHV.Text) == 1)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong thanh cong");
                    }
                    datagvDSHOCVIEN.DataSource = hv.LayDS();
                    lamMoiHV();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void lamMoiHV()
        {
            try
            {
                txtMaHV.Text = "";
                txtHovaTenDemHV.Text = "";
                txtTenhv.Text = "";
                DatepNgaysinh.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
                if (raNuHV.Checked == true)
                {
                    raNuHV.Checked = false;
                }
                else
                {
                    raNamHV.Checked = false;
                }
                txtDiachihocvien.Text = "";
                txtMaNDH.Text = "";
                txtlienhehocvien.Text = "";
                cbCapDoHV.Text = "(Select)";
                cbLopHV.Text = "(Select)";
                datagvDSHOCVIEN.DataSource = hv.LayDS();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnLamMoiHV_Click(object sender, EventArgs e)
        {
            lamMoiHV();
        }
        private void datagvDSHOCVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHV.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHovaTenDemHV.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenhv.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[2].Value.ToString();
                DatepNgaysinh.Value = suLyNgayThangNam(datagvDSHOCVIEN.Rows[e.RowIndex].Cells[3].Value.ToString());
                string gioitinh = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (gioitinh.Trim() == "Nu" || gioitinh.Trim() == "NU")
                {
                    raNuHV.Checked = true;
                }
                else
                {
                    raNamHV.Checked = true;
                }
                txtDiachihocvien.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMaNDH.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtlienhehocvien.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbCapDoHV.Text = CapDo(datagvDSHOCVIEN.Rows[e.RowIndex].Cells[8].Value.ToString());
                cbLopHV.Text = datagvDSHOCVIEN.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        /// Lop hoc
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LOPHOC et = new ET_LOPHOC(txtMalop.Text, txtTenLop.Text,
                CapDo(cbCapDoLop.Text), dateNgayBatDauLophoc.Text,
               dateNgayKetThucLophoc.Text);
                if (loph.Them(et) == 1)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                lamMoiLopHoc();
                datagvDSLOPHOC.DataSource = loph.LayDS();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LOPHOC et = new ET_LOPHOC(txtMalop.Text, txtTenLop.Text,
               CapDo(cbCapDoLop.Text), dateNgayBatDauLophoc.Text,
               dateNgayKetThucLophoc.Text);
                if (loph.Sua(et) == 1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                lamMoiLopHoc();
                datagvDSLOPHOC.DataSource = loph.LayDS();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Bạn có muốn Xóa !", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        if (loph.Xoa(txtMalop.Text) == 1)
                        {
                            MessageBox.Show("Xoa thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong thanh cong");
                        }
                        lamMoiLopHoc();
                        datagvDSLOPHOC.DataSource = loph.LayDS();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thực hiện được !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        void lamMoiLopHoc()
        {
            try
            {
                txtMalop.Text = "";
                txtTenLop.Text = "";
                cbCapDoLop.Text = "(Select)";
                dateNgayBatDauLophoc.Value = new DateTime(2022, 9, 11, 0, 0, 0, 0);
                dateNgayKetThucLophoc.Value = new DateTime(2023, 1, 7, 0, 0, 0, 0);
                datagvDSLOPHOC.DataSource = loph.LayDS();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            lamMoiLopHoc();
        }

        private void datagvDSLOPHOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMalop.Text = datagvDSLOPHOC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLop.Text = datagvDSLOPHOC.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbCapDoLop.Text = CapDo(datagvDSLOPHOC.Rows[e.RowIndex].Cells[2].Value.ToString());
                dateNgayBatDauLophoc.Value = suLyNgayThangNam(datagvDSLOPHOC.Rows[e.RowIndex].Cells[3].Value.ToString());
                dateNgayKetThucLophoc.Value = suLyNgayThangNam(datagvDSLOPHOC.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// Lich hoc
        int loctuan = 1;
        void setCBLophoc()
        {
            try
            {
                DataTable malop = loph.LayDSMaLop();
                foreach (DataRow row in malop.Rows)
                {
                    cbMaLopLichHoc.Items.Add(row["MALOP"]);

                    cbLopHV.Items.Add(row["MALOP"]);
                    cbTimKiemLophoc.Items.Add(row["MALOP"]);
                    cbTimKiemMaLop.Items.Add(row["MALOP"]);
                }
                DataTable magv = gv.LayDSMaGV();
                foreach (DataRow row in magv.Rows)
                {
                    cbLuongMaGV.Items.Add(row["MAGV"]);
                    cbMaGVLichHoc.Items.Add(row["MAGV"]);
                }
            }
            catch (Exception)
            {

                
            }
            
        }
        private void btnThemLich_Click(object sender, EventArgs e)
        {
            try
            {
                int tuan = int.Parse(cbTuan.Text.Trim());
                ET_LỊCHHOC et = new ET_LỊCHHOC(cbMaLopLichHoc.Text,cbMaGVLichHoc.Text, cbLichHoc.Text, cbPhonghoc.Text, tuan);
                if (lh.Them(et) == 1)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                datagvDSLICHHOC.DataSource = lh.LayDS(loctuan);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSuaLich_Click(object sender, EventArgs e)
        {
            try
            {
                int tuan = int.Parse(cbTuan.Text);
                ET_LỊCHHOC et = new ET_LỊCHHOC(cbMaLopLichHoc.Text, cbMaGVLichHoc.Text, cbLichHoc.Text, cbPhonghoc.Text, tuan);
                if (lh.Sua(et) == 1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                datagvDSLICHHOC.DataSource = lh.LayDS(loctuan);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Bạn có muốn Xóa !", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        if (lh.Xoa(cbLichHoc.Text) == 1)
                        {
                            MessageBox.Show("Xoa thanh cong");
                        }
                        else
                        {
                            MessageBox.Show("Khong thanh cong");
                        }
                        datagvDSLICHHOC.DataSource = lh.LayDS(loctuan);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagvDSLICHHOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbMaLopLichHoc.Text = datagvDSLICHHOC.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbMaGVLichHoc.Text = datagvDSLICHHOC.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLichHoc.Text = datagvDSLICHHOC.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbPhonghoc.Text = datagvDSLICHHOC.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbTuan.Text = datagvDSLICHHOC.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoiLich_Click(object sender, EventArgs e)
        {
            cbMaLopLichHoc.Text = "(Select)";
            cbMaGVLichHoc.Text = "(Select)";
            cbLichHoc.Text = "(Select)";
            cbPhonghoc.Text = "(Select)";
            cbTuan.Text = "(Select)";
            datagvDSLICHHOC.DataSource = lh.LayDS(loctuan);
        }
        private void btnLocTuanhoc_Click(object sender, EventArgs e)
        {
            try
            {
                loctuan = int.Parse(cbLocTuan.Text);
                datagvDSLICHHOC.DataSource = lh.LayDS(loctuan);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        //LUONG GV
        DateTime ngaynhanluong = new DateTime(2022, 11, 10);
        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LUONGGIANGVIEN et = new ET_LUONGGIANGVIEN(cbLuongMaGV.Text, dateNgayNhanLuong.Text,int.Parse(txtSogioday.Text), int.Parse(mtxtLuong.Text.Replace(".","")));
                if (luong.Sua(et)==1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                lammoiLuong();
                datagvDSLUONGGV.DataSource = luong.LayDS(ngaynhanluong);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnApDungLuongGV_Click(object sender, EventArgs e)
        {
            try
            {
                
                ngaynhanluong = sulyngaythangluong(dateNgayLuong.Text);

                datagvDSLUONGGV.DataSource = luong.LayDS(ngaynhanluong);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
        DateTime sulyngaythangluong(string str)
        {

            string[] arr = str.Split('/');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 2)
                {
                    if (arr[i].Substring(0, 1) == "0")
                    {
                        arr[i] = arr[i].Substring(1, 1);
                    }
                }
            }
            int ngay = int.Parse(arr[0]);
            int thang = int.Parse(arr[1]);
            int nam = int.Parse(arr[2]);
            DateTime kq = new DateTime(nam, thang, ngay, 0, 0, 0, 0);
            return kq;
        }
        private void datagvDSLUONGGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbLuongMaGV.Text = datagvDSLUONGGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                txthovatendemLuong.Text = datagvDSLUONGGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenGVLuong.Text = datagvDSLUONGGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNgayNhanLuong.Value = suLyNgayThangNam(datagvDSLUONGGV.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtSogioday.Text = datagvDSLUONGGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                string luong = datagvDSLUONGGV.Rows[e.RowIndex].Cells[5].Value.ToString() + "000";
                if (luong.Length == 7)
                {
                    luong = "0" + luong;
                }
                mtxtLuong.Text = luong;

            }
            catch (Exception)
            {


            }
        }
        void lammoiLuong()
        {
            cbLuongMaGV.Text = "(Select)";
            txthovatendemLuong.Text = "";
            txtTenGVLuong.Text = "";
            dateNgayNhanLuong.Value = new DateTime(2022, 12, 10);
            txtSogioday.Text = "";
            mtxtLuong.Text = "";
            datagvDSLUONGGV.DataSource = luong.LayDS(ngaynhanluong);
        }
        private void btnLamMoiLuong_Click(object sender, EventArgs e)
        {
            lammoiLuong();
        }

        private void btnXoaLuong_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn Xóa !", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (luong.Xoa(cbLuongMaGV.Text.Substring(0,4),sulyngaythangluong(dateNgayNhanLuong.Text)) == 1)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong thanh cong");
                    }
                    datagvDSLUONGGV.DataSource = luong.LayDS(ngaynhanluong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemLuong_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// diem dau vao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagvDSDiemDauVao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMAHVDiemdauvao.Text = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHovatendemDiemdauvao.Text = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenHVDiemdauvao.Text = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateNgaysinhDiemdauvao.Value = suLyNgayThangNam(datagvDSDiemDauVao.Rows[e.RowIndex].Cells[3].Value.ToString());
                string gioitinh = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (gioitinh.Trim() == "Nu" || gioitinh.Trim() == "NU")
                {
                    rabNuDDV.Checked = true;
                }
                else
                {
                    radNamDDV.Checked = true;
                }
                txtDiachiDiemdauvao.Text = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLienHeDiemdauvao.Text = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiemThiDiemdauvao.Text = datagvDSDiemDauVao.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch (Exception)
            {
            }
            
        }
        void lammoidiemdauvao()
        {
            txtMAHVDiemdauvao.Text = "";
            txtHovatendemDiemdauvao.Text = "";
            txtTenHVDiemdauvao.Text = "";
            dateNgaysinhDiemdauvao.Value = new DateTime(2000, 1, 1);
            radNamDDV.Checked = false;
            rabNuDDV.Checked = false;
            txtDiachiDiemdauvao.Text = "";
            txtLienHeDiemdauvao.Text = "";
            txtDiemThiDiemdauvao.Text = "";
            datagvDSDiemDauVao.DataSource = diem.LayDS();
        }
        private void btnLamMoiDiamDauVao_Click(object sender, EventArgs e)
        {
            try
            {
                lammoidiemdauvao();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnThemDiamDauVao_Click(object sender, EventArgs e)
        {
            try
            {
                int diemthi = int.Parse(txtDiemThiDiemdauvao.Text);
                ET_DIEMDAUVAO et = new ET_DIEMDAUVAO(txtMAHVDiemdauvao.Text, txtHovatendemDiemdauvao.Text,
                    txtTenHVDiemdauvao.Text, dateNgaysinhDiemdauvao.Text, Gioitinh(), txtDiachiDiemdauvao.Text, int.Parse(txtLienHeDiemdauvao.Text), diemthi);
                if (diem.Them(et) == 1)
                {
                    MessageBox.Show("Them thanh cong");
                    datagvDSDiemDauVao.DataSource = diem.LayDS();
                    lammoidiemdauvao();
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

        private void btnSuaDiamDauVao_Click(object sender, EventArgs e)
        {
            try
            {
                int diemthi = int.Parse(txtDiemThiDiemdauvao.Text);
                ET_DIEMDAUVAO et = new ET_DIEMDAUVAO(txtMAHVDiemdauvao.Text, txtHovatendemDiemdauvao.Text,
                    txtTenHVDiemdauvao.Text, dateNgaysinhDiemdauvao.Text, Gioitinh(), txtDiachiDiemdauvao.Text, int.Parse(txtLienHeDiemdauvao.Text), diemthi);
                if (diem.Sua(et) == 1)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
                datagvDSDiemDauVao.DataSource = diem.LayDS();
                lammoidiemdauvao();
            }
            catch (Exception)
            {

            }
        }

        private void btnXoaDiamDauVao_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn Xóa !", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (diem.Xoa(txtMAHVDiemdauvao.Text) == 1)
                    {
                        MessageBox.Show("Xoa thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Khong thanh cong");
                    }
                    datagvDSDiemDauVao.DataSource = diem.LayDS();
                    lammoidiemdauvao();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thực hiện được !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnThemVaoDSHV_Click(object sender, EventArgs e)
        {
            if (cbCapDoHVThem.Text!= "(Select)" && cbLopHVThem.Text != "(Select)")
            {
                try
                {
                    int lienhe = int.Parse(txtLienHeDiemdauvao.Text);
                    ET_HOCVIEN et = new ET_HOCVIEN(txtMAHVDiemdauvao.Text, txtHovatendemDiemdauvao.Text,
                        txtTenHVDiemdauvao.Text, dateNgaysinhDiemdauvao.Text, Gioitinh(), txtDiachiDiemdauvao.Text,
                        "", lienhe, CapDo(cbCapDoHVThem.Text), cbLopHVThem.Text);
                    if (diem.ThemHocVienTuDiemDauVao(et) == 1)
                    {
                        MessageBox.Show("Them thanh cong");
                        diem.Xoa(txtMAHVDiemdauvao.Text);
                    }
                    else
                    {
                        MessageBox.Show("Khong thanh cong");
                    }
                    datagvDSDiemDauVao.DataSource = diem.LayDS();
                    lammoidiemdauvao();
                }
                catch (Exception)
                {

                }
            }
           
        }
        private void cbCapDoHVThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLopHVThem.Items.Clear();
            if (cbCapDoHVThem.SelectedIndex == 0)
            {
                cbLopHVThem.Items.Add("MAL01");
                cbLopHVThem.Items.Add("MAL02");
            }
            else if (cbCapDoHVThem.SelectedIndex == 1)
            {
                cbLopHVThem.Items.Add("MAL03");
                cbLopHVThem.Items.Add("MAL04");
            }
            else
            {
                cbLopHVThem.Items.Add("MAL05");
                cbLopHVThem.Items.Add("MAL06");
                cbLopHVThem.Items.Add("MAL07");
            }
        }
        /// <summary>
        /// Diem thi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagvDSDiemThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnXuatfileGV_Click(object sender, EventArgs e)
        {
            Form xfGV = new frmDSGiangVien();
            xfGV.ShowDialog();
        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemHVTheoMa_Click(object sender, EventArgs e)
        {
            try
            {
                datagvDSHOCVIEN.DataSource = hv.TimkiemMaHV(txtTimKiemMaHV.Text);
            }
            catch (Exception)
            {

                
            }
        }

        private void btnTimKiemHVTheoTen_Click(object sender, EventArgs e)
        {
            try
            {
                datagvDSHOCVIEN.DataSource = hv.TimkiemTENHV(txtTimKiemTenHV.Text);
            }
            catch (Exception)
            {


            }
        }

        private void btnTimKiemHVTheolop_Click(object sender, EventArgs e)
        {
            try
            {
                datagvDSHOCVIEN.DataSource = hv.TimkiemlopHOCVIEN(cbTimKiemLophoc.Text);
            }
            catch (Exception)
            {


            }
        }

        private void btnXuatFileHV_Click(object sender, EventArgs e)
        {
            Form hv = new frmDSHocVienTheoLop();
            hv.ShowDialog();
        }

        private void btnXuatfileLich_Click(object sender, EventArgs e)
        {
            Form lh = new frmDSLichHocTheoTuan();
            lh.ShowDialog();
        }

        private void btnXuatFileThongke_Click(object sender, EventArgs e)
        {

            Form dt = new frmDoanhThu();
            dt.ShowDialog();
        }
    }
}
