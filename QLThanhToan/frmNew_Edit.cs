using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThanhToan
{
    public partial class frmNew_Edit : Form
    {
        bool nuoc;
        object obj;
        public frmNew_Edit()
        {
            InitializeComponent();
        }
        public frmNew_Edit(object _obj, bool _nuoc)
        {
            InitializeComponent();
            this.obj = _obj;
            this.nuoc = _nuoc;
        }
        public frmNew_Edit(bool _nuoc)
        {
            InitializeComponent();
            this.nuoc = _nuoc;
        }
        private void frmNew_Edit_Load(object sender, EventArgs e)
        {
            if (obj != null)
            {
                if (nuoc == true)
                {
                    banGiaNuoc gia = new banGiaNuoc();
                    gia = obj as banGiaNuoc;
                    txtTenDinhMuc.Text = gia.TenDinhMuc;
                    TxtDinhMuc.Text = gia.DinhMuc.ToString();
                    txtGia.Text = gia.GiaDinhMuc.ToString();
                    numberVAT.Value = gia.ThueVAT;
                    lbDonVi.Text = "Khối";
                }
                else
                {
                    banGiaDien gia = new banGiaDien();
                    gia = obj as banGiaDien;
                    txtTenDinhMuc.Text = gia.TenDinhMuc;
                    TxtDinhMuc.Text = gia.DinhMuc.ToString();
                    txtGia.Text = gia.GiaDinhMuc.ToString();
                    numberVAT.Value = gia.ThueVAT;
                    lbDonVi.Text = "Kwh";
                }
            }
            else
            {
                Txt_Changed(null, null);
                if(nuoc==true)
                    lbDonVi.Text = "Khối";
                else
                    lbDonVi.Text = "Kwh";
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar < 32 || (e.KeyChar >= '0' && e.KeyChar <= '9')))
                e.KeyChar = '\0';
        }

        private void Txt_Changed(object sender, EventArgs e)
        {
            if (txtTenDinhMuc.Text == "" || TxtDinhMuc.Text == "" || txtGia.Text == "")
            {
                btnDongy.Enabled = false;
                btnDongy.BackgroundImage = null;
            }
            else
            {
                btnDongy.Enabled = true;
                btnDongy.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            }
        }

        private void btnDongy_MouseLeave(object sender, EventArgs e)
        {
            if (btnDongy.Enabled == true)
                btnDongy.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnDongy_MouseHover(object sender, EventArgs e)
        {
            btnDongy.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnBoQua_MouseLeave(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnBoQua_MouseHover(object sender, EventArgs e)
        {
            btnBoQua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }
    }
}