
namespace Quanlygiaydepca2.Forms
{
    partial class frmdmmua
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
            this.dgridDMmua = new System.Windows.Forms.DataGridView();
            this.txttenmua = new System.Windows.Forms.TextBox();
            this.txtmamua = new System.Windows.Forms.TextBox();
            this.lbltenmua = new System.Windows.Forms.Label();
            this.lblmamua = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lbldmmua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMmua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridDMmua
            // 
            this.dgridDMmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMmua.Location = new System.Drawing.Point(30, 213);
            this.dgridDMmua.Name = "dgridDMmua";
            this.dgridDMmua.RowHeadersWidth = 62;
            this.dgridDMmua.Size = new System.Drawing.Size(694, 150);
            this.dgridDMmua.TabIndex = 30;
            this.dgridDMmua.Click += new System.EventHandler(this.dgridDMmua_Click);
            // 
            // txttenmua
            // 
            this.txttenmua.Location = new System.Drawing.Point(237, 164);
            this.txttenmua.Name = "txttenmua";
            this.txttenmua.Size = new System.Drawing.Size(100, 20);
            this.txttenmua.TabIndex = 29;
            // 
            // txtmamua
            // 
            this.txtmamua.Location = new System.Drawing.Point(237, 106);
            this.txtmamua.Name = "txtmamua";
            this.txtmamua.Size = new System.Drawing.Size(100, 20);
            this.txtmamua.TabIndex = 28;
            // 
            // lbltenmua
            // 
            this.lbltenmua.AutoSize = true;
            this.lbltenmua.Location = new System.Drawing.Point(78, 164);
            this.lbltenmua.Name = "lbltenmua";
            this.lbltenmua.Size = new System.Drawing.Size(49, 13);
            this.lbltenmua.TabIndex = 27;
            this.lbltenmua.Text = "Tên mùa";
            // 
            // lblmamua
            // 
            this.lblmamua.AutoSize = true;
            this.lblmamua.Location = new System.Drawing.Point(78, 106);
            this.lblmamua.Name = "lblmamua";
            this.lblmamua.Size = new System.Drawing.Size(45, 13);
            this.lblmamua.TabIndex = 26;
            this.lblmamua.Text = "Mã mùa";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(649, 409);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 38;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(522, 409);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 37;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(397, 409);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 36;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(283, 409);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 35;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(162, 409);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(30, 409);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 33;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lbldmmua
            // 
            this.lbldmmua.AutoSize = true;
            this.lbldmmua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmmua.Location = new System.Drawing.Point(320, 25);
            this.lbldmmua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmmua.Name = "lbldmmua";
            this.lbldmmua.Size = new System.Drawing.Size(178, 25);
            this.lbldmmua.TabIndex = 40;
            this.lbldmmua.Text = "DANH MỤC MÙA";
            // 
            // frmdmmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldmmua);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMmua);
            this.Controls.Add(this.txttenmua);
            this.Controls.Add(this.txtmamua);
            this.Controls.Add(this.lbltenmua);
            this.Controls.Add(this.lblmamua);
            this.Name = "frmdmmua";
            this.Text = "DANH MỤC MÙA";
            this.Load += new System.EventHandler(this.frmdmmua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMmua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridDMmua;
        private System.Windows.Forms.TextBox txttenmua;
        private System.Windows.Forms.TextBox txtmamua;
        private System.Windows.Forms.Label lbltenmua;
        private System.Windows.Forms.Label lblmamua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lbldmmua;
    }
}