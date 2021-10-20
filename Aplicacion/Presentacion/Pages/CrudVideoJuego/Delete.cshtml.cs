using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudVideoJuego
{
    public class DeleteModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public DeleteModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public VideoJuego VideoJuego { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoJuego = await _context.VideoJuego.FirstOrDefaultAsync(m => m.Id == id);

            if (VideoJuego == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VideoJuego = await _context.VideoJuego.FindAsync(id);

            if (VideoJuego != null)
            {
                _context.VideoJuego.Remove(VideoJuego);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
