using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace pong
{
    public class DatabaseControler
    {
        private static string datasource = "Server=PC-PC;Database=PingPong;Trusted_Connection=True;";
        private static SqlConnection connection;
        private static SqlCommand cmd;
        private DatabaseControler ()
        {
            connection = new SqlConnection(datasource);
      
            cmd= new SqlCommand();
            cmd.Connection = connection;
 
        }
        private static DatabaseControler instance;
        public static DatabaseControler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseControler();
                }
                return instance;
            }
        }
        public void insert(string value,string cot)// them ten nguoi choi vào cột người chơi
        {
            connection.Open();
            try
            {

                string query = "insert into nguoichoi ("+cot+") values ('"+value+"')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }



        public void update(string value,string MAC)//update ten nguoi dung
        {
            connection.Open();
            try
            {

                string query = "update nguoichoi set TEN='"+value+"' where MAC='"+MAC+"'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
        public void updateHighscore(string value, string MAC)//update diem so cao nhat
        {
            connection.Open();
            try
            {

                string query = "update nguoichoi set highscore=" + value + " where MAC='" + MAC + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }

        public string select(string value,string MAC) // lấy dữ liệu value
        {
            string res="";
            connection.Open();
            try
            {
                string query = "select " + value + " from nguoichoi where MAC='" + MAC + "'";
                cmd.CommandText = query;
                SqlDataReader dataReader = cmd.ExecuteReader();//ExecuteReader dùng khi cần lấy giá trị trả về
                dataReader.Read();
                res = dataReader[value].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return res;
        }
        public string showlichsu(string MAC)
        {
            string res = "";
            connection.Open();
            try
            {
                string query = "select ThoiGian,POINT from choivoimay where MAC='" + MAC + "'";
                cmd.CommandText = query;
                SqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    res=res + "Time: "+ dataReader[0].ToString() + "       Point: "+dataReader[1].ToString()+"\n";
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return res;
        }
        public void xoalichsu (string MAC) // xóa lịch sử người chơi
        {
            connection.Open();
            try
            {
                string query = "delete * from choivoimay where MAC='" + MAC + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }

        public bool check(string name)
        {
            bool kiemtra;
            connection.Open();
            string query = "select * from nguoichoi where MAC='" + name + "'";
            cmd.CommandText = query;
            SqlDataReader reader= cmd.ExecuteReader();
            kiemtra = reader.Read();// kiemtra= true là có dữ liệu, = false là không có dữ liệu                   
            reader.Close();
            connection.Close();
            return kiemtra;
        }
    }

}
