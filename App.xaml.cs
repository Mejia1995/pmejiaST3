namespace pmejiaST3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Vistas.Vgrid()); // cambiar la pagina de ejecucion
        }
    }
}
