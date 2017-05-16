using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class Alimentacion
    {

        public int AlimentacionId { get; set; }
        public string desayuno { get; set; }
        public string almuerzo { get; set; }
        public string cena { get; set; }


        private CategoriaAlimentacion _CategoriaAlimentacion;

        public Alimentacion()
        {
            _CategoriaAlimentacion = new CategoriaAlimentacion();

        }
    }




}
