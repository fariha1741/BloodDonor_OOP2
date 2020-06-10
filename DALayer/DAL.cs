using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BELayer;

namespace DALayer
{
    public class DAL
    {
        public SqlConnection con = new SqlConnection("Data Source=QFT;Initial Catalog=bdms;Persist Security Info=True;User ID=sa;Password=P@$sw0rd");
        public SqlCommand cmd = new SqlCommand();

        public int userDetailsInsertMethod(BEL obj)
        {

            bool available = checkUserName(obj._userName);

            if (available == true)
            {

                cmd.Connection = con;
                con.Open();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"INSERT INTO donor(user_name,password,phone,blood_group,address,activity,requested) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7)";
                cmd.Parameters.AddWithValue("@param1", obj._userName);
                cmd.Parameters.AddWithValue("@param2", obj._password);
                cmd.Parameters.AddWithValue("@param3", obj._phone);
                cmd.Parameters.AddWithValue("@param4", obj._bloodGroup);
                cmd.Parameters.AddWithValue("@param5", obj._address);
                cmd.Parameters.AddWithValue("@param6", obj._activity);
                cmd.Parameters.AddWithValue("@param7", obj._requested);

                int result = cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                con.Close();

                return result;
            }
            

            return -1;

        }

        public bool login(BEL obj)
        {
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"SELECT user_name,password from donor";

            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                if(obj._userName ==  reader.GetString(0) && obj._password == reader.GetString(1))
                {
                    con.Close();
                    return true;
                }
              
            }

            
            con.Close();
            return false;
        }

        public BEL getAll(BEL obj)
        {
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"SELECT * from donor where user_name = '"+obj._userName+"'";
           

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (obj._userName == reader.GetString(1))
                {
                    obj.userName = reader.GetString(1);
                    obj.password = reader.GetString(2);
                    obj.phone = reader.GetString(3);
                    obj.bloodGroup = reader.GetString(4);
                    obj.address = reader.GetString(5);
                    obj.activity = reader.GetString(6);
                    obj.requested = reader.GetString(7);

                    con.Close();
                    return obj;
                }

            }


            con.Close();
            return null;
        }

        public bool checkUserName(String userName)
        {
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"SELECT user_name from donor";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (userName == reader.GetString(0))
                {
                    con.Close();
                    return false;
                }

            }

            con.Close();
            return true;

        }

        public int setActivity(string userName,string activity)
        {
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"UPDATE donor SET activity = @param1 WHERE user_name = '"+userName+"'";
            cmd.Parameters.AddWithValue("@param1", activity);


            int result = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            con.Close();
            return result;
        }

        public int setRequest(string userName, string requested)
        {
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"UPDATE donor SET requested = @param1 WHERE user_name = '" + userName + "'";
            cmd.Parameters.AddWithValue("@param1", requested);


            int result = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            con.Close();
            return result;
        }

        public DataTable getAllDonors()
        {
            con.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from donor where activity = 'active'",con);
            DataTable dt = new DataTable();

            sqlData.Fill(dt);

            con.Close();

            return dt;
        }

        public DataTable getAllRequests()
        {
            con.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from donor where requested = 'yes'", con);
            DataTable dt = new DataTable();

            sqlData.Fill(dt);

            con.Close();

            return dt;


        }
    }
}
