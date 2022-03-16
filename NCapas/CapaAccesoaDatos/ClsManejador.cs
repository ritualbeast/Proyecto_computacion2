using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoaDatos
{
    public class ClsManejador
    {

        //Tabla alumnos en memoria - reemplazo de la BD
        List<ClsDatosAlumnos> datosAlumnos = new List<ClsDatosAlumnos>();
        
        //Abrir conexion a BD
        void abrir_conexion()
        { }
        
        //Cerrar conexion a BD
        void cerrar_conexion()
        { }

        //Método para insertar información
        public void ejecutar_insert(List<ClsParametros> lst)
        {
            try
            {
                if (lst != null)
                {                    
                    datosAlumnos.Add(new ClsDatosAlumnos(lst[0].cedula, lst[0].nombres, lst[0].apellidos,lst[0].edad, lst[0].direccion));                    
                    
                }
            }
            catch (Exception ex)
            {  throw ex;  }
            
        }

        public List<ClsDatosAlumnos> listar_alumno()
        {
            return datosAlumnos;
        }

        public String ejecutar_remove(String ci)
        {
            String msj = "No existe un alumno con ese indentificador";
            foreach(ClsDatosAlumnos al in datosAlumnos)
            {
                if(al.cedula == ci)
                {
                    datosAlumnos.Remove(al);
                    msj = "Alumo removido exitosamente";
                    break;
                }
            }
            return msj;
        }
    }
}
