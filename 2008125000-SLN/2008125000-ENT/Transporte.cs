using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class Transporte
    {
        public int TransporteId { get; set; }
        public string placa { get; set; }
        public int capacidad { get; set; }

        private TipoTransporte _TipoTransporte;
        private CategoriaTransporte _CategoriaTransporte;

        public Transporte()
        {
            _TipoTransporte = new TipoTransporte();
            _CategoriaTransporte = new CategoriaTransporte();
            
        }
    }
}
