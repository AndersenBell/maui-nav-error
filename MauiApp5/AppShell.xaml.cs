namespace MauiApp5
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            BindingContext = new AppShellViewModel();
            InitializeComponent();
        }
    }

}
