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
            table = DB.update();
            detailsDG.ItemsSource = table.DefaultView;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb.Text == "")
            {
                table = DB.update();
                detailsDG.ItemsSource = table.DefaultView;
            }
            else
            {
                table = DB.search(tb.Text);
                detailsDG.ItemsSource = table.DefaultView;
            } 
        }
    }
}
