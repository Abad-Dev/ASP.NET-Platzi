using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;

namespace ASP_Platzi.Controllers;

public class AlumnoController : Controller
{
    public IActionResult Index()
    {
        List<Alumno> listaAlumnos = new () {
            new Alumno { Nombre = "Luis" },
            new Alumno { Nombre = "Alberto" },
            new Alumno { Nombre = "José" },
            new Alumno { Nombre = "Pedro" },
            new Alumno { Nombre = "Francisco" }
        };
        
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