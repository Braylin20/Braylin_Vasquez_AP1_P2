using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Braylin_Vasquez_AP1_P2.API.Dal;
public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Accesorios> Accesorios { get; set;}
    public DbSet<Vehiculos> Vehiculos { get; set;}
    public DbSet<VehiculosDetalle> VehiculosDetalle { get; set;}
}
