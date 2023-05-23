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
    public partial class frmTimHDBan : System.Windows.Forms.Form
    {
        DataTable tblTHDB;
        public frmTimHDBan()
        {
            InitializeComponent();
        }

        private void frmTimHDBan_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgridTimHDBan.DataSource = null;
         
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMagiaydep.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMagiaydep.Text == "") && (txtManhanvien.Text == "") && (txtMakhach.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT a.Magiaydep, a.SoHDB, b.MaNV, b.Ngayban, b.Makhach, b.Tongtien FROM tblChitietHDBan AS a, tblHoadonban AS b WHERE 1=1 AND a.SoHDB=b.SoHDB";
           
            if (txtMagiaydep.Text != "")
                sql = sql + " AND Magiaydep Like N'%" + txtMagiaydep.Text + "%'";
            if (txtManhanvien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtManhanvien.Text + "%'";
            if (txtMakhach.Text != "")
                sql = sql + " AND Makhach Like N'%" + txtMakhach.Text + "%'";

            tblTHDB = Class.Quanlygiaydep.GetDataToTable(sql);
            if (tblTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblTHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridTimHDBan.DataSource = tblTHDB;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridTimHDBan.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
