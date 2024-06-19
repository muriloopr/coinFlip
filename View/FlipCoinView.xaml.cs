using FlipCoin.ViewModels;

namespace FlipCoin.View;

public partial class FlipCoinView : ContentPage
{
	public FlipCoinView()
	{
		InitializeComponent();

		this.BindingContext = new CoinViewModel();
	}
}