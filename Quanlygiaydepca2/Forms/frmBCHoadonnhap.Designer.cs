
namespace Quanlygiaydepca2.Forms
{
    partial class frmBCHoadonnhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.DGridBCHoadonnhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridBCHoadonnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChonquy
            // 
            this.txtChonquy.Location = new System.Drawing.Point(276, 79);
            this.txtChonquy.Name = "txtChonquy";
            this.txtChonquy.Size = new System.Drawing.Size(100, 20);
            this.txtChonquy.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quý";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(424, 77);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(97, 23);
            this.btnBaocao.TabIndex = 4;
            this.btnBaocao.Text = "Xem báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "DANH SÁCH HÓA ĐƠN NHẬP THEO QUÝ";
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
            // DGridBCHoadonnhap
            // 
            this.DGridBCHoadonnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridBCHoadonnhap.Location = new System.Drawing.Point(48, 118);
            this.DGridBCHoadonnhap.Name = "DGridBCHoadonnhap";
            this.DGridBCHoadonnhap.Size = new System.Drawing.Size(705, 174);
            this.DGridBCHoadonnhap.TabIndex = 79;
            // 
            // frmBCHoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.DGridBCHoadonnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChonquy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaocao);
            this.Name = "frmBCHoadonnhap";
            this.Text = "Báo cáo hóa đơn nhập";
       
            ((System.ComponentModel.ISupportInitialize)(this.DGridBCHoadonnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChonquy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.DataGridView DGridBCHoadonnhap;
    }
}