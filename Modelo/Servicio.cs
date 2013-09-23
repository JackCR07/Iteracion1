using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Modelo
{
    public class Servicio
    {
        public Servicio(String pNombre, String pDescripcion, String pMonto, string  pId_Encargado)
        {
            _Nombre = pNombre;
            _Descripcion = pDescripcion;
            _Monto = pMonto;
            _Id_Encargado = pId_Encargado;
        }

        #region Propiedades

        public String getNombre
        {
            get { return _Nombre; }
        }

        public String getDescripcion
        {
            get { return _Descripcion; }
        }

        public String getMonto
        {
            get { return _Monto; }
        }

        public String getId_Encargado
        {
            get { return _Id_Encargado; }
        }

        #endregion


        private String _Nombre;
        private String _Descripcion;
        private String _Monto;
        private String _Id_Encargado;
    }
}
