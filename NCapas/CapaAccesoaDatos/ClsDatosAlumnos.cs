using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoaDatos
{
    public class ClsDatosAlumnos
    {
        //Atributos 
        public String cedula { get; set; }
        private String nombres { get; set; }
        private String apellidos { get; set; }
        private Int16 edad { get; set; }
        private String direccion { get; set; }

        public ClsDatosAlumnos(String cedula, String nombres, String apellidos, Int16 edad, String direccion)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;            
            this.direccion = direccion;
        }

    }
}
