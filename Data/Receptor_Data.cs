using System;
using System.Collections.Generic;
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



        private static Receptor_Data _Instancia;
    }
}
