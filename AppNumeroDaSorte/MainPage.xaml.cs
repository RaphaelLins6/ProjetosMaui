using System;

namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
    }

    private void GerarNumeros(object sender, EventArgs e) {
        NomeApp.IsVisible = false;
        ConatinerNumeros.IsVisible = true;

        var lista = NumAleatorios();

        Num1.Text = lista.ElementAt(0).ToString("D2");
        Num2.Text = lista.ElementAt(1).ToString("D2");
        Num3.Text = lista.ElementAt(2).ToString("D2");
        Num4.Text = lista.ElementAt(3).ToString("D2");
        Num5.Text = lista.ElementAt(4).ToString("D2");
        Num6.Text = lista.ElementAt(5).ToString("D2");
    }

    private SortedSet<int> NumAleatorios() 
    {
        var lista = new SortedSet<int>();
        while (lista.Count < 6) 
        {
            var random = new Random();
            var NumSortudo = random.Next(1, 60);

            lista.Add(NumSortudo);
        }

        return lista;
    }
    protected override void OnAppearing() {
        base.OnAppearing();
        Console.WriteLine("MainPage apareceu");
    }
}
