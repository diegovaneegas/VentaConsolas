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
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string CedulaLogin { get; set; }

        [BindProperty]
        public string ContrasenaLogin { get; set; }

        [BindProperty]
        public string MensajeUsuario { get; set; }

        [BindProperty]
        public string MensajePassword { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost(){
            Console.WriteLine(CedulaLogin);
            Conexion conn = new Conexion();
            Empleado emp1 = conn.Empleados.FirstOrDefault(e => e.Cedula == CedulaLogin);

            if(emp1 != null){
                if(emp1.primerIngreso){
                    HttpContext.Session.SetString("username", CedulaLogin);
                    return RedirectToPage("../CambiarContrasena/CambiarContrasena");
                }

                if(emp1.Password.Equals(ContrasenaLogin)){
                    return RedirectToPage("../CrudEmpleado/Index");
                }else{
                    MensajePassword = "La contraseña no coincide";
                    return Page();
                }

            }else{
                MensajeUsuario = "El usuario no ha sido encontrado";
                return Page();
            }

            
        }
    }
}
