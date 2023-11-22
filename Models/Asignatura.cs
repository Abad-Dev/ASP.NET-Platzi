namespace ASP_Platzi.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public Curso Curso { get;set; }
        public string CursoId { get;set; }
    }
}