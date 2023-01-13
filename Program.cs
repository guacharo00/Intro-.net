
using System;
using CoreEscuela.Entities;
using static System.Console; // Nos permite imprimir en consola escribiendo solo WriteLine.

namespace Etapa1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var escuela = new Escuela(
                "techno scool", 
                2015, 
                TiposEscuela.Secundaria,
                pais: "Rep. Dom.",
                ciudad: "San Cristobal"
                );
            // var arregloCursos = new Curso[3];
            // Optimizando el arreglo
            // Curso[] arregloCursos = {
            //     new Curso() { Nombre = "101" },
            //     new Curso() { Nombre = "102" },
            //     new Curso() { Nombre = "103" },
            // };
            // Agregando el arreglo a la escuel

            // escuela.Cursos = new Curso[]{
            //     new Curso() { Nombre = "101" },
            //     new Curso() { Nombre = "102" },
            //     new Curso() { Nombre = "103" },
            // };

            // Cambiando el arreglo de cursos por una coleccion
            escuela.Cursos = new List<Curso>(){
                new Curso() { Nombre = "101", Jornada = TiposJornada.Matutino },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Vespertino  },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Nocturno  },
            };

            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Matutino });
            escuela.Cursos.Add( new Curso{ Nombre = "202", Jornada = TiposJornada.Vespertino } );
            
            var otraCollection = new List<Curso>(){
                new Curso() { Nombre = "401", Jornada = TiposJornada.Matutino },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Matutino  },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Vespertino  },
                new Curso() { Nombre = "502", Jornada = TiposJornada.Nocturno  },
            };

            /*
            Curso tmp = new Curso() { Nombre = "505-Vacacional", Jornada = TiposJornada.Nocturno  }; // para eliminar

            otraCollection.Clear(); // Borra todos los elementos de la coleccion

            escuela.Cursos.AddRange(otraCollection); // Concatena dos collecciones

            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);

            WriteLine("Curso HashCode: " + tmp.GetHashCode()); // Obtener el hashcode, Es un identificador unico de objetos asi sabe el metodo remove cual objeto eliminar

            Predicate<Curso> miAlgoritmo = Predicado; // Un delegado asegura que la funcion que enviamos como parametro cumpla con los requisitos de entrada y salida. No se usa....
            
            escuela.Cursos.RemoveAll( Predicado ); // Ejecuta el metodo predicado por cada uno de los cursos en la coleccion.
            escuela.Cursos.RemoveAll( delegate(Curso cur){ return cur.Nombre == "202"; } ); // Le pasamos el delegado como parametro asi evitamos crear un metodo nuevo Explicito
            escuela.Cursos.RemoveAll( (cur) =>  cur.Nombre == "501" && cur.Jornada == TiposJornada.Matutino ); // Le pasamos el delegado como parametro asi evitamos crear un metodo nuevo con return implicito
            escuela.Cursos.Remove(tmp); // Remueve un curso especifico de el cual sabemos la referencia
            */

            WriteLine("=================================");
            ImprimirCursosEscuela(escuela);

        }

        private static bool Predicado(Curso obj) // El predicado es un metodo que devielve booleano depende de la condicion
        {
            return obj.Nombre == "301"; // Devuelve true si encuentra un curso con el nombre "301" y RemoveAll lo elimina
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("======================");
                    WriteLine("Cursos de la escuela");
                    WriteLine("======================");

            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Numero de curso {curso.Nombre}, Jornada {curso.Jornada}, ID {curso.UniqueId}");
                }
            }


        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Numero de curso {arregloCursos[contador].Nombre}, ID {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Numero de curso {arregloCursos[contador].Nombre}, ID {arregloCursos[contador].UniqueId}");
                contador++;
            }while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            // for (int i = 0; i < arregloCursos.Length; i++)
            // {
            //     Console.WriteLine($"Numero de curso {arregloCursos[i].Nombre}, ID {arregloCursos[i].UniqueId}");
            // }

            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Numero de curso {curso.Nombre}, ID {curso.UniqueId}");
            }
        }
    }
}