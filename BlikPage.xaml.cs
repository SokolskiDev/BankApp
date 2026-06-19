namespace BankApp;

public partial class BlikPage : ContentPage
{
	public BlikPage()
	{
		InitializeComponent();
	}

    private void blik_copy_Clicked(object sender, EventArgs e)
    {
		Random r = new();
		int blik = r.Next(999999);
		int blik1 = blik / 1000;
        int blik2 = blik % 1000;
        string sblik1 = blik1.ToString();
        string sblik2 = blik2.ToString();
        if (blik1<100)
			sblik1 = $"0{blik1}";
		if (blik1<10)
            sblik1 = $"00{blik1}";
        if (blik2 < 100)
            sblik2 = $"0{blik2}";
        if (blik2 < 10)
            sblik2 = $"00{blik2}";
        blik_code.Text = $"{sblik1} {sblik2}";
    }
}