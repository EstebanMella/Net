using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    class LibroDiario
    {
        String fecha, nombre, debe, haber;

        public  LibroDiario(String fecha, String nombre, String debe, String haber)
        {
            this.fecha = fecha;
            this.nombre = nombre;
            this.debe = debe;
            this.haber=haber;
        
        }
    }
}
