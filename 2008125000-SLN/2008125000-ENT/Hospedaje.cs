using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class Hospedaje
    {

        public int HospedajeId { get; set; }
        public string nombreHospedaje { get; set; }
       


        private TipoHospedaje _TipoHospedaje;
        private CalificacionHospedaje _CalificacionHospedaje;
        private CategoriaHospedaje _CategoriaHospedaje;
        private ServicioHospedaje _ServicioHospedaje;



        public Hospedaje()
        {
            _TipoHospedaje = new TipoHospedaje();
            _CalificacionHospedaje = new CalificacionHospedaje();
            _CategoriaHospedaje = new CategoriaHospedaje();
            _ServicioHospedaje = new ServicioHospedaje();
        }


    }
}
