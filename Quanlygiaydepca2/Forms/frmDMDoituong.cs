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

    public partial class frmDMdoituong : System.Windows.Forms.Form
    {
        DataTable tblDoituong;
        public frmDMdoituong()
        {
            InitializeComponent();
        }

        private void frmDMdoituong_Load(object sender, EventArgs e)
        {
            Class.Quanlygiaydep.Connect();
            btnluu.Enabled = false;
            txtmadoituong.Enabled = false;
            Load_DataGridView();
            ResetValues();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT madoituong, tendoituong FROM tblDoituong";
            tblDoituong = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMdoituong.DataSource = tblDoituong;

        }
        private void ResetValues()
        {
            txtmadoituong.Text = "";
            txttendoituong.Text = "";
        }
        private void dgridDMdoituong_Click(object sender, EventArgs e)
        {
          
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmadoituong.Focus();
                return;
            }
            if (tblDoituong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmadoituong.Text = dgridDMdoituong.CurrentRow.Cells["madoituong"].Value.ToString();
            txttendoituong.Text = dgridDMdoituong.CurrentRow.Cells["tendoituong"].Value.ToString();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmadoituong.Enabled = true;
            txtmadoituong.Focus();

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmadoituong.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadoituong.Focus();
                return;
            }
            if (txtmadoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadoituong.Focus();
                return;
            }

            sql = "SELECT Madoituong FROM tblDoituong WHERE Madoituong=N'" + txtmadoituong.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã đối tượng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadoituong.Text = "";
                txtmadoituong.Focus();
                return;
            }
            sql = "INSERT INTO tblDoituong(madoituong,tendoituong) VALUES(N'" + txtmadoituong.Text.Trim() + "',N'" + txttendoituong.Text.Trim() + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmadoituong.Enabled = false;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDoituong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmadoituong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttendoituong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendoituong.Focus();
                return;
            }
            sql = "UPDATE tblDoituong SET  tendoituong=N'" + txttendoituong.Text.Trim().ToString() + "'  WHERE madoituong=N'" + txtmadoituong.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDoituong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmadoituong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblDoituong WHERE madoituong=N'" + txtmadoituong.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }
    }
}
