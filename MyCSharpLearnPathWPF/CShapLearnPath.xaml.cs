using System.Windows;
using System.Windows.Media;
using ApplicationCore;
using DataAccess;
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
            Pointer3.Opacity = 0;
            Pointer2.Opacity = 0;
            Pointer1.Opacity = 100;
        }
        
        private User User { get; set; }
        
        private void HomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Home();
            Pointer3.Opacity = 0;
            Pointer2.Opacity = 0;
            Pointer1.Opacity = 100;
        }

        private void LearnPathButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataContext = new LearnPath();
            Pointer1.Opacity = 0;
            Pointer3.Opacity = 0;
            Pointer2.Opacity = 100;
            
        }

        private void ReminderButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Reminder();
            Pointer1.Opacity = 0;
            Pointer2.Opacity = 0;
            Pointer3.Opacity = 100;
        }
    }
}