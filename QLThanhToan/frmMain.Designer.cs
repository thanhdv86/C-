namespace QLThanhToan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lvThongTin = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.BtnDonGia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDien = new System.Windows.Forms.Button();
            this.btnNuoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.lbKhachHang = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnInHoaDon);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.lvThongTin);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(161, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 402);
            this.panel1.TabIndex = 8;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Enabled = false;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInHoaDon.Location = new System.Drawing.Point(311, 326);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(109, 28);
            this.btnInHoaDon.TabIndex = 5;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.MouseLeave += new System.EventHandler(this.btnInHoaDon_MouseLeave);
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            this.btnInHoaDon.MouseHover += new System.EventHandler(this.btnInHoaDon_MouseHover);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(427, 326);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 28);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnXoa_MouseLeave);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseHover += new System.EventHandler(this.btnXoa_MouseHover);
            // 
            // lvThongTin
            // 
            this.lvThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThongTin.FullRowSelect = true;
            this.lvThongTin.GridLines = true;
            this.lvThongTin.Location = new System.Drawing.Point(7, 9);
            this.lvThongTin.Name = "lvThongTin";
            this.lvThongTin.Size = new System.Drawing.Size(532, 312);
            this.lvThongTin.TabIndex = 3;
            this.lvThongTin.UseCompatibleStateImageBehavior = false;
            this.lvThongTin.View = System.Windows.Forms.View.Details;
            this.lvThongTin.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvThongTin_ItemSelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QLThanhToan.Properties.Resources.main_hdr;
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Controls.Add(this.BtnDonGia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 44);
            this.panel4.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.BackgroundImage")));
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(245, 7);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(141, 30);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Ghi chỉ số nước";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.MouseLeave += new System.EventHandler(this.btnThanhToan_MouseLeave);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnThanhToan.MouseHover += new System.EventHandler(this.btnThanhToan_MouseHover);
            // 
            // BtnDonGia
            // 
            this.BtnDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDonGia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDonGia.BackgroundImage")));
            this.BtnDonGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDonGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDonGia.Location = new System.Drawing.Point(395, 7);
            this.BtnDonGia.Name = "BtnDonGia";
            this.BtnDonGia.Size = new System.Drawing.Size(141, 30);
            this.BtnDonGia.TabIndex = 0;
            this.BtnDonGia.Text = "Cập nhật đơn giá";
            this.BtnDonGia.UseVisualStyleBackColor = true;
            this.BtnDonGia.MouseLeave += new System.EventHandler(this.BtnDonGia_MouseLeave);
            this.BtnDonGia.Click += new System.EventHandler(this.BtnDonGia_Click);
            this.BtnDonGia.MouseHover += new System.EventHandler(this.BtnDonGia_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDien);
            this.panel3.Controls.Add(this.btnNuoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 46);
            this.panel3.TabIndex = 6;
            // 
            // btnDien
            // 
            this.btnDien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDien.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_bg;
            this.btnDien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDien.Location = new System.Drawing.Point(-2, 0);
            this.btnDien.Name = "btnDien";
            this.btnDien.Size = new System.Drawing.Size(365, 49);
            this.btnDien.TabIndex = 0;
            this.btnDien.Text = "Quản lý điện";
            this.btnDien.UseVisualStyleBackColor = false;
            this.btnDien.MouseLeave += new System.EventHandler(this.btnDien_MouseLeave);
            this.btnDien.Click += new System.EventHandler(this.btnDien_Click);
            this.btnDien.MouseHover += new System.EventHandler(this.btnDien_MouseHover);
            // 
            // btnNuoc
            // 
            this.btnNuoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuoc.Enabled = false;
            this.btnNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.Location = new System.Drawing.Point(355, 0);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(352, 49);
            this.btnNuoc.TabIndex = 0;
            this.btnNuoc.Text = "Quản lý nước";
            this.btnNuoc.UseVisualStyleBackColor = false;
            this.btnNuoc.MouseLeave += new System.EventHandler(this.btnNuoc_MouseLeave);
            this.btnNuoc.Click += new System.EventHandler(this.btnNuoc_Click);
            this.btnNuoc.MouseHover += new System.EventHandler(this.btnNuoc_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QLThanhToan.Properties.Resources.main_hdr;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnKhachHang);
            this.panel2.Controls.Add(this.lbKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 402);
            this.panel2.TabIndex = 7;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.BackgroundImage")));
            this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(10, 365);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(141, 30);
            this.btnKhachHang.TabIndex = 0;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.MouseLeave += new System.EventHandler(this.btnKhachHang_MouseLeave);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            this.btnKhachHang.MouseHover += new System.EventHandler(this.btnKhachHang_MouseHover);
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.FormattingEnabled = true;
            this.lbKhachHang.ItemHeight = 15;
            this.lbKhachHang.Location = new System.Drawing.Point(10, 9);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(140, 349);
            this.lbKhachHang.TabIndex = 1;
            this.lbKhachHang.SelectedIndexChanged += new System.EventHandler(this.lbKhachHang_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 504);
            this.MinimumSize = new System.Drawing.Size(714, 504);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điện nước";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button BtnDonGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbKhachHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDien;
        private System.Windows.Forms.Button btnNuoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.ListView lvThongTin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}

