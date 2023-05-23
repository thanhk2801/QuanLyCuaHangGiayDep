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
    public partial class frmDMNuocSX : System.Windows.Forms.Form
    {
        DataTable tblNSX;
        public frmDMNuocSX()
        {
            InitializeComponent();
        }

        private void frmDMNuocSX_Load(object sender, EventArgs e)
        {
            txtmanuocsx.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT ManuocSX, TennuocSX FROM tblNuocsanxuat";
            tblNSX = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMnuocsx.DataSource = tblNSX;
        }

        private void dgridDMnuocsx_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanuocsx.Focus();
                return;
            }
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanuocsx.Text = dgridDMnuocsx.CurrentRow.Cells["ManuocSX"].Value.ToString();
            txttennuocsx.Text = dgridDMnuocsx.CurrentRow.Cells["TennuocSX"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmanuocsx.Enabled = true;
            txtmanuocsx.Focus();

        }
        private void ResetValues()
        {
            txtmanuocsx.Text = "";
            txttennuocsx.Text = "";

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmanuocsx.Text =="")
            {
                MessageBox.Show("Bạn phải nhập mã nước sản xuất", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanuocsx.Focus();
                return;
            }
            if (txttennuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennuocsx.Focus();
                return;
            }
            sql = "SELECT ManuocSX FROM tblNuocsanxuat WHERE ManuocSX=N'" +txtmanuocsx.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã nước sản xuất này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanuocsx.Focus();
                txtmanuocsx.Text = "";
                return;
            }
            sql = "INSERT INTO tblNuocsanxuat(ManuocSX,TennuocSX) VALUES(N'" +txtmanuocsx.Text + "',N'" + txttennuocsx.Text + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmanuocsx.Enabled = false;


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanuocsx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennuocsx.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennuocsx.Focus();
                return;
            }

            sql = "UPDATE tblNuocsanxuat SET TennuocSX =N'" + txttennuocsx.Text.ToString() + "' WHERE ManuocSX=N'" + txtmanuocsx.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanuocsx.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanuocsx.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNuocsanxuat WHERE ManuocSX=N'" + txtmanuocsx.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }


        }
    }
}
