using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThanhToan
{
    public partial class frmNew_Edit_KH : Form
    {
        object obj;
        public frmNew_Edit_KH()
        {
            InitializeComponent();
        }
        public frmNew_Edit_KH(object _obj)
        {
            InitializeComponent();
            this.obj = _obj;
        }

        private void frmNew_Edit_KH_Load(object sender, EventArgs e)
        {
            if (obj != null)
            {
                KhachHang kh = new KhachHang();
                kh = obj as KhachHang;
                txtHoTen.Text = kh.HoTen;
                ckbGioiTinh.Checked = kh.GioiTinh;
                txtDiaChi.Text = kh.DiaChi;
                txtSoDT.Text = kh.SoDT;                    
            }
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar < 32 || (e.KeyChar >= '0' && e.KeyChar <= '9')))
                e.KeyChar = '\0';
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtDiaChi.Text == "")
            {
                btnDongY.Enabled = false;
                btnDongY.BackgroundImage = null;
            }
            else
            {
                btnDongY.Enabled = true;
                btnDongY.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            }
        }

        private void btnDongY_MouseLeave(object sender, EventArgs e)
        {
            if (btnDongY.Enabled == true)
                btnDongY.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnDongY_MouseHover(object sender, EventArgs e)
        {
            btnDongY.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void tnBoQua_MouseLeave(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void tnBoQua_MouseHover(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

    }
}