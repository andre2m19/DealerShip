using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DealerShip
{
    public partial class Carro
    {
        public Carro()
        {
        }

        public Carro(string numerochassis, string marca, string modelo, string combustivel)
        {
            NumeroChassis = numerochassis;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
        }
    }
}
