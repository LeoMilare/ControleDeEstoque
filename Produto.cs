using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AddProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int remover) 
        { 
            Quantidade = Quantidade - remover;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) + " Reais.";
        }
    }
}
