
namespace Quanlygiaydepca2.Forms
{
    partial class frmdmco
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
            this.dgridDMco = new System.Windows.Forms.DataGridView();
            this.txttenco = new System.Windows.Forms.TextBox();
            this.txtmaco = new System.Windows.Forms.TextBox();
            this.lbltenco = new System.Windows.Forms.Label();
            this.lblmaco = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.lbldmco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridDMco
            // 
            this.dgridDMco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDMco.Location = new System.Drawing.Point(17, 211);
            this.dgridDMco.Name = "dgridDMco";
            this.dgridDMco.RowHeadersWidth = 62;
            this.dgridDMco.Size = new System.Drawing.Size(695, 150);
            this.dgridDMco.TabIndex = 9;
            this.dgridDMco.Click += new System.EventHandler(this.dgridDMco_Click);
            // 
            // txttenco
            // 
            this.txttenco.Location = new System.Drawing.Point(234, 163);
            this.txttenco.Name = "txttenco";
            this.txttenco.Size = new System.Drawing.Size(100, 20);
            this.txttenco.TabIndex = 8;
            // 
            // txtmaco
            // 
            this.txtmaco.Location = new System.Drawing.Point(234, 104);
            this.txtmaco.Name = "txtmaco";
            this.txtmaco.Size = new System.Drawing.Size(100, 20);
            this.txtmaco.TabIndex = 7;
            // 
            // lbltenco
            // 
            this.lbltenco.AutoSize = true;
            this.lbltenco.Location = new System.Drawing.Point(55, 163);
            this.lbltenco.Name = "lbltenco";
            this.lbltenco.Size = new System.Drawing.Size(41, 13);
            this.lbltenco.TabIndex = 6;
            this.lbltenco.Text = "Tên cỡ";
            // 
            // lblmaco
            // 
            this.lblmaco.AutoSize = true;
            this.lblmaco.Location = new System.Drawing.Point(55, 104);
            this.lblmaco.Name = "lblmaco";
            this.lblmaco.Size = new System.Drawing.Size(37, 13);
            this.lblmaco.TabIndex = 5;
            this.lblmaco.Text = "Mã cỡ";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(17, 408);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(138, 408);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(259, 408);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(373, 408);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(498, 408);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 14;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(637, 408);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 15;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // lbldmco
            // 
            this.lbldmco.AutoSize = true;
            this.lbldmco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldmco.Location = new System.Drawing.Point(314, 23);
            this.lbldmco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldmco.Name = "lbldmco";
            this.lbldmco.Size = new System.Drawing.Size(162, 25);
            this.lbldmco.TabIndex = 17;
            this.lbldmco.Text = "DANH MỤC CỠ";
            // 
            // frmdmco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldmco);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridDMco);
            this.Controls.Add(this.txttenco);
            this.Controls.Add(this.txtmaco);
            this.Controls.Add(this.lbltenco);
            this.Controls.Add(this.lblmaco);
            this.Name = "frmdmco";
            this.Text = "DANH MỤC CỠ";
            this.Load += new System.EventHandler(this.frmdmco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDMco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridDMco;
        private System.Windows.Forms.TextBox txttenco;
        private System.Windows.Forms.TextBox txtmaco;
        private System.Windows.Forms.Label lbltenco;
        private System.Windows.Forms.Label lblmaco;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label lbldmco;
    }
}