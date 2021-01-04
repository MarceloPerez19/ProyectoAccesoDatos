using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class PersonaDAO
    {
        private static String cadenaConexcion = @"Server=USER-PC\SQLEXPRESS; database = Estudiantes; integrated security = true";
        public static int crear(Persona persona)
        {
            //agregar estudiantes en la bdd
            //1. definir y configurar la conexion con el motor de BDD
            //String cadenaConexcion = @"Server=USER-PC\SQLEXPRESS; database = Estudiantes; integrated security = true";


            //definir un objeto tipo Conexion para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            // 2definiar operacion en la base de datos (insertar)
            string sql = "insert into Personas(cedula, apellidos, nombres, sexo, fechaNacimiento, correo, estatura, peso) " +
                "values(@cedula, @apellidos,  @nombres, @sexo, @fechaNacimiento, @correo, @estatura, @peso)";

            //definir un objeto de la clase Command para ejecurtar la sentencia sql que hemos creado
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", persona.Cedula);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@nombres", persona.Nombres);
            comando.Parameters.AddWithValue("@sexo", persona.Sexo);
            comando.Parameters.AddWithValue("@fechaNacimiento", persona.fechaNacimiento);
            comando.Parameters.AddWithValue("@correo", persona.Correo);
            comando.Parameters.AddWithValue("@estatura", persona.estatura);
            comando.Parameters.AddWithValue("@peso", persona.Peso);

            //3. abrir la conexcion y ejecutar el comando
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //4. cerrar  la conexion
            conexion.Close();

            return x;

        }

        public static int actualizar(Persona persona)
        {
            
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            // 2definiar operacion en la base de datos (actualizar)
            string sql = "update Personas set apellidos=@apellidos, nombres=@nombres, sexo=@sexo, fechaNacimiento=@fechaNacimiento, correo=@correo, estatura=@estatura, peso=@peso " +
                "where cedula=@cedula ";

            //definir un objeto de la clase Command para ejecurtar la sentencia sql que hemos creado
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", persona.Cedula);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@nombres", persona.Nombres);
            comando.Parameters.AddWithValue("@sexo", persona.Sexo);
            comando.Parameters.AddWithValue("@fechaNacimiento", persona.fechaNacimiento);
            comando.Parameters.AddWithValue("@correo", persona.Correo);
            comando.Parameters.AddWithValue("@estatura", persona.estatura);
            comando.Parameters.AddWithValue("@peso", persona.Peso);

            //3. abrir la conexcion y ejecutar el comando
            conexion.Open();
            int x = comando.ExecuteNonQuery();//devuelve el total de filas afectadas
            //4. cerrar  la conexion
            conexion.Close();

            return x;

        }

        public static int eliminar(String cedula)
        {

            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            // 2definiar operacion en la base de datos (actualizar)
            string sql = "delete from Personas " +
                "where cedula=@cedula ";

            //definir un objeto de la clase Command para ejecurtar la sentencia sql que hemos creado
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", cedula);
            
            //3. abrir la conexcion y ejecutar el comando
            conexion.Open();
            int x = comando.ExecuteNonQuery();//devuelve el total de filas afectadas
            //4. cerrar  la conexion
            conexion.Close();

            return x;

        }


        public static DataTable getAll()
        {
            //1. definir y configurar la conexion con el motor de BDD
            //cadena de conexion que utiliza la autentificacion que proporciona sql se
            //String cadenaConexcion = "Server="; database = Estudiantes; user id=sa; pwd=isa" ;

            //cadena de conexion utilizando usuario de windows
            //String cadenaConexcion = @"Server=USER-PC\SQLEXPRESS; database = Estudiantes; integrated security = true";

            //definir un objeto tipo Conexion para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            //2. definir la operacion a realizar en el servidor
            //operacion : obtener todos los registros
            //sql(lenguaje estructurado de consultas)
            string sql = "select cedula, apellidos, nombres, upper(apellidos +' '+ nombres) as estudiante, case when sexo='M' then 'Masculino' else 'Femenino' end as sexo, fechaNacimiento, correo, estatura, peso " + "from Personas order by apellidos, nombres";

            //definir adaptador de datos: es un pueste que permite pasar los datos de la base de datos hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. recuperamos los datos 

            DataTable dt = new DataTable();
            ad.Fill(dt); //desde el adaptador paso los datos al datatable
            return dt;
        }
        public static Persona getPersona(String cedula)
        {
            //1. definir y configurar la conexion con el motor de BDD
            //cadena de conexion que utiliza la autentificacion que proporciona sql se
            //String cadenaConexcion = "Server="; database = Estudiantes; user id=sa; pwd=isa" ;

            //cadena de conexion utilizando usuario de windows
            //String cadenaConexcion = @"Server=USER-PC\SQLEXPRESS; database = Estudiantes; integrated security = true";

            //definir un objeto tipo Conexion para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexcion);

            //2. definir la operacion a realizar en el servidor
            //operacion : obtener todos los registros
            //sql(lenguaje estructurado de consultas)
            string sql = "select cedula, apellidos, nombres, sexo, fechaNacimiento, correo, estatura, peso " + "from Personas " + "where cedula=@cedula";

            //definir adaptador de datos: es un pueste que permite pasar los datos de la base de datos hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
            ad.SelectCommand.Parameters.AddWithValue("@cedula", cedula);

            //3. recuperamos los datos 

            DataTable dt = new DataTable();    
            ad.Fill(dt); //desde el adaptador paso los datos al datatable

            Persona P = new Persona();
            //encerar valores
            P.Cedula = " ";
            P.Apellidos = " ";
            P.Nombres = " ";
            P.Sexo = " ";
            P.estatura = 0;
            P.Peso = 0;
            P.Correo = " ";

            //recorrer el datatable
            foreach (DataRow fila in dt.Rows)
            {
                P.Cedula = fila["cedula"].ToString();
                P.Apellidos = fila["apellidos"].ToString();
                P.Nombres = fila["nombres"].ToString();
                P.Sexo = fila["sexo"].ToString();
                P.Correo = fila["correo"].ToString();
                P.estatura = int.Parse(fila["estatura"].ToString());
                P.Peso = decimal.Parse(fila["peso"].ToString());
                P.fechaNacimiento = Convert.ToDateTime(fila["fechaNacimiento"].ToString());
                break;//abandonar el for
            }
            return P;
            
        }
    }
}
