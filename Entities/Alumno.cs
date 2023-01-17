using System;

namespace CoreEscuela.Entities
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Alumno () => UniqueId = Guid.NewGuid().ToString();
    }
}