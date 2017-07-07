using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        // quantos itens tenho no banco
        public int ItensTotal { get; set; }

        // quantos itens quero por página
        public int ItensPorPagina { get; set; }

        // cor da página atual na paginação
        public int PaginaAtual { get; set; }

        // quantas paginas vou ter
        public int TotalPagina
        {
            get
            {   // a quantidade de quadrados na paginação
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);
            } 
        }
    }
}