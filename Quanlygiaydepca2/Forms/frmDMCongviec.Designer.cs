
namespace Quanlygiaydepca2.Forms
{
    partial class frmDMcongviec
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
            this.dgridDMcongviec = new System.Windows.Forms.DataGridView();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.lbltencv = new System.Windows.Forms.Label();
            this.lblmacv = new System.Windows.Forms.Label();
            this.lbldmcongviec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMcongviec)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(602, 411);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 43;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(493, 411);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(87, 23);
            this.btnboqua.TabIndex = 42;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(375, 411);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(87, 23);
            this.btnluu.TabIndex = 41;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(253, 411);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(87, 23);
            this.btnsua.TabIndex = 40;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(142, 411);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 23);
            this.btnxoa.TabIndex = 39;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(20, 411);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 23);
            this.btnthem.TabIndex = 38;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMcongviec
            // 
            this.dgridDMcongviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMcongviec.Location = new System.Drawing.Point(20, 205);
            this.dgridDMcongviec.Name = "dgridDMcongviec";
            this.dgridDMcongviec.RowHeadersWidth = 62;
            this.dgridDMcongviec.Size = new System.Drawing.Size(669, 179);
            this.dgridDMcongviec.TabIndex = 37;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(174, 142);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(112, 20);
            this.txttencv.TabIndex = 36;
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(174, 94);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(112, 20);
            this.txtmacv.TabIndex = 35;
            // 
            // lbltencv
            // 
            this.lbltencv.AutoSize = true;
            this.lbltencv.Location = new System.Drawing.Point(54, 149);
            this.lbltencv.Name = "lbltencv";
            this.lbltencv.Size = new System.Drawing.Size(76, 13);
            this.lbltencv.TabIndex = 34;
            this.lbltencv.Text = "Tên công việc";
            // 
            // lblmacv
            // 
            this.lblmacv.AutoSize = true;
            this.lblmacv.Location = new System.Drawing.Point(54, 98);
            this.lblmacv.Name = "lblmacv";
            this.lblmacv.Size = new System.Drawing.Size(72, 13);
            this.lblmacv.TabIndex = 33;
            this.lblmacv.Text = "Mã công việc";
            // 
            // lbldmcongviec
            // 
            this.lbldmcongviec.AutoSize = true;
            this.lbldmcongviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmcongviec.Location = new System.Drawing.Point(233, 20);
            this.lbldmcongviec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmcongviec.Name = "lbldmcongviec";
            this.lbldmcongviec.Size = new System.Drawing.Size(247, 25);
            this.lbldmcongviec.TabIndex = 45;
            this.lbldmcongviec.Text = "DANH MỤC CÔNG VIỆC";
            // 
            // frmDMcongviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 443);
            this.Controls.Add(this.lbldmcongviec);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMcongviec);
            this.Controls.Add(this.txttencv);
            this.Controls.Add(this.txtmacv);
            this.Controls.Add(this.lbltencv);
            this.Controls.Add(this.lblmacv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDMcongviec";
            this.Text = "Danh mục công việc";
            this.Load += new System.EventHandler(this.frmDMcongviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMcongviec)).EndInit();
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
        private System.Windows.Forms.DataGridView dgridDMcongviec;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.Label lbltencv;
        private System.Windows.Forms.Label lblmacv;
        private System.Windows.Forms.Label lbldmcongviec;
    }
}