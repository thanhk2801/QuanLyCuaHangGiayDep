
namespace Quanlygiaydepca2.Forms
{
    partial class frmDMdoituong
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
            this.dgridDMdoituong = new System.Windows.Forms.DataGridView();
            this.txtmadoituong = new System.Windows.Forms.TextBox();
            this.lbltendoituong = new System.Windows.Forms.Label();
            this.lblmadoituong = new System.Windows.Forms.Label();
            this.txttendoituong = new System.Windows.Forms.TextBox();
            this.lbldmdoituong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMdoituong)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(590, 397);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 23);
            this.btndong.TabIndex = 55;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(481, 397);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(87, 23);
            this.btnboqua.TabIndex = 54;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(363, 397);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(87, 23);
            this.btnluu.TabIndex = 53;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(241, 397);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(87, 23);
            this.btnsua.TabIndex = 52;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(130, 397);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 23);
            this.btnxoa.TabIndex = 51;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(8, 397);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 23);
            this.btnthem.TabIndex = 50;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridDMdoituong
            // 
            this.dgridDMdoituong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMdoituong.Location = new System.Drawing.Point(8, 191);
            this.dgridDMdoituong.Name = "dgridDMdoituong";
            this.dgridDMdoituong.RowHeadersWidth = 62;
            this.dgridDMdoituong.Size = new System.Drawing.Size(669, 179);
            this.dgridDMdoituong.TabIndex = 49;
            // 
            // txtmadoituong
            // 
            this.txtmadoituong.Location = new System.Drawing.Point(162, 81);
            this.txtmadoituong.Name = "txtmadoituong";
            this.txtmadoituong.Size = new System.Drawing.Size(112, 20);
            this.txtmadoituong.TabIndex = 47;
            // 
            // lbltendoituong
            // 
            this.lbltendoituong.AutoSize = true;
            this.lbltendoituong.Location = new System.Drawing.Point(39, 132);
            this.lbltendoituong.Name = "lbltendoituong";
            this.lbltendoituong.Size = new System.Drawing.Size(74, 13);
            this.lbltendoituong.TabIndex = 46;
            this.lbltendoituong.Text = "Tên đối tượng";
            // 
            // lblmadoituong
            // 
            this.lblmadoituong.AutoSize = true;
            this.lblmadoituong.Location = new System.Drawing.Point(42, 84);
            this.lblmadoituong.Name = "lblmadoituong";
            this.lblmadoituong.Size = new System.Drawing.Size(70, 13);
            this.lblmadoituong.TabIndex = 45;
            this.lblmadoituong.Text = "Mã đối tượng";
            // 
            // txttendoituong
            // 
            this.txttendoituong.Location = new System.Drawing.Point(162, 128);
            this.txttendoituong.Name = "txttendoituong";
            this.txttendoituong.Size = new System.Drawing.Size(112, 20);
            this.txttendoituong.TabIndex = 57;
            // 
            // lbldmdoituong
            // 
            this.lbldmdoituong.AutoSize = true;
            this.lbldmdoituong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmdoituong.Location = new System.Drawing.Point(216, 24);
            this.lbldmdoituong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmdoituong.Name = "lbldmdoituong";
            this.lbldmdoituong.Size = new System.Drawing.Size(248, 25);
            this.lbldmdoituong.TabIndex = 58;
            this.lbldmdoituong.Text = "DANH MỤC ĐỐI TƯỢNG";
            // 
            // frmDMdoituong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 426);
            this.Controls.Add(this.lbldmdoituong);
            this.Controls.Add(this.txttendoituong);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMdoituong);
            this.Controls.Add(this.txtmadoituong);
            this.Controls.Add(this.lbltendoituong);
            this.Controls.Add(this.lblmadoituong);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDMdoituong";
            this.Text = "DANH MỤC ĐỐI TƯỢNG";
            this.Load += new System.EventHandler(this.frmDMdoituong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMdoituong)).EndInit();
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
        private System.Windows.Forms.DataGridView dgridDMdoituong;
        private System.Windows.Forms.TextBox txtmadoituong;
        private System.Windows.Forms.Label lbltendoituong;
        private System.Windows.Forms.Label lblmadoituong;
        private System.Windows.Forms.TextBox txttendoituong;
        private System.Windows.Forms.Label lbldmdoituong;
    }
}