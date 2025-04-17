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
				var categorialblTitulo = new Label();
                categorialblTitulo.Text += "  " + componente.Titulo + "\n";

                var categorialblDescricao = new Label();
                categorialblDescricao.Text += "    " + componente.Descricao + "\n";

                MenuContainer.Children.Add(categorialblTitulo);
                MenuContainer.Children.Add(categorialblDescricao);
            }
        }
	}
}