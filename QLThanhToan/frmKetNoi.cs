using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace QLThanhToan
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void btnKetNoi_MouseLeave(object sender, EventArgs e)
        {
            btnKetNoi.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnKetNoi_MouseHover(object sender, EventArgs e)
        {
            btnKetNoi.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnThuKetNoi_MouseLeave(object sender, EventArgs e)
        {
            btnThuKetNoi.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnThuKetNoi_MouseHover(object sender, EventArgs e)
        {
            btnThuKetNoi.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnThuKetNoi_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(string.Format("Data source={0};Initial Catalog={1};Integrated security=true;User ID={2}; password={3}", txtServerName.Text, txtCSDL.Text, txtUserID.Text, txtPassword.Text));
            try
            {
                cnn.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi kết nối!\nChi tiết lỗi:"+ exc.Message,"Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    MessageBox.Show("Kết nối thành công!");
                cnn.Close();
            }
            cnn.Dispose();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {            
            string line = string.Format("Data source={0};Initial Catalog={1};Integrated security=true;User ID={2}; password={3}", txtServerName.Text, txtCSDL.Text, txtUserID.Text, txtPassword.Text);
            using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\config.qltt"))
            {
                writer.WriteLine(line);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }
    }
}