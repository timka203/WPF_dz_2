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

namespace Wpf_for_dz
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 mainWindow = new MainWindow1();
            mainWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow2 mainWindow = new MainWindow2();
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow3 mainWindow = new MainWindow3();
            mainWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
