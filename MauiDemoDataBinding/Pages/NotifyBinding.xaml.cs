using MauiDemoDataBinding.Models;
using System.Threading.Tasks;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBinding : ContentPage
{
	Produto produto = new Produto();
	public NotifyBinding()
	{
		InitializeComponent();
		produto = new Produto
		{
			Nome = "Iphone 5",
			Preco = 5000,
			Stock = 5
		};

        BindingContext = produto;
    }

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
		produto.Nome = "Galaxy SamSung 10";
		produto.Preco = 6000;
		produto.Stock = 3;

		await DisplayAlert("Produto Atualizado", $"{produto.Nome} - {produto.Preco}" + $"{produto.Stock}", "OK");
    }
}