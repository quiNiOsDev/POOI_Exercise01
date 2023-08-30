using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Alumno
    {
        public string nombres { get; set; }
        public string apellido { get; set; }
        public int ciclo { get; set; }
        public int edad { get; set;}

        public Alumno()
        {
            ciclo = 1;    
        }

        public Alumno(int ciclo)
        {
            this.ciclo = ciclo;
        }

        public string Leer()
        {
            return "El alumno está leyendo";
        }

    }
}
