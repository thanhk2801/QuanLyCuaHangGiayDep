using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlygiaydepca2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Quanlygiaydep.Connect();

        }

        private void mnuHoadonnhap_Click(object sender, EventArgs e)
        {
            Forms.frmHoadonnhap f = new Forms.frmHoadonnhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuHoadonban_Click(object sender, EventArgs e)
        {
            Forms.frmHoadonban f = new Forms.frmHoadonban();
            f.Show();
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            Forms.frmdmchatlieu f = new Forms.frmdmchatlieu();
            f.Show();
        }

        private void mnuCo_Click(object sender, EventArgs e)
        {
            Forms.frmdmco f = new Forms.frmdmco();
            f.Show();
        }

        private void mnuCongviec_Click(object sender, EventArgs e)
        {
            Forms.frmDMcongviec f = new Forms.frmDMcongviec();
            f.Show();
        }

        private void mnuDoituong_Click(object sender, EventArgs e)
        {
            Forms.frmDMdoituong f = new Forms.frmDMdoituong();
            f.Show();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.frmdmkhachhang f = new Forms.frmdmkhachhang();
            f.Show();
        }

        private void mnuMau_Click(object sender, EventArgs e)
        {
            Forms.frmDMmau f = new Forms.frmDMmau();
            f.Show();
        }

        private void mnuMua_Click(object sender, EventArgs e)
        {
            Forms.frmdmmua f = new Forms.frmdmmua();
            f.Show();
        }

        private void mnuNhaCC_Click(object sender, EventArgs e)
        {
            Forms.frmDMNhacungcap f = new Forms.frmDMNhacungcap();
            f.Show();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            Forms.frmDMnhanvien f = new Forms.frmDMnhanvien();
            f.Show();

        }

        private void mnuNuocSX_Click(object sender, EventArgs e)
        {
            Forms.frmDMNuocSX f = new Forms.frmDMNuocSX();
            f.Show();
        }

        private void mnuTheloai_Click(object sender, EventArgs e)
        {
            Forms.frmdmtheloai f = new Forms.frmdmtheloai();
            f.Show();
        }

        private void mnuSanpham_Click(object sender, EventArgs e)
        {
            Forms.frmSanpham f = new Forms.frmSanpham();
            f.Show();
        }

        private void mnuFindHDB_Click(object sender, EventArgs e)
        {
            Forms.frmTimHDBan f = new Forms.frmTimHDBan();
            f.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }


        private void mnuBCHangton_Click(object sender, EventArgs e)
        {
            Forms.frmBCHangtonkho f = new Forms.frmBCHangtonkho();
            f.Show();
        }

        private void mnuBCHoadonnhap_Click(object sender, EventArgs e)
        {
            Forms.frmBCHoadonnhap f = new Forms.frmBCHoadonnhap();
            f.Show();
        }

        private void frmBDHoadonban_Click(object sender, EventArgs e)
        {
            Forms.frmBCHoadonban f = new Forms.frmBCHoadonban();
            f.Show();
        }

        private void frmBDKhachhang_Click(object sender, EventArgs e)
        {
            Forms.frmBCKhachhang f = new Forms.frmBCKhachhang();
            f.Show();
        }

        private void mnuFindHDN_Click(object sender, EventArgs e)
        {
            Forms.frmTimHDNhap f = new Forms.frmTimHDNhap();
            f.Show();
        }
    }
}
