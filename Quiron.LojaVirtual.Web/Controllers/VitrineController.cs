using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;

        public ActionResult ListaProdutos(int pagina = 1)
        {
            // exemplo = pagina 3
            // pagina - 1 = 2
            // 2 * ProdutosPorPagina(que é 3) = 6
            // ignora os 6 produtos anteriores
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);

            return View(produtos);
        }
    }
}