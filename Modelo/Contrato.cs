using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Modelo
{
    class Contrato
    {
        public Contrato(int pIdentificacion, ArrayList pId_Servicios, int pId_Funcionarios, int pId_Cliente, String pNombre_Beneficiado, float pMontoTotal)
        {
            _Identificacion = pIdentificacion;
            _Id_Servicios = pId_Servicios;
            _Id_Funcionario = pId_Funcionarios;
            _Id_Cliente = pId_Cliente;
            _Nombre_Beneficiado = pNombre_Beneficiado;
            _MontoTotal = pMontoTotal;
        }

        #region Propiedades

        public int getIdentificacion
        {
            get { return _Identificacion; }
        }

        public ArrayList getId_Servicios
        {
            get { return _Id_Servicios; }
        }

        public int getId_Funcionario
        {
            get { return _Id_Funcionario; }
        }

        public int getId_Cliente
        {
            get { return _Id_Cliente; }
        }

        public String getNombre_Beneficiado
        {
            get { return _Nombre_Beneficiado; }
        }

        public float getMontoTotal
        {
            get { return _MontoTotal; }
        }

        #endregion

        #region Atributos
        private int _Identificacion;
        private ArrayList _Id_Servicios;
        private int _Id_Funcionario;
        private int _Id_Cliente;
        private String _Nombre_Beneficiado;
        private float _MontoTotal;
        #endregion
    }
}
