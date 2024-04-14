using System.Data.SqlClient;

namespace Gimnasio_1._0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmIniSesion());


            //codigo para crear el primer usuario administrador 
            string cadenaConexion = "SERVER=LAPTOP-MOLTPACP\\SSQLSERVER;DATABASE=GimnasioV1;integrated security=true;";
            string consultaAbrir = "select count(*) from Administradores";

            int cantidadRegistros = 0;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(consultaAbrir, connection))
                {
                    connection.Open();
                    cantidadRegistros = (int)command.ExecuteScalar();
                }
            }


            if ( cantidadRegistros == 0)
            {
                Application.Run(new frmCrearUsuario());
            }
            else
            {
                Application.Run(new frmIniSesion());
            }


        }
    }
}