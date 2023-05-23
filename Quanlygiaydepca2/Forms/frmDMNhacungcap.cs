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
    public partial class frmDMNhacungcap : System.Windows.Forms.Form
    {
        DataTable tblNhacc;
        public frmDMNhacungcap()
        {
            InitializeComponent();
        }

        private void frmDMNhacungcap_Load(object sender, EventArgs e)
        {
            txtmancc.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaNCC, TenNCC, Diachi, Dienthoai FROM tblNhacungcap";
            tblNhacc = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMnhacungcap.DataSource = tblNhacc;
        }

        private void dgridDMnhacungcap_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmancc.Focus();
                return;
            }
            if (tblNhacc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmancc.Text = dgridDMnhacungcap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txttenncc.Text = dgridDMnhacungcap.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtdiachi.Text = dgridDMnhacungcap.CurrentRow.Cells["Diachi"].Value.ToString();
            mskdienthoai.Text = dgridDMnhacungcap.CurrentRow.Cells["Dienthoai"].Value.ToString();
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
            txtmancc.Enabled = true;
            txtmancc.Focus();

        }
        private void ResetValues()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmancc.Focus();
                return;
            }
            if (txttenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenncc.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }

            sql = "SELECT MaNCC FROM tblNhacungcap WHERE MaNCC=N'" + txtmancc.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmancc.Focus();
                txtmancc.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhacungcap(MaNCC,TenNCC, Diachi, Dienthoai) VALUES(N'" + txtmancc.Text.Trim() + "', N'" + txttenncc.Text.Trim() + "', N'" + txtdiachi.Text.Trim() + "', '" + mskdienthoai.Text + "' )";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmancc.Enabled = false;


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhacc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenncc.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "UPDATE tblNhacungcap SET  TenNCC=N'" + txttenncc.Text.Trim().ToString() + "',Diachi=N'" + txtdiachi.Text.Trim().ToString() + "',Dienthoai='" + mskdienthoai.Text.ToString() + "' WHERE MaNCC=N'" + txtmancc.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhacc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhacungcap WHERE MaNCC=N'" + txtmancc.Text + "'";
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
            txtmancc.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
