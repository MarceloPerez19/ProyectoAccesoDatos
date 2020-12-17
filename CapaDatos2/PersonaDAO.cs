using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

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
            String cadenaConexcion = @"Server=USER-PC\SQLEXPRESS; database = Estudiantes; integrated security = true";

            //definir un objeto tipo Conexion para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            //2. definir la operacion a realizar en el servidor
            //operacion : obtener todos los registros
            //sql(lenguaje estructurado de consultas)
            string sql = "select cedula, apellidos, nombres, sexo, fechaNacimientos, correo, estarura, peso " + "from Personas";

            //definir adaptador de datos: es un pueste que permite pasar los datos de la base de datos hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. recuperamos los datos 

            DataTable dt = new DataTable();
            ad.Fill(dt); //desde el adaptador paso los datos al datatable
            return dt;
        }
    }
}
