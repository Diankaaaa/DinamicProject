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

namespace DinamicProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Queue<Student> AddStudent; //Создание очереди
        public MainWindow()
        {
            InitializeComponent();
            AddStudent = new Queue<Student>();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Получение данных от пользователя
                string surname = SurnameStudent.Text;
                float averageScore = float.Parse(AverageScoreStudent.Text);

                //Создание объекта класса Student
                Student student = new Student(surname, averageScore);
                AddStudent.Enqueue(student);
                UpdateQueue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateQueue()
        {
            OUTPUT.ItemsSource = null;
            OUTPUT.Items.Clear();
            OUTPUT.ItemsSource = AddStudent;
        }
    }
}
