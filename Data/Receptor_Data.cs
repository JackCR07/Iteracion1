using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Receptor_Data
    {
         private Receptor_Data() { }

        /// <summary>
        /// Implementacion del patron singleton para la llamada al receptor
        /// </summary>
        public static Receptor_Data getInstance
        {
            get
            {
                  if(_Instancia==null)
                  {
                      _Instancia = new Receptor_Data();
                  }
                  return _Instancia;
            }
        }

        /// <summary>
        /// Manda los datos a la bd, para saber si el usuario existe
        /// </summary>
        /// <param name="pUsuario"></param>
        /// <param name="pContrasenia"></param>
        /// <returns></returns>
        /// devuelve el tipo de usuarios si existe, en caso que no encuentre el usuario devolvera "NULL"
        public String Es_Usuario(String pUsuario, String pContrasenia)
        {
            return "ROOT"; 
            
        }

        /// <summary>
        /// Devuelve en un String, todos los servicios numerados con su nombre,dia,hora y encargado
        /// EJ: 1. Natacion L-M 13:00-!4:00 Carlos_Montana
        ///     2. Basket ....
        /// </summary>
        /// <returns></returns>
        /// RETORNA un  STRING CON su RESPECTIVO ID, para hacer el calculo de costo,,, separa con enter por cada columna
        public String getLista_Servicios()
        {
            return  "8. Natacion L-M 13:00-!4:00 Carlos_Montana\n 12. Fut L-M 13:00-!4:00 Raul_Montana" ;
        }



        private static Receptor_Data _Instancia;
    }
}
