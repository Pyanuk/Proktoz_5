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

namespace TEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            code.Visibility = Visibility.Collapsed;
        }

        private void start_test_Click(object sender, RoutedEventArgs e)
        {
            
            string rez = code.Text;           
            Okno tester = new Okno(rez);           
            tester.ShowDialog();
        }

        private void code_TextChanged(object sender, RoutedEventArgs e)
        {           
            string rez = code.Text;
            
            if (code.Text == "gei")
            {         
                Okno test = new Okno(rez);


                test.ShowDialog();
            }
        }

        private void edit_test_Click(object sender, RoutedEventArgs e)
        {
            
            code.Visibility = Visibility.Visible;
        }


    }
}
