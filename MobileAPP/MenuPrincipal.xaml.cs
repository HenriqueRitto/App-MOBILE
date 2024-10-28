using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipal : ContentPage
	{
		public MenuPrincipal()
		{            
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {            
            var cadastroFornecedores = new CadastroFornecedores();
            Navigation.PushAsync(cadastroFornecedores);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var cadastroProdutos = new CadastroProdutos();
            Navigation.PushAsync(cadastroProdutos);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var cadastroClientes = new CadastroClientes();
            Navigation.PushAsync(cadastroClientes);
        }
    }
}