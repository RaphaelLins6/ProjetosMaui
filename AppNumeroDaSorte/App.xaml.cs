namespace AppNumeroDaSorte {
    public partial class App : Application {
        public App() {
            InitializeComponent();
            Console.WriteLine("Aplicativo inicializado");

            // Página atual
            MainPage = new MainPage();
        }
    }
}
