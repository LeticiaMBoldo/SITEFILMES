using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteFilmes.Data;
using SiteFilmes.Models;

namespace SiteFilmes.Controllers
{
    public class TipoAtuacaoController : Controller
    {
        private readonly SiteFilmesContext _context;

        public TipoAtuacaoController(SiteFilmesContext context)
        {
            _context = context;
        }

        // GET: TipoAtuacao
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoAtuacao.ToListAsync());
        }

        // GET: TipoAtuacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAtuacao = await _context.TipoAtuacao
                .FirstOrDefaultAsync(m => m.idTipoAtuacao == id);
            if (tipoAtuacao == null)
            {
                return NotFound();
            }

            return View(tipoAtuacao);
        }

        // GET: TipoAtuacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoAtuacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTipoAtuacao,nomeTipoAtuacao")] TipoAtuacao tipoAtuacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoAtuacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoAtuacao);
        }

        // GET: TipoAtuacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAtuacao = await _context.TipoAtuacao.FindAsync(id);
            if (tipoAtuacao == null)
            {
                return NotFound();
            }
            return View(tipoAtuacao);
        }

        // POST: TipoAtuacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTipoAtuacao,nomeTipoAtuacao")] TipoAtuacao tipoAtuacao)
        {
            if (id != tipoAtuacao.idTipoAtuacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoAtuacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoAtuacaoExists(tipoAtuacao.idTipoAtuacao))
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
            return View(tipoAtuacao);
        }

        // GET: TipoAtuacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoAtuacao = await _context.TipoAtuacao
                .FirstOrDefaultAsync(m => m.idTipoAtuacao == id);
            if (tipoAtuacao == null)
            {
                return NotFound();
            }

            return View(tipoAtuacao);
        }

        // POST: TipoAtuacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoAtuacao = await _context.TipoAtuacao.FindAsync(id);
            _context.TipoAtuacao.Remove(tipoAtuacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoAtuacaoExists(int id)
        {
            return _context.TipoAtuacao.Any(e => e.idTipoAtuacao == id);
        }
    }
}
