using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadIT2
{
    public abstract class Persona
    {
        public long DNI = 0;
        public string Nombre = string.Empty;
        public string Apellido = string.Empty;
        public DateOnly FechaDeNacimiento = new();

        public Persona(long dni, string nombre, string apellido, DateOnly fechaDeNacimiento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
        }

        public string NombreCompleto
        { 
            get
            {
                return $"{Nombre} {Apellido}";
            }
            set
            {
            }
        }

        public virtual string DevolverNombreCompleto()
        {
            return $"{NombreCompleto}";
        }

        public abstract string Saludo();
    }
}
