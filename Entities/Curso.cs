using System;

namespace CoreEscuela.Entities
{
    public class Curso
    {
        public string UniqueId { get; private set; } // Solo se asigna en la clase
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso() => UniqueId = Guid.NewGuid().ToString();
    }
}