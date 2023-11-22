namespace ASP_Platzi.Models
{
    public class Evaluacion : ObjetoEscuelaBase
    {
        public Alumno Alumno { get;set; }
        public Asignatura Asignatura  { get;set; }
        public string AlumnoId { get;set; }
        public string AsignaturaId { get;set; }

        public float Nota { get; set; }
    }
}