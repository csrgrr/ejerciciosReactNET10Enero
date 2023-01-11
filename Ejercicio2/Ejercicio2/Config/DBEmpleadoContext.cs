using Ejercicio2.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio2.Config
{
    public class DBEmpleadoContext : DbContext
    {
        public DBEmpleadoContext(DbContextOptions<DBEmpleadoContext> options) : base(options)
        {
           
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
