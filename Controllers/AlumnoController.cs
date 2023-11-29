using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using ASP_Platzi.Context;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class AlumnoController : Controller
{
    private EscuelaContext _context;
    public AlumnoController(EscuelaContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        List<Alumno> listaAlumnos = _context.Alumnos.ToList();
        
        return View(listaAlumnos);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Alumno Alumno)
    {
        if (ModelState.IsValid)
        {
            _context.Alumnos.Add(Alumno);
            _context.SaveChanges();
            return RedirectToAction("Single", "Alumno", new {id=Alumno.Id});
        } else {
            return View(Alumno);
        }
    }

    public IActionResult Single(string id)
    {
        Alumno alumno = _context.Alumnos.Where(p => p.Id == id).SingleOrDefault();
        ViewBag.Inscripciones = _context.Inscripciones.Where(p => p.AlumnoId == id).Include(p => p.Curso).ToList();
        ViewBag.Cursos = _context.Cursos.Include(p => p.Escuela).ToList();
        return View(alumno);
    }

    public IActionResult Inscribir(string cursoId, string alumnoId)
    {
        _context.Inscripciones.Add(new Inscripcion()
        {
            CursoId = cursoId,
            AlumnoId = alumnoId
        });
        _context.SaveChanges();
        return RedirectToAction("Single", "Alumno", new {id=alumnoId});
        
    }
}