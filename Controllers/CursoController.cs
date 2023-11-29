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

    [Route("Curso/Single/{CursoId}")]
    public IActionResult Single(string CursoId)
    {
        Curso curso = _context.Cursos
            .Where(p => p.Id == CursoId)
            .Include(p => p.Escuela)
            .Include(p => p.Inscripciones)
            .ThenInclude(p => p.Alumno)
            .SingleOrDefault();
        if (curso != null)
        {
            return View(curso);
        } else
        {
            return View("Error");
        }

    }


    public IActionResult Create()
    {
        List<Escuela> Escuelas = _context.Escuelas.ToList();
        ViewBag.Escuelas = Escuelas;
        return View();
    }

    [HttpPost]
    public IActionResult Create(Curso curso)
    {
        List<Escuela> Escuelas = _context.Escuelas.ToList();
        ViewBag.Escuelas = Escuelas;

        if (ModelState.IsValid)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            return RedirectToAction("Single", "Curso", new {id=curso.Id});
        } else {
            return View(curso);
        }
    }
}