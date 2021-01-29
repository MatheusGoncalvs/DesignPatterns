using System;
using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");

            var opcao = Console.Read();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao)
            {
                case '1':
                    ExecuteAbstract.Executar();
                    break;
            }

            Console.Read();
            Console.Clear();
            Console.Clear();
            Main();
        }
    }
}
