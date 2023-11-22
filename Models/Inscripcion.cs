namespace ASP_Platzi.Models;

public class Inscripcion : ObjetoEscuelaBase
{
    public Alumno Alumno { get;set; }
    public Curso Curso { get;set; }
    public string AlumnoId { get;set; }
    public string CursoId { get;set; }
}