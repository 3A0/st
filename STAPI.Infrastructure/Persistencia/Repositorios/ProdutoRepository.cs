using ST.Core.Entidades;
using ST.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAPI.Infrastructure.Persistencia.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> _produto;
        public async Task<List<Produto>> ObterTodos()
        {
            _produto = new List<Produto>();

            var produto1 = new Produto();
            produto1.Name = "H2O";

            _produto.Add(produto1);

            return await Task.FromResult(_produto);
        }
    }
}
