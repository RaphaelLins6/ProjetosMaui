using AppMAUIGaleria.Reps;

namespace AppMAUIGaleria.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

		var categorias = new CategoriaReps().GetCategorias;

		var categorialbl = new Label();
		
		foreach (var categoria in categorias()) 
		{
            categorialbl.Text += categoria.Name + "\n";

            MenuContainer.Children.Add(categorialbl);

            foreach (var componente in categoria.Componentes) 
			{
                var tap = new TapGestureRecognizer();
                tap.CommandParameter = componente.Pagina;
                tap.Tapped += TapGestureRecognizer_Tapped;

				var categorialblTitulo = new Label();
                categorialblTitulo.Text += "  " + componente.Titulo + "\n";
				categorialblTitulo.FontFamily = "OpenSansSemibold";
				categorialblTitulo.Margin = new Thickness(20, 10, 0, 0);
                categorialblTitulo.GestureRecognizers.Add(tap);

                var categorialblDescricao = new Label();
                categorialblDescricao.Text += "    " + componente.Descricao + "\n";
                categorialblDescricao.Margin = new Thickness(20, 0, 0, 0);
                categorialblDescricao.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(categorialblTitulo);
                MenuContainer.Children.Add(categorialblDescricao);
            }
        }
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e) 
    {
        var label = (Label)sender;
        var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
        var page = (Page)tap.CommandParameter;

        ((FlyoutPage)App.Current.MainPage).Detail = page;
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}