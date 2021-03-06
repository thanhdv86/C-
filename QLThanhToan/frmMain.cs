using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace QLThanhToan
{
    public partial class frmMain : Form
    {
        DataSet dsDien;
        DataSet dsNuoc;
        List<KhachHang> lstKH = new List<KhachHang>();
        DALQLThanhToan dal = new DALQLThanhToan();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            dsNuoc = new DataSet();
            lstKH.Clear();
            lvThongTin.Columns.Clear();
            lbKhachHang.Items.Clear();
            btnDien.Enabled = true;
            btnNuoc.Enabled = false;
            btnDien.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            btnNuoc.BackgroundImage = null;
            btnThanhToan.Text = "Ghi chỉ số nước";
            dsNuoc = dsKhachHang("getinfoKhachHangNuoc");
            listBoxKhachHang(dsNuoc);            
        }

        private void btnDien_Click(object sender, EventArgs e)
        {
            dsDien = new DataSet();
            lstKH.Clear();
            lvThongTin.Columns.Clear();
            lbKhachHang.Items.Clear();
            btnDien.Enabled = false;
            btnNuoc.Enabled = true;
            btnNuoc.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            btnDien.BackgroundImage = null;
            btnThanhToan.Text = "Ghi chỉ số điện";
            dsDien = dsKhachHang("getinfoKhachHangDien");
            listBoxKhachHang(dsDien);
        }
        /// <summary>
        /// Nạp thông tin khách hàng vào listBox
        /// </summary>
        /// <param name="ds">DataSet chứa thông tin cần đưa vào listBox</param>
        void listBoxKhachHang(DataSet ds)
        {
            DataTableReader sqlReader = ds.CreateDataReader();
            KhachHang kh;
            while (sqlReader.Read())
            {
                kh = new KhachHang();
                kh.MaKH = new Guid(sqlReader[0].ToString());
                kh.HoTen = sqlReader[1].ToString();
                kh.GioiTinh = Convert.ToBoolean(sqlReader[2]);
                kh.DiaChi = sqlReader[3].ToString();
                kh.SoDT = sqlReader[4].ToString();
                kh.LoaiKH = Convert.ToInt16(sqlReader[5]);
                lstKH.Add(kh);
                lbKhachHang.Items.Add(kh);
            }
            if (lbKhachHang.Items.Count > 0)
            {
                lbKhachHang.SelectedIndex = 0;
                btnThanhToan.Enabled = true;
                btnThanhToan.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnThanhToan.BackgroundImage = null;
            }
        }
        /// <summary>
        /// Truy vấn lấy thông tin khách hàng lưu vào DataSet
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <returns>DataSet chứa thông tin khách hàng</returns>
        DataSet dsKhachHang(string sqlQuery)
        {
            DataSet ds = new DataSet();
            ds = dal.ExecuteDataSetQuery(sqlQuery,CommandType.StoredProcedure,null,null);
            return ds;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool testConnec = false;
            if (dal.testConnection() == true)
            {
                dsNuoc = dsKhachHang("getInfoKhachHangNuoc");
                listBoxKhachHang(dsNuoc);
            }
            else
            {
                frmKetNoi frm = new frmKetNoi();
                while (testConnec == false)
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        testConnec = dal.testConnection();
                    }
                    else
                        break;
                }
                if (testConnec == true)
                {
                    dsNuoc = dsKhachHang("getInfoKhachHangNuoc");
                    listBoxKhachHang(dsNuoc);
                }
            }
        }

        private void lbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInHoaDon.Enabled = false;
            btnInHoaDon.BackgroundImage = null;
            KhachHang kh = new KhachHang();
            kh = lbKhachHang.SelectedItem as KhachHang;
            if (btnNuoc.Enabled == false)
            {
                khoiTaoColumn(true);
                hienThiThongTin("getInfoSoKhoiNuoc", kh,true);
            }
            else
            {
                khoiTaoColumn(false);
                hienThiThongTin("getInfoSoChuDien", kh,false);
            }
        }
        /// <summary>Khởi tạo column cho listView
        /// Khởi tạo column cho listView
        /// </summary>
        /// <param name="nuoc">true nếu là quản lí nước, fale(Điện)</param>
        void khoiTaoColumn(bool nuoc)
        {
            lvThongTin.Columns.Clear();
            lvThongTin.Columns.Add("Ngày Lập", 80);
            lvThongTin.Columns.Add("Chỉ số cũ", 70);
            lvThongTin.Columns.Add("Chỉ số mới", 75);
            if (nuoc==true)
            {
                lvThongTin.Columns.Add("Số khối thâm hụt", 108);
                lvThongTin.Columns.Add("Số tháng sử dụng", 112);
            }
            lvThongTin.Columns.Add("Thành tiền", 90);
        }
        /// <summary>nạp thông tin vào listView
        /// nạp thông tin vào listView
        /// </summary>
        /// <param name="sqlQuery">Chuổi chứa câu lệnh sql, hay tên thủ tục sql</param>
        /// <param name="kh"> khách hàng cần lấy thông tin</param>
        void hienThiThongTin(string sqlQuery, KhachHang kh,bool nuoc)
        {
            string[] paramName ={ "@MaKH" };
            string[] value ={ kh.MaKH.ToString() };
            DataSet ds = new DataSet();
            ds = dal.ExecuteDataSetQuery(sqlQuery, CommandType.StoredProcedure, paramName, value);
            DataTableReader reader = ds.CreateDataReader();
            lvThongTin.Items.Clear();
            if (nuoc == true)
            {
                while (reader.Read())
                {
                    QLNuoc qlNuoc = new QLNuoc();
                    qlNuoc.NgayLap = Convert.ToDateTime(reader[0]);
                    qlNuoc.ChiSoCu = Convert.ToInt32(reader[1]);
                    qlNuoc.ChiSoMoi = Convert.ToInt32(reader[2]);
                    qlNuoc.SoKhoiThamHut = Convert.ToInt32(reader[3]);
                    qlNuoc.SoThangSuDung = Convert.ToInt32(reader[4]);
                    qlNuoc.ThanhTien = Convert.ToDouble(reader[5]);
                    ListViewItem lvi = new ListViewItem(qlNuoc.NgayLap.ToShortDateString());
                    lvi.SubItems.Add(reader[1].ToString());
                    lvi.SubItems.Add(reader[2].ToString());
                    lvi.SubItems.Add(reader[3].ToString());
                    lvi.SubItems.Add(reader[4].ToString());
                    lvi.SubItems.Add(reader[5].ToString());
                    lvi.Tag = qlNuoc;
                    lvThongTin.Items.Add(lvi);
                    
                }
            }
            else
            {
                while (reader.Read())
                {
                    QLDien qlDien = new QLDien();
                    qlDien.NgayLap = Convert.ToDateTime(reader[0]);
                    qlDien.ChiSoCu = Convert.ToInt32(reader[1]);
                    qlDien.ChiSoMoi = Convert.ToInt32(reader[2]);
                    qlDien.ThanhTien = Convert.ToDouble(reader[3]);
                    ListViewItem lvi = new ListViewItem(qlDien.NgayLap.ToShortDateString());
                    lvi.SubItems.Add(reader[1].ToString());
                    lvi.SubItems.Add(reader[2].ToString());
                    lvi.SubItems.Add(reader[3].ToString());
                    lvi.Tag = qlDien;
                    lvThongTin.Items.Add(lvi);
                    
                }
            }
            if (lvThongTin.Items.Count > 0)
            {
                btnXoa.Enabled = true;
                btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            }
            else
            {
                btnXoa.Enabled = false;
                btnXoa.BackgroundImage = null;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            int i = lvThongTin.Items.Count;
            ListViewItem lvi = new ListViewItem();
            if (i > 0)
            {
                lvi = lvThongTin.Items[i - 1];
            }
            kh = lbKhachHang.SelectedItem as KhachHang;
            if (btnThanhToan.Text == "Ghi chỉ số nước")
            {
                QLNuoc nuoc = lvi.Tag as QLNuoc;
                frmChiSoNuoc frm = new frmChiSoNuoc(kh,nuoc);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnXoa.Enabled = true;
                    QLNuoc qlNuoc = new QLNuoc();
                    qlNuoc.NgayLap = Convert.ToDateTime(frm.dtpNgayLap.Value);
                    qlNuoc.ChiSoCu = Convert.ToInt32(frm.txtChiSoCu.Text);
                    qlNuoc.ChiSoMoi = Convert.ToInt32(frm.txtChiSoMoi.Text);
                    qlNuoc.SoKhoiThamHut = Convert.ToInt32(frm.txtSoKhoiTH.Text);
                    qlNuoc.SoThangSuDung = Convert.ToInt32(frm.txtSothangSD.Text);
                    qlNuoc.ThanhTien = dal.tinhTien(kh, qlNuoc as object, true);
                    lvi = new ListViewItem(frm.dtpNgayLap.Value.ToShortDateString());
                    lvi.SubItems.Add(frm.txtChiSoCu.Text);
                    lvi.SubItems.Add(frm.txtChiSoMoi.Text);
                    lvi.SubItems.Add(frm.txtSoKhoiTH.Text);
                    lvi.SubItems.Add(frm.txtSothangSD.Text);
                    lvi.SubItems.Add(qlNuoc.ThanhTien.ToString());
                    lvi.Tag = qlNuoc;
                    lvThongTin.Items.Add(lvi);
                    //Cập nhật thông tin vào cơ sở dữ liệu
                    string[] paramName ={ "@MaKH", "@NgayLap", "@ChiSoCu", "@ChiSoMoi", "@SoThangSD", "@SoKhoiThamHut", "@ThanhTien" };
                    string[] value ={kh.MaKH.ToString(),qlNuoc.NgayLap.ToString(),qlNuoc.ChiSoCu.ToString(),qlNuoc.ChiSoMoi.ToString(),
                    qlNuoc.SoThangSuDung.ToString(),qlNuoc.SoKhoiThamHut.ToString(),qlNuoc.ThanhTien.ToString() };
                    dal.ExecuteNonQuery("insertInfoSoKhoiNuoc", CommandType.StoredProcedure, paramName, value);
                }
            }
            else
            {
                QLDien qlDien=new QLDien();
                qlDien = lvi.Tag as QLDien;
                frmGhiChiSoDien frm = new frmGhiChiSoDien(kh, qlDien);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    qlDien=new QLDien();
                    qlDien.NgayLap = Convert.ToDateTime(frm.dtpNgayLap.Value);
                    qlDien.ChiSoCu = Convert.ToInt32(frm.txtChiSoCu.Text);
                    qlDien.ChiSoMoi = Convert.ToInt32(frm.txtChiSoMoi.Text);
                    qlDien.ThanhTien = dal.tinhTien(kh, qlDien as object, false);
                    lvi = new ListViewItem(frm.dtpNgayLap.Value.ToShortDateString());                    
                    lvi.SubItems.Add(frm.txtChiSoCu.Text);
                    lvi.SubItems.Add(frm.txtChiSoMoi.Text);
                    lvi.SubItems.Add(qlDien.ThanhTien.ToString());
                    lvi.Tag = qlDien;
                    lvThongTin.Items.Add(lvi);
                    //Cập nhật thông tin vào cơ sở dữ liệu
                    string[] paramName ={ "@MaKH","@NgayLap", "@ChiSoCu", "@ChiSoMoi", "@ThanhTien" };
                    string[] value ={kh.MaKH.ToString(), qlDien.NgayLap.ToString(), qlDien.ChiSoCu.ToString(), qlDien.ChiSoMoi.ToString(), qlDien.ThanhTien.ToString() };
                    dal.ExecuteNonQuery("insertInfoSoChuDien", CommandType.StoredProcedure, paramName, value);
                }
            }
            if (lvThongTin.Items.Count > 0)
            {
                btnXoa.Enabled = true;
                btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            }
            else
            {
                btnXoa.Enabled = false;
                btnXoa.BackgroundImage = null;
            }
        }

        private void BtnDonGia_Click(object sender, EventArgs e)
        {
            if (btnNuoc.Enabled == false)
            {
                frmDonGia frm = new frmDonGia(true);
                frm.ShowDialog();
            }
            else
            {
                frmDonGia frm = new frmDonGia(false);
                frm.ShowDialog();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm;
            if (btnNuoc.Enabled == false)
            {
                frm = new frmKhachHang(lstKH, true);
                frm.ShowDialog();
                btnNuoc_Click(null, null);
            }
            else
            {
                frm = new frmKhachHang(lstKH, false);
                frm.ShowDialog();
                btnDien_Click(null, null);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lvThongTin.FocusedItem != null)
                {
                    ListViewItem lvi = lvThongTin.FocusedItem;
                    if (btnNuoc.Enabled == false)
                    {
                        QLNuoc qlNuoc = lvi.Tag as QLNuoc;
                        string[] paramName ={ "@MaKH", "@NgayLap" };
                        string[] value ={ (lbKhachHang.SelectedItem as KhachHang).MaKH.ToString(), qlNuoc.NgayLap.ToString() };
                        dal.ExecuteNonQuery("deleteInfoSoKhoiNuoc", CommandType.StoredProcedure, paramName, value);
                    }
                    else
                    {
                        QLDien qlDien = lvi.Tag as QLDien;
                        string[] paramName ={ "@MaKH", "@NgayLap" };
                        string[] value ={ (lbKhachHang.SelectedItem as KhachHang).MaKH.ToString(), qlDien.NgayLap.ToString() };
                        dal.ExecuteNonQuery("deleteInfoSoChuDien", CommandType.StoredProcedure, paramName, value);
                    }
                    lvThongTin.FocusedItem.Remove();
                    if (lvThongTin.Items.Count > 0)
                    {
                        btnXoa.Enabled = true;
                        btnXoa.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
                    }
                    else
                    {
                        btnXoa.Enabled = false;
                        btnXoa.BackgroundImage = null;
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #region Hiệu ứng cho các Button

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            btnKhachHang.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnKhachHang_MouseHover(object sender, EventArgs e)
        {
            btnKhachHang.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btnThanhToan.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnThanhToan_MouseHover(object sender, EventArgs e)
        {
            btnThanhToan.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void BtnDonGia_MouseLeave(object sender, EventArgs e)
        {
            BtnDonGia.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void BtnDonGia_MouseHover(object sender, EventArgs e)
        {
            BtnDonGia.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
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

        #endregion

        private void btnDien_MouseLeave(object sender, EventArgs e)
        {
            if (btnDien.Enabled == true)
                btnDien.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnDien_MouseHover(object sender, EventArgs e)
        {
            btnDien.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
            //Label lb = new Label();
            //lb.Location = System.Drawing.Point(MousePosition.X,MousePosition.Y);
        }

        private void btnNuoc_MouseLeave(object sender, EventArgs e)
        {
            if (btnNuoc.Enabled == true)
                btnNuoc.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnNuoc_MouseHover(object sender, EventArgs e)
        {
            btnNuoc.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;          
        }

        private void btnInHoaDon_MouseLeave(object sender, EventArgs e)
        {
            if (btnInHoaDon.Enabled == true)
                btnInHoaDon.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
        }

        private void btnInHoaDon_MouseHover(object sender, EventArgs e)
        {
            btnInHoaDon.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround_Light;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            PrintDialog printDiag = new PrintDialog();
            string[] textDocument=new string[10];
            // 1. Tạo tài liệu cần in
            textDocument[0] = "HÓA ĐƠN TIỀN NƯỚC";
            textDocument[3] = "Tên khách hàng : " + (lbKhachHang.SelectedItem as KhachHang).HoTen;
            textDocument[4] = "Địa chỉ : " + (lbKhachHang.SelectedItem as KhachHang).DiaChi;
            if (btnNuoc.Enabled == false)
            {
                QLNuoc nuoc = new QLNuoc();
                nuoc = lvThongTin.FocusedItem.Tag as QLNuoc;
                textDocument[1] = string.Format("Ngày {0} tháng {1} năm {2}", nuoc.NgayLap.Day.ToString(), nuoc.NgayLap.Month.ToString(), nuoc.NgayLap.Year.ToString());
                textDocument[5] = "Chỉ số cũ : " + nuoc.ChiSoCu.ToString();
                textDocument[6] = "Chỉ số mới : " + nuoc.ChiSoMoi.ToString();
                textDocument[7] = "Số khối sử dụng : " + (nuoc.ChiSoMoi-nuoc.ChiSoCu).ToString();
                textDocument[8] = "Số khối thâm hụt : " + nuoc.SoKhoiThamHut.ToString();
                textDocument[9] = "Thành tiền : " +Convert.ToInt64(nuoc.ThanhTien).ToString()+" đồng";
            }
            else
            {
                QLDien dien = lvThongTin.FocusedItem.Tag as QLDien;
                textDocument[0] = "HÓA ĐƠN TIỀN ĐIỆN";
                textDocument[1] = string.Format("Ngày {0} tháng {1} năm {2}", dien.NgayLap.Day.ToString(), dien.NgayLap.Month.ToString(), dien.NgayLap.Year.ToString());
                textDocument[5] = "Chỉ số cũ : " + dien.ChiSoCu.ToString();
                textDocument[6] = "Chỉ số mới : " + dien.ChiSoMoi.ToString();
                textDocument[7] = "Thành tiền : " +Convert.ToInt64(dien.ThanhTien).ToString()+" đồng";
            }
            // 2. Thực hiện in tài liệu
            //2.1. Gán tài liệu cần in vào phương thức thụ lí sự kiện
            PrintDocument doc = new PrintText(textDocument);
            doc.PrintPage += new PrintPageEventHandler(this.doc_PrintPage);
            printDiag.Document = doc;
            if (printDiag.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        { 
            // Thu lấy văn bản đã gửi sự kiện
            PrintText doc = (PrintText) sender;
            // Định nghĩa font.
            Font font = new Font("Tohoma", 12);
            // xác định chiều cao của một dòng.
            float lineHigh = font.GetHeight(e.Graphics);
            // tạo các biến lưu giữ vị trí trên trang
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            //Tăng biến đếm cho trang để biết số trang đã được in.
            doc.PageNumber += 1;
            // In tất cả thông tin vừa khít trên trang.       
            // Vòng lặp này kết thúc khi dòng kế tiếp vượt quá biên lề,
            // hoặc không còn dòng nào để in.
            float g = doc.TextDocument.GetUpperBound(0);
            while (y + lineHigh < e.MarginBounds.Bottom && doc.LineNumber <= doc.TextDocument.GetUpperBound(0))
            {
                e.Graphics.DrawString(doc.TextDocument[doc.LineNumber], font, Brushes.Black,x,y, StringFormat.GenericDefault);
                // Dịch đến dòng dữ liệu kế tiếp
                doc.LineNumber += 1;
                // Dịch đến dòng kế tiếp trên trang.
                y += lineHigh;
                if (doc.LineNumber < doc.TextDocument.GetUpperBound(0))//Nếu dữ liệu còn ít nhất một trang nữa
                    e.HasMorePages = true;//cho biết sự kiện printPage được phát sinh một lần nữa
                else
                {
                    //doc.LineNumber = 0;
                    e.HasMorePages = false;
                }
            }
        }
        private void lvThongTin_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvThongTin.FocusedItem != null)
            {
                btnInHoaDon.Enabled = true;
                btnInHoaDon.BackgroundImage = global::QLThanhToan.Properties.Resources.btn_BackGround;
            }
            else
            {
                btnInHoaDon.Enabled = false;
                btnInHoaDon.BackgroundImage = null;
            }
        }
    }
}