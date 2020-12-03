using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace SQLData
{
    class SQLQuery
    {
        private static string sqlconnectionstring = @"server=localhost;port=3307;UID=root;DATABASE=praktikanr2";

        public static bool connectToSql()
        {
            MySqlConnection con = new MySqlConnection(sqlconnectionstring);
            try
            {
                con.Open();
                MessageBox.Show("Connection Succeeded");
                con.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Connection Failed" + e);
                return false;
            }
        }
        public static bool LoginwithSql(string Username, string Password)
        {
            MySqlConnection con = new MySqlConnection(sqlconnectionstring);
            string MySqlQuery = string.Empty;
            MySqlQuery += "SELECT * FROM usertable ";
            MySqlQuery += "Where username = @user ";
            MySqlQuery += "AND Slaptazodis = @pass";
            try
            {
                MySqlCommand com = new MySqlCommand(MySqlQuery, con);
                com.Parameters.AddWithValue("@user", Username);
                com.Parameters.AddWithValue("@pass", Password);
                con.Open();
                MySqlDataReader myreader = com.ExecuteReader();
                if (myreader.Read() != true)
                {
                    MessageBox.Show("Nepavyko Prisijungti!");
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
                

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public static bool InsertDataFromSql(string Username, ref DataTable dat)
        {
            MySqlConnection con = new MySqlConnection(sqlconnectionstring);
            string SqlCommand = string.Empty;
            SqlCommand += "SELECT * FROM usertable ";
            SqlCommand += "Where username = '" + Username + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(SqlCommand, con);
            try
            {
                con.Open();
                
                //DataTable dt = new DataTable();
                da.Fill(dat);
                
                if (dat.Rows.Count == 1)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Critical Error there is no data in row");
                    con.Close();
                    return false;
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Connection Failed" + e);
                return false;
            }
        }

        public static DataTable ListGroups(string selectonly = "*", string condition = null)
        {
            //List<string> a = new List<string>();
            MySqlConnection con = new MySqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "SELECT "+ selectonly +" FROM groups";
            query += condition;
            try
            {
                MySqlDataAdapter b = new MySqlDataAdapter(query, con);
                con.Open();
                DataTable a = new DataTable();
                b.Fill(a);
                con.Close();
                return a;

            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public static DataTable SelectLectures(string condition = null)
        {
            //List<string> a = new List<string>();
            MySqlConnection con = new MySqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "SELECT * FROM lecturetable";
            query += condition;
            try
            {
                MySqlDataAdapter b = new MySqlDataAdapter(query, con);
                con.Open();
                DataTable a = new DataTable();
                b.Fill(a);
                con.Close();
                return a;

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public static void UpdateTable(string from, DataGridView dat)
        {
            MySqlConnection con = new MySqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "SELECT * FROM "+from+"";

            try
            {
                MySqlDataAdapter b = new MySqlDataAdapter(query, con);
                con.Open();
                MySqlCommandBuilder sad = new MySqlCommandBuilder(b);
                b.Update((DataTable)dat.DataSource);

                con.Close();
                

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                
            }
        }
    }
}
