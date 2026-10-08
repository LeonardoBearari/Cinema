using CinemaDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDomain
{
    public class Sala : BaseEntity
    {
        public int Numero { get; set; }


        public int Capacidade { get; set; }


        public int Fileiras { get; set; }


        public int Assentos { get; set; }

    }
}