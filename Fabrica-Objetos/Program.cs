using Fabrica_Objetos.Criador;
using Fabrica_Objetos.CriadorConcreto;
using System;

namespace Fabrica_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t *** TODOS OS DIREITOS DE CÓDIGO RESERVADOS AO Daniel, do canal 'DANIEL JESUS' *** \n");

            CartaoFabrica fabricaCartao = null;

            Console.Write(" Digite o tipo de cartao que você deseja: ");
            string tipoCartao = Console.ReadLine();

            switch (tipoCartao.ToLower())
            {
                case "black":
                    fabricaCartao = new BlackFabrica(2000, 0);
                    break;
                case "gold":
                    fabricaCartao = new GoldFabrica(3000, 50);
                    break;
                case "titanium":
                    fabricaCartao = new TitaniumFabrica(5000, 150);
                    break;

                default:
                    break;
            }

            CartaoCredito cartao = fabricaCartao.BuscarCartao();
            Console.WriteLine("\n Detalhes do cartão escolhido logo abaixo: \n");
            Console.WriteLine("\t Tipo de cartão: {0}", cartao.TipoCartao);
            Console.WriteLine("\t Limite do cartão: {0}", cartao.LimiteCredito);
            Console.WriteLine("\t Valor de cobrança anual: {0}", cartao.CobrancaAnual);

            Console.ReadKey();
        }
    }
}
