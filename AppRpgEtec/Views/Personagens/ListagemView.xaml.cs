using AppRpgEtec.ViewModels.Personagens;

namespace AppRpgEtec.Views.Personagens
{
    public partial class ListagemView : ContentPage
    {
        public ListagemPersonagemViewModel viewModel;

        public ListagemView()
        {
            InitializeComponent();

            viewModel = new ListagemPersonagemViewModel();
            BindingContext = viewModel;
            Title = "Personagens - App Rpg Etec";
        }
    }
}
