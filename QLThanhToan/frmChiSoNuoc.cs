using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThanhToan
{
    public partial class frmChiSoNuoc : Form
    {
        KhachHang kh;
        QLNuoc nuoc;
        public frmChiSoNuoc(KhachHang _kh,QLNuoc _nuoc)
        {
            InitializeComponent();
            this.kh = _kh;
            this.nuoc = _nuoc;
        }

        private void frmChiSoNuoc_Load(object sender, EventArgs e)
        {
            lbKhachHang.Text = kh.HoTen;
            if (nuoc != null)
                txtChiSoCu.Text = nuoc.ChiSoMoi.ToString();
            else
                txtChiSoCu.Text = "0";
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar < 32 || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.KeyChar = '\0';
            }
        }

        private void txtSothangSD_TextChanged(object sender, EventArgs e)
        {
            if (txtSothangSD.Text == "")
            {
                btnDongY.Enabled = false;
                btnDongY.BackgroundImage = null;
            }
            else
            {
                btnDongY.Enabled = true;
                btnDongY_MouseLeave(null, null);
            }
            try
            {
                if (Convert.ToInt16(txtSothangSD.Text) > 12)
                {
                    txtSothangSD.Text = "1";
                    MessageBox.Show("Xin vui lòng nhập đúng thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) { }
        }

        private void txtChiSoMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtChiSoMoi.Text != "" && txtChiSoCu.Text != "")
                if (Convert.ToInt32(txtChiSoMoi.Text) > Convert.ToInt32(txtChiSoCu.Text))
                {
                    btnDongY.Enabled = true;
                    btnDongY_MouseLeave(null, null);
                }
                else
                {
                    btnDongY.Enabled = false;
                    btnDongY.BackgroundImage = null;
                }
            else
            {
                btnDongY.Enabled = false;
                btnDongY.BackgroundImage = null;
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

        private void btnBoQua_MouseLeave(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnBoQua_MouseHover(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void txtSoKhoiTH_TextChanged(object sender, EventArgs e)
        {
            if (txtSoKhoiTH.Text == "")
            {
                btnDongY.Enabled = false;
                btnDongY.BackgroundImage = null;
            }
            else
            {
                btnDongY.Enabled = true;
                btnDongY_MouseLeave(null, null);
            }
        }

    }
}