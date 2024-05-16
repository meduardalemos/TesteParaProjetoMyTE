using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TesteParaProjetoMyTE.Models;

namespace TesteParaProjetoMyTE.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TesteParaProjetoMyTE.Models.Departamento> Departamento { get; set; } = default!;
    }
}
