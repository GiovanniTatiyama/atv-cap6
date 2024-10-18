using Microsoft.EntityFrameworkCore;
using Trafego1.Models;

namespace Trafego1.Data.Contexts;

public class DatabaseContext : DbContext
{

    public DbSet<Trafego> Trafegos { get; set; }
    public DbSet<Semaforos> Semaforos { get; set; }
    public DbSet<Notificacoes> Notificacoes { get; set; }
    
    
    
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}