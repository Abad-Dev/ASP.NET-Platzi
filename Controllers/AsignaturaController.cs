using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;

namespace ASP_Platzi.Controllers;

public class AsignaturaController : Controller
{
    public IActionResult Index()
    {
        List<Asignatura> listaAsignaturas = new () {
            new Asignatura { Nombre = "Matemáticas" },
            new Asignatura { Nombre = "Educación Física" },
            new Asignatura { Nombre = "Castellano" },
            new Asignatura { Nombre = "Ciencias Naturales" },
            new Asignatura { Nombre = "Programacion" }
        };

        ViewBag.CosaDinamica = "Dinamismo"; // Sirve para mandar datos dinámicos, se envía automáticamente
        
        return View(listaAsignaturas);
    }

    public IActionResult Single()
    {
        Asignatura asignatura1 = new()
        {   
            Nombre = "Matemáticas",
        };
        return View(asignatura1);
    }
}