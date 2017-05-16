using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class Paquete
    {

        public int PaqueteId { get; set; }
        public string nombre { get; set; }
        public double precioPaquete { get; set; }
        public string descripcionPaquete { get; set; }

        private ServicioTuristico _ServicioTuristico;

        public Paquete()
        {
            _ServicioTuristico = new ServicioTuristico();
        }

    }
}
