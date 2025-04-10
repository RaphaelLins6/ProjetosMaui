namespace AppNavigationPage;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void BtnVoltar(object sender, EventArgs e) 
	{
		Navigation.PushAsync(new Page2());
    }
}