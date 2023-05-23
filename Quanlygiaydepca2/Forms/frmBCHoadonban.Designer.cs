
namespace Quanlygiaydepca2.Forms
{
    partial class frmBCHoadonban
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
            this.btnBaocao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChonNV = new System.Windows.Forms.TextBox();
            this.lbldmnhacungcap = new System.Windows.Forms.Label();
            this.DGridBCHoadonban = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridBCHoadonban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(454, 83);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(87, 23);
            this.btnBaocao.TabIndex = 1;
            this.btnBaocao.Text = "Xem báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhân viên";
            // 
            // txtChonNV
            // 
            this.txtChonNV.Location = new System.Drawing.Point(304, 86);
            this.txtChonNV.Name = "txtChonNV";
            this.txtChonNV.Size = new System.Drawing.Size(100, 20);
            this.txtChonNV.TabIndex = 3;
            // 
            // lbldmnhacungcap
            // 
            this.lbldmnhacungcap.AutoSize = true;
            this.lbldmnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmnhacungcap.Location = new System.Drawing.Point(162, 20);
            this.lbldmnhacungcap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmnhacungcap.Name = "lbldmnhacungcap";
            this.lbldmnhacungcap.Size = new System.Drawing.Size(470, 25);
            this.lbldmnhacungcap.TabIndex = 75;
            this.lbldmnhacungcap.Text = "DANH SÁCH HÓA ĐƠN BÁN THEO NHÂN VIÊN";
            // 
            // DGridBCHoadonban
            // 
            this.DGridBCHoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridBCHoadonban.Location = new System.Drawing.Point(49, 131);
            this.DGridBCHoadonban.Name = "DGridBCHoadonban";
            this.DGridBCHoadonban.Size = new System.Drawing.Size(705, 174);
            this.DGridBCHoadonban.TabIndex = 76;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(421, 323);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 78;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Location = new System.Drawing.Point(259, 323);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(104, 23);
            this.btnInhoadon.TabIndex = 77;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // frmBCHoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.DGridBCHoadonban);
            this.Controls.Add(this.lbldmnhacungcap);
            this.Controls.Add(this.txtChonNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaocao);
            this.Name = "frmBCHoadonban";
            this.Text = "Báo cáo hóa đơn bán";
        
            ((System.ComponentModel.ISupportInitialize)(this.DGridBCHoadonban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChonNV;
        private System.Windows.Forms.Label lbldmnhacungcap;
        private System.Windows.Forms.DataGridView DGridBCHoadonban;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnInhoadon;
    }
}