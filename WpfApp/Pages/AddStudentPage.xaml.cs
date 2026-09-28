using System.Windows.Controls;

namespace WpfApp.Pages
{
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();
            LoadHalls(); 
        }

        private void LoadHalls()
        {

            string[] halls = { "A", "B", "C", "D", "E" };


            CmbHalls.ItemsSource = halls;
            CmbHalls.SelectedIndex = 0; 
        }
    }
}