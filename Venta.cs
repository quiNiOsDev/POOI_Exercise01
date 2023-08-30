using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Venta
    {
        public string numero { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string mueble { get; set; }
        public double precio { get; set; }

        public double Descuento()
        {
            if (precio <= 500)
                return 0.02 * precio;
            else
                return 0.10 * precio;
        }
        public double PrecioVenta()
        {
            return precio - Descuento();
        }
    }
}
