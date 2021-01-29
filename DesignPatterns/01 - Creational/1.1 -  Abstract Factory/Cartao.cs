using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Product
    public abstract class Cartao
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public TipoBandeira TipoBandeira { get; set; }

        protected Cartao(string numero, TipoBandeira tipoBandeira)
        {
            Id = new Guid();
            Numero = numero;
            TipoBandeira = tipoBandeira;
        }
    }
    public enum TipoBandeira
    {
        Visa,
        Mastercard,
        Elo
    }
    // Produto Concreto
    public class CartaoVisa : Cartao
    {
        public CartaoVisa(string numero, TipoBandeira tipoBandeira) : base(numero, tipoBandeira)
        {
        }
    }
    // Produto Concreto
    public class CartaoMastercard : Cartao
    {
        public CartaoMastercard(string numero, TipoBandeira tipoBandeira) : base(numero, tipoBandeira)
        {
        }
    }
    // Produto Concreto
    public class CartaoElo : Cartao
    {
        public CartaoElo(string numero, TipoBandeira tipoBandeira) : base(numero, tipoBandeira)
        {
        }
    }
    public class CartaoCreator
    {
        public static Cartao Criar(string numero, TipoBandeira tipoBandeira)
        {
            switch (tipoBandeira)
            {
                case TipoBandeira.Visa:
                    return new CartaoVisa(numero, tipoBandeira);
                case TipoBandeira.Mastercard:
                    return new CartaoMastercard(numero, tipoBandeira);
                case TipoBandeira.Elo:
                    return new CartaoElo(numero, tipoBandeira);
                default:
                    throw new ApplicationException("Tipo do cartao desconhecido.");
            }
        }
    }
}