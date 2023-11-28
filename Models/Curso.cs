using System.ComponentModel.DataAnnotations;

namespace ASP_Platzi.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        public override string Nombre { get => base.Nombre; set => base.Nombre = value; }
        public TiposJornada Jornada { get;set; }
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Inscripcion> Inscripciones { get; set; }
    }
}