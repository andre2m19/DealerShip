﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip
{
    public partial class Parcela
    {
        public Parcela(string valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Valor + "(" + Descricao + ")";
        }
    }
}
