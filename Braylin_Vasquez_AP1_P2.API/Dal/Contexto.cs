using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Braylin_Vasquez_AP1_P2.API.Dal;
public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Accesorios> Accesorios { get; set;}
    public DbSet<Vehiculos> Vehiculos { get; set;}
    public DbSet<VehiculosDetalle> VehiculosDetalle { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Accesorios>().HasData(new List<Accesorios>()
        {
            new Accesorios (){ AccesoriosId=1,Descripcion="Camara Trasera" },
            new Accesorios (){ AccesoriosId=2,Descripcion="Pantalla Inferior" },
            new Accesorios (){ AccesoriosId=3,Descripcion="Interior Trasera" }
        }); 

        
    }
}
