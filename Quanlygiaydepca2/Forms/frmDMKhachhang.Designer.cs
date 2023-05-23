
namespace Quanlygiaydepca2.Forms
{
    partial class frmdmkhachhang
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
            this.dgridDMkhachhang = new System.Windows.Forms.DataGridView();
            this.lblmakhach = new System.Windows.Forms.Label();
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.lbldmkhachhang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(641, 409);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 32;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(503, 409);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 31;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(377, 409);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 30;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(263, 409);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 29;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(143, 409);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 28;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(17, 409);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 27;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMkhachhang
            // 
            this.dgridDMkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMkhachhang.Location = new System.Drawing.Point(40, 256);
            this.dgridDMkhachhang.Name = "dgridDMkhachhang";
            this.dgridDMkhachhang.RowHeadersWidth = 62;
            this.dgridDMkhachhang.Size = new System.Drawing.Size(676, 127);
            this.dgridDMkhachhang.TabIndex = 33;
            this.dgridDMkhachhang.Click += new System.EventHandler(this.dgridDMkhachhang_Click);
            // 
            // lblmakhach
            // 
            this.lblmakhach.AutoSize = true;
            this.lblmakhach.Location = new System.Drawing.Point(40, 79);
            this.lblmakhach.Name = "lblmakhach";
            this.lblmakhach.Size = new System.Drawing.Size(55, 13);
            this.lblmakhach.TabIndex = 34;
            this.lblmakhach.Text = "Mã khách";
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Location = new System.Drawing.Point(37, 124);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(59, 13);
            this.lbltenkhach.TabIndex = 35;
            this.lbltenkhach.Text = "Tên khách";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(40, 172);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(40, 13);
            this.lbldiachi.TabIndex = 36;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Location = new System.Drawing.Point(37, 216);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(55, 13);
            this.lbldienthoai.TabIndex = 37;
            this.lbldienthoai.Text = "Điện thoại";
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(155, 71);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(100, 20);
            this.txtmakhach.TabIndex = 38;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(155, 124);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(100, 20);
            this.txttenkhach.TabIndex = 39;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(155, 168);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 20);
            this.txtdiachi.TabIndex = 40;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(155, 216);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(100, 20);
            this.mskdienthoai.TabIndex = 43;
            // 
            // lbldmkhachhang
            // 
            this.lbldmkhachhang.AutoSize = true;
            this.lbldmkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmkhachhang.Location = new System.Drawing.Point(281, 18);
            this.lbldmkhachhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmkhachhang.Name = "lbldmkhachhang";
            this.lbldmkhachhang.Size = new System.Drawing.Size(270, 25);
            this.lbldmkhachhang.TabIndex = 44;
            this.lbldmkhachhang.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // frmdmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldmkhachhang);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lbltenkhach);
            this.Controls.Add(this.lblmakhach);
            this.Controls.Add(this.dgridDMkhachhang);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Name = "frmdmkhachhang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.frmdmkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMkhachhang)).EndInit();
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
        private System.Windows.Forms.DataGridView dgridDMkhachhang;
        private System.Windows.Forms.Label lblmakhach;
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Label lbldmkhachhang;
    }
}