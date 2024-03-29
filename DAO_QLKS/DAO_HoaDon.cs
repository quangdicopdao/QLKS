﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Data;
using System.Data.SqlClient;
namespace DAO_QLKS
{
    public class DAO_HoaDon : DBConnect
    {
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [HOADON]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // GET MAHD
        public DataTable getMahd()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAHD FROM [HOADON]", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool themHoaDon(DTO_HoaDon tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO [HOADON](MAHD,MAKH) VALUES('{0}', '{1}')", tv.Mahd,tv.Makh);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close(); // Đóng kết nối
            }
            return false;
        }
    }
}
