using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica_Objetos
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get; }

        public abstract int LimiteCredito { get; set; }

        public abstract int CobrancaAnual { get; set; }
    }
}


