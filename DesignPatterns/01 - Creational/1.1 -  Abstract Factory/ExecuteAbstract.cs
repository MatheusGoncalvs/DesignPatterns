using System;
using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public class ExecuteAbstract
    {
        public static void Executar()
        {
            var cartoes = new List<Cartao>
            {
                CartaoCreator.Criar("11-122-333-555", TipoBandeira.Elo),
                CartaoCreator.Criar("126-462-432-444", TipoBandeira.Mastercard),
                CartaoCreator.Criar("908-132-123-999", TipoBandeira.Visa)
            };

            cartoes.ForEach(c => SaveChanges(Bandeira.CriarBandeira(c)));
        }

        public static void SaveChanges(Bandeira bandeira)
        {
            Console.WriteLine($"Salvando cartao: {bandeira._cartao.Id}");
        }
    }
}