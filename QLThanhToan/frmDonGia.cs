using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThanhToan
{
    public partial class frmDonGia : Form
    {
        DALQLThanhToan dal = new DALQLThanhToan();
        bool nuoc;
        public frmDonGia(bool _nuoc)
        {
            InitializeComponent();
            this.nuoc = _nuoc;
        }

        private void frmDonGia_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (nuoc == true)
            {
                List<banGiaNuoc> lstGiaNuoc = new List<banGiaNuoc>();
                ds = dal.ExecuteDataSetQuery("getInfoCTNuoc", CommandType.StoredProcedure, null, null);
                DataTableReader reader = ds.CreateDataReader();
                banGiaNuoc giaNuoc;
                while (reader.Read())
                {
                    giaNuoc = new banGiaNuoc();
                    giaNuoc.MaDinhMuc = Convert.ToInt16(reader[0]);
                    giaNuoc.TenDinhMuc = reader[1].ToString();
                    giaNuoc.DinhMuc = Convert.ToInt32(reader[2]);
                    giaNuoc.GiaDinhMuc = Convert.ToDouble(reader[3]);
                    giaNuoc.ThueVAT = Convert.ToInt16(reader[4]);
                    lstGiaNuoc.Add(giaNuoc);
                    lbDonGia.Items.Add(giaNuoc);
                }
            }
            else
            {

                List<banGiaDien> lstGiaDien = new List<banGiaDien>();
                ds = dal.ExecuteDataSetQuery("getInfoCTDien", CommandType.StoredProcedure, null, null);
                DataTableReader reader = ds.CreateDataReader();
                banGiaDien giaDien;
                while (reader.Read())
                {
                    giaDien = new banGiaDien();
                    giaDien.MaDinhMuc = Convert.ToInt16(reader[0]);
                    giaDien.TenDinhMuc = reader[1].ToString();
                    giaDien.DinhMuc = Convert.ToInt16(reader[2]);
                    giaDien.GiaDinhMuc = Convert.ToDouble(reader[3]);
                    giaDien.ThueVAT = Convert.ToInt16(reader[4]);
                    lstGiaDien.Add(giaDien);
                    lbDonGia.Items.Add(giaDien);
                }
            }
            if (lbDonGia.Items.Count > 0)
                lbDonGia.SelectedIndex = 0;
            else
            {
                btnChinhSua.Enabled = btnXoa.Enabled = false;
                btnXoa.BackgroundImage = btnChinhSua.BackgroundImage = null;
            }
        }

        private void lbDonGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nuoc == true)
            {
                banGiaNuoc gia = new banGiaNuoc();
                gia = lbDonGia.SelectedItem as banGiaNuoc;
                lbTenDinhMuc.Text = gia.TenDinhMuc;
                lbDinhMuc.Text = gia.DinhMuc.ToString() + " Khối";
                lbGiaDinhMuc.Text = gia.GiaDinhMuc.ToString()+" VNĐ";
                lbThueVAT.Text = gia.ThueVAT.ToString()+" %";
            }
            else
            { 
                banGiaDien gia = new banGiaDien();
                gia = lbDonGia.SelectedItem as banGiaDien;
                lbTenDinhMuc.Text = gia.TenDinhMuc;
                lbDinhMuc.Text = gia.DinhMuc.ToString() + " Kw/h";
                lbGiaDinhMuc.Text = gia.GiaDinhMuc.ToString()+" VNĐ";
                lbThueVAT.Text = gia.ThueVAT.ToString()+" %";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (nuoc == true)
                {
                    banGiaNuoc gia = lbDonGia.SelectedItem as banGiaNuoc;
                    string[] paramName ={ "@MaDinhMuc" };
                    string[] value ={ gia.MaDinhMuc.ToString() };
                    dal.ExecuteNonQuery("deleteCTNuoc", CommandType.StoredProcedure, paramName, value);
                }
                else
                {
                    banGiaDien gia = lbDonGia.SelectedItem as banGiaDien;
                    string[] paramName ={ "@MaDinhMuc" };
                    string[] value ={ gia.MaDinhMuc.ToString() };
                    dal.ExecuteNonQuery("deleteCTDien", CommandType.StoredProcedure, paramName, value);
                }
                int hight = lbDonGia.Items.Count;
                int index = lbDonGia.SelectedIndex;
                if (index > 0)
                {
                    lbDonGia.SelectedIndex = index - 1;
                    lbDonGia.Items.Remove(lbDonGia.Items[index]);
                }
                else if (index + 1 < hight)
                {
                    lbDonGia.SelectedIndex = index + 1;
                    lbDonGia.Items.Remove(lbDonGia.Items[index]);
                }
                else
                {
                    lbDonGia.Items.Clear();
                    btnChinhSua.Enabled = btnXoa.Enabled = false;
                    btnXoa.BackgroundImage = btnChinhSua.BackgroundImage = null;
                    label1.Text = label2.Text = label3.Text = label6.Text =lbDinhMuc.Text=lbGiaDinhMuc.Text=lbTenDinhMuc.Text=lbThueVAT.Text= "";
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frmNew_Edit frmNew = new frmNew_Edit(nuoc);
            frmNew.Text = "Tạo mới Đơn giá";
            if (frmNew.ShowDialog() == DialogResult.OK)
            {
                string sqlQuery = "";
                if (nuoc == true)
                    sqlQuery = "insertCTNuoc";
                else
                    sqlQuery = "insertCTDien";
                string[] paramName ={ "@TenDinhMuc","@DinhMuc","@GiaDinhMuc","@ThueVAT"};
                string[] value ={frmNew.txtTenDinhMuc.Text,frmNew.TxtDinhMuc.Text,frmNew.txtGia.Text,frmNew.numberVAT.Value.ToString() };
                if (dal.ExecuteNonQuery(sqlQuery, CommandType.StoredProcedure, paramName, value) == 1)
                {
                    lbDonGia.Items.Clear();
                    frmDonGia_Load(null, null);
                    btnChinhSua.Enabled = btnXoa.Enabled = true;
                    btnXoa.BackgroundImage = btnChinhSua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
                }
                else
                    MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmNew_Edit frmEdit = new frmNew_Edit(lbDonGia.SelectedItem, nuoc);
            frmEdit.Text = "Chỉnh sửa đơn giá";
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                string[] paramName ={ "@MaDinhMuc","@TenDinhMuc", "@DinhMuc", "@GiaDinhMuc", "@ThueVAT" };
                if (nuoc == true)
                {
                    string[] value ={ (lbDonGia.SelectedItem as banGiaNuoc).MaDinhMuc.ToString(), frmEdit.txtTenDinhMuc.Text, frmEdit.TxtDinhMuc.Text, frmEdit.txtGia.Text, frmEdit.numberVAT.Value.ToString() };
                    if (dal.ExecuteNonQuery("updateCTNuoc", CommandType.StoredProcedure, paramName, value) == 1)
                    {
                        lbDonGia.Items.Clear();
                        frmDonGia_Load(null, null);
                    }
                    else
                        MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] value ={ (lbDonGia.SelectedItem as banGiaDien).MaDinhMuc.ToString(), frmEdit.txtTenDinhMuc.Text, frmEdit.TxtDinhMuc.Text, frmEdit.txtGia.Text, frmEdit.numberVAT.Value.ToString() };
                    if (dal.ExecuteNonQuery("updateCTDien", CommandType.StoredProcedure, paramName, value) == 1)
                    {
                        lbDonGia.Items.Clear();
                        frmDonGia_Load(null, null);
                    }
                    else
                        MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            if (btnXoa.Enabled == true)
                btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
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
            if (btnChinhSua.Enabled == true)
                btnChinhSua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnChinhSua_MouseHover(object sender, EventArgs e)
        {
            btnChinhSua.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }
    }
}