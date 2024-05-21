namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var viewModel = Shell.Current.BindingContext as AppShellViewModel;
            viewModel.IsLoggedIn = !viewModel.IsLoggedIn;
            viewModel.IsNotLoggedIn = !viewModel.IsNotLoggedIn;
            Random random = new Random();
            var value = random.Next();
            viewModel.SomeTimesEnabled = value % 2 == 0;
        }
    }
}
