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
        Escuela escuela1 = _context.Escuelas.FirstOrDefault();

        return View(escuela1);
    }
}