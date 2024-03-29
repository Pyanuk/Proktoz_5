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
    /// Логика взаимодействия для Redactor.xaml
    /// </summary>
    public partial class Redactor : Window
    {
        private List<GetSet> testiks = new List<GetSet>();

        public Redactor()
        {
            InitializeComponent();
            tablichka.ItemsSource = testiks;
        }

        private void tablichka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Save.Serialize(testiks);
        }

        private void add_que_Click(object sender, RoutedEventArgs e)
        {
            testiks.Add(new GetSet("Сладенький", "Позвони мне", "ответ1", "ответ2", "ответ3", TestEnum.vop1));
            Save.Serialize(testiks.Count + 1);
            tablichka.ItemsSource = null;
            tablichka.ItemsSource = testiks;
        }
    }
}
