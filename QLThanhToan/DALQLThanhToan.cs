using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace QLThanhToan
{
    class DALQLThanhToan
    {
        string stconn = "Data source=.;Initial Catalog=QLThanhToan;Integrated security=true;User ID=sa; password=12345";
        DataSet ds;
        public string taoChuoiKetNoi()
        {
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Config.qltt");
            string dataFile = reader.ReadToEnd();
            reader.Dispose();
            return dataFile;
        }
        public bool testConnection()
        {
            bool thanhCong = true;
            SqlConnection cnn = new SqlConnection(taoChuoiKetNoi());
            try
            {
                cnn.Open();
            }
            catch (Exception)
            {
                thanhCong = false;
            }
            cnn.Dispose();
            return thanhCong;
        }
        /// <summary>Thủ tục thực hiện việc truy vấn lấy dữ liệu
        /// Thủ tục thực hiện việc truy vấn lấy dữ liệu
        /// </summary>
        /// <param name="sqlQuery">chuỗi chứa câu lệnh sql, hay tên thủ tục sql</param>
        /// <param name="commandTye">kiểu của sqlcommand</param>
        /// <param name="paramName">Danh sách tên các biến trong thủ tục sql</param>
        /// <param name="Value">Danh sách các giá trị tương ứng với pramname</param>
        /// <returns>DataSet chứa dữ liệu của kết quả truy vấn</returns>
        public DataSet ExecuteDataSetQuery(string sqlQuery, CommandType commandTye, string[] paramName, string[] Value)
        {
            SqlConnection conn = new SqlConnection(taoChuoiKetNoi());
            SqlCommand command = new SqlCommand();
            command.CommandType = commandTye;
            command.CommandText = sqlQuery;
            SqlParameter sqlpara;
            if (paramName!=null)
            {
                for (int i = 0; i < paramName.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = paramName[i];
                    sqlpara.SqlValue = Value[i];
                    command.Parameters.Add(sqlpara);
                }
            }
            command.Connection = conn;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            sqlDataAdapter.Dispose();
            return ds;
        }
        /// <summary>Thủ tục thực hiện việc cập nhật dữ liệu
        /// Thủ tục thực hiện việc cập nhật dữ liệu
        /// </summary>
        /// <param name="sqlQuery">Chuổi chứa câu lệnh sql hay thủ tên thủ tục sql</param>
        /// <param name="commandTye">kiểu của sqlcommand</param>
        /// <param name="paramName">Danh sách tên của các tham số trong thủ tục sql</param>
        /// <param name="Value">danh sách các giá trị tương ứng với paramName</param>
        /// <returns>giá trị kiểu int</returns>
        public int ExecuteNonQuery(string sqlQuery, CommandType commandTye, string[] paramName, string[] Value)
        {
            SqlConnection conn = new SqlConnection(taoChuoiKetNoi());
            SqlCommand command = new SqlCommand();
            command.CommandType = commandTye;
            command.CommandText = sqlQuery;
            SqlParameter sqlpara;
            if (paramName != null)
            {
                for (int i = 0; i < paramName.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = paramName[i];
                    sqlpara.SqlValue = Value[i];
                    command.Parameters.Add(sqlpara);
                }
            }
            command.Connection = conn;
            conn.Open();
            int ketQua = command.ExecuteNonQuery();
            conn.Close();
            return ketQua;
        }

        public double tinhTien(KhachHang kh, object obj, bool nuoc)
        {
            DataSet ds = new DataSet();
            double thanhTien;
            if (nuoc == true)
            {
                ds = ExecuteDataSetQuery("getInfoCTNuoc", CommandType.StoredProcedure, null, null);
                int count = ds.Tables[0].Rows.Count;
                DataTableReader tableReader = ds.CreateDataReader();
                QLNuoc qlNuoc = obj as QLNuoc;
                int soKhoiTieuThu = qlNuoc.ChiSoMoi - qlNuoc.ChiSoCu + qlNuoc.SoKhoiThamHut;
                if (soKhoiTieuThu < 4 * qlNuoc.SoThangSuDung)
                    soKhoiTieuThu = 4 * qlNuoc.SoThangSuDung;
                qlNuoc.ThanhTien = 0;
                while (tableReader.Read() && soKhoiTieuThu > 0)
                {
                    if (count > 1)
                    {
                        if (soKhoiTieuThu > Convert.ToInt16(tableReader[2]) * qlNuoc.SoThangSuDung)
                        {
                            thanhTien = Convert.ToInt16(tableReader[2]) * qlNuoc.SoThangSuDung * Convert.ToDouble(tableReader[3]);
                            thanhTien += thanhTien * Convert.ToDouble(tableReader[4]) / 100;
                        }
                        else
                        {
                            thanhTien = soKhoiTieuThu * Convert.ToDouble(tableReader[3]);
                            thanhTien += thanhTien * Convert.ToDouble(tableReader[4]) / 100;
                        }

                        soKhoiTieuThu = soKhoiTieuThu - Convert.ToInt16(tableReader[2]) * qlNuoc.SoThangSuDung;
                        count -= 1;
                    }
                    else
                    {
                        thanhTien = soKhoiTieuThu * Convert.ToDouble(tableReader[3]);
                        thanhTien += thanhTien * Convert.ToDouble(tableReader[4]) / 100;
                    }
                    qlNuoc.ThanhTien += thanhTien;
                }
                thanhTien = qlNuoc.ThanhTien;
            }
            else
            {
                ds = ExecuteDataSetQuery("getInfoCTDien", CommandType.StoredProcedure, null, null);
                int count = ds.Tables[0].Rows.Count;
                DataTableReader tableReader = ds.CreateDataReader();
                QLDien qlDien = obj as QLDien;
                int soChuTieuThu = qlDien.ChiSoMoi - qlDien.ChiSoCu;
                qlDien.ThanhTien = 0;
                while (tableReader.Read() && soChuTieuThu > 0)
                {
                    if (count > 1)
                    {
                        if (soChuTieuThu > Convert.ToInt16(tableReader[2]))
                        {
                            thanhTien = Convert.ToInt16(tableReader[2]) * Convert.ToDouble(tableReader[3]);
                            thanhTien += thanhTien * Convert.ToDouble(tableReader[4]) / 100;
                        }
                        else
                        {
                            thanhTien = soChuTieuThu * Convert.ToDouble(tableReader[3]);
                            thanhTien += thanhTien * Convert.ToDouble(tableReader[4]) / 100;
                        }

                        soChuTieuThu = soChuTieuThu - Convert.ToInt16(tableReader[2]);
                        count -= 1;
                    }
                    else
                    {
                        thanhTien = soChuTieuThu * Convert.ToDouble(tableReader[3]);
                        thanhTien = +thanhTien * Convert.ToDouble(tableReader[4]) / 100;
                    }
                    qlDien.ThanhTien += thanhTien;
                }
                thanhTien = qlDien.ThanhTien;
            }
            return thanhTien;
        }
    }
}
