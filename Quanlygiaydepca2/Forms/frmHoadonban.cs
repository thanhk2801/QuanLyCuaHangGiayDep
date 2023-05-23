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
    public partial class frmHoadonban : System.Windows.Forms.Form
    {
        DataTable tblCTHDB;
        public frmHoadonban()
        {
            InitializeComponent();
        }

        private void frmHoadonban_Load(object sender, EventArgs e)
        {
            btnThemmoi.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnInhoadon.Enabled = false;
            txtSoHDB.Enabled = true;
            txtTennhanvien.Enabled = true;
            txtTenkhach.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtTengiaydep.Enabled = true;
            txtDongia.Enabled = true;
            txtThanhtien.Enabled = true;
            txtTongtien.Enabled = true;
            txtGiamgia.Text = "0";
            txtTongtien.Text = "0";

            Quanlygiaydep.FillCombo("SELECT MaNV, TenNV FROM tblNhanvien", cboManhanvien, "MaNV", "MaNV");
            cboManhanvien.SelectedIndex = -1;
            Quanlygiaydep.FillCombo("SELECT Makhach, Tenkhach FROM tblKhachhang", cboMakhach, "Makhach", "Makhach");
            cboMakhach.SelectedIndex = -1;
            Quanlygiaydep.FillCombo("SELECT Magiaydep, Tengiaydep FROM tblSanpham", cboMagiaydep, "Magiaydep", "Magiaydep");
            cboMagiaydep.SelectedIndex = -1;

            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT a.Magiaydep, b.Tengiaydep, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien FROM tblChitietHDBan AS a, tblSanpham AS b WHERE a.SoHDB = N'" + txtSoHDB.Text + "' AND a.Magiaydep=b.Magiaydep";
            tblCTHDB = Quanlygiaydep.GetDataToTable(sql);
            DGridHoadonban.DataSource = tblCTHDB;

            DGridHoadonban.Columns[0].HeaderText = "Mã giày dép";
            DGridHoadonban.Columns[1].HeaderText = "Tên giày dép";
            DGridHoadonban.Columns[2].HeaderText = "Số lượng";
            DGridHoadonban.Columns[3].HeaderText = "Đơn giá bán";
            DGridHoadonban.Columns[4].HeaderText = "Giảm giá %";
            DGridHoadonban.Columns[5].HeaderText = "Thành tiền";
            DGridHoadonban.Columns[0].Width = 80;
            DGridHoadonban.Columns[1].Width = 130;
            DGridHoadonban.Columns[2].Width = 80;
            DGridHoadonban.Columns[3].Width = 90;
            DGridHoadonban.Columns[4].Width = 90;
            DGridHoadonban.Columns[5].Width = 90;
            DGridHoadonban.AllowUserToAddRows = false;
            DGridHoadonban.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void ResetValues()
        {
            txtSoHDB.Text = "";
            txtNgayban.Text = DateTime.Now.ToShortDateString();
            cboManhanvien.Text = "";
            cboMakhach.Text = "";
            txtTongtien.Text = "0";
            lblBangchu.Text = "Bằng chữ: ";
            cboMagiaydep.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }
        private void ResetValuesSP()
        {
            cboMagiaydep.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
        }

        private void cboManhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboManhanvien.Text == "")
                txtTennhanvien.Text = "";

            str = "SELECT TenNV FROM tblNhanvien WHERE MaNV =N'" + cboManhanvien.SelectedValue + "'";
            txtTennhanvien.Text = Quanlygiaydep.GetFieldValues(str);
        }

        private void cboMakhach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMakhach.Text == "")
            {
                txtTenkhach.Text = "";
                txtDiachi.Text = "";
                txtDienthoai.Text = "";
            }
            str = "SELECT Tenkhach FROM tblKhachhang WHERE Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtTenkhach.Text = Quanlygiaydep.GetFieldValues(str);

            str = "SELECT Diachi FROM tblKhachhang WHERE Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtDiachi.Text = Quanlygiaydep.GetFieldValues(str);

            str = "SELECT Dienthoai FROM tblKhachhang WHERE Makhach = N'" + cboMakhach.SelectedValue + "'";
            txtDienthoai.Text = Quanlygiaydep.GetFieldValues(str);
        }

        private void cboMagiaydep_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMagiaydep.Text == "")
                txtTengiaydep.Text = "";

            str = "SELECT Tengiaydep FROM tblSanpham WHERE Magiaydep =N'" + cboMagiaydep.SelectedValue + "'";
            txtTengiaydep.Text = Quanlygiaydep.GetFieldValues(str);

            str = "SELECT Dongiaban FROM tblSanpham WHERE Magiaydep =N'" + cboMagiaydep.SelectedValue + "'";
            txtDongia.Text = Quanlygiaydep.GetFieldValues(str);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            double dg, sl, gg, tt;

            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);

            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);

            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);

            tt = sl * dg - sl * dg * gg / 100;

            txtThanhtien.Text = tt.ToString();
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;

            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);

            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);

            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);

            tt = sl * dg - sl * dg * gg / 100;

            txtThanhtien.Text = tt.ToString();
        }
     
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnInhoadon.Enabled = false;
            btnThemmoi.Enabled = false;
            btnLuu.Enabled = true;
            ResetValues();
            txtSoHDB.Text = Quanlygiaydep.CreateKey("HDB");
            Load_DataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, slcon, tong, tongmoi;

            sql = "SELECT SoHDB FROM tblHoadonban WHERE SoHDB=N'" + txtSoHDB.Text + "'";
            if (!Quanlygiaydep.CheckKey(sql))
            {
                if (txtNgayban.Text.Length == 0)
                {
                    MessageBox.Show("Chưa chọn ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNgayban.Focus();
                    return;

                }
                if (cboManhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Chưa chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboManhanvien.Focus();
                    return;

                }
                if (cboMakhach.Text.Length == 0)
                {
                    MessageBox.Show("Chưa chọn mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMakhach.Focus();
                    return;
                }
                sql = "INSERT INTO tblHoadonban(SoHDB, MaNV, Ngayban, Makhach, Tongtien) VALUES(N'" + txtSoHDB.Text + "',N'" + cboManhanvien.SelectedValue + "',N'" + Quanlygiaydep.ConvertDateTime(txtNgayban.Text) + "',N'" + cboMakhach.SelectedValue + "',N'" + txtTongtien.Text + "')";
                Quanlygiaydep.RunSql(sql);
            }

            if (cboMagiaydep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa chọn mã giày dép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMagiaydep.Focus();
                return;
            }
            if ((txtSoluong.Text.Trim().Length == 0) || (txtSoluong.Text == "0"))
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }
            if (txtGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiamgia.Focus();
                return;
            }

            sql = "SELECT Magiaydep from tblChitietHDBan WHERE Magiaydep =N'" + cboMagiaydep.SelectedValue + "' AND SoHDB = N'" + txtSoHDB.Text.Trim() + "'";
            if (Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetValuesSP();
                cboMagiaydep.Focus();
                return;
            }


            sl = Convert.ToDouble(Quanlygiaydep.GetFieldValues("SELECT Soluong FROM tblSanpham WHERE Magiaydep=N'" + cboMagiaydep.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Text = "";
                txtSoluong.Focus();
                return;
            }

            sql = "INSERT INTO tblChitietHDBan(SoHDB, Magiaydep, Soluong, Giamgia, Thanhtien) VALUES(N'" + txtSoHDB.Text + "',N'" + cboMagiaydep.SelectedValue + "',N'" + txtSoluong.Text + "',N'" + txtGiamgia.Text + "',N'" + txtThanhtien.Text + "')";
            Quanlygiaydep.RunSql(sql);
            Load_DataGridView();

            slcon = sl - Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE tblSanpham SET Soluong = " + slcon + " WHERE Magiaydep =N'" + cboMagiaydep.SelectedValue + "'";
            Quanlygiaydep.RunSql(sql);

            tong = Convert.ToDouble(Quanlygiaydep.GetFieldValues("SELECT Tongtien FROM tblHoadonban WHERE SoHDB =N'" + txtSoHDB.Text + "'"));
            tongmoi = tong + Convert.ToDouble(txtThanhtien.Text);
            sql = "UPDATE tblHoadonban SET Tongtien= " + tongmoi + " WHERE SoHDB =N'" + txtSoHDB.Text + "'";
            Quanlygiaydep.RunSql(sql);

            txtTongtien.Text = tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Quanlygiaydep.ChuyenSoSangChu(tongmoi.ToString());
            ResetValuesSP();
            btnHuy.Enabled = true;
            btnThemmoi.Enabled = true;
            btnInhoadon.Enabled = true;
        }

        private void DGridHoadonban_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string magiaydep;
            Double Thanhtien;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                magiaydep = DGridHoadonban.CurrentRow.Cells["Magiaydep"].Value.ToString();
                DelHang(txtSoHDB.Text, magiaydep);

                Thanhtien = Convert.ToDouble(DGridHoadonban.CurrentRow.Cells["Thanhtien"].Value.ToString());
                DelUpdateTongtien(txtSoHDB.Text, Thanhtien);
                Load_DataGridView();
            }
        }
        private void DelHang(string Sohdb, string Magiaydep)
        {
            Double s, sl, slcon;
            string sql;
            sql = "SELECT Soluong FROM tblChitietHDBan WHERE SoHDB = N'" + Sohdb + "' AND Magiaydep = N'" + Magiaydep + "'";
            s = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));

            sql = "DELETE tblChitietHDBan WHERE SoHDB =N'" + Sohdb + "' AND Magiaydep = N'" + Magiaydep + "'";
            Quanlygiaydep.RunSqlDel(sql);

            sql = "SELECT Soluong FROM tblSanpham WHERE Magiaydep = N'" + Magiaydep + "'";
            sl = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));

            slcon = sl + s;
            sql = "UPDATE tblSanpham SET Soluong =" + slcon + " WHERE Magiaydep= N'" + Magiaydep + "'";
            Quanlygiaydep.RunSql(sql);
        }
        private void DelUpdateTongtien(string Sohdb, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT Tongtien FROM tblHoadonban WHERE SoHDB = N'" + Sohdb + "'";
            Tong = Convert.ToDouble(Quanlygiaydep.GetFieldValues(sql));

            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHoadonban SET Tongtien =" + Tongmoi + " WHERE SoHDB = N'" + Sohdb + "'";
            Quanlygiaydep.RunSql(sql);

            txtTongtien.Text = Tongmoi.ToString();
            lblBangchu.Text = "Bằng chữ: " + Quanlygiaydep.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql;
                int n = 0;
                string[] Magiaydep = new string[100];
                sql = "SELECT Magiaydep FROM tblChitietHDBan WHERE SoHDB = N'" + txtSoHDB.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Quanlygiaydep.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Magiaydep[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();

                for (int i = 0; i < n; i++)
                {
                    DelHang(txtSoHDB.Text, Magiaydep[i]);
                }

                sql = "DELETE tblHoadonban WHERE SoHDB =N'" + txtSoHDB.Text + "'";
                Quanlygiaydep.RunSql(sql);
                ResetValues();
                Load_DataGridView();
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";

            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SoHDB, a.Ngayban, a.Tongtien, b.Tenkhach, b.Diachi, b.Dienthoai, c.TenNV FROM tblHoadonban AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.SoHDB = N'" + txtSoHDB.Text + "' AND a.Makhach = b.Makhach AND a.MaNV = c.MaNV";
            tblThongtinHD = Quanlygiaydep.GetDataToTable(sql);

            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn bán:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();

            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tengiaydep, a.Soluong, b.Dongiaban, a.Giamgia, a.Thanhtien FROM tblChitietHDBan AS a , tblSanpham AS b WHERE a.SoHDB = N'" + txtSoHDB.Text + "' AND a.Magiaydep = b.Magiaydep";
            tblThongtinHang = Quanlygiaydep.GetDataToTable(sql);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên giày dép";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá bán";
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
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn bán";
            exApp.Visible = true;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
