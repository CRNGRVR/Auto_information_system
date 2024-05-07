using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;


using System.Data;

namespace Auto_information_system
{
    /// <summary>
    /// Логика взаимодействия для TicketsUI.xaml
    /// </summary>
    /// 
    
    public partial class TicketsUI : UserControl
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable table;

        public TicketsUI()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            updateDB();
        }

        void updateDB()
        {
            string sql = "SELECT * FROM Users";
            table = new DataTable();
            SqlConnection connectioin = null;
            try
            {
                connectioin = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connectioin);
                adapter = new SqlDataAdapter(command);
                connectioin.Open();
                adapter.Fill(table);
                detailsDG.ItemsSource = table.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            detailsDG.SelectedItem = null;
        }
    }
}
