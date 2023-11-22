namespace ASP_Platzi.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Inscripcion> Inscripciones { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
    }
}