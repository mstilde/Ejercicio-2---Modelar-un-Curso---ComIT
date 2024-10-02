using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadIT2
{
    public class Profesor : Persona
    {
        public int AñosDeExperiencia = 0;

        public Profesor(long dni, string nombre, string apellido, DateOnly fechaNacimiento, int añosDeExperiencia)
            : base(dni, nombre, apellido, fechaNacimiento)
        {
            AñosDeExperiencia = añosDeExperiencia;
        }

        public override string DevolverNombreCompleto()
        {
            return $"Profesor: {base.DevolverNombreCompleto()}";
        }

        public override string Saludo()
        {
            return "Buenos días alumno";
        }
    }
}
