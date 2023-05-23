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
    public partial class frmdmmua : System.Windows.Forms.Form
    {
        DataTable tblMu;
        public frmdmmua()
        {
            InitializeComponent();
        }

        private void frmdmmua_Load(object sender, EventArgs e)
        {

            txtmamua.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Mamua, Tenmua FROM tblMua";
            tblMu = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMmua.DataSource = tblMu;
        }

        private void dgridDMmua_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamua.Focus();
                return;
            }
            if (tblMu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmamua.Text = dgridDMmua.CurrentRow.Cells["Mamua"].Value.ToString();
            txttenmua.Text = dgridDMmua.CurrentRow.Cells["Tenmua"].Value.ToString();
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
            txtmamua.Enabled = true;
            txtmamua.Focus();

        }
        private void ResetValues()
        {
            txtmamua.Text = "";
            txttenmua.Text = "";
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamua.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblMua WHERE Mamua =N'" + txtmamua.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
                string sql;
                if (tblMu.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtmamua.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txttenmua.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenmua.Focus();
                    return;
                }
                sql = "UPDATE tblMua SET Tenmua=N'" + txttenmua.Text.ToString() + "' WHERE Mamua=N'" + txtmamua.Text + "'";
                Class.Quanlygiaydep.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmamua.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamua.Focus();
                return;
            }
            if (txttenmua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmua.Focus();
                return;
            }
            sql = "SELECT Mamua FROM tblMua WHERE Mamua =N'" + txtmamua.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã mùa này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamua.Focus();
                txtmamua.Text = "";
                return;
            }
            sql = "INSERT INTO tblMua(Mamua,Tenmua) VALUES(N'" + txtmamua.Text + "',N'" + txttenmua.Text + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmamua.Enabled = false;

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmamua.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
