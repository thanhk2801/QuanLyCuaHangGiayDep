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
    public partial class frmdmco : System.Windows.Forms.Form
    {
        DataTable tblC;
        public frmdmco()
        {
            InitializeComponent();
        }

        private void frmdmco_Load(object sender, EventArgs e)
        {
            txtmaco.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Maco, Tenco FROM tblCo";
            tblC = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMco.DataSource = tblC;
        }

        private void dgridDMco_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaco.Focus();
                return;
            }
            if (tblC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaco.Text = dgridDMco.CurrentRow.Cells["Maco"].Value.ToString();
            txttenco.Text = dgridDMco.CurrentRow.Cells["Tenco"].Value.ToString();
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
            txtmaco.Enabled = true;
            txtmaco.Focus();

        }
        private void ResetValues()
        {
            txtmaco.Text = "";
            txttenco.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaco.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaco.Focus();
                return;
            }
            if (txttenco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenco.Focus();
                return;
            }
            sql = "SELECT Maco FROM tblCo WHERE Maco =N'" + txtmaco.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã cỡ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaco.Focus();
                txtmaco.Text = "";
                return;
            }
            sql = "INSERT INTO tblCo(Maco,Tenco) VALUES(N'" + txtmaco.Text + "',N'" + txttenco.Text + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmaco.Enabled = false;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaco.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenco.Focus();
                return;
            }
            sql = "UPDATE tblCo SET Tenco=N'" + txttenco.Text.ToString() + "' WHERE Maco=N'" + txtmaco.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaco.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblCo WHERE Maco =N'" + txtmaco.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }


        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaco.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
