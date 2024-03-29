using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        private int num_of_que = 0;
        private int right_answers = 0;

        private List<GetSet> tests = new List<GetSet>();
        private List<string> variable_positive = new List<string> { "Сладенький" };
        private List<string> variable_not = new List<string> { "Пидор" };

        public Test()
        {
            InitializeComponent();

            DisplayQuestion();
        }

        

        private void answer_1_button_Click(object sender, RoutedEventArgs e) => CheckAnswer(TestEnum.vop1);
        private void answer_2_button_Click(object sender, RoutedEventArgs e) => CheckAnswer(TestEnum.vop2);
        private void answer_3_button_Click(object sender, RoutedEventArgs e) => CheckAnswer(TestEnum.vop3);

        private void DisplayQuestion()
        {
            tests = Save.Deserialize<List<GetSet>>();

            if (tests != null && tests.Count > num_of_que)
            {
                var currentQuestion = tests[num_of_que];
                _title.Text = currentQuestion.title;
                _desc.Text = currentQuestion.desc;
                answer_1_button.Content = currentQuestion.answ1;
                answer_1_button.Tag = TestEnum.vop1;
                answer_2_button.Content = currentQuestion.answ2;
                answer_2_button.Tag = TestEnum.vop2;
                answer_3_button.Content = currentQuestion.answ3;
                answer_3_button.Tag = TestEnum.vop3;
            }
            else
            {
                MessageBox.Show("Список тестов пуст или не удалось загрузить тесты.");
            }
        }

        private void CheckAnswer(Enum selectedAnswer)
        {
            if (tests[num_of_que].correct_answ == selectedAnswer)
            {
                var rand = new Random();
                var msg = variable_positive[rand.Next(0, variable_positive.Count)];
                _message.Text = msg;
                right_answers++;
            }
            else
            {
                var rand = new Random();
                var msg = variable_not[rand.Next(0, variable_not.Count)];
                _message.Text = msg;
            }

            num_of_que++;

            if (num_of_que < tests.Count)
            {
                DisplayQuestion();
            }
            else
            {
                Task.Delay(100).Wait(); // Wait for a short period to display the final message
                answer_1_button.IsEnabled = false;
                answer_2_button.IsEnabled = false;
                answer_3_button.IsEnabled = false;
                _message.Text = $"{right_answers} из {tests.Count}";
            }
        }
    }
}
