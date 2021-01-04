using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
    public class Persona
    {
        //get devolver el valor
        //set cambia el valor de atributos
        public String Cedula { get; set; }
        public String Apellidos { get; set; }
        public String Nombres { get; set; }
        public String Sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String Correo { get; set; }
        public int estatura { get; set; }
        public Decimal Peso { get; set; }
    }
}
