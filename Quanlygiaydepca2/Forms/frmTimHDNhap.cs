using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlygiaydepca2.Forms
{
    public partial class frmTimHDNhap : System.Windows.Forms.Form
    {
        DataTable tblTHDN;
        public frmTimHDNhap()
        {
            InitializeComponent();
        }

        private void DGridFindHDN_Click(object sender, EventArgs e)
        {
            ResetValues();
            DGridFindHDN.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtManhanvien.Focus();
        }
        private void Load_DataGridView()
        {
            DGridFindHDN.Columns[0].HeaderText = "Mã giày dép";
            DGridFindHDN.Columns[1].HeaderText = "Số hóa đơn nhập";
            DGridFindHDN.Columns[2].HeaderText = "Mã nhân viên";
            DGridFindHDN.Columns[3].HeaderText = "Ngày nhập";
            DGridFindHDN.Columns[5].HeaderText = "Mã nhà cung cấp";
            DGridFindHDN.Columns[4].HeaderText = "Tổng tiền";
            DGridFindHDN.Columns[0].Width = 100;
            DGridFindHDN.Columns[1].Width = 150;
            DGridFindHDN.Columns[2].Width = 80;
            DGridFindHDN.Columns[3].Width = 80;
            DGridFindHDN.Columns[4].Width = 80;
            DGridFindHDN.AllowUserToAddRows = false;
            DGridFindHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtManhanvien.Text == "") && (txtMaNCC.Text == "") && (txtMagiaydep.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.Magiaydep, a.SoHDN,b.MaNV,b.Ngaynhap,b.MaNCC,b.Tongtien from tblChitietHDNhap as a,tblHoadonnhap as b where 1=1 and a.SoHDN=b.SoHDN";
            if (txtManhanvien.Text != "")
                sql = sql + " and MaNV Like N'%" + txtManhanvien.Text + "%'";
            if (txtMaNCC.Text != "")
                sql = sql + " and MaNCC Like N'%" + txtMaNCC.Text + "%'";
            if (txtMagiaydep.Text != "")
                sql = sql + " and Magiaydep Like N'%" + txtMagiaydep.Text + "%'";

            tblTHDN = Class.Quanlygiaydep.GetDataToTable(sql);
            if (tblTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblTHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DGridFindHDN.DataSource = tblTHDN;
            Load_DataGridView();
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DGridFindHDN.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
