using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlipCoin.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _ladoEscolhido;

        [ObservableProperty]
        private int _imagem;

        [ObservableProperty]
        private int _resultado;

        public ICommand FlipCommand { get; private set; }

        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }

        public void Flip()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
        }
    }

    internal class Coin
    {
        internal int Jogar(int ladoEscolhido)
        {
            throw new NotImplementedException();
        }
    }
}
