namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void BtnVoltar(object sender, EventArgs e) 
	{
        Navigation.PopAsync();
		//Navigation.RemovePage(Navigation.NavigationStack[1]);
    }
}