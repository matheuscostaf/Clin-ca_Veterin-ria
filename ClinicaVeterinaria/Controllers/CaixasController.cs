﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Controllers
{
    public class CaixasController : Controller
    {
        private readonly ClinicaVeterinariaContext _context;

        public CaixasController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        // GET: Caixas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caixa.OrderByDescending(x => x.Data).ToListAsync());
        }

        // GET: Caixas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixa = await _context.Caixa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixa == null)
            {
                return NotFound();
            }

            return View(caixa);
        }

        // GET: Caixas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Caixas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Historico,EntradaouSaida")] Caixa caixa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caixa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caixa);
        }

        // GET: Caixas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixa = await _context.Caixa.FindAsync(id);
            if (caixa == null)
            {
                return NotFound();
            }
            return View(caixa);
        }

        // POST: Caixas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Historico,EntradaouSaida")] Caixa caixa)
        {
            if (id != caixa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caixa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaixaExists(caixa.Id))
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
            return View(caixa);
        }

        // GET: Caixas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixa = await _context.Caixa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixa == null)
            {
                return NotFound();
            }

            return View(caixa);
        }

        // POST: Caixas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caixa = await _context.Caixa.FindAsync(id);
            _context.Caixa.Remove(caixa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaixaExists(int id)
        {
            return _context.Caixa.Any(e => e.Id == id);
        }
    }
}
