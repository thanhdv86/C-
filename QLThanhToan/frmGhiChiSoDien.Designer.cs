namespace QLThanhToan
{
    partial class frmGhiChiSoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGhiChiSoDien));
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoQua.BackgroundImage")));
            this.btnBoQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(125, 165);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(110, 31);
            this.btnBoQua.TabIndex = 0;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.MouseLeave += new System.EventHandler(this.btnBoQua_MouseLeave);
            this.btnBoQua.MouseHover += new System.EventHandler(this.btnBoQua_MouseHover);
            // 
            // btnDongY
            // 
            this.btnDongY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Enabled = false;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(11, 165);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(110, 31);
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.MouseLeave += new System.EventHandler(this.btnDongY_MouseLeave);
            this.btnDongY.MouseHover += new System.EventHandler(this.btnDongY_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách hàng :";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.Location = new System.Drawing.Point(97, 20);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(47, 15);
            this.lbKhachHang.TabIndex = 2;
            this.lbKhachHang.Text = "label2";
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoCu.Location = new System.Drawing.Point(97, 81);
            this.txtChiSoCu.MaxLength = 5;
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Size = new System.Drawing.Size(138, 21);
            this.txtChiSoCu.TabIndex = 3;
            this.txtChiSoCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtChiSoCu.TextChanged += new System.EventHandler(this.txt_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chỉ số cũ :";
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoMoi.Location = new System.Drawing.Point(97, 117);
            this.txtChiSoMoi.MaxLength = 5;
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(138, 21);
            this.txtChiSoMoi.TabIndex = 3;
            this.txtChiSoMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txtChiSoMoi.TextChanged += new System.EventHandler(this.txt_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chỉ số mới :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày lập :";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(97, 51);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(138, 21);
            this.dtpNgayLap.TabIndex = 4;
            // 
            // frmGhiChiSoDien
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(249, 202);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnBoQua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(255, 234);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 234);
            this.Name = "frmGhiChiSoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghi chỉ số điện";
            this.Load += new System.EventHandler(this.frmGhiChiSoDien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtChiSoCu;
        public System.Windows.Forms.TextBox txtChiSoMoi;
        public System.Windows.Forms.DateTimePicker dtpNgayLap;
    }
}