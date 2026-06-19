namespace BankApp;

public partial class UserPage : ContentPage
{
    double saldo_konto = 100000.00;
    double saldo_oszcz = 0.00;
    double saldo_all = 0.00;
    public UserPage()
	{
		InitializeComponent();
        RefreshSaldo();

    }

    private void btn_historia_Clicked(object sender, EventArgs e)
    {
        saldo_oszcz += 1000;
        RefreshSaldo();

    }

    private void btn_przelew_Clicked(object sender, EventArgs e)
    {
        saldo_oszcz -= 1000;
        RefreshSaldo();
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PushAsync(new MainPage());
    }

    //Blik_Button
    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PushAsync(new BlikPage());
    }
    void RefreshSaldo()
    {
        saldo_all = saldo_konto + saldo_oszcz;
        saldo_konto_amount.Text = $"{saldo_konto} PLN";
        saldo_oszcz_amount.Text = $"{saldo_oszcz} PLN";
        saldo_all_amount.Text = $"{saldo_all} PLN";
    }
}