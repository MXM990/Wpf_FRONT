using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddHall_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.AddHallPage());
        }

        private void BtnAddtech_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.AddTeacherPage());
        }

        private void BtnAddStu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.AddStudentPage());
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.ShowAllPage());
        }

        private void BtnTestConntion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("تم الاتصال بنجاح!", "اختبار الاتصال", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}