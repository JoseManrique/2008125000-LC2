using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class VentaPaquete
    {
        public int VentaPaqueteId { get; set; }

        public string observacioVenta { get; set; }


        private Paquete _Paquete;
        private MedioPago _MedioPago;
        private ComprobantePago _ComprobantePago;

        public VentaPaquete()
        {
            _Paquete = new Paquete();
            _MedioPago = new MedioPago();
            _ComprobantePago = new ComprobantePago();
      
        }
        public Persona Persona { get; set; }

        public VentaPaquete(Persona persona)
        {
            Persona = persona;
        }

        public Cliente Cliente { get; set; }

        public VentaPaquete(Cliente cliente)
        {
            Cliente = cliente;
        }

        public VentaPaquete(int ventaPaqueteId)
        {
            VentaPaqueteId = ventaPaqueteId;
        }


    }
}
