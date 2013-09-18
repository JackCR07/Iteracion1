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

        /// <summary>
        /// Uso de singleton con el parerametro de instance para el uso de un solo objeto
        /// </summary>
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
        public bool Almacenar_Cliente(Cliente pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacenamiento de los Funcionarios
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        /// Returna false si algo fallo en el proceso en caso contrario true.
        public bool Almacenar_Funcionario(Funcionario pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena los horarios. // Contiene un arrayList en Los dias del horario
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        public bool Almacenar_Horario(Horario pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena un Servicio // Contiene un id de un funcionario y arraylist de los horarios
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        public bool Almacenar_Servicio(Servicio pDato)
        {
            return false;
        }

        /// <summary>
        /// Almacena los contratos // 
        /// ***en la base de datos se debe hacer un split de los servicios id que vienen en ej: 1,2,3 -- Devuelve false si algun id no existe
        /// ***en la base de datos de debe validar la identificacion del usuario -- devuelve false si no existe el usuario
        /// </summary>
        /// <param name="pDato"></param>
        /// <returns></returns>
        public bool Almacenar_Contrato(Contrato pDato)
        {
            Console.WriteLine(pDato.getId_Cliente + "-" + pDato.getId_Funcionario + "-" + pDato.getId_Servicios + "-" + pDato.getNombre_Beneficiado);
            
            return false;
        }

        /// <summary>
        /// Almacena contratos , con al la funcion extra de usar un horario predeterminado.
        /// </summary>
        /// <param name="pDato"></param>
        /// <param name="pHorario"></param>
        /// <returns></returns>
        public bool Almacenar_Contrato_Especial(Contrato pDato, Horario pHorario)
        {
            return false;
        }
        
        #endregion

        private static Emisor_Data _Instancia;
    }
}
