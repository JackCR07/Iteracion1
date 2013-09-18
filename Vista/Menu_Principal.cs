using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(bool pEs_Root)
        {
            InitializeComponent();
        }

        //==================== Boton de Mostrar lista de Servicios
        private void button6_Click(object sender, EventArgs e)
        {
            Lista_Servicios();
        }


        public void Lista_Servicios()
        {
            if (Abrir_Lista_Servicios != null)
            {
                Abrir_Lista_Servicios(this, EventArgs.Empty);
            }
        }
        //=======================================================

        //================= Boton de Generar Contrato y evento
        private void button2_Click(object sender, EventArgs e)
        {
            _Nombre_Cliente = txt_Cliente.Text;
            _Nombre_Beneficiado = txt_Beneficiado.Text;
            _Seleccion_Servicio = txt_Servicios.Text;
            Generar_Contrato();
        }

        public void Generar_Contrato()
        {
            if (Abrir_Generar_Contrato != null)
            {
                Abrir_Generar_Contrato(this, EventArgs.Empty);
            }
        }


        //====================================================

        //======================= Boton para volver a login
        private void button1_Click_1(object sender, EventArgs e)
        {
            Abrir_Login();
        }

        public void Abrir_Login()
        {
            if (Volver_Login != null)
            {
                Volver_Login(null, EventArgs.Empty);
            }
        }
        //=================================================

        #region Propiedades de Text Box
        public String Get_Cliente
        {
            get { return _Nombre_Cliente; }
        }

        public String Get_Beneficiado
        {
            get { return _Nombre_Beneficiado; }
        }

        public String Get_Seleccion_Servicio
        {
            get { return _Seleccion_Servicio; }
        }
        #endregion

        private String _Nombre_Cliente;
        private String _Nombre_Beneficiado;
        private String _Seleccion_Servicio;
        private String _Horarios_Disponibles;
        private String _Encargado;
        private String _Dias;
        private String _Costo;

        public event EventHandler Abrir_Generar_Contrato;
        public event EventHandler Abrir_Lista_Servicios;
        public event EventHandler Volver_Login;









        #region Auto Generado

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion


        
        }
}
