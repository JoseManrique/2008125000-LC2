using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_ENT
{
    public class Persona
    {

        
        public int PersonaId { get; set; }
        public int dni { get; set; }
        public string nombres { get; set; }
        public string apePat { get; set; }
        public string apeMat { get; set; }
        public char sexo { get; set; }
        public string direcPer { get; set; }

        private Empleado _Empleado;
        private Cliente _Cliente;


        public Persona(Empleado empleado,
                       Cliente cliente)
        {
            _Empleado = empleado;
            _Cliente = cliente;
        }

        public Persona()
        {

        }



    }
}
