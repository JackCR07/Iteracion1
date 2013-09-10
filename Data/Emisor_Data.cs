using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Data
{
    public class Emisor_Data
    {
        private Emisor_Data() { }


        public static Emisor_Data getInstance
        {
            get
            {
                  if(_Instancia==null)
                  {
                      _Instancia = new Emisor_Data();
                  }
                  return _Instancia;
            }
        }

        #region Almacenamiento en BD



        /// <summary>
        /// Almacenamiento de los Clientes en la base de Datos
        /// </summary>
        /// <returns></returns>
        /// Returna false si algo fallo en el proceso en caso contrario true.
        /*public bool Almacenar(Cliente pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacenamiento de los Funcionarios
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        /// Returna false si algo fallo en el proceso en caso contrario true.
        public bool Almacenar(Funcionario pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena los horarios. // Contiene un arrayList en Los dias del horario
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        public bool Almacenar(Horario pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena un Servicio // Contiene un id de un funcionario y arraylist de los horarios
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        public bool Almacenar(Servicio pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena los contratos // Contiene un arraylist de servicios con su respectivos id, un id de administrador,id cliente
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        public bool Almacenar(Contrato pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena contratos , con al la funcion extra de usar un horario predeterminado.
        /// </summary>
        /// <param name="pDato"></param>
        /// <param name="pHorario"></param>
        /// <returns></returns>
        public bool Almacenar(Contrato pDato, Horario pHorario)
        {
            return false;
        }
        */
        #endregion

        private static Emisor_Data _Instancia;
    }
}
