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
    public partial class frmDMmau : System.Windows.Forms.Form
    {
        DataTable tblMau;
        public frmDMmau()
        {
            InitializeComponent();
        }

        private void frmDMmau_Load(object sender, EventArgs e)
        {
            Class.Quanlygiaydep.Connect();
            btnluu.Enabled = false;
            txtmamau.Enabled = false;
            Load_DataGridView();
            ResetValues();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Mamau, Tenmau FROM tblMau";
            tblMau = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMMau.DataSource = tblMau;

        }
        private void ResetValues()
        {
            txtmamau.Text = "";
            txttenmau.Text = "";
        }
        private void dgridDMMau_Click(object sender, EventArgs e)
        {
          
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamau.Focus();
                return;
            }
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmamau.Text = dgridDMMau.CurrentRow.Cells["mamau"].Value.ToString();
            txttenmau.Text = dgridDMMau.CurrentRow.Cells["tenmau"].Value.ToString();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmamau.Enabled = true;
            txtmamau.Focus();

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {

            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmamau.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamau.Focus();
                return;
            }
            if (txtmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamau.Focus();
                return;
            }

            sql = "SELECT mamau FROM tblmau WHERE mamau=N'" + txtmamau.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã màu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamau.Text = "";
                txtmamau.Focus();
                return;
            }
            sql = "INSERT INTO tblMau(mamau,tenmau) VALUES(N'" + txtmamau.Text.Trim() + "',N'" + txttenmau.Text.Trim() + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmamau.Enabled = false;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenmau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmau.Focus();
                return;
            }
            sql = "UPDATE tblMau SET  TenCV=N'" + txttenmau.Text.Trim().ToString() + "'  WHERE mamau=N'" + txtmamau.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMau.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblMau WHERE mamau=N'" + txtmamau.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }
    }
}
