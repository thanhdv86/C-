using System;
using System.Collections.Generic;
using System.Text;

namespace QLThanhToan
{
    public partial class QLDien
    {
        #region Thuộc tính
        DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        int chiSoCu;

        public int ChiSoCu
        {
            get { return chiSoCu; }
            set { chiSoCu = value; }
        }
        int chiSoMoi;

        public int ChiSoMoi
        {
            get { return chiSoMoi; }
            set { chiSoMoi = value; }
        }
        int soChuSD;

        public int SoChuSD
        {
            get { return soChuSD; }
            set { soChuSD = value; }
        }
        double thanhTien;

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        #endregion

        #region Phương thức
        #endregion
}
}
