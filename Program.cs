using System;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "Fender";
            p.Preco = 35.49f;

            p.Inserir(p);
        }
    }
}
