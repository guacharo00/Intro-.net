using System;

namespace CoreEscuela.Entities
{
    public class Evaluacion
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Alumno Alumno { set; get; }
        public Asignatura Asignatura { set; get; }
        public float Nota { get; set; }

        public Evaluacion () => UniqueId = Guid.NewGuid().ToString();
    }
}