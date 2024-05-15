using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Net.NetworkInformation;
using System.Configuration;

namespace Auto_information_system
{
    static class DB
    {
        static String connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static DataTable update()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table;
            string sql = "SELECT * FROM Tickets";
            table = new DataTable();
            SqlConnection connectioin = null;
            try
            {
                connectioin = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connectioin);
                adapter = new SqlDataAdapter(command);
                connectioin.Open();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //static DataTable updateDB()
        //{
        //    DataTable table;
        //    string sql = "SELECT * FROM Tickets";
        //    table = new DataTable();
        //    SqlConnection connectioin = null;
        //    try
        //    {
        //        connectioin = new SqlConnection(connectionString);
        //        SqlCommand command = new SqlCommand(sql, connectioin);
        //        adapter = new SqlDataAdapter(command);
        //        connectioin.Open();
        //        adapter.Fill(table);
        //        detailsDG.ItemsSource = table.DefaultView;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    detailsDG.SelectedItem = null;
        //}

        public static DataTable search(string like)
        {
            DataTable table;
            SqlDataAdapter adapter;
            string sql = "SELECT * FROM Tickets WHERE title LIKE N'%" + like + "%'";
            table = new DataTable();
            SqlConnection connectioin = null;
            try
            {
                connectioin = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connectioin);
                adapter = new SqlDataAdapter(command);
                connectioin.Open();
                adapter.Fill(table);
                //detailsDG.ItemsSource = table.DefaultView;
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            //detailsDG.SelectedItem = null;
        }
    }
}
