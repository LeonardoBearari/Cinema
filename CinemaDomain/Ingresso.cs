using CinemaDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDomain
{
    public class Ingresso : BaseEntity
    {

        public string Documento { get; set; }


        public Sessao Sessao { get; set; }


        public System.DateTime DataCompra {  get; set; }

        public List<IngressoItem> IngressoItens { get; set; }

        public decimal ValorTotal { get; set; }


        public string FormaPagamento { get; set; }

    }
}