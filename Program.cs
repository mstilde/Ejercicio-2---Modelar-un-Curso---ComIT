
using ComunidadIT2;

List<Curso> listaCursos = new List<Curso>();

EstablecerCursos(listaCursos);

InformarCursos(listaCursos);


static string IngresoNuevoNombreCurso()
{
    Console.WriteLine("Ingrese un nombre para el curso nuevo (De querer parar la ejecución, no ingrese nada)");
    return Console.ReadLine();
}

static void EstablecerCursos(List<Curso> listaCursos)
{
    Console.WriteLine("Ingrese la cantidad de cursos a ingresar");
    int cantidadCursos = int.Parse(Console.ReadLine());
    GenerarCursos(listaCursos, cantidadCursos);
}


static void GenerarCursos(List<Curso> cursos, int cantidadCusos)
{
    String? nombreIngresado = IngresoNuevoNombreCurso();
    int contador = 0;
    while (!string.IsNullOrEmpty(nombreIngresado) && (contador < cantidadCusos))
    {
        contador++;

        Console.WriteLine("Ingrese la cantidad de alumnos del nuevo curso");
        int cantidadMaximaAlumnos = int.Parse(Console.ReadLine());

        Curso curso = new(nombreIngresado, cantidadMaximaAlumnos);
        curso.Profesor = curso.CargarDatosProfesor();
        curso.IngresarAlumnos(cantidadMaximaAlumnos);
        cursos.Add(curso);
        nombreIngresado = IngresoNuevoNombreCurso();
    }
}

static void InformarCursos(List<Curso> cursos)
{
    foreach (Curso curso in cursos)
    {
        curso.ImprimirDatosCurso();
        Console.WriteLine();
    }
}




// ANOTACIONES DEL CURSO



/*
Profesor profesor = new(40768651, "Ricardo", "Montaner", new(19, 02, 1977), 13);
Curso curso1 = new("Curso .NET", 30)
{
    Profesor = profesor
};

Alumno alumno1 = new(35728444, "David", "Bisbal", new(11, 04, 1991), false);

curso1.Alumnos[0] = alumno1;

// Para una correcta 

for (int i = 0; i < curso1.CantidadMaxAlumnos; i++)
{
    Console.WriteLine($"Ingrese el alumno {i + 1}");
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

    curso1.Alumnos.Add(new Alumno(dni, nombre, apellido, fechaNacimiento, trabaja));
}

for (int i = 0;i < curso.CantidadMaxAlumnos;i++)
{
    Console.WriteLine($"{i}) DNI: {curso.Alumnos[i].DNI} | Nombre: {curso.Alumnos[i].Nombre} | Apellido: {curso.Alumnos[i].Apellido} | Fecha de nacimiento {curso.Alumnos[i].FechaDeNacimiento} | {(curso.Alumnos[i].Trabaja ? "El alumno trabaja" : "El alumno no trabaja")}");
    Console.WriteLine();
}

int cont = 1;
foreach (var alumno in curso1.Alumnos)
{
    Console.WriteLine($"{cont}) DNI: {alumno.DNI} | Nombre: {alumno.Nombre} | Apellido: {alumno.Apellido} | Fecha de nacimiento {alumno.FechaDeNacimiento} | {(alumno.Trabaja ? "El alumno trabaja" : "El alumno no trabaja")}");
    Console.WriteLine();
    cont++;
}
Console.WriteLine($"Los alumnos del curso {curso1.Nombre} son:");

String nombreABuscar = "Martin";
Alumno? alumnoEncontrado = curso1.Alumnos.Find(a => a.Nombre == nombreABuscar);

Console.WriteLine(alumnoEncontrado != null ? $"El apellido del alumno buscado es {alumnoEncontrado.Apellido}" : "No se encontró el alumno");



profesor.NombreCompleto = $"{profesor.Nombre} {profesor.Apellido}";

var nombreCompleto = profesor.NombreCompleto;

Console.WriteLine(profesor.NombreCompleto);
*/