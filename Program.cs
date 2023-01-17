
using System;
using CoreEscuela.App;
using CoreEscuela.Entities;
using CoreEscuela.Util;
using static System.Console; // Nos permite imprimir en consola escribiendo solo WriteLine.

namespace CoreEscuela
{
    class Program
    {
        public static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            // Printer.dibujarTitulo("Datos de la escuela");
            
            Printer.dibujarTitulo("Info de la escuela");

            WriteLine(engine.Escuela);
            WriteLine("");
            // Printer.Pitido();
            ImprimirCursosEscuela(engine.Escuela);

        }

        private static bool Predicado(Curso obj) // El predicado es un metodo que devielve booleano depende de la condicion
        {
            return obj.Nombre == "301"; // Devuelve true si encuentra un curso con el nombre "301" y RemoveAll lo elimina
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.dibujarTitulo("Cursos");

            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Numero de curso {curso.Nombre}, Jornada {curso.Jornada}, ID {curso.UniqueId}");
                }
            }


        }
    }
}