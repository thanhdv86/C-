using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThanhToan
{
    public partial class frmGhiChiSoDien : Form
    {
        KhachHang kh;
        QLDien qlDien;
        public frmGhiChiSoDien(KhachHang _kh,QLDien _qlDien)
        {
            InitializeComponent();
            this.kh = _kh;
            this.qlDien = _qlDien;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar < 32 || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.KeyChar = '\0';
            }
        }

        private void frmGhiChiSoDien_Load(object sender, EventArgs e)
        {
            lbKhachHang.Text = kh.HoTen;
            if (qlDien != null)
                txtChiSoCu.Text = qlDien.ChiSoMoi.ToString();
            else
                txtChiSoCu.Text = "0";
        }

        private void btnDongY_MouseLeave(object sender, EventArgs e)
        {
            if (btnDongY.Enabled == true)
                btnDongY.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            else
                btnDongY.BackgroundImage = null;
        }

        private void btnDongY_MouseHover(object sender, EventArgs e)
        {
            btnDongY.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnBoQua_MouseLeave(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnBoQua_MouseHover(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void txt_Changed(object sender, EventArgs e)
        {
            if (txtChiSoCu.Text == "" || txtChiSoMoi.Text == "" || Convert.ToInt32(txtChiSoCu.Text) >= Convert.ToInt32(txtChiSoMoi.Text))
            {
                btnDongY.Enabled = false;
                btnDongY.BackgroundImage = null;
            }
            else
            {
                btnDongY.Enabled = true;
                btnDongY.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
            }
        }


    }
}