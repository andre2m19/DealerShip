using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DealerShip
{
    public partial class CarroOficina
    {

        public CarroOficina(string numerochassis, string marca, string modelo, string combustivel, string matricula, string kms) : base(numerochassis, marca, modelo, combustivel)
        {
            Matricula = matricula;
            Kms = kms;
            this.Servico = new HashSet<Servico>();
        }

        public override string ToString()
        {
            return Matricula + "(" + Kms + ")";
        }
    }
}
