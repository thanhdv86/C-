namespace QLThanhToan
{
    partial class frmNew_Edit_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNew_Edit_KH));
            this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ckbGioiTinh
            // 
            this.ckbGioiTinh.AutoSize = true;
            this.ckbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGioiTinh.Location = new System.Drawing.Point(276, 5);
            this.ckbGioiTinh.Name = "ckbGioiTinh";
            this.ckbGioiTinh.Size = new System.Drawing.Size(53, 19);
            this.ckbGioiTinh.TabIndex = 7;
            this.ckbGioiTinh.Text = "Nam";
            this.ckbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên khách hàng :";
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoQua.BackgroundImage")));
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(234, 219);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(84, 26);
            this.btnBoQua.TabIndex = 8;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.MouseLeave += new System.EventHandler(this.tnBoQua_MouseLeave);
            this.btnBoQua.MouseHover += new System.EventHandler(this.tnBoQua_MouseHover);
            // 
            // btnDongY
            // 
            this.btnDongY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDongY.BackgroundImage")));
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Enabled = false;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(136, 219);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(84, 26);
            this.btnDongY.TabIndex = 8;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.MouseLeave += new System.EventHandler(this.btnDongY_MouseLeave);
            this.btnDongY.MouseHover += new System.EventHandler(this.btnDongY_MouseHover);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(111, 5);
            this.txtHoTen.MaxLength = 35;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(159, 20);
            this.txtHoTen.TabIndex = 9;
            this.txtHoTen.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(111, 58);
            this.txtDiaChi.MaxLength = 255;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 80);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(111, 169);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(151, 20);
            this.txtSoDT.TabIndex = 9;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            this.txtSoDT.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // frmNew_Edit_KH
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(330, 254);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.ckbGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 286);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 286);
            this.Name = "frmNew_Edit_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNew_Edit_KH";
            this.Load += new System.EventHandler(this.frmNew_Edit_KH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDongY;
        internal System.Windows.Forms.CheckBox ckbGioiTinh;
        internal System.Windows.Forms.TextBox txtHoTen;
        internal System.Windows.Forms.TextBox txtDiaChi;
        internal System.Windows.Forms.TextBox txtSoDT;
    }
}