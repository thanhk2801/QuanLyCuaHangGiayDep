
namespace Quanlygiaydepca2.Forms
{
    partial class frmDMmau
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
            this.dgridDMMau = new System.Windows.Forms.DataGridView();
            this.txtmamau = new System.Windows.Forms.TextBox();
            this.lbltenmau = new System.Windows.Forms.Label();
            this.lblmamau = new System.Windows.Forms.Label();
            this.txttenmau = new System.Windows.Forms.TextBox();
            this.lbldmmau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMMau)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(604, 405);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 67;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(495, 405);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(87, 23);
            this.btnboqua.TabIndex = 66;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(377, 405);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(87, 23);
            this.btnluu.TabIndex = 65;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(255, 405);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(87, 23);
            this.btnsua.TabIndex = 64;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(144, 405);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 23);
            this.btnxoa.TabIndex = 63;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(22, 405);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 23);
            this.btnthem.TabIndex = 62;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMMau
            // 
            this.dgridDMMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMMau.Location = new System.Drawing.Point(22, 199);
            this.dgridDMMau.Name = "dgridDMMau";
            this.dgridDMMau.RowHeadersWidth = 62;
            this.dgridDMMau.Size = new System.Drawing.Size(669, 179);
            this.dgridDMMau.TabIndex = 61;
            // 
            // txtmamau
            // 
            this.txtmamau.Location = new System.Drawing.Point(176, 88);
            this.txtmamau.Name = "txtmamau";
            this.txtmamau.Size = new System.Drawing.Size(112, 20);
            this.txtmamau.TabIndex = 60;
            // 
            // lbltenmau
            // 
            this.lbltenmau.AutoSize = true;
            this.lbltenmau.Location = new System.Drawing.Point(53, 140);
            this.lbltenmau.Name = "lbltenmau";
            this.lbltenmau.Size = new System.Drawing.Size(49, 13);
            this.lbltenmau.TabIndex = 59;
            this.lbltenmau.Text = "Tên mầu";
            // 
            // lblmamau
            // 
            this.lblmamau.AutoSize = true;
            this.lblmamau.Location = new System.Drawing.Point(56, 92);
            this.lblmamau.Name = "lblmamau";
            this.lblmamau.Size = new System.Drawing.Size(45, 13);
            this.lblmamau.TabIndex = 58;
            this.lblmamau.Text = "Mã mầu";
            // 
            // txttenmau
            // 
            this.txttenmau.Location = new System.Drawing.Point(176, 135);
            this.txttenmau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttenmau.Name = "txttenmau";
            this.txttenmau.Size = new System.Drawing.Size(112, 20);
            this.txttenmau.TabIndex = 69;
            // 
            // lbldmmau
            // 
            this.lbldmmau.AutoSize = true;
            this.lbldmmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmmau.Location = new System.Drawing.Point(263, 20);
            this.lbldmmau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmmau.Name = "lbldmmau";
            this.lbldmmau.Size = new System.Drawing.Size(178, 25);
            this.lbldmmau.TabIndex = 70;
            this.lbldmmau.Text = "DANH MỤC MẦU";
            // 
            // frmDMmau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 442);
            this.Controls.Add(this.lbldmmau);
            this.Controls.Add(this.txttenmau);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMMau);
            this.Controls.Add(this.txtmamau);
            this.Controls.Add(this.lbltenmau);
            this.Controls.Add(this.lblmamau);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDMmau";
            this.Text = "Danh mục mầu";
            this.Load += new System.EventHandler(this.frmDMmau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMMau)).EndInit();
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
        private System.Windows.Forms.DataGridView dgridDMMau;
        private System.Windows.Forms.TextBox txtmamau;
        private System.Windows.Forms.Label lbltenmau;
        private System.Windows.Forms.Label lblmamau;
        private System.Windows.Forms.TextBox txttenmau;
        private System.Windows.Forms.Label lbldmmau;
    }
}