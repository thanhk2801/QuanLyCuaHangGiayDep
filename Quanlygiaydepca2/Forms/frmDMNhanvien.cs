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
    public partial class frmDMnhanvien : System.Windows.Forms.Form
    {
        DataTable tblNhanvien;
        public frmDMnhanvien()
        {
            InitializeComponent();
        }

        private void frmDMnhanvien_Load(object sender, EventArgs e)
        {
            txtmanv.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            Class.Quanlygiaydep.FillCombo("select MaCV,TenCV from tblCongviec", cbomacv, "MaCV", "TenCV");
            cbomacv.SelectedIndex = -1;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaNV, TenNV, Gioitinh, Diachi, Dienthoai, Ngaysinh, MaCV FROM tblNhanvien";
            tblNhanvien = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridDMNhanvien.DataSource = tblNhanvien;
            dgridDMNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgridDMNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgridDMNhanvien.Columns[2].HeaderText = "Giới tính";
            dgridDMNhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgridDMNhanvien.Columns[4].HeaderText = "Điện thoại";
            dgridDMNhanvien.Columns[5].HeaderText = "Ngày sinh";
            dgridDMNhanvien.Columns[5].HeaderText = "Mã công việc";
            dgridDMNhanvien.Columns[0].Width = 100;
            dgridDMNhanvien.Columns[1].Width = 150;
            dgridDMNhanvien.Columns[2].Width = 100;
            dgridDMNhanvien.Columns[3].Width = 150;
            dgridDMNhanvien.Columns[4].Width = 100;
            dgridDMNhanvien.Columns[5].Width = 100;
            dgridDMNhanvien.AllowUserToAddRows = false;
            dgridDMNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
  
        private void ResetValues()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            chkgioitinh.Checked = false;
            txtdiachi.Text = "";
            mskngaysinh.Text = "";
            mskdienthoai.Text = "";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmanv.Enabled = true;
            txtmanv.Focus();

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtmanv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Quanlygiaydep.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (cbomacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            sql = "SELECT MaNV FROM tblNhanvien WHERE MaNV=N'" + txtmanv.Text.Trim() + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                txtmanv.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanvien(MaNV,TenNV,Gioitinh, Diachi, Dienthoai, Ngaysinh, MaCV) VALUES(N'" + txtmanv.Text.Trim() + "', N'" + txttennv.Text.Trim() + "', N'" + gt + "', N'" + txtdiachi.Text.Trim() + "', '" + mskdienthoai.Text + "', '" + Class.Quanlygiaydep.ConvertDateTime(mskngaysinh.Text) + "','" + cbomacv.SelectedValue + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Quanlygiaydep.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (cbomacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            sql = "UPDATE tblNhanvien SET  TenNV=N'" + txttennv.Text.Trim().ToString() + "',Diachi=N'" + txtdiachi.Text.Trim().ToString() + "',Dienthoai='" + mskdienthoai.Text.ToString() + "',Gioitinh=N'" + gt + "',Ngaysinh='" + Class.Quanlygiaydep.ConvertDateTime(mskngaysinh.Text) + "',MaCV=N'" + cbomacv.SelectedValue + "' WHERE MaNV=N'" + txtmanv.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanvien WHERE MaNV=N'" + txtmanv.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }

        private void dgridDMNhanvien_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
                return;
            }
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanv.Text = dgridDMNhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txttennv.Text = dgridDMNhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (dgridDMNhanvien.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkgioitinh.Checked = true;
            else
                chkgioitinh.Checked = false;
            txtdiachi.Text = dgridDMNhanvien.CurrentRow.Cells["Diachi"].Value.ToString();
            mskdienthoai.Text = dgridDMNhanvien.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskngaysinh.Text = dgridDMNhanvien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            cbomacv.Text = dgridDMNhanvien.CurrentRow.Cells["MaCV"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }
    }
}
