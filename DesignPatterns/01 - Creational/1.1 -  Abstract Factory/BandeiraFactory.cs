namespace DesignPatterns.AbstractFactory
{
    // Abstract Factory
    public abstract class BandeiraFactory
    {
        public abstract Cartao CriarCartao(string numero, TipoBandeira tipoBandeira);
    }
}