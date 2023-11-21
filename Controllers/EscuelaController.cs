using System;
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

        _context.Cursos.Add(new Curso
        {
            Jornada = TiposJornada.Mañana,
            Escuela = escuela1,
            Nombre = "Programación"
        });

        _context.SaveChanges();

        return View(escuela1);
    }
}