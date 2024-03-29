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
using System.Windows.Shapes;

namespace TEST
{
    /// <summary>
    /// Логика взаимодействия для Okno.xaml
    /// </summary>
    public partial class Okno : Window
    {
        public Okno(string rez)
        {
            InitializeComponent();

            
            edit_test_button.IsEnabled = rez == "gei";
        }

        private void start_test_button_Click(object sender, RoutedEventArgs e)
        {
            List<GetSet> tests = Save.Deserialize<List<GetSet>>();
            pages.Content = tests == null ? new Gei() : new Test();
        }

        private void edit_test_button_Click(object sender, RoutedEventArgs e)
        {

            pages.Content = new Redactor();
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
