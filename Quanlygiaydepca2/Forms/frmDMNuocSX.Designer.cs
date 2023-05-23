
namespace Quanlygiaydepca2.Forms
{
    partial class frmDMNuocSX
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
            this.dgridDMnuocsx = new System.Windows.Forms.DataGridView();
            this.txttennuocsx = new System.Windows.Forms.TextBox();
            this.txtmanuocsx = new System.Windows.Forms.TextBox();
            this.lbltennuocsx = new System.Windows.Forms.Label();
            this.lblmanuocsx = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lbldmnuocsx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMnuocsx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridDMnuocsx
            // 
            this.dgridDMnuocsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMnuocsx.Location = new System.Drawing.Point(37, 226);
            this.dgridDMnuocsx.Name = "dgridDMnuocsx";
            this.dgridDMnuocsx.RowHeadersWidth = 62;
            this.dgridDMnuocsx.Size = new System.Drawing.Size(693, 150);
            this.dgridDMnuocsx.TabIndex = 25;
            this.dgridDMnuocsx.Click += new System.EventHandler(this.dgridDMnuocsx_Click);
            // 
            // txttennuocsx
            // 
            this.txttennuocsx.Location = new System.Drawing.Point(249, 168);
            this.txttennuocsx.Name = "txttennuocsx";
            this.txttennuocsx.Size = new System.Drawing.Size(100, 20);
            this.txttennuocsx.TabIndex = 24;
            // 
            // txtmanuocsx
            // 
            this.txtmanuocsx.Location = new System.Drawing.Point(249, 109);
            this.txtmanuocsx.Name = "txtmanuocsx";
            this.txtmanuocsx.Size = new System.Drawing.Size(100, 20);
            this.txtmanuocsx.TabIndex = 23;
            // 
            // lbltennuocsx
            // 
            this.lbltennuocsx.AutoSize = true;
            this.lbltennuocsx.Location = new System.Drawing.Point(70, 168);
            this.lbltennuocsx.Name = "lbltennuocsx";
            this.lbltennuocsx.Size = new System.Drawing.Size(96, 13);
            this.lbltennuocsx.TabIndex = 22;
            this.lbltennuocsx.Text = "Tên nước sản xuất";
            // 
            // lblmanuocsx
            // 
            this.lblmanuocsx.AutoSize = true;
            this.lblmanuocsx.Location = new System.Drawing.Point(70, 109);
            this.lblmanuocsx.Name = "lblmanuocsx";
            this.lblmanuocsx.Size = new System.Drawing.Size(92, 13);
            this.lblmanuocsx.TabIndex = 21;
            this.lblmanuocsx.Text = "Mã nước sản xuất";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(655, 412);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 32;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(529, 412);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 31;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(403, 412);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 30;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(290, 412);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 29;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(169, 412);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 28;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(37, 412);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 27;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lbldmnuocsx
            // 
            this.lbldmnuocsx.AutoSize = true;
            this.lbldmnuocsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmnuocsx.Location = new System.Drawing.Point(244, 32);
            this.lbldmnuocsx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmnuocsx.Name = "lbldmnuocsx";
            this.lbldmnuocsx.Size = new System.Drawing.Size(303, 25);
            this.lbldmnuocsx.TabIndex = 34;
            this.lbldmnuocsx.Text = "DANH MỤC NƯỚC SẢN XUẤT";
            // 
            // frmDMNuocSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.lbldmnuocsx);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMnuocsx);
            this.Controls.Add(this.txttennuocsx);
            this.Controls.Add(this.txtmanuocsx);
            this.Controls.Add(this.lbltennuocsx);
            this.Controls.Add(this.lblmanuocsx);
            this.Name = "frmDMNuocSX";
            this.Text = "Danh mục nước sản xuất";
            this.Load += new System.EventHandler(this.frmDMNuocSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMnuocsx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridDMnuocsx;
        private System.Windows.Forms.TextBox txttennuocsx;
        private System.Windows.Forms.TextBox txtmanuocsx;
        private System.Windows.Forms.Label lbltennuocsx;
        private System.Windows.Forms.Label lblmanuocsx;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lbldmnuocsx;
    }
}