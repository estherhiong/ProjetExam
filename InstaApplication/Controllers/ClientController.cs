using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstaApplication.Models;


namespace AspMVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly Myctx _context;

        public ClientController(Myctx context)
        {

            _context = context;
        }

        //GET: Produits
        public IActionResult Index()
        {
            return View(_context.Clients.ToList());
        }

        //GET: Produits/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Clients = _context.Clients
                .FirstOrDefault(m => m.Id == id);
            if (Clients == null)
            {
                return NotFound();
            }

            return View(Clients);
        }

        // GET: Produits/Create

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create([Bind("Id,Name,Prenom,age,adresse")] Client Clients)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Clients);
                _context.SaveChanges();
                //return RedirectToAction(nameof(Index));
            }
            return View(Clients);
        }

        // GET: Produits/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Clients = _context.Clients.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }

        // POST: Produits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Prenom,age,adresse")] Client Clients)
        {
            if (id != Clients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Clients);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(Clients.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Clients);
        }

        // GET: Produits/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Clients = _context.Clients
                .FirstOrDefault(m => m.Id == id);
            if (Clients == null)
            {
                return NotFound();
            }

            return View(Clients);
        }

        // POST: Produits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var Clients = _context.Clients.Find(id);
            if (Clients != null)
            {
                _context.Clients.Remove(Clients);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}