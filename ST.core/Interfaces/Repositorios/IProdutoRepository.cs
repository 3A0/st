using ST.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ST.Core.Interfaces.Repositorios
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> ObterTodos();
    }
}
