using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadIT2
{
    public class Curso
    {
        public string Nombre = string.Empty;
        public int CantidadMaxAlumnos = 0;
        public Profesor? Profesor;
        public List<Alumno> Alumnos;

        public Curso(string nombreCurso, int cantidadMaxAlumnos)
        {
            Nombre = nombreCurso;
            CantidadMaxAlumnos = cantidadMaxAlumnos;
            Alumnos = new();
        }

        public Profesor CargarDatosProfesor()
        {
            Console.WriteLine("Ingrese el nombre del profesor");
            String? nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del profesor");
            String? apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el dni del profesor");
            long dni = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de nacimiento del profesor en formato dd/mm/aaaa");
            String fecha = Console.ReadLine();
            DateOnly fechaNacimiento = new DateOnly(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));
            Console.WriteLine("Ingrese los años de experiencia del profesor");
            int añosExperiencia = int.Parse(Console.ReadLine());
            return new(dni, nombre, apellido, fechaNacimiento, añosExperiencia);
        }

        private bool SeIngresaAlumno()
        {
            Console.WriteLine("Desea ingresar un alumno? (Si/No): ");
            return Console.ReadLine() == "Si";
        }

        public void IngresarAlumnos(int alumnosMaximos)
        {
            int alumnosIngresados = 0;
            bool ingresarAlumnos = SeIngresaAlumno();
            while (alumnosIngresados < alumnosMaximos && ingresarAlumnos)
            {
                alumnosIngresados++;

                Console.WriteLine($"Ingrese el alumno {alumnosIngresados}");
                Console.WriteLine("DNI: ");
                long dni = long.Parse(Console.ReadLine());
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingresar fecha (dd/mm/aaaa): ");
                string fecha = Console.ReadLine();
                DateOnly fechaNacimiento = new DateOnly(int.Parse(fecha.Substring(6, 4)), int.Parse(fecha.Substring(3, 2)), int.Parse(fecha.Substring(0, 2)));
                Console.WriteLine("Trabaja (Si/No): ");
                bool trabaja = Console.ReadLine() == "Si";

                Alumnos.Add(new Alumno(dni, nombre, apellido, fechaNacimiento, trabaja));
                ingresarAlumnos = SeIngresaAlumno();
            }
            if (alumnosIngresados >= alumnosMaximos)
            {
                Console.WriteLine("Se completó el cupo total de alumnos");
            }
        }

        public void ImprimirDatosCurso()
        {
            Console.WriteLine($"Nombre del curso: {Nombre}");
            Console.WriteLine($"Cantidad máxima de alumnos: {CantidadMaxAlumnos}");
            Console.WriteLine();
            Console.WriteLine("Datos del docente a cargo:");
            Console.WriteLine($"Nombre completo: {Profesor.NombreCompleto}");
            Console.WriteLine($"DNI: {Profesor.DNI}");
            Console.WriteLine($"Fecha de nacimiento: {Profesor.FechaDeNacimiento}");
            Console.WriteLine($"Años de experiencia: {Profesor.AñosDeExperiencia}");
            Console.WriteLine();
            Console.WriteLine("Alumnos del curso:");
            int contadorAl = 0;
            foreach(Alumno al in Alumnos)
            {
                contadorAl++;
                Console.WriteLine($"{contadorAl}- Nombre completo: {al.NombreCompleto}, DNI: {al.DNI}, Fecha de nacimiento: {al.FechaDeNacimiento}, Trabaja {(al.Trabaja ? "Sí" : "No")}");
            }
        }
    }
}
