﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica_Objetos.ProdutoConcreto
{
    public class CartaoTitanium : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoTitanium(int limiteCredito, int conbrancaAnual)
        {
            this._tipoCartao = "Titanium";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = conbrancaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }

        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }

        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
