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
    }
}