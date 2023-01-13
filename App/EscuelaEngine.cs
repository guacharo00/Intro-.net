using System;
using System.Collections.Generic;
using CoreEscuela.Entities;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela( "techno scool", 2015, TiposEscuela.Secundaria, pais: "Rep. Dom.", ciudad: "San Cristobal" );

            Escuela.Cursos = new List<Curso>(){
                new Curso() { Nombre = "101", Jornada = TiposJornada.Matutino },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Vespertino  },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Nocturno  },
                new Curso() { Nombre = "401", Jornada = TiposJornada.Matutino },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Matutino  },
            };
        }
    }
}