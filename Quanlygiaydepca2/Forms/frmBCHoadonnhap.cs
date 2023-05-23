using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using Quanlygiaydepca2.Class;

namespace Quanlygiaydepca2.Forms
{
    public partial class frmBCHoadonnhap : Form
    {
        DataTable tblBCHDN;
        public frmBCHoadonnhap()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            txtChonquy.Text = "";
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtChonquy.Text == "")
            {
                MessageBox.Show("Bạn chưa điền quý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChonquy.Focus();
                return;
            }
            sql = "SELECT SoHDN, MaNV, Ngaynhap, MaNCC, Tongtien, DATEPART(QUARTER, Ngaynhap) AS Quy FROM tblHoadonnhap WHERE 1=1";
            if (txtChonquy.Text != "")
                sql = sql + "and DATEPART(QUARTER, Ngaynhap) ='" + txtChonquy.Text + "'";
            tblBCHDN = Quanlygiaydep.GetDataToTable(sql);

            if (tblBCHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblBCHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DGridBCHoadonnhap.DataSource = tblBCHDN;
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
            DataTable tblThongtinHD;
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
            exRange.Range["C2:E2"].Value = "BÁO CÁO HÓA ĐƠN NHẬP";

            //Lấy thông tin của hóa đơn nhập
            sql = "SELECT SoHDN, Ngaynhap, MaNV, MaNCC, Tongtien, DATEPART(QUARTER, Ngaynhap) AS Quy FROM tblHoadonnhap WHERE DATEPART(QUARTER, Ngaynhap) = '" + txtChonquy.Text + "'";
            tblThongtinHD = Quanlygiaydep.GetDataToTable(sql);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A6:G6"].Font.Bold = true;
            exRange.Range["A6:G6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B6:C6"].ColumnWidth = 20;
            exRange.Range["D6:E6"].ColumnWidth = 15;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn nhập";
            exRange.Range["C6:C6"].Value = "Ngày nhập";
            exRange.Range["D6:D6"].Value = "Mã nhân viên";
            exRange.Range["E6:E6"].Value = "Mã nhà cung cấp";
            exRange.Range["F6:F6"].Value = "Tổng tiền";
            exRange.Range["G6:G6"].Value = "Quý";
            for (hang = 0; hang <= tblThongtinHD.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 7
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot <= tblThongtinHD.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 7
                    exSheet.Cells[cot + 2][hang + 7] = tblThongtinHD.Rows[hang][cot].ToString();
            }

            exRange = exSheet.Cells[5][hang + 12]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exSheet.Name = "Báo cáo hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
