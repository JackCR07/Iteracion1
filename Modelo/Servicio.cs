using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Modelo
{
    class Servicio
    {
        public Servicio(int pIdentificacion, String pNombre, String pDescripcion, int pMonto, int pId_Encargado, ArrayList pId_Horarios)
        {
            _Identificacion = pIdentificacion;
            _Nombre = pNombre;
            _Descripcion = pDescripcion;
            _Monto = pMonto;
            _Id_Encargado = pId_Encargado;
            _Id_Horarios = pId_Horarios;
        }

        #region Propiedades
        public int getIdentificacion
        {
            get { return _Identificacion; }
        }

        public String getNombre
        {
            get { return _Nombre; }
        }

        public String getDescripcion
        {
            get { return _Descripcion; }
        }

        public int getMonto
        {
            get { return _Monto; }
        }

        public int getId_Encargado
        {
            get { return _Id_Encargado; }
        }

        public ArrayList getId_Horarios
        {
            get { return _Id_Horarios; }
        }
        #endregion


        private int _Identificacion;
        private String _Nombre;
        private String _Descripcion;
        private int _Monto;
        private int _Id_Encargado;
        private ArrayList _Id_Horarios;
    }
}
