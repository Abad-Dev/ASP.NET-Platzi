using System;
using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;

namespace ASP_Platzi.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        Escuela escuela1 = new Escuela();
        escuela1.AñoFundacion = 2005;
        escuela1.EscuelaId = Guid.NewGuid().ToString();
        escuela1.Nombre = "Platzi School";

        ViewBag.CosaDinamica = "Dinamismo"; // Sirve para mandar datos dinámicos, se envía automáticamente

        return View(escuela1);
    }
}