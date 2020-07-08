using System.Collections.Generic;
using MVCConsole.Models;
using System;

namespace MVCConsole.View
{
    public class ProdutoView
    {
        public void MostrarnoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Cost} -- {item.Name}");
            }
        }
    }
}