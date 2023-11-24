namespace ASP_Platzi.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get;set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Inscripcion> Inscripciones { get; set; }
    }
}