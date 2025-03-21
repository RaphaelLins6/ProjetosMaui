namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
    }

    protected override void OnAppearing() {
        base.OnAppearing();
        Console.WriteLine("MainPage apareceu");
    }
}
