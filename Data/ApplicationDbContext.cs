using D_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace D_Project.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
    : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // ROLES
        var admin = new IdentityRole("Admin");
        admin.NormalizedName = "ADMIN";
        
        var client = new IdentityRole("Client");
        client.NormalizedName = "CLIENT";
        
        var donator = new IdentityRole("Donator");
        donator.NormalizedName = "DONATOR";
        
        builder.Entity<IdentityRole>().HasData(admin, client, donator);
    }
    
}