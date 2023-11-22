using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using ASP_Platzi.Context;

namespace ASP_Platzi.Controllers;

public class AlumnoController : Controller
{
    private EscuelaContext _context;
    public AlumnoController(EscuelaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Alumno> listaAlumnos = _context.Alumnos.ToList();
        
        return View(listaAlumnos);
    }

 /*   public IActionResult Single()
    {
        Asignatura asignatura1 = new()
        {   
            Nombre = "Matemáticas",
        };
        return View(asignatura1);
    }*/
}