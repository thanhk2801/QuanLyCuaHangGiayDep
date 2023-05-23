
namespace Quanlygiaydepca2.Forms
{
    partial class frmBCKhachhang
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
            this.txtChonquy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.DGridBCKhachhang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGridBCKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChonquy
            // 
            this.txtChonquy.Location = new System.Drawing.Point(282, 72);
            this.txtChonquy.Name = "txtChonquy";
            this.txtChonquy.Size = new System.Drawing.Size(100, 20);
            this.txtChonquy.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quý";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(430, 70);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(97, 23);
            this.btnBaocao.TabIndex = 7;
            this.btnBaocao.Text = "Xem báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(420, 310);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 81;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Location = new System.Drawing.Point(258, 310);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(104, 23);
            this.btnInhoadon.TabIndex = 80;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // DGridBCKhachhang
            // 
            this.DGridBCKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridBCKhachhang.Location = new System.Drawing.Point(48, 118);
            this.DGridBCKhachhang.Name = "DGridBCKhachhang";
            this.DGridBCKhachhang.Size = new System.Drawing.Size(705, 174);
            this.DGridBCKhachhang.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "DANH SÁCH 3 KHÁCH HÀNG MUA NHIỀU NHẤT THEO QUÝ";
            // 
            // frmBCKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.DGridBCKhachhang);
            this.Controls.Add(this.txtChonquy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaocao);
            this.Name = "frmBCKhachhang";
            this.Text = "Báo cáo khách hàng";
            //this.Load += new System.EventHandler(this.frmBCKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridBCKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChonquy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.DataGridView DGridBCKhachhang;
        private System.Windows.Forms.Label label3;
    }
}