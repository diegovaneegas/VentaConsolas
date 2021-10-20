using Microsoft.EntityFrameworkCore; /*importacion de librerias para uso del DbContext*/
using Dominio;
using Persistencia;


namespace Persistencia
{
    public class Conexion : DbContext
    {   /*Cada tabla necesita un DbSet* con su respectivo get y set y que sea public*/
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Consolas> Consolas {get; set;}
        public DbSet<VideoJuego> VideoJuego {get; set;}
        public DbSet<Control> Control {get; set;}

        
                
        /*Conexion base de datos*/
        protected override void OnConfiguring(DbContextOptionsBuilder conn){
                if(!conn.IsConfigured){
                    conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = DatosExito"); /*Conexion base de datos*/
                }
        }
    }
}