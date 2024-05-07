using System;
using System.Collections.Generic;
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

namespace Auto_information_system
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TicketsUI_Loaded(object sender, RoutedEventArgs e)
        {
            gr1.Children.Clear();
            MainUI m = new MainUI();
            gr1.Children.Add(m);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gr1.Children.Clear();
            TicketsUI t = new TicketsUI();
            gr1.Children.Add(t);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            gr1.Children.Clear();
            MainUI m = new MainUI();
            gr1.Children.Add(m);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            gr1.Children.Clear();
            ReportUI r = new ReportUI();
            gr1.Children.Add(r);
        }
    }
}
