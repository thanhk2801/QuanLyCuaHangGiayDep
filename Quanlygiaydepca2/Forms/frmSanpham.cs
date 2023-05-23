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
    public partial class frmSanpham : System.Windows.Forms.Form
    {
        DataTable tblSP;
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
           
            Load_DataGridView();
            Class.Quanlygiaydep.FillCombo("select Maloai,Tenloai from tblTheloai", cbomaloai, "Maloai", "Tenloai");
            cbomaloai.SelectedIndex = -1;
            Class.Quanlygiaydep.FillCombo("select Maco,Tenco from tblCo", cbomaco, "Maco", "Tenco");
            cbomaco.SelectedIndex = -1;
            Class.Quanlygiaydep.FillCombo("select Machatlieu,Tenchatlieu from tblChatlieu", cbomachatlieu, "Machatlieu", "Tenchatlieu");
            cbomachatlieu.SelectedIndex = -1;
            Class.Quanlygiaydep.FillCombo("select Mamau,Tenmau from tblMau", cbomamau, "Mamau", "Tenmau");
            cbomamau.SelectedIndex = -1;
            Class.Quanlygiaydep.FillCombo("select Madoituong,Tendoituong from tblDoituong", cbomadoituong, "Madoituong", "Tendoituong");
            cbomadoituong.SelectedIndex = -1;
            Class.Quanlygiaydep.FillCombo("select Mamua,Tenmua from tblMua", cbomamua, "Mamua", "Tenmua");
            cbomamua.SelectedIndex = -1;
            Class.Quanlygiaydep.FillCombo("select ManuocSX,TennuocSX from tblNuocsanxuat", cbomansx, "ManuocSX", "TennuocSX");
            cbomansx.SelectedIndex = -1;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select Magiaydep,Tengiaydep,Maloai,Maco,Machatlieu,Mamau,Madoituong,Mamua,ManuocSX,Dongianhap,Dongiaban,Soluong,Anh from tblSanpham";
            tblSP = Class.Quanlygiaydep.GetDataToTable(sql);
            dgridSanpham.DataSource = tblSP;
            dgridSanpham.Columns[0].HeaderText = "Mã giày dép";
            dgridSanpham.Columns[1].HeaderText = "Tên giày dép";
            dgridSanpham.Columns[2].HeaderText = "Mã loại";
            dgridSanpham.Columns[3].HeaderText = "Mã cỡ";
            dgridSanpham.Columns[4].HeaderText = "Mã chất liệu";
            dgridSanpham.Columns[5].HeaderText = "Mã màu";
            dgridSanpham.Columns[6].HeaderText = "Mã đối tượng";
            dgridSanpham.Columns[7].HeaderText = "Mã mùa";
            dgridSanpham.Columns[8].HeaderText = "Mã nước sản xuất";
            dgridSanpham.Columns[9].HeaderText = "Đơn giá nhập";
            dgridSanpham.Columns[10].HeaderText = "Đơn giá bán";
            dgridSanpham.Columns[11].HeaderText = "Số lượng";
            dgridSanpham.Columns[12].HeaderText = "Ảnh";
            dgridSanpham.Columns[1].Width = 140;
            dgridSanpham.AllowUserToAddRows = false;
            dgridSanpham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridSanpham_Click(object sender, EventArgs e)
        {
            string ma, ma1, ma2, ma3, ma4, ma5, ma6;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmagiaydep.Focus();
                return;

            }
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmagiaydep.Text = dgridSanpham.CurrentRow.Cells["Magiaydep"].Value.ToString();
            txttengiaydep.Text = dgridSanpham.CurrentRow.Cells["Tengiaydep"].Value.ToString();
            ma = dgridSanpham.CurrentRow.Cells["Maloai"].Value.ToString();
            cbomaloai.Text = Class.Quanlygiaydep.GetFieldValues("select Tenloai from tblTheloai where Maloai=N'" + ma + "'");
            ma1 = dgridSanpham.CurrentRow.Cells["Maco"].Value.ToString();
            cbomaco.Text = Class.Quanlygiaydep.GetFieldValues("select Tenco from tblCo where Maco=N'" + ma1 + "'");
            ma2 = dgridSanpham.CurrentRow.Cells["Machatlieu"].Value.ToString();
            cbomachatlieu.Text = Class.Quanlygiaydep.GetFieldValues("select Tenchatlieu from tblChatlieu where Machatlieu=N'" + ma2 + "'");
            ma3 = dgridSanpham.CurrentRow.Cells["Mamau"].Value.ToString();
            cbomamau.Text = Class.Quanlygiaydep.GetFieldValues("select Tenmau from tblMau where Mamau=N'" + ma3 + "'");
            ma4 = dgridSanpham.CurrentRow.Cells["Madoituong"].Value.ToString();
            cbomadoituong.Text = Class.Quanlygiaydep.GetFieldValues("select Tendoituong from tblDoituong where Madoituong=N'" + ma4 + "'");
            ma5 = dgridSanpham.CurrentRow.Cells["Mamua"].Value.ToString();
            cbomamua.Text = Class.Quanlygiaydep.GetFieldValues("select Tenmua from tblMua where Mamua=N'" + ma5 + "'");
            ma6 = dgridSanpham.CurrentRow.Cells["ManuocSX"].Value.ToString();
            cbomansx.Text = Class.Quanlygiaydep.GetFieldValues("select TennuocSX from tblNuocsanxuat where ManuocSX=N'" + ma6 + "'");
            txtdongiaban.Text = dgridSanpham.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtdongianhap.Text = dgridSanpham.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtsoluong.Text = dgridSanpham.CurrentRow.Cells["Soluong"].Value.ToString();
            
            txtanh.Text = Class.Quanlygiaydep.GetFieldValues("select Anh from tblSanpham where Magiaydep=N'" + txtmagiaydep.Text + "'");
            picanh.Image = Image.FromFile(txtanh.Text);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            txtmagiaydep.Enabled = false;
        }
        private void ResetValues()
        {
            txtmagiaydep.Text = "";
            txttengiaydep.Text = "";
            cbomachatlieu.Text = "";
            cbomaco.Text = "";
            cbomadoituong.Text = "";
            cbomaloai.Text = "";
            cbomamau.Text = "";
            cbomamua.Text = "";
            cbomansx.Text = "";
            txtsoluong.Text = "0";
            txtdongiaban.Text = "0";
            txtdongianhap.Text = "0";
            txtanh.Text = "";
            picanh.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtmagiaydep.Enabled = true;
            txtmagiaydep.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmagiaydep.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giày dép", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmagiaydep.Focus();
                return;
            }
            if (txttengiaydep.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giày dép", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttengiaydep.Focus();
                return;
            }
            if (cbomachatlieu.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomachatlieu.Focus();
                return;
            }
            if (cbomaco.Text.Length == 0)

            {
                MessageBox.Show("Bạn phải nhập mã cỡ ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaco.Focus();
                return;
            }
            if (cbomadoituong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đối tượng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomadoituong.Focus();
                return;
            }
            if (cbomaloai.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (cbomamau.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamau.Focus();
                return;
            }
            if (cbomamua.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;

            }
            if (cbomansx.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà sản xuât", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomansx.Focus();
                return;
            }
            if (txtanh.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }

            sql = "select Magiaydep from tblSanpham where Magiaydep=N'" + txtmagiaydep.Text + "'";
            if (Class.Quanlygiaydep.CheckKey(sql))
            {
                MessageBox.Show("Mã giày dép này đã có, phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmagiaydep.Focus();
                return;
            }
            sql = "insert into tblSanpham(Magiaydep,Tengiaydep,Maloai,Maco,Machatlieu,Mamau,Madoituong,Mamua,ManuocSX,Soluong,Dongianhap,Dongiaban,Anh) values (N'" + txtmagiaydep.Text + "',N'" + txttengiaydep.Text + "',N'" + cbomaloai.SelectedValue.ToString() + "',N'" +
                cbomaco.SelectedValue.ToString() + "',N'" + cbomachatlieu.SelectedValue.ToString() + "',N'" +
                cbomamau.SelectedValue.ToString() + "',N'" + cbomadoituong.SelectedValue.ToString() + "',N'" +
                cbomamua.SelectedValue.ToString() + "',N'" + cbomansx.SelectedValue.ToString() + "'," + txtsoluong.Text + "," +
                txtdongianhap.Text + "," + txtdongiaban.Text + ",N'" + txtanh.Text + "')";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmagiaydep.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttengiaydep.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giày dép", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttengiaydep.Focus();
                return;
            }
            if (cbomachatlieu.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomachatlieu.Focus();
                return;
            }
            if (cbomaco.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã cỡ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaco.Focus();
                return;
            }
            if (cbomadoituong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đối tượng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomadoituong.Focus();
                return;
            }
            if (cbomaloai.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (cbomamau.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamau.Focus();
                return;
            }
            if (cbomamua.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã mùa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;
            }
            if (cbomansx.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà sản xuất", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomansx.Focus();
                return;
            }
            if (txtanh.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }
            sql = "UPDATE tblSanpham SET  Tengiaydep=N'" + txttengiaydep.Text.ToString() +
                "',Maloai=N'" + cbomaloai.SelectedValue.ToString() + "',Maco=N'" + cbomaco.SelectedValue.ToString() + "',Machatlieu=N'" +
                cbomachatlieu.SelectedValue.ToString() + "',Mamau=N'" + cbomamau.SelectedValue.ToString() + "',Madoituong=N'" +
                cbomadoituong.SelectedValue.ToString() + "',Mamua=N'" + cbomamua.SelectedValue.ToString() + "',ManuocSX=N'" +
                cbomansx.SelectedValue.ToString() + "',Anh=N'"+ txtanh.Text.ToString() + "' WHERE Magiaydep=N'" + txtmagiaydep.Text + "'";
            Class.Quanlygiaydep.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmagiaydep.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblSanpham WHERE Magiaydep=N'" + txtmagiaydep.Text + "'";
                Class.Quanlygiaydep.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmagiaydep.Enabled = true;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap|*.btm|Gif|*.gif|All files|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chon hinh anh";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picanh.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmagiaydep.Text == "") && (txttengiaydep.Text == "") && (cbomachatlieu.Text == "") && (cbomaco.Text == "")
               && (cbomadoituong.Text == "") && (cbomaloai.Text == "") && (cbomamau.Text == "") && (cbomamua.Text == "") && (cbomansx.Text == ""))
            {
                MessageBox.Show("Nhập một điều kiện tìm kiếm", "yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblSanpham WHERE 1=1";
            if (txtmagiaydep.Text != "")
                sql = sql + " AND Magiaydep Like N'%" + txtmagiaydep.Text + "%'";
            if (txttengiaydep.Text != "")
                sql = sql + " AND Tengiaydep Like N'%" + txttengiaydep.Text + "%'";
            if (cbomachatlieu.Text != "")
                sql = sql + " AND Machatlieu Like N'%" + cbomachatlieu.SelectedValue + "%'";
            if (cbomaco.Text != "")
                sql = sql + "and Maco like N'%" + cbomaco.SelectedValue + "%'";
            if (cbomadoituong.Text != "")
                sql = sql + "and Madoituong like '%" + cbomadoituong.SelectedValue + "%'";
            if (cbomaloai.Text != "")
                sql = sql + "and Maloai like '%" + cbomaloai.SelectedValue + "%'";
            if (cbomamau.Text != "")
                sql = sql + "and Mamau like '%" + cbomamau.SelectedValue + "%'";
            if (cbomamua.Text != "")
                sql = sql + "and Mamua like '%" + cbomamua.SelectedValue + "%'";
            if (cbomansx.Text != "")
                sql = sql + "and ManuocSX like '%" + cbomansx.SelectedValue + "%'";

            tblSP = Class.Quanlygiaydep.GetDataToTable(sql);
            if (tblSP.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblSP.Rows.Count + " bản ghi thỏa mãn điều kiện","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dgridSanpham.DataSource = tblSP;
            ResetValues();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
