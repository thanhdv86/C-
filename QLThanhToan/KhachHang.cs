using System;
using System.Collections.Generic;
using System.Text;

namespace QLThanhToan
{
    public partial class KhachHang
    {
        #region Thuộc tính
        Guid maKH;

        public Guid MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        bool gioiTinh;

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        string soDT;

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        int loaiKH;

        public int LoaiKH
        {
            get { return loaiKH; }
            set { loaiKH = value; }
        }
        #endregion
        #region Phương thức
        /// <summary>
        /// Phuong thux khoi dung
        /// </summary>
        public KhachHang()
        {}

        public KhachHang(Guid _maKH, string _hoTen,bool _gioiTinh, string _diaChi, String _soDT)
        {
            _maKH = MaKH;
            _hoTen = HoTen;
            _gioiTinh = GioiTinh;
            _diaChi = DiaChi;
            _soDT = SoDT;
        }

        public override string ToString()
        {
            return HoTen;
        }
        #endregion
    }
}
