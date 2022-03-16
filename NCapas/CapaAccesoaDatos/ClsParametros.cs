using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoaDatos
{
    public class ClsParametros
    {

        public String cedula { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public Int16 edad { get; set; }        
        public String direccion { get; set; }

        public ClsParametros(String cedula, String nombres, String apellidos, Int16 edad, String direccion)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;            
            this.direccion = direccion;
        }


    }
}
