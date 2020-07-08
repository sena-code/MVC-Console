using MVCConsole.Models;
using MVCConsole.View;
using System.Collections.Generic;

namespace MVCConsole.Controller
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void Listar(){
            produtoView.MostrarnoConsole(produtoModel.Read());
        }
        public void Buscar(string _cost){
            List<Produto> busca = produtoModel.Read().FindAll(x => x.Cost == float.Parse(_cost));
            produtoView.MostrarnoConsole(busca);
        }
    }
}