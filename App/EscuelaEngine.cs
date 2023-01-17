using System;
using System.Collections.Generic;
using CoreEscuela.Entities;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela("techno scool", 2015, TiposEscuela.Secundaria, pais: "Rep. Dom.", ciudad: "San Cristobal");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            var lista = new List<Evaluacion>();
            foreach (var cursos in Escuela.Cursos)
            {
                foreach (var asig in cursos.Asignaturas)
                {
                    foreach (var alum in cursos.Alumnos)
                    {
                       var rnd = new Random(System.Environment.TickCount);

                       for (int i = 0; i < 5; i++)
                       {
                            var ev = new Evaluacion
                            {
                                Asignatura = asig,
                                Nombre = $"{asig.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alum
                            };

                            lista.Add(ev);
                       }
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos )
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{ Nombre = "Matematicas" },
                    new Asignatura{ Nombre = "Ciencias Sociales" },
                    new Asignatura{ Nombre = "Ciencias Naturales" },
                    new Asignatura{ Nombre = "Lengua Espanola" }
                };
                
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno{Nombre = $"{n1} {n2} {a1}"};

            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
            /*
            * Usamos 3 arreglos de alumnos para crear alumnos aleatorios (Juntar nombre1 con nombre2 y apeellido1)
            * Creamos una lista de alumnos con la opcion from en forma de mapa cartesiano. Esto lo que hace es que toma el primer nombre e la
            * lista nombre1 y lo machea con todos de la lista nombre2 y con todos los apellidos.
            * Esto se hace con linQ
            * Retornamos una lista Sorteada por el ID con una cantidad definida por el argumento que mandemos(cantidad).
            */
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso() { Nombre = "101", Jornada = TiposJornada.Matutino },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Vespertino  },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Nocturno  },
                new Curso() { Nombre = "401", Jornada = TiposJornada.Matutino },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Matutino  },
            };

            Random rdn = new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rdn.Next(10, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}