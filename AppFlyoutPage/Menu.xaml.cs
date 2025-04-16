namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e) {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Pag1());
    }

    private void Button_Clicked_1(object sender, EventArgs e) {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Pag2());
    }

    private void Button_Clicked_2(object sender, EventArgs e) {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Pag3());
    }
}