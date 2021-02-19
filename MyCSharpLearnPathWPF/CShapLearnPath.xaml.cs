using System.Windows;
using ApplicationCore;
using MyCSharpLearnPathWPF.Views;

namespace MyCSharpLearnPathWPF
{
    public partial class CSharpLearnPath : Window
    {
        public CSharpLearnPath()
        {
            InitializeComponent();
        }

        public CSharpLearnPath(User user) : this()
        {
            User = user;
            DataContext = new Home();
        }
        
        private User User { get; set; }
        
        private void HomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Home();
        }

        private void LearnPathButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataContext = new LearnPath();
        }

        private void ReminderButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Reminder();
        }
    }
}