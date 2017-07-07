using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorio _repositorio;
        // GET: Produtos
        public ActionResult Index()
        {
            // instancia do objeto ProdutosRepositorio
            _repositorio = new ProdutosRepositorio();
            // tudo o que for obtido no banco através do
            // _repositorio.Produtos será atribuído a variavel
            // produtos
            var produtos =_repositorio.Produtos.Take(3);


            // e será passado como parâmetro para a view
            return View(produtos);
        }
    }
}