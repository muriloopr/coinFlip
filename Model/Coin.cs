namespace FlipCoin.Model
{
    public class Coin
    {
        public string Lado { get; set; }

        public string Jogar()
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            return Lado;
        }

        public string Jogar(string ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            string resultado = Lado == ladoEscolhido ?
                $"Parab�ns, voc� pediu {ladoEscolhido} e deu {Lado}" :
                $"Que pena, voc� pediu {ladoEscolhido} e deu {Lado}";
            return resultado;
        }
    }
}
