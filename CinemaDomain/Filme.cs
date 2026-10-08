using CinemaDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDomain
{
    public class Filme : BaseEntity
    {
        public string Nome { get; set; }


        public string Classificacao { get; set; }


        public Genero Genero { get; set; }


        public int Duracao { get; set; }

    }
}