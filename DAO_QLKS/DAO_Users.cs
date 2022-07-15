using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Data.SqlClient;
using System.Data;
namespace DAO_QLKS
{
    public class DAO_Users :DBConnect
    {
        //GET USER
        public DataTable getUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USER ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // GET USER NAME
        public DataTable getUserName()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT USERNAME FROM USER ",_conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //GET PASS
        public DataTable getPass()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT PASSWORD FROM USER ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //GET MAKS
        public DataTable getMAKS()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAKS FROM USER ", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Them user
        public bool themUser(DTO_Users us)
        {
            try
            {
             _conn.Open();
                string SQL = string.Format("INSERT INTO USER(USERNAME,PASSWORD,PHANQUYEN,MAKS) VALUES('{0}','{1}','{2}','{3}')", us.UserName, us.Password, us.Phanquyen, us.Maks);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
            _conn.Close();
            }
            return false;
        }
        //sua user
        public bool suaUser(DTO_Users us)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE [USER] SET PASSWORD = '{0}',PHANQUYEN = N'{1}', MAKS = '{2}' WHERE USERNAME = '{3}'",  us.Password, us.Phanquyen, us.Maks,us.UserName);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        //XOA USER
        public bool xoaUser(string id)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM[USER] WHERE USERNAME = '{0}'", id);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
