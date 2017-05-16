using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class ComprobantePago
    {
        public int ComprobantePagoId { get; set; }
        public DateTime fecha { get; set; }
        public double montoTotal { get; set; }
    

        private TipoComprobante _TipoComprobante;

        public ComprobantePago()
        {
            _TipoComprobante = new TipoComprobante();
        }

        

    }
}
