using System.Windows;
using ApplicationCore;

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
        }
        
        private User User { get; set; }
        
        private void HomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void LearnPathButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ReminderButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}