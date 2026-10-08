using CinemaDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDomain
{
    public class IngressoItem : BaseEntity
    {
        public int Assento { get; set; }


        public int Fileira { get; set; }


        public Ingresso Ingresso { get; set; }

        public bool MeiaEntrada { get; set; }

    }
}