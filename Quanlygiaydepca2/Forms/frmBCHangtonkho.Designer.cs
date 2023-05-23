
namespace Quanlygiaydepca2.Forms
{
    partial class frmBCHangtonkho
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
            this.lbldmnhacungcap = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.DGridHangtonkho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridHangtonkho)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldmnhacungcap
            // 
            this.lbldmnhacungcap.AutoSize = true;
            this.lbldmnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmnhacungcap.Location = new System.Drawing.Point(234, 30);
            this.lbldmnhacungcap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmnhacungcap.Name = "lbldmnhacungcap";
            this.lbldmnhacungcap.Size = new System.Drawing.Size(302, 25);
            this.lbldmnhacungcap.TabIndex = 77;
            this.lbldmnhacungcap.Text = "DANH SÁCH HÀNG TỒN KHO";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(449, 279);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 76;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Location = new System.Drawing.Point(265, 279);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(104, 23);
            this.btnInhoadon.TabIndex = 75;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // DGridHangtonkho
            // 
            this.DGridHangtonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridHangtonkho.Location = new System.Drawing.Point(45, 93);
            this.DGridHangtonkho.Name = "DGridHangtonkho";
            this.DGridHangtonkho.Size = new System.Drawing.Size(710, 150);
            this.DGridHangtonkho.TabIndex = 74;
            // 
            // frmBCHangtonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.lbldmnhacungcap);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.DGridHangtonkho);
            this.Name = "frmBCHangtonkho";
            this.Text = "Báo cáo hàng tồn kho";
            this.Load += new System.EventHandler(this.frmBCHangtonkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridHangtonkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldmnhacungcap;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.DataGridView DGridHangtonkho;
    }
}