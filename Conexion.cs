using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
/*
namespace Clave1_Grupo1
{
    class Conexion
    {
        //Definimos una nueva clase llamada ConexionMySQL que es accesible desde otras partes del código.
        public class ConexionMySQL
        {
            //Declaramos una variable de tipo MySqlConnection llamada conexion que será utilizada para mantener la conexión a la base de datos.
            private MySqlConnection conexion;

            //Este es el constructor de la clase. Se ejecuta automáticamente cuando creas una instancia de ConexionMySQL.
            public ConexionMySQL()
            {
                //Aquí se define una cadena de conexión a la base de datos.
                string Conexion = "Server=localhost; Database=clave1_grupo1db; User ID=root; Password=root;";
                //Se crea una nueva instancia de MySqlConnection utilizando la cadena de conexión proporcionada y se asigna a la variable conexion.
                conexion = new MySqlConnection(Conexion);
            }

            //Creamos un método público que permite abrir la conexión a la base de datos.
            public MySqlConnection AbrirConexion()
            {
                //Verifica si la conexión está cerrada.
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    // Si la conexión está cerrada, la abre.
                    conexion.Open();
                }
                return conexion;
            }

            //Creamos un método público que permite cerrar la conexión a la base de datos.
            public MySqlConnection CerrarConexion()
            {
                //Verifica si la conexión está abierta.
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    //Si la conexión está abierta, la cierra.
                    conexion.Close();
                }
                return conexion;
            }
        }
    }
}
*/
