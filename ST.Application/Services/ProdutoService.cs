using ST.Application.Interfaces;
using ST.Core.Entidades;
using ST.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<List<Produto>> ObterTodos()
        {
            var produto = await _produtoRepository.ObterTodos();

            return produto;
        }
    }
}
