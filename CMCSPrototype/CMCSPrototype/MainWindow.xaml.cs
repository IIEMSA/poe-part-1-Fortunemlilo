using System.Windows;

namespace CMCSPrototype
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handler to open Lecturer Dashboard
        private void OpenLecturerDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LecturerDashboard());
        }

        // Event handler to open Coordinator Dashboard
        private void OpenCoordinatorDashboard_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoordinatorDashboard());
        }
    }
}
