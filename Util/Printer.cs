using static System.Console;

namespace CoreEscuela.Util
{
    /*
    * Una clase estatica no permite crear nuevas intancias
    * la clase en si misma funciona como un objeto
    */
    public static class Printer
    {
        
        public static void dibujarLinea(int tamano)
        {
            var linea = "".PadLeft(tamano, '=');
            WriteLine(linea);
        }

        public static void dibujarTitulo(string titulo)
        {
            dibujarLinea(titulo.Length + 4);
            WriteLine($"| {titulo} |");
            dibujarLinea(titulo.Length + 4);
        }

        public static void Pitido(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }

    }
}