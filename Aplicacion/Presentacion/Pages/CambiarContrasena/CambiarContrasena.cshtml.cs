using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Http;

namespace Presentacion.Pages
{
    public class CambiarContrasenaModel : PageModel
    {
        [BindProperty]
        public string ConfirmarContrasenaN1 { get; set; }

        [BindProperty]
        public string ConfirmarContrasenaN2 { get; set; }

        [BindProperty]
        public string MensajePassword { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Conexion conn = new Conexion();
            var Username = HttpContext.Session.GetString("username");
            HttpContext.Session.Remove("username");

            Empleado emp1 = conn.Empleados.FirstOrDefault(e => e.Cedula == Username);
            if(!ConfirmarContrasenaN1 .Equals(ConfirmarContrasenaN2)){
                MensajePassword = "Las contraseñas no coinciden";
            }else{
                emp1.Password = ConfirmarContrasenaN2;
                emp1.primerIngreso = false;
                conn.SaveChanges();
            }
        }


    }
}
