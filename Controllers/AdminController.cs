using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GestionBiblioteca.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GestionBiblioteca.Models;

namespace GestionBiblioteca.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult BookEnterFrom()
        {
            return View();
        }

        // public int Id {get;set;}
        // public string Isbn { get; set; }
        // public string Title { get; set; }
        // public string Author { get; set; }
        // public bool Availability { get; set; }
        // metodo para crear un book
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateBook([Bind("Id,Isbn,Title,Author,Img_Url, Category, Availability")] Book book)
        {
            {
                if (ModelState.IsValid)
                {
                    _context.Add(book);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));

            }
        }
    }
}