﻿using Fabrica_Objetos.Criador;
using Fabrica_Objetos.ProdutoConcreto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica_Objetos.CriadorConcreto
{
    public class GoldFabrica : CartaoFabrica
    {
        private int _limiteCartao;
        private int _cobrancaAnual;

        public GoldFabrica(int limiteCartao, int cobrancaAnual)
        {
            this._limiteCartao = limiteCartao;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoGold(_limiteCartao, _cobrancaAnual);
        }
    }
}
