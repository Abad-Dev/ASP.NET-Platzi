using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;

namespace ASP_Platzi.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        Escuela escuela1 = new()
        {
            AñoFundacion = 2005,
            EscuelaId = Guid.NewGuid().ToString(),
            Nombre = "Platzi School"
        };

        ViewBag.CosaDinamica = "Dinamismo"; // Sirve para mandar datos dinámicos, se envía automáticamente
        
        return View(escuela1);
    }
}