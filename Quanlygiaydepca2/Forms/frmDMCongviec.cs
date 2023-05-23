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
    public partial class frmDMcongviec : System.Windows.Forms.Form
    {
        DataTable tblCongviec;
        public frmDMcongviec()
        {
            InitializeComponent();
        }

        private void frmDMcongviec_Load(object sender, EventArgs e)
        {
            Class.Quanlygiaydep.Connect();
            btnluu.Enabled = false;
            txtmacv.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaCV, TenCV FROM tblCongviec";
            tblCongviec = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMcongviec.DataSource = tblCongviec;

        }
        private void ResetValues()
        {
            txtmacv.Text = "";
            txttencv.Text = "";
        }
        private void dgridDMcongviec_Click(object sender, EventArgs e)
        {
         
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacv.Focus();
                return;
            }
            if (tblCongviec.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmacv.Text = dgridDMcongviec.CurrentRow.Cells["MaCV"].Value.ToString();
            txttencv.Text = dgridDMcongviec.CurrentRow.Cells["TenCV"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmacv.Enabled = true;
            txtmacv.Focus();

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmacv.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmacv.Focus();
                return;
            }
            if (txtmacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmacv.Focus();
                return;
            }

            sql = "SELECT MaCV FROM tblCongviec WHERE MaCV=N'" + txtmacv.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã công việc này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmacv.Text = "";
                txtmacv.Focus();
                return;
            }
            sql = "INSERT INTO tblCongviec(MaCV,TenCV) VALUES(N'" + txtmacv.Text.Trim() + "',N'" + txttencv.Text.Trim() + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmacv.Enabled = false;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblCongviec.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmacv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencv.Focus();
                return;
            }
            sql = "UPDATE tblCongviec SET  TenCV=N'" + txttencv.Text.Trim().ToString() + "'  WHERE MaCV=N'" + txtmacv.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCongviec.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmacv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblCongviec WHERE MaCV=N'" + txtmacv.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }
    }
}
