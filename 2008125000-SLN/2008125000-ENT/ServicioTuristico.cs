using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class ServicioTuristico
    {

        public int ServicioTuristicoId { get; set; }
        public string nombreServicio { get; set; }



        private Hospedaje _Hospedaje;
        private Transporte _Transporte;
        private Alimentacion _Alimentacion;


        public ServicioTuristico(Hospedaje hospedaje,
                       Transporte transporte,
                        Alimentacion alimentacion)
        {
            _Hospedaje = hospedaje;
            _Transporte = transporte;
            _Alimentacion = alimentacion;
        }

        public ServicioTuristico()
        {

        }



    }
}
