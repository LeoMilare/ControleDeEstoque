using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Digite os dados do produto que procura: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade disponível em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            string resposta = "";
            string pergunta = "Gostaria de adicionar ou remover algum produto? (Adicionar/Remover/Não) ";

            while (resposta != "Não")
            {
                Console.WriteLine(pergunta);
                resposta = Console.ReadLine();
                if (resposta == "Adicionar")
                {
                    Console.Write("Qual a quantidade de produto será adicionada ao estoque? ");
                    int quantidade = int.Parse(Console.ReadLine());
                    p.AddProdutos(quantidade);
                    Console.WriteLine("Dados atualizados: " + p);
                    Console.WriteLine();
                    pergunta = "Gostaria de adicionar mais algum produto ou remover? (Adicionar/Remover/Não) ";
                }
                else if (resposta == "Remover")
                {
                    Console.WriteLine("Qual a quantidade de produto será removida do estoque?");
                    int remover = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(remover);
                    Console.WriteLine("Dados atualizados: " + p);
                    Console.WriteLine();
                    pergunta = "Gostaria de remover mais algum produto ou adicionar? (Adicionar/Remover/Não) ";

                }
                else if (resposta == "Não")
                {
                    Console.WriteLine("A operação será encerrada. Seu aplicativo de controle de estoque será fechado.");
                }
                else
                {
                    Console.WriteLine("Operação inválida. Tente novamente");
                }
            }
        }
    }
}