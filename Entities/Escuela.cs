using System.Collections.Generic;

namespace CoreEscuela.Entities
{
    public class Escuela
    {
        string nombre;

        public string Nombre
        {
            get{ return "copia:" + nombre; }
            set{ nombre = value.ToUpper(); }
        } 

        public int AnoDeCreacion {get;set;}

        public string Pais { get; set; }

        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela {get; set;}
        public List<Curso> Cursos { get; set; }

    //   Constructor del componente
        // public Escuela(string nombre, int ano)
        // {
        //     this.nombre = nombre;
        //     this.AnoDeCreacion = ano;
        // }

        // Otra forma de construir el constructor
        public Escuela (string nombre, int ano) => (Nombre, AnoDeCreacion) = (nombre, ano);
        public Escuela (string nombre, int ano, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            // Asignar valores a los parametros
            (Nombre, AnoDeCreacion) = (nombre, ano);
            Pais = pais;
            Ciudad = ciudad;
            TipoEscuela = tipo;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}