using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Context;

public class EscuelaContext : DbContext 
{
    public DbSet<Escuela> Escuelas { get;set; }
    public DbSet<Asignatura> Asignaturas { get;set; }
    public DbSet<Alumno> Alumnos { get;set; }
    public DbSet<Inscripcion> Inscripciones { get;set; }
    public DbSet<Curso> Cursos { get;set; }
    public DbSet<Evaluacion> Evaluaciones { get;set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=70.32.23.64;Database=limamenus_asp;Uid=limamenus_asp;Pwd=Diego5147;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curso>().HasKey(p => p.Id);
        modelBuilder.Entity<Asignatura>().HasKey(p => p.Id);
        modelBuilder.Entity<Inscripcion>().HasKey(p => p.Id);
        modelBuilder.Entity<Inscripcion>().HasKey(p => p.Id);


        modelBuilder.Entity<Curso>().HasOne(p => p.Escuela).WithMany(p => p.Cursos).HasForeignKey(p => p.EscuelaId);
        modelBuilder.Entity<Asignatura>().HasOne(p => p.Curso).WithMany(p => p.Asignaturas).HasForeignKey(p => p.CursoId);
        modelBuilder.Entity<Inscripcion>().HasOne(p => p.Alumno).WithMany(p => p.Inscripciones).HasForeignKey(p => p.AlumnoId);
        modelBuilder.Entity<Inscripcion>().HasOne(p => p.Curso).WithMany(p => p.Inscripciones).HasForeignKey(p => p.CursoId);

        Escuela escuela1 = new()
        { 
            Nombre = "Colegio Los Álamos",
            AñoDeCreación = 2015,
            Pais = "Colombia",
            Ciudad = "Bogotá",
            Dirección = "Av. Siempreviva 507",
            TipoEscuela = TiposEscuela.Secundaria
        };
        modelBuilder.Entity<Escuela>().HasData(escuela1);

        Curso curso1 = new()
        {
            Nombre = "Matemáticas", 
            EscuelaId = escuela1.Id
        };
        modelBuilder.Entity<Curso>().HasData(curso1);

        Asignatura asignatura1 = new()
        {
            Nombre = "Álgebra",
            CursoId = curso1.Id
        };
        modelBuilder.Entity<Asignatura>().HasData(asignatura1);

        Alumno alumno1 = new()
        {
            Nombre = "Juan Perez"
        };
        modelBuilder.Entity<Alumno>().HasData(alumno1);

        Inscripcion inscripcion1 = new()
        {
            AlumnoId = alumno1.Id,
            CursoId = curso1.Id
        };
        modelBuilder.Entity<Inscripcion>().HasData(inscripcion1);

        base.OnModelCreating(modelBuilder);
    }
}