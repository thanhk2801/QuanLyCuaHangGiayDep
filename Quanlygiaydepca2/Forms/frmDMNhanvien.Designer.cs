
namespace Quanlygiaydepca2.Forms
{
    partial class frmDMnhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgridDMNhanvien = new System.Windows.Forms.DataGridView();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblmacv = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lbldmnhanvien = new System.Windows.Forms.Label();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.chkgioitinh = new System.Windows.Forms.CheckBox();
            this.cbomacv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(599, 407);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 55;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(489, 407);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(87, 23);
            this.btnboqua.TabIndex = 54;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(372, 407);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(87, 23);
            this.btnluu.TabIndex = 53;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(250, 407);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(87, 23);
            this.btnsua.TabIndex = 52;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(139, 407);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 23);
            this.btnxoa.TabIndex = 51;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(17, 407);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 23);
            this.btnthem.TabIndex = 50;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMNhanvien
            // 
            this.dgridDMNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMNhanvien.Location = new System.Drawing.Point(17, 204);
            this.dgridDMNhanvien.Name = "dgridDMNhanvien";
            this.dgridDMNhanvien.RowHeadersWidth = 62;
            this.dgridDMNhanvien.Size = new System.Drawing.Size(669, 179);
            this.dgridDMNhanvien.TabIndex = 49;
            this.dgridDMNhanvien.Click += new System.EventHandler(this.dgridDMNhanvien_Click);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(171, 93);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(112, 20);
            this.txttennv.TabIndex = 48;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(171, 53);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(112, 20);
            this.txtmanv.TabIndex = 47;
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.Location = new System.Drawing.Point(62, 97);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(44, 13);
            this.lbltennv.TabIndex = 46;
            this.lbltennv.Text = "Tên NV";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(59, 57);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(40, 13);
            this.lblmanv.TabIndex = 45;
            this.lblmanv.Text = "Mã NV";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(63, 142);
            this.lblgioitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(47, 13);
            this.lblgioitinh.TabIndex = 58;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(171, 179);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(68, 20);
            this.txtdiachi.TabIndex = 62;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(65, 183);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(40, 13);
            this.lbldiachi.TabIndex = 63;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblmacv
            // 
            this.lblmacv.AutoSize = true;
            this.lblmacv.Location = new System.Drawing.Point(392, 142);
            this.lblmacv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmacv.Name = "lblmacv";
            this.lblmacv.Size = new System.Drawing.Size(39, 13);
            this.lblmacv.TabIndex = 64;
            this.lblmacv.Text = "Mã CV";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Location = new System.Drawing.Point(392, 97);
            this.lbldienthoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(55, 13);
            this.lbldienthoai.TabIndex = 65;
            this.lbldienthoai.Text = "Điện thoại";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(392, 57);
            this.lblngaysinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblngaysinh.TabIndex = 66;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // lbldmnhanvien
            // 
            this.lbldmnhanvien.AutoSize = true;
            this.lbldmnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmnhanvien.Location = new System.Drawing.Point(225, 9);
            this.lbldmnhanvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmnhanvien.Name = "lbldmnhanvien";
            this.lbldmnhanvien.Size = new System.Drawing.Size(244, 25);
            this.lbldmnhanvien.TabIndex = 67;
            this.lbldmnhanvien.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(477, 93);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(2);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(91, 20);
            this.mskdienthoai.TabIndex = 69;
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Location = new System.Drawing.Point(477, 53);
            this.mskngaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(91, 20);
            this.mskngaysinh.TabIndex = 68;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // chkgioitinh
            // 
            this.chkgioitinh.AutoSize = true;
            this.chkgioitinh.Location = new System.Drawing.Point(171, 142);
            this.chkgioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.chkgioitinh.Name = "chkgioitinh";
            this.chkgioitinh.Size = new System.Drawing.Size(48, 17);
            this.chkgioitinh.TabIndex = 70;
            this.chkgioitinh.Text = "Nam";
            this.chkgioitinh.UseVisualStyleBackColor = true;
            // 
            // cbomacv
            // 
            this.cbomacv.FormattingEnabled = true;
            this.cbomacv.Location = new System.Drawing.Point(477, 134);
            this.cbomacv.Name = "cbomacv";
            this.cbomacv.Size = new System.Drawing.Size(91, 21);
            this.cbomacv.TabIndex = 71;
            // 
            // frmDMnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 446);
            this.Controls.Add(this.cbomacv);
            this.Controls.Add(this.chkgioitinh);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.lbldmnhanvien);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lblmacv);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMNhanvien);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.lbltennv);
            this.Controls.Add(this.lblmanv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDMnhanvien";
            this.Text = "DANH MỤC NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmDMnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgridDMNhanvien;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblmacv;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lbldmnhanvien;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.CheckBox chkgioitinh;
        private System.Windows.Forms.ComboBox cbomacv;
    }
}