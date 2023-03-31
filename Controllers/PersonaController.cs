using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba_connection_postgresql.Data;
using prueba_connection_postgresql.Models;


namespace prueba_connection_postgresql.Controllers
{
  public class PersonaController: Controller
  {
    private readonly ApplicationDbContext _context;

    public PersonaController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        System.Console.WriteLine("Hola");
        var personas = _context.Personas.ToList();
        System.Console.WriteLine(personas);
        return View(personas);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Persona persona)
    {
        _context.Personas.Add(persona);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var persona = _context.Personas.Find(id);
        return View(persona);
    }

    [HttpPost]
    public IActionResult Edit(Persona persona)
    {
        _context.Personas.Update(persona);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var persona = _context.Personas.Find(id);
        return View(persona);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        System.Console.WriteLine(id);
        var persona = _context.Personas.Find(id);
        _context.Personas.Remove(persona);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}