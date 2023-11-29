using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using ASP_Platzi.Context;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class AsignaturaController : Controller
{
    private EscuelaContext _context;
    public AsignaturaController(EscuelaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Asignatura> listaAsignaturas = _context.Asignaturas.ToList();
        return View(listaAsignaturas);
    }

    [Route("Asignatura/Single/{AsignaturaId}")]
    public IActionResult Single(string AsignaturaId)
    {
        Asignatura asignatura = _context.Asignaturas
        .Where(p => p.Id == AsignaturaId)
        .Include(p => p.Curso)
        .ThenInclude(p => p.Escuela)
        .SingleOrDefault();
        if (asignatura != null)
        {
            return View(asignatura);
        } else{
            return View("Error");
        }
    }

    public IActionResult Create()
    {
        List<Curso> Cursos = _context.Cursos.ToList();
        ViewBag.Cursos = Cursos;

        return View();
    }

    [HttpPost]
    public IActionResult Create(Asignatura asignatura)
    {
        List<Curso> Cursos = _context.Cursos.ToList();
        ViewBag.Cursos = Cursos;

        if (ModelState.IsValid)
        {
            _context.Asignaturas.Add(asignatura);
            _context.SaveChanges();
            return RedirectToAction("Single", "Asignatura", new {id=asignatura.Id});
        } else {
            return View(asignatura);
        }

    }
}