using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using ASP_Platzi.Context;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class CursoController : Controller
{
    private EscuelaContext _context;
    public CursoController(EscuelaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        // Importante el método Include, sino devuelve null
        List<Curso> Cursos = _context.Cursos.Include(p => p.Escuela).ToList();
        
        return View(Cursos);
    }
}