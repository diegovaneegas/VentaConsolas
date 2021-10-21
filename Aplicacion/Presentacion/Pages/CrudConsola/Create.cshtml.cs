using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudConsola
{
    public class CreateModel : PageModel
    {
        public SelectList VideoJuegosFront;

        public int VideoJuegoID {get; set;}
        private readonly Persistencia.Conexion _context;

        public CreateModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            List<VideoJuego> listaVideojuegos = _context.VideoJuego.ToList();
            VideoJuegosFront= new SelectList(listaVideojuegos, nameof(VideoJuego.Id), nameof(VideoJuego.Nombre));
            return Page();
        }

        [BindProperty]
        public Consolas Consolas { get; set; }

        [BindProperty]
        public VideoJuego VideoJuego { get; set; }

        [BindProperty]
        public TipoAlmacenamiento TipoAlmacenamiento { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            VideoJuego videojuego =_context.VideoJuego.FirstOrDefault(v => v.Id == VideoJuegoID);
            Consolas.VideoJuego = videojuego;

            _context.Consolas.Add(Consolas);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
