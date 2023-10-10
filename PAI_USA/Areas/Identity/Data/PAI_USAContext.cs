using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PAI_USA.Models;

namespace PAI_USA.Data;

public class PAI_USAContext : IdentityDbContext<IdentityUser>
{
    public PAI_USAContext(DbContextOptions<PAI_USAContext> options)
        : base(options)
    {
    }
    public DbSet<CrmLogIn> CrmLogIn { get; set; }   
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
