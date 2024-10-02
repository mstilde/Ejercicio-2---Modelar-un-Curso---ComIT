using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadIT2
{
    public class Alumno : Persona
    {
        public bool Trabaja = false;

        public Alumno(long dni, string nombre, string apellido, DateOnly fechaNacimiento, bool trabaja)
            : base(dni, nombre, apellido, fechaNacimiento)
        {
            Trabaja = trabaja;
        }

        public override string DevolverNombreCompleto()
        {
            return $"Alumno: {base.DevolverNombreCompleto()}";
        }

        public override string Saludo()
        {
            return "Buenos días profesor";
        }
    }

}
