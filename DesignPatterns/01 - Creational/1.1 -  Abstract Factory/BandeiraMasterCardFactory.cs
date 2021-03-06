namespace DesignPatterns.AbstractFactory
{
    public class BandeiraMasterCardFactory : BandeiraFactory
    {
        public override Cartao CriarCartao(string numero, TipoBandeira tipoBandeira)
        {
            return CartaoCreator.Criar(numero, tipoBandeira);
        }
    }
}