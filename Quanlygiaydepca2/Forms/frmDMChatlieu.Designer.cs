
namespace Quanlygiaydepca2.Forms
{
    partial class frmdmchatlieu
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
            this.dgridDMchatlieu = new System.Windows.Forms.DataGridView();
            this.txttenchatlieu = new System.Windows.Forms.TextBox();
            this.txtmachatlieu = new System.Windows.Forms.TextBox();
            this.lbltenchatlieu = new System.Windows.Forms.Label();
            this.lblmachatlieu = new System.Windows.Forms.Label();
            this.lbldmchatlieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMchatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(659, 417);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 26;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(519, 417);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 25;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(394, 417);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 24;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(280, 417);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(159, 417);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(27, 417);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMchatlieu
            // 
            this.dgridDMchatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMchatlieu.Location = new System.Drawing.Point(27, 220);
            this.dgridDMchatlieu.Name = "dgridDMchatlieu";
            this.dgridDMchatlieu.RowHeadersWidth = 62;
            this.dgridDMchatlieu.Size = new System.Drawing.Size(707, 150);
            this.dgridDMchatlieu.TabIndex = 20;
            this.dgridDMchatlieu.Click += new System.EventHandler(this.dgridDMchatlieu_Click);
            // 
            // txttenchatlieu
            // 
            this.txttenchatlieu.Location = new System.Drawing.Point(255, 172);
            this.txttenchatlieu.Name = "txttenchatlieu";
            this.txttenchatlieu.Size = new System.Drawing.Size(100, 20);
            this.txttenchatlieu.TabIndex = 19;
            // 
            // txtmachatlieu
            // 
            this.txtmachatlieu.Location = new System.Drawing.Point(255, 113);
            this.txtmachatlieu.Name = "txtmachatlieu";
            this.txtmachatlieu.Size = new System.Drawing.Size(100, 20);
            this.txtmachatlieu.TabIndex = 18;
            // 
            // lbltenchatlieu
            // 
            this.lbltenchatlieu.AutoSize = true;
            this.lbltenchatlieu.Location = new System.Drawing.Point(76, 172);
            this.lbltenchatlieu.Name = "lbltenchatlieu";
            this.lbltenchatlieu.Size = new System.Drawing.Size(69, 13);
            this.lbltenchatlieu.TabIndex = 17;
            this.lbltenchatlieu.Text = "Tên chất liệu";
            // 
            // lblmachatlieu
            // 
            this.lblmachatlieu.AutoSize = true;
            this.lblmachatlieu.Location = new System.Drawing.Point(76, 113);
            this.lblmachatlieu.Name = "lblmachatlieu";
            this.lblmachatlieu.Size = new System.Drawing.Size(65, 13);
            this.lblmachatlieu.TabIndex = 16;
            this.lblmachatlieu.Text = "Mã chất liệu";
            // 
            // lbldmchatlieu
            // 
            this.lbldmchatlieu.AutoSize = true;
            this.lbldmchatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmchatlieu.Location = new System.Drawing.Point(288, 29);
            this.lbldmchatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmchatlieu.Name = "lbldmchatlieu";
            this.lbldmchatlieu.Size = new System.Drawing.Size(240, 25);
            this.lbldmchatlieu.TabIndex = 28;
            this.lbldmchatlieu.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // frmdmchatlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldmchatlieu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMchatlieu);
            this.Controls.Add(this.txttenchatlieu);
            this.Controls.Add(this.txtmachatlieu);
            this.Controls.Add(this.lbltenchatlieu);
            this.Controls.Add(this.lblmachatlieu);
            this.Name = "frmdmchatlieu";
            this.Text = "Danh mục chất liệu";
            this.Load += new System.EventHandler(this.frmdmchatlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMchatlieu)).EndInit();
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
        private System.Windows.Forms.DataGridView dgridDMchatlieu;
        private System.Windows.Forms.TextBox txttenchatlieu;
        private System.Windows.Forms.TextBox txtmachatlieu;
        private System.Windows.Forms.Label lbltenchatlieu;
        private System.Windows.Forms.Label lblmachatlieu;
        private System.Windows.Forms.Label lbldmchatlieu;
    }
}