using System;
using System.Collections.Generic;
using System.Text;

namespace QLThanhToan
{
    public partial class QLNuoc
    {
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
        int soKhoiSD;

        public int SoKhoiSD
        {
            get { return soKhoiSD; }
            set { soKhoiSD = value; }
        }
        int soThangSuDung;

        public int SoThangSuDung
        {
            get { return soThangSuDung; }
            set { soThangSuDung = value; }
        }
        int soKhoiThamHut;

        public int SoKhoiThamHut
        {
            get { return soKhoiThamHut; }
            set { soKhoiThamHut = value; }
        }
        double thanhTien;

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
}
}
