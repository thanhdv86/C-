using System;
using System.Collections.Generic;
using System.Text;

namespace QLThanhToan
{
    class banGiaDien
    {
        #region Thuộc tính
        int maDinhMuc;

        public int MaDinhMuc
        {
            get { return maDinhMuc; }
            set { maDinhMuc = value; }
        }
        string tenDinhMuc;

        public string TenDinhMuc
        {
            get { return tenDinhMuc; }
            set { tenDinhMuc = value; }
        }
        int dinhMuc;

        public int DinhMuc
        {
            get { return dinhMuc; }
            set { dinhMuc = value; }
        }
        double giaDinhMuc;

        public double GiaDinhMuc
        {
            get { return giaDinhMuc; }
            set { giaDinhMuc = value; }
        }
        int thueVAT;

        public int ThueVAT
        {
            get { return thueVAT; }
            set { thueVAT = value; }
        }
        #endregion
        #region phương thức
        public override string ToString()
        {
            return TenDinhMuc.ToString();
        }
        #endregion
    }
}
