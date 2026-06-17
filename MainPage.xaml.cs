namespace BankApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Login button
        private void OnCounterClicked(object? sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//UserPage");
        }

        //Fingerprint button
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            lb_greeting.Text = "Dotknąłeś odcisku palca!";
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//BlikPage");
        }

        private void mobile_transfer_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//MobileTransferPage");

        }

        private void help_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//HelpPage");

        }
    }
}
