using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using ASP_Platzi.Context;

namespace ASP_Platzi.Controllers;

public class EscuelaController : Controller
{
    private EscuelaContext _context;
    public EscuelaController(EscuelaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        _context.Database.EnsureCreated();
        Escuela escuela1 = new()
        {   
            Nombre = "Platzi",
            Ciudad = "Bogotá",
            Pais = "Colombia",
            Dirección = "Av. Quienque 356",
            AñoDeCreación = 2005,
            TipoEscuela = TiposEscuela.Secundaria
        };

        ViewBag.CosaDinamica = "Dinamismo"; // Sirve para mandar datos dinámicos, se envía automáticamente
        
        return View(escuela1);
    }
}