namespace QLThanhToan
{
    partial class frmNew_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNew_Edit));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDinhMuc = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenDinhMuc = new System.Windows.Forms.TextBox();
            this.numberVAT = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongy = new System.Windows.Forms.Button();
            this.lbDonVi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberVAT)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thuế VAT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá định mức :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên định mức :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Định mức :";
            // 
            // TxtDinhMuc
            // 
            this.TxtDinhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDinhMuc.Location = new System.Drawing.Point(106, 55);
            this.TxtDinhMuc.Name = "TxtDinhMuc";
            this.TxtDinhMuc.Size = new System.Drawing.Size(120, 21);
            this.TxtDinhMuc.TabIndex = 5;
            this.TxtDinhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            this.TxtDinhMuc.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(106, 92);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(120, 21);
            this.txtGia.TabIndex = 5;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            this.txtGia.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // txtTenDinhMuc
            // 
            this.txtTenDinhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDinhMuc.Location = new System.Drawing.Point(106, 18);
            this.txtTenDinhMuc.Name = "txtTenDinhMuc";
            this.txtTenDinhMuc.Size = new System.Drawing.Size(157, 21);
            this.txtTenDinhMuc.TabIndex = 5;
            this.txtTenDinhMuc.TextChanged += new System.EventHandler(this.Txt_Changed);
            // 
            // numberVAT
            // 
            this.numberVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberVAT.Location = new System.Drawing.Point(106, 131);
            this.numberVAT.Name = "numberVAT";
            this.numberVAT.Size = new System.Drawing.Size(120, 21);
            this.numberVAT.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "%";
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBoQua.BackgroundImage")));
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(182, 176);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(81, 27);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.MouseLeave += new System.EventHandler(this.btnBoQua_MouseLeave);
            this.btnBoQua.MouseHover += new System.EventHandler(this.btnBoQua_MouseHover);
            // 
            // btnDongy
            // 
            this.btnDongy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDongy.BackgroundImage")));
            this.btnDongy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDongy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongy.Location = new System.Drawing.Point(95, 176);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(81, 27);
            this.btnDongy.TabIndex = 7;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.MouseLeave += new System.EventHandler(this.btnDongy_MouseLeave);
            this.btnDongy.MouseHover += new System.EventHandler(this.btnDongy_MouseHover);
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.Location = new System.Drawing.Point(232, 60);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(41, 15);
            this.lbDonVi.TabIndex = 8;
            this.lbDonVi.Text = "label7";
            // 
            // frmNew_Edit
            // 
            this.AcceptButton = this.btnDongy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(275, 211);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.numberVAT);
            this.Controls.Add(this.txtTenDinhMuc);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.TxtDinhMuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "frmNew_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmNew_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberVAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDongy;
        internal System.Windows.Forms.TextBox TxtDinhMuc;
        internal System.Windows.Forms.TextBox txtGia;
        internal System.Windows.Forms.TextBox txtTenDinhMuc;
        internal System.Windows.Forms.NumericUpDown numberVAT;
        private System.Windows.Forms.Label lbDonVi;
    }
}