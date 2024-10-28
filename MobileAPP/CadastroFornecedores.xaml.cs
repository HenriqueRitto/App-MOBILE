using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.SqlClient;

namespace MobileAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroFornecedores : ContentPage
    {
		private readonly string connectionString = "Data Source=DESKTOP-HHGJAQC\\SQLEXPRESS;Initial Catalog=\"Fazenda Urbana MOBILE\";Integrated Security=True;Encrypt=True;";
		public CadastroFornecedores()
		{
			InitializeComponent();
		}

        private async void BtnIncluirForn_Clicked(object sender, EventArgs e)
        {
			string nome = txtNome.Text;
			string CNPJ = txtCNPJ.Text;	
			string produto = txtProdutoForn.Text;

			if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(CNPJ) || string.IsNullOrWhiteSpace(produto))
			{
				await DisplayAlert("Atenção", "preenha todos os campos.", "OK");
				return;
			}
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = "INSERT INTO CadastroFornecedores (Nome, CNPJ, Produto) VALUES (@Nome, @CNPJ, @Produto)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@CNPJ", CNPJ);
                        command.Parameters.AddWithValue("@Produto", produto);

                        await command.ExecuteNonQueryAsync();
                        await DisplayAlert("Sucesso", "Usuário incluído com sucesso!", "OK");

                        // Limpar campos após inclusão
                        txtNome.Text = null;
                        txtCNPJ.Text = null;
                        txtProdutoForn = null;
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
                }
            }
            }
    }
}