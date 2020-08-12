using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double ValTotEstoq()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValTotEstoq().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
