﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(bool pEs_Root,String[] pEncargados)
        {
            InitializeComponent();
            box_Agre_Encargado.Items.AddRange(pEncargados);
            box_Mod_Encargado.Items.AddRange(pEncargados);
            if (!pEs_Root)
            { 
                tab_Agregar.Dispose();
                tab_Modificar.Dispose();
                tab_Eliminar.Dispose();
            }
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

        //============================ Bonton Agregar nuevo servicio
        private void button4_Click(object sender, EventArgs e)
        {
            _Seleccion_Servicio = txt_Agre_NombreServicio.Text;
            _Encargado = (String)box_Agre_Encargado.SelectedItem;
            _Dias = txt_Agre_Dias.Text;
            _Hora_Inicio = txt_Agre_HoraInicio.Text;
            _Costo = txt_Agre_Costo.Text;
            _Hora_Final = txt_Agre_HoraFinal.Text;
            if(txt_Agre_Descripcion.Text==null)
            {
                _Descripcion = "No hay despcripcion del servicio";
            }
            else
            {
                _Descripcion = txt_Agre_Descripcion.Text;
            }
            Guardar_Servicio();
        }

        public void Guardar_Servicio()
        {
            if (Almacenar_Servicio != null)
            {
                Almacenar_Servicio(this, EventArgs.Empty);
            }
        }
        //======================================================
        /*
                 private void button3_Click(object sender, EventArgs e)
                {
                    _Id_Servicio = txt_Mod_NumeroServicio1.Text;
                    _Encargado = (String)box_Mod_Encargado1.SelectedItem;
                    _Dias = txt_Mod_Dias1.Text;
                    _Hora_Inicio = txt_Mod_HoraInicio1.Text;
                    _Costo = txt_Mod_Costo1.Text;
                    _Hora_Final = txt_Mod_HoraFinal1.Text;
                    if (txt_Mod_Descripcion1.Text == null)
                    {
                        _Descripcion = "No hay despcripcion del servicio";
                    }
                    else
                    {
                        _Descripcion = txt_Mod_Descripcion1.Text;
                    }
                    Modificar_Servicio();
                }
 
         */

        //============================== Boton Modificar un Servicio

        private void button7_Click(object sender, EventArgs e)
        {
            _Id_Servicio = txt_Mod_NumeroServicio.Text;
            _Encargado = (String)box_Mod_Encargado.SelectedItem;
            _Dias = txt_Mod_Dias.Text;
            _Hora_Inicio = txt_Mod_HoraInicio.Text;
            _Costo = txt_Mod_Costo.Text;
            _Hora_Final = txt_Mod_HoraFinal.Text;
            if (txt_Mod_Descripcion.Text == null)
            {
                _Descripcion = "No hay despcripcion del servicio";
            }
            else
            {
                _Descripcion = txt_Mod_Descripcion.Text;
            }
            Modificar_Servicio();
        }





        public void Modificar_Servicio()
        {
            if (Modificar_Servi != null)
            {
                Modificar_Servi(this, EventArgs.Empty);
            }
        }
        //=========================================================

        //====================================== Boton de Eliminar Servicio

        private void button3_Click(object sender, EventArgs e)
        {
            _Id_Servicio = txt_Eli_NumeroServicio.Text;
            _Ventana_Confirmacion = new Eliminar_Servicio();
            _Ventana_Confirmacion.Ev_Confirma_Elminar += Eliminar_Servicio;
            Thread Hilo_Confirmacion = new Thread(Iniciar_Ventana);
            Hilo_Confirmacion.Start();
        }


        public void Iniciar_Ventana()
        {
            Application.Run(_Ventana_Confirmacion);
        }
        public void Eliminar_Servicio(Object Sender,EventArgs e)
        {
            if (Ev_Eliminar_Servicio != null)
            {
                Ev_Eliminar_Servicio(_Id_Servicio, EventArgs.Empty);
            }
        }

        //================================================================

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

        #region Propiedades de Manejo de Servicios
        public String Get_Encargado
        {
            get { return _Encargado; }
        }
        public String Get_Dias
        {
            get { return _Dias; }
        }
        public String Get_Hora_Inicio
        {
            get { return _Hora_Inicio; }
        }
        public String Get_Hora_Final
        {
            get { return _Hora_Final; }
        }
        public String Get_Costo
        {
            get { return _Costo; }
        }

        public String Get_Descripcion
        {
            get { return _Descripcion; }
        }
        public String Get_Id_Servicio
        {
            get { return _Id_Servicio; }
        }

        #endregion

        private Eliminar_Servicio _Ventana_Confirmacion;

        private String _Nombre_Cliente;
        private String _Nombre_Beneficiado;
        private String _Seleccion_Servicio;
        private String _Encargado;
        private String _Dias;
        private String _Hora_Inicio;
        private String _Costo;
        private String _Descripcion;
        private String _Hora_Final;
        private String _Id_Servicio;

        public event EventHandler Abrir_Generar_Contrato;
        public event EventHandler Abrir_Lista_Servicios;
        public event EventHandler Volver_Login;
        public event EventHandler Almacenar_Servicio;
        public event EventHandler Modificar_Servi;
        public event EventHandler Ev_Eliminar_Servicio;








        #region Auto Generado
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
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

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
        #endregion













        }
}
