using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;

namespace ASP_Platzi.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
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