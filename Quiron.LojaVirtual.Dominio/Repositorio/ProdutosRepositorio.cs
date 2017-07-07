using Quiron.LojaVirtual.Dominio.Entidades;
using System.Collections.Generic;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        // retorna todos os produto da tabela
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

    }
}
