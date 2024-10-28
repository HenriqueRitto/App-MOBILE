using System;
using Xamarin.Forms;

namespace MobileAPP
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if(login == "Gerente" && senha == "1234")
            {
                DisplayAlert("Sucesso", "Bem - vindo a Fazenda Urbana", "OK");
                Navigation.PushAsync(new MenuPrincipal());                
            }
            else
            {
                DisplayAlert("Usuário ou Senha Incorretos!! ", " Digite suas credenciais corretas. ", "OK");
                
            }

            txtLogin.Text = null;
            txtSenha.Text = null;    
                            

        }     

    }
}
