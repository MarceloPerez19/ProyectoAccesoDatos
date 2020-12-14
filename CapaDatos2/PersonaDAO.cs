using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    class PersonaDAO
    {
        public static DataTable getAll()
        {
            //1. definir y configurar la conexion con el motor de BDD
            //cadena de conexion que utiliza la autentificacion que proporciona sql se
            //String cadenaConexcion = "Server="; database = Estudiantes; user id=sa; pwd=isa" ;

            //cadena de conexion utilizando usuario de windows
            String cadenaConexcion = "Server="; database = Estudiantes; integrated security = true";

            //definir un objeto tipo Conexion para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            //2. definir la operacion a realizar en el servidor
            //operacion : obtener todos los registros
            string sql = "";
        }
    }
}
