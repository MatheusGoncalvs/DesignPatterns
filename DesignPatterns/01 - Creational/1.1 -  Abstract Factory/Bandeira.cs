using System;

namespace DesignPatterns.AbstractFactory
{
    // Client Class
    public class Bandeira
    {
        public readonly Cartao _cartao;

        public Bandeira(BandeiraFactory factory, Cartao cartao)
        {
            _cartao = factory.CriarCartao(cartao.Numero, cartao.TipoBandeira);
        }

        public static Bandeira CriarBandeira(Cartao cartao)
        {
            switch (cartao.TipoBandeira)
            {
                case TipoBandeira.Visa:
                    return new Bandeira(new BandeiraVisaFactory(), cartao);
                case TipoBandeira.Mastercard:
                    return new Bandeira(new BandeiraMasterCardFactory(), cartao);
                case TipoBandeira.Elo:
                    return new Bandeira(new BandeiraEloFactory(), cartao);
                default:
                    throw new ApplicationException("Tipo de bandeira desconhecida.");
            }
        }
    }
}