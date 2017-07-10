using Quiron.LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        // total de paginas = 3
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= paginacao.TotalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");

                // adiciona href como atributo
                tag.MergeAttribute("href",paginaUrl(i));
                // id da página
                tag.InnerHtml = i.ToString();

                // adiciona o css para definir cor do seletor de pagina quando
                // na atual
                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}