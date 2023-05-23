using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using Quanlygiaydepca2.Class;

namespace Quanlygiaydepca2.Forms
{
    public partial class frmHoadonnhap : System.Windows.Forms.Form
    {
        DataTable tblCTHDN;
        public frmHoadonnhap()
        {
            InitializeComponent();
        }

        private void frmHoadonnhap_Load(object sender, EventArgs e)
        {
            btnThemmoi.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnInhoadon.Enabled = false;
            txtSoHDN.ReadOnly = true;
            txtTennhanvien.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDienthoai.ReadOnly = true;
            txtTengiaydep.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            txtTongtien.Text = "0";
            
            Quanlygiaydep.FillCombo("select MaNCC, TenNCC from tblNhacungcap",cboMaNCC, "MaNCC", "MaNCC");
            cboMaNCC.SelectedIndex = -1;
            Quanlygiaydep.FillCombo("select MaNV, TenNV from  tblNhanvien",cboManhanvien, "MaNV", "MaNV");
            cboManhanvien.SelectedIndex = -1;
            Quanlygiaydep.FillCombo("select Magiaydep, Tengiaydep from tblSanpham", cboMagiaydep, "Magiaydep", "Magiaydep");
            cboMagiaydep.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm

            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT a.Magiaydep, b.Tengiaydep, a.Soluong, a.Dongia, a.Giamgia,a.Thanhtien FROM tblChitietHDNhap AS a, tblSanpham AS b WHERE a.SoHDN = N'" + txtSoHDN.Text + "' AND a.Magiaydep = b.Magiaydep";
            tblCTHDN = Quanlygiaydep.GetDataToTable(sql);
            DGridHoadonnhap.DataSource = tblCTHDN;
            DGridHoadonnhap.Columns[0].HeaderText = "Mã giày dép";
            DGridHoadonnhap.Columns[1].HeaderText = "Tên giày dep";
            DGridHoadonnhap.Columns[2].HeaderText = "Số lượng";
            DGridHoadonnhap.Columns[3].HeaderText = "Đơn giá";
            DGridHoadonnhap.Columns[4].HeaderText = "Giảm giá %";
            DGridHoadonnhap.Columns[5].HeaderText = "Thành tiền";
            DGridHoadonnhap.Columns[0].Width = 80;
            DGridHoadonnhap.Columns[1].Width = 130;
            DGridHoadonnhap.Columns[2].Width = 80;
            DGridHoadonnhap.Columns[3].Width = 90;
            DGridHoadonnhap.Columns[4].Width = 90;
            DGridHoadonnhap.Columns[5].Width = 90;
            DGridHoadonnhap.AllowUserToAddRows = false;
            DGridHoadonnhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
            btnInhoadon.Enabled = false;
            btnThemmoi.Enabled = false;
            ResetValues();
            txtSoHDN.Text = Quanlygiaydep.CreateKey("HDN");
            Load_DataGridView();

        }
        private void ResetValues()
        {
            txtSoHDN.Text = "";
            txtNgaynhap.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            cboMaNCC.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMagiaydep.Text = "";
            txtSoluong.Text = "";
            txtDongianhap.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }
        private void ResetValuesSP()
        {
            cboMagiaydep.Text = ""; 
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtDongianhap.Text = "";
            txtThanhtien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLmoi, tong, Tongmoi, dgb;
            sql = "select SoHDN from tblHoadonnhap where SoHDN=N'" + txtSoHDN.Text + "'";
            if (!Quanlygiaydep.CheckKey(sql))
            {
                //Số hóa đơn được thêm tự động nên không trùng khóa
                //Tiến hành lưu thông tin hóa đơn
                if (txtNgaynhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgaynhap.Focus();
                    return;
                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboManhanvien.Focus();
                    return;
                }
                if (cboMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã nhà cung cấp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNCC.Focus();
                    return;
                }
                sql = "insert into tblHoadonnhap(SoHDN,Ngaynhap,MaNV,MaNCC,Tongtien) values(N'" + txtSoHDN.Text.Trim() + "','" + Quanlygiaydep.ConvertDateTime(txtNgaynhap.Text) + "',N'" + cboManhanvien.SelectedValue + "',N'" + cboMaNCC.SelectedValue + "'," + txtTongtien.Text + ")";
                Quanlygiaydep.RunSql(sql);
            }

            //Lưu thông tin sản phẩm
            if (cboMagiaydep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã giày dép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMagiaydep.Focus();
                return;
            }

            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải chọn số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Text = "";
                txtSoluong.Focus(); 
                return;
            }
            

            if (txtDongianhap.Text.Trim().Length == 0 || txtDongianhap.Text == "0")
            {
                MessageBox.Show("Bạn phải chọn đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongianhap.Text = "";
                txtDongianhap.Focus();
                return;
            }


            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamgia.Focus();
                return;
            }

            //Kiểm tra khóa
            sql = "Select Magiaydep from tblChitietHDNhap where Magiaydep=N'" + cboMagiaydep.SelectedValue + "' and SoHDN=N'" + txtSoHDN.Text + "'";
            if (Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có,Mời bạn chọn mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesSP();
                cboMagiaydep.Focus();
                return;

            }
            sql = "insert into tblChitietHDNhap(SoHDN,Magiaydep,Soluong,Dongia,Giamgia,Thanhtien) values(N'" + txtSoHDN.Text + "',N'"+cboMagiaydep.SelectedValue+"'," + txtSoluong.Text + "," + txtDongianhap.Text + "," + txtGiamgia.Text + "," + txtThanhtien.Text + ")";
            Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            //Cập nhật lại đơn giá nhập vào bảng sản phẩm
            sql = "update tblSanpham set Dongianhap=" + txtDongianhap.Text + " where Magiaydep=N'" + cboMagiaydep.SelectedValue + "'";
            Quanlygiaydep.RunSql(sql);
            //Cập nhật lại đơn giá bán vào bảng sản phẩm
            dgb = 1.1 * Convert.ToDouble(txtDongianhap.Text);
            sql = "update tblSanpham set Dongiaban=" + dgb + " where Magiaydep=N'" + cboMagiaydep.SelectedValue + "'";
            Quanlygiaydep.RunSql(sql);
            //Cập nhật lại số lượng trong kho
            sql = "Select Soluong from tblSanpham where Magiaydep=N'" + cboMagiaydep.SelectedValue + "'";
            sl = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));
            SLmoi = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "update tblSanpham set Soluong=" + SLmoi + " where Magiaydep=N'" + cboMagiaydep.SelectedValue+ "'";
            Quanlygiaydep.RunSql(sql);
            //Cập nhật lại tổng tiền
            sql = "select Tongtien from tblHoadonnhap where SoHDN =N'" + txtSoHDN.Text + "'";
            tong = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));
            Tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "update tblHoadonnhap set Tongtien=" + Tongmoi + " where SoHDN=N'" + txtSoHDN.Text + "'";
            Quanlygiaydep.RunSql(sql);
            
            
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ:" + Quanlygiaydep.ChuyenSoSangChu(Tongmoi.ToString());

            ResetValuesSP();
            btnThemmoi.Enabled = true;
            btnHuy.Enabled = true;
            btnInhoadon.Enabled = true;
            
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if(cboManhanvien.Text=="")
            {
                txtTennhanvien.Text = "";
            }    
            str = "select TenNV from tblNhanvien where MaNV='" + cboManhanvien.SelectedValue + "'";
            txtTennhanvien.Text = Quanlygiaydep.GetFieldValues(str);
        }

        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
            }
            str = "select TenNCC from tblNhacungcap where MaNCC='" + cboMaNCC.SelectedValue + "'";
            txtTenNCC.Text = Quanlygiaydep.GetFieldValues(str);
            str = "select Diachi from tblNhacungcap where MaNCC='" + cboMaNCC.SelectedValue + "'";
            txtDiachi.Text = Quanlygiaydep.GetFieldValues(str);
            str = "select Dienthoai from tblNhacungcap where MaNCC='" + cboMaNCC.SelectedValue + "'";
            txtDienthoai.Text = Quanlygiaydep.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0; 
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtDongianhap_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongianhap.Text == "")
                dg = 0; 
            else
                dg = Convert.ToDouble(txtDongianhap.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void cboMagiaydep_TextChanged(object sender, EventArgs e)
        {
            string str;
            if(cboMagiaydep.Text=="")
            {
                txtTengiaydep.Text = " ";
            }
            str = "select Tengiaydep from tblSanpham where Magiaydep=N'" + cboMagiaydep.SelectedValue + "'";
            txtTengiaydep.Text = Quanlygiaydep.GetFieldValues(str);
        }

        private void DGridHoadonnhap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string magiaydep;
            double thanhtien;
            if(tblCTHDN.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //Xóa sản phẩm cập nhật lại số sản phẩm trong kho
                magiaydep = DGridHoadonnhap.CurrentRow.Cells["Magiaydep"].Value.ToString();
                DelSP(txtSoHDN.Text, magiaydep);
                //Cập nhật lại tổng tiền cho hóa đơn
                thanhtien =Convert.ToDouble(DGridHoadonnhap.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtSoHDN.Text, thanhtien);
                //Cập nhật lại giá bán,giá nhập trong bảng sản phẩm
                Load_DataGridView();
            }    
        }
        private void DelSP(string Mahoadon,string magiaydep)
        {
            string sql;
            double s, sl, SLcon;
            sql = "select Soluong from tblChitietHDNhap where SoHDN=N'" + Mahoadon + "' and Magiaydep=N'" + magiaydep + "'";
            s = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));
            sql = "delete tblChitietHDNhap where Magiaydep=N'" + magiaydep + "' and SoHDN=N'" + Mahoadon + "'";
            Quanlygiaydep.RunSql(sql);
            //Cập nhật lại số lượng trong bảng sản phẩm
            sql = "select Soluong from tblSanpham where Magiaydep=N'" + magiaydep + "'";
            sl = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));
            SLcon = sl - s;
            sql = "update tblSanpham set Soluong=" + SLcon + " where Magiaydep=N'" + magiaydep + "'";
            Quanlygiaydep.RunSql(sql);
            //Cập nhật giá nhập và giá bán trong bảng sản phẩm về giá trị null
            //sql = "update tblSanpham set Dongianhap=" + null + " and Dongiaban=" + null + " where Magiaydep=N'" + cboMagiaydep.SelectedValue + "'";
            //Quanlygiaydep.RunSql(sql);
           
        }
        private void DelUpdateTongtien(string Mahoadon,double thanhtien)
        {
            string sql;
            double tong, Tongmoi;
            sql = "select Tongtien from tblHoadonnhap where SoHDN=N'" + Mahoadon + "'";
            tong = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));
            Tongmoi = tong - thanhtien;
            sql = "update tblHoadonnhap set Tongtien=" + Tongmoi + " where SoHDN=N'" + Mahoadon + "'";
            Quanlygiaydep.RunSql(sql);
            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ:" + Quanlygiaydep.ChuyenSoSangChu(Tongmoi.ToString());

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string[] Magiaydep = new string[20];
                string sql;
                int n = 0;
                sql = "SELECT Magiaydep FROM tblChitietHDNhap WHERE SoHDN = N'" +txtSoHDN.Text + "'";
                SqlCommand cmd = new SqlCommand(sql,Quanlygiaydep.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Magiaydep[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các sản phẩm
                for (int i = 0; i <= n - 1; i++)
                    DelSP(txtSoHDN.Text, Magiaydep[i]);
                //Xóa hóa đơn
                sql = "delete tblChitietHDNhap where SoHDN=N'" + txtSoHDN.Text + "'";
                Quanlygiaydep.RunSql(sql);
                Load_DataGridView();
                ResetValues();

                btnHuy.Enabled = false;
                btnInhoadon.Enabled = false;
            }
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng ABC";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Cầu Giấy - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";

            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SoHDN, a.Ngaynhap, a.Tongtien, b.TenNCC, b.Diachi, b.Dienthoai, c.TenNV FROM tblHoadonnhap AS a, tblNhacungcap AS b, tblNhanvien AS c WHERE a.SoHDN = N'" + txtSoHDN.Text + "' AND a.MaNCC = b.MaNCC AND a.MaNV = c.MaNV";
            tblThongtinHD = Quanlygiaydep.GetDataToTable(sql);

            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn nhập:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();

            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tengiaydep, a.Soluong, b.Dongianhap, a.Giamgia, a.Thanhtien FROM tblChitietHDNhap AS a , tblSanpham AS b WHERE a.SoHDN = N'" + txtSoHDN.Text + "' AND a.Magiaydep = b.Magiaydep";
            tblThongtinHang = Quanlygiaydep.GetDataToTable(sql);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên giày dép";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá nhập";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Quanlygiaydep.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
