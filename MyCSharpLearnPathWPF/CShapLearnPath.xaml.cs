using System.Windows;
using ApplicationCore;

namespace MyCSharpLearnPathWPF
{
    public partial class CSharpLearnPath : Window
    {
        private User User { get; set; }
        public CSharpLearnPath()
        {
            InitializeComponent();
        }

        public CSharpLearnPath(User user) : this()
        {
            User = user;
        }
    }
}