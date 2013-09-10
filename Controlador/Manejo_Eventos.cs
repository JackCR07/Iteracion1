using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using Data;
using System.Windows.Forms;
using System.Threading;

namespace Controlador
{
    class Manejo_Eventos
    {
        public Manejo_Eventos(Login pLogin_View)
        {
            _Login_View = pLogin_View;
        }

        /// <summary>
        /// Empieza a traerse los datos del login con el observer
        /// </summary>
        internal void Iniciar()
        {
            _Login_View.Cambio_De_Datos += Validar_Usuario;
            Application.EnableVisualStyles();
            Application.Run(_Login_View);
        }

        private void Validar_Usuario(Object sender, EventArgs e)
        {
            String pUsuario =  ((Login)sender).getUsuario;
            String pContrasenia = ((Login)sender).getContrasenia;
            Console.WriteLine("NOMBRE " + pUsuario );
            Console.WriteLine("Constra " + pContrasenia );

            switch (Receptor_Data.getInstance.Es_Usuario(pUsuario, pContrasenia))
            {
                case "ROOT":
                    _Login_View.Hide();
                    _Hilo_Menu_Principal = new Thread(Correr_Menu);
                    _Hilo_Menu_Principal.Start(true);
                    break;
                case "USUARIO":
                    _Login_View.Hide();
                    _Hilo_Menu_Principal = new Thread(Correr_Menu);
                    _Hilo_Menu_Principal.Start(false);
                    break;
                case "NULL":
                    Console.WriteLine("EL USUARIO NO EXISTE");
                    break;
                default:
                    Console.WriteLine("ESTE USUARIO NO PUEDE USAR LA APP");
                    break;

            }

        }

        private void Correr_Menu(Object pEs_Root)
        {
            _Menu_Princiapal = new Menu_Principal((bool)pEs_Root);
            Application.Run(_Menu_Princiapal);
        }

        private Login _Login_View;
        private Menu_Principal _Menu_Princiapal;
        private Thread _Hilo_Menu_Principal;
        
    }
}
