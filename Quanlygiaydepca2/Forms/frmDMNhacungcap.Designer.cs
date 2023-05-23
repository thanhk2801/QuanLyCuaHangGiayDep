
namespace Quanlygiaydepca2.Forms
{
    partial class frmDMNhacungcap
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
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbltenncc = new System.Windows.Forms.Label();
            this.lblmancc = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgridDMnhacungcap = new System.Windows.Forms.DataGridView();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.lbldmnhacungcap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMnhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(183, 167);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 20);
            this.txtdiachi.TabIndex = 48;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(183, 123);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(100, 20);
            this.txttenncc.TabIndex = 47;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(183, 70);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(100, 20);
            this.txtmancc.TabIndex = 46;
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Location = new System.Drawing.Point(65, 214);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(55, 13);
            this.lbldienthoai.TabIndex = 45;
            this.lbldienthoai.Text = "Điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(65, 174);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(40, 13);
            this.lbldiachi.TabIndex = 44;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lbltenncc
            // 
            this.lbltenncc.AutoSize = true;
            this.lbltenncc.Location = new System.Drawing.Point(65, 123);
            this.lbltenncc.Name = "lbltenncc";
            this.lbltenncc.Size = new System.Drawing.Size(51, 13);
            this.lbltenncc.TabIndex = 43;
            this.lbltenncc.Text = "Tên NCC";
            // 
            // lblmancc
            // 
            this.lblmancc.AutoSize = true;
            this.lblmancc.Location = new System.Drawing.Point(68, 78);
            this.lblmancc.Name = "lblmancc";
            this.lblmancc.Size = new System.Drawing.Size(47, 13);
            this.lblmancc.TabIndex = 42;
            this.lblmancc.Text = "Mã NCC";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(643, 402);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 55;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(519, 402);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 54;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(393, 402);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 53;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(279, 402);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 52;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(159, 402);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 51;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(33, 402);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 50;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMnhacungcap
            // 
            this.dgridDMnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMnhacungcap.Location = new System.Drawing.Point(43, 246);
            this.dgridDMnhacungcap.Name = "dgridDMnhacungcap";
            this.dgridDMnhacungcap.RowHeadersWidth = 62;
            this.dgridDMnhacungcap.Size = new System.Drawing.Size(682, 138);
            this.dgridDMnhacungcap.TabIndex = 56;
            this.dgridDMnhacungcap.Click += new System.EventHandler(this.dgridDMnhacungcap_Click);
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(183, 206);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(100, 20);
            this.mskdienthoai.TabIndex = 58;
            // 
            // lbldmnhacungcap
            // 
            this.lbldmnhacungcap.AutoSize = true;
            this.lbldmnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmnhacungcap.Location = new System.Drawing.Point(264, 20);
            this.lbldmnhacungcap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmnhacungcap.Name = "lbldmnhacungcap";
            this.lbldmnhacungcap.Size = new System.Drawing.Size(291, 25);
            this.lbldmnhacungcap.TabIndex = 59;
            this.lbldmnhacungcap.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // frmDMNhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldmnhacungcap);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.dgridDMnhacungcap);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lbltenncc);
            this.Controls.Add(this.lblmancc);
            this.Name = "frmDMNhacungcap";
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.frmDMNhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMnhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbltenncc;
        private System.Windows.Forms.Label lblmancc;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgridDMnhacungcap;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Label lbldmnhacungcap;
    }
}