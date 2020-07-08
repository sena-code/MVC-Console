using System;
using MVCConsole.Controller;

namespace MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();

            prod.Buscar("598,8");
        }
    }
}
