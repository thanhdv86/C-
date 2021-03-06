using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThanhToan
{
    public partial class frmKhachHang : Form
    {
        DALQLThanhToan dal = new DALQLThanhToan();
        List<KhachHang> lstKH = new List<KhachHang>();
        bool nuoc;
        public frmKhachHang(List<KhachHang> _lstKH,bool _nuoc)
        {
            InitializeComponent();
            this.lstKH = _lstKH;
            this.nuoc = _nuoc;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            foreach (KhachHang kh in lstKH)
            {
                lbKhachHang.Items.Add(kh);
            }
            if (lbKhachHang.Items.Count > 0)
                lbKhachHang.SelectedIndex = 0;
            else
            {
                pnThongTin.Visible = false;
                btnXoa.Enabled = btnChinhSua.Enabled = false;
                btnXoa.BackgroundImage = btnChinhSua.BackgroundImage = null;
            }
        }

        private void lbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            KhachHang kh=new KhachHang();
            kh = lbKhachHang.SelectedItem as KhachHang;
            lbHoTen.Text = kh.HoTen;
            lbDiaChi.Text = kh.DiaChi;
            lbSoDT.Text = kh.SoDT;
            ckbGioiTinh.Checked = kh.GioiTinh;
            if (kh.LoaiKH != -1)
                btnDiChuyenThongTin.Visible = true;
            else
                btnDiChuyenThongTin.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] paramName ={ "@maKH" };
                string[] value ={ (lbKhachHang.SelectedItem as KhachHang).MaKH.ToString() };
                try
                {


                    if (nuoc == true)
                        dal.ExecuteNonQuery("deleteKhachHangNuoc", CommandType.StoredProcedure, paramName, value);
                    else
                        dal.ExecuteNonQuery("deleteKhachHangDien", CommandType.StoredProcedure, paramName, value);
                    int hight = lbKhachHang.Items.Count;
                    int index = lbKhachHang.SelectedIndex;
                    if (index > 0)
                    {
                        lbKhachHang.SelectedIndex = index - 1;
                        lbKhachHang.Items.Remove(lbKhachHang.Items[index]);
                    }
                    else if (index + 1 < hight)
                    {
                        lbKhachHang.SelectedIndex = index + 1;
                        lbKhachHang.Items.Remove(lbKhachHang.Items[index]);
                    }
                    else
                    {
                        lbKhachHang.Items.Clear();
                        pnThongTin.Visible = false;
                        btnXoa.Enabled=btnChinhSua.Enabled = false;
                        btnXoa.BackgroundImage = btnChinhSua.BackgroundImage = null;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmNew_Edit_KH frmNew = new frmNew_Edit_KH();
            frmNew.Text = "Tạo mới thông tin khách hàng";
            if (frmNew.ShowDialog() == DialogResult.OK)
            {
                string[] paramName ={ "@MaKH", "@HoTen", "@GioiTinh", "@DiaChi", "@SoDT", "@LoaiKH" };
                Guid maKH = Guid.NewGuid();
                int loaiKH;
                if (nuoc == true)
                    loaiKH = 0;
                else
                    loaiKH = 1;
                string[] value ={maKH.ToString(),frmNew.txtHoTen.Text,ckbGioiTinh.Checked.ToString(),frmNew.txtDiaChi.Text,frmNew.txtSoDT.Text,loaiKH.ToString() };
                if (dal.ExecuteNonQuery("insertInfoKH", CommandType.StoredProcedure, paramName, value) == 1)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = maKH;
                    kh.HoTen = frmNew.txtHoTen.Text;
                    kh.GioiTinh = frmNew.ckbGioiTinh.Checked;
                    kh.DiaChi = frmNew.txtDiaChi.Text;
                    kh.SoDT = frmNew.txtSoDT.Text;
                    lstKH.Add(kh);
                    lbKhachHang.Items.Add(kh);
                    lbKhachHang.SelectedIndex = lbKhachHang.Items.Count - 1;
                    pnThongTin.Visible = true;
                    if (btnXoa.Enabled == false)
                    {
                        btnXoa.Enabled = btnChinhSua.Enabled = true;
                        btnChinhSua.BackgroundImage = btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
                    }
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmNew_Edit_KH frmEdit = new frmNew_Edit_KH(lbKhachHang.SelectedItem);
            frmEdit.Text = "Chỉnh sửa thông tin khách hàng";
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                string[] paramName ={"@MaKH","@HoTen","@GioiTinh","@DiaChi","@SoDT"};
                string[] value ={ (lbKhachHang.SelectedItem as KhachHang).MaKH.ToString(), frmEdit.txtHoTen.Text, frmEdit.ckbGioiTinh.Checked.ToString(), frmEdit.txtDiaChi.Text, frmEdit.txtSoDT.Text };
                if (dal.ExecuteNonQuery("updateInfoKH", CommandType.StoredProcedure, paramName, value) == 1)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = (lbKhachHang.SelectedItem as KhachHang).MaKH;
                    kh.HoTen = frmEdit.txtHoTen.Text;
                    kh.GioiTinh = frmEdit.ckbGioiTinh.Checked;
                    kh.DiaChi = frmEdit.txtDiaChi.Text;
                    kh.SoDT = frmEdit.txtSoDT.Text;
                    int hight = lbKhachHang.Items.Count;
                    int index = lbKhachHang.SelectedIndex;
                    if (index > 0)
                    {
                        lbKhachHang.SelectedIndex = index - 1;
                        lbKhachHang.Items.Remove(lbKhachHang.Items[index]);
                    }
                    else if (index + 1 < hight)
                    {
                        lbKhachHang.SelectedIndex = index + 1;
                        lbKhachHang.Items.Remove(lbKhachHang.Items[index]);
                    }
                    else
                    {
                        lbKhachHang.Items.Clear();
                    }
                    lbKhachHang.Items.Add(kh);
                }
            }
        }

        private void btnDiChuyenThongTin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn di chuyển thông tin\n từ điện sang nước hoặc ngược lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhachHang kh = new KhachHang();
                kh = lbKhachHang.SelectedItem as KhachHang;
                string[] paramName ={"@MaKH"};
                string[] value ={ kh.MaKH.ToString() };
                if (dal.ExecuteNonQuery("moveInfo", CommandType.StoredProcedure, paramName, value) == 0)
                    MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    kh.LoaiKH = -1;
                    btnDiChuyenThongTin.Visible = false;
                }
            }
        }

        #region tạo hiệu ứng cho Button

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            if (btnXoa.Enabled == true)
                btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnDiChuyenThongTin_MouseLeave(object sender, EventArgs e)
        {
            if(btnDiChuyenThongTin.Enabled==true)
                btnDiChuyenThongTin.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnDiChuyenThongTin_MouseHover(object sender, EventArgs e)
        {
            btnDiChuyenThongTin.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnTaoMoi_MouseLeave(object sender, EventArgs e)
        {
            btnTaoMoi.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnTaoMoi_MouseHover(object sender, EventArgs e)
        {
            btnTaoMoi.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnChinhSua_MouseLeave(object sender, EventArgs e)
        {
            btnChinhSua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnChinhSua_MouseHover(object sender, EventArgs e)
        {
            btnChinhSua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }
        #endregion

    }
}