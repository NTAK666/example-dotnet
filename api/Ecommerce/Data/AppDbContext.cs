using System.Reflection.Emit;
using Bogus;
using Ecommerce.Enum;
using Ecommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        GlobalFilter(modelBuilder);
        SeedRoles(modelBuilder);
        SeedUser(modelBuilder);
        SeedUserRoles(modelBuilder);
        SeedData(modelBuilder);
    }

    private void GlobalFilter(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasQueryFilter(b => !b.IsDeleted);
        modelBuilder.Entity<Category>().HasQueryFilter(b => !b.IsDeleted);
        modelBuilder.Entity<Product>().HasQueryFilter(b => !b.IsDeleted);
        modelBuilder.Entity<Order>().HasQueryFilter(b => !b.IsDeleted);
        modelBuilder.Entity<OrderDetail>().HasQueryFilter(b => !b.IsDeleted);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(new Faker<Category>()
            .RuleFor(c => c.Name, f => f.Name.JobTitle())
            .Generate(10));
        modelBuilder.Entity<Product>().HasData(new Faker<Product>()
            .RuleFor(c => c.Name, f => f.Commerce.ProductName())
            .RuleFor(c => c.Price, f => f.Commerce.Price())
            .RuleFor(c => c.Image, f => "https://api.lorem.space/image/watch?w=300&h=500")
            .RuleFor(c => c.Description, f => f.Commerce.ProductDescription())
            .Generate(10));
    }


    private void SeedUser(ModelBuilder modelBuilder)
    {
        User admin = new User()
        {
            Id = "2dfb43f4-24d5-44a7-af3c-78196e881f23",
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            Email = "admin@gmail.com",
            // Password@123
            PasswordHash = "AQAAAAEAACcQAAAAEL9mII8beu8tjw6mh5JAHpWuTWg1l7+tgRnvYClpWpjRh436/61C4W2D087Bn8efjA=="
        };

        User user = new User()
        {
            Id = "75fa9827-0f5f-41db-a825-64d68d242d7e",
            UserName = "User",
            NormalizedUserName = "USER",
            NormalizedEmail = "USER@GMAIL.COM",
            Email = "user@gmail.com",
            // Password@123
            PasswordHash = "AQAAAAEAACcQAAAAED5zOQ+dt8K/cxCZeSG0A1dl9HZ6IAie9NS3ac+ccp9ZO7yY1C8cucoF1nTZyDQUGA=="
        };

        User guest = new User()
        {
            Id = "df31566d-5ccb-45dc-b1be-864d72133ca4",
            UserName = "Guest",
            NormalizedUserName = "GUEST",
            NormalizedEmail = "GUEST@GMAIL.COM",
            Email = "guest@gmail.com",
            // Password@123
            PasswordHash = "AQAAAAEAACcQAAAAEMRbNZ3zxaCSA+mplWJ8NiHnz/T1r2kYSOjXQlUlQNAt2yp0R7Z4q/V6CGRs/Qiwfg=="
        };

        modelBuilder.Entity<User>().HasData(admin);
        modelBuilder.Entity<User>().HasData(user);
        modelBuilder.Entity<User>().HasData(guest);
    }

    private void SeedUserRoles(ModelBuilder modelBuilder)
    {
        // Admin Role
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
        {
            RoleId = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
            UserId = "2dfb43f4-24d5-44a7-af3c-78196e881f23",
        });
        // User Role
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
        {
            RoleId = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
            UserId = "75fa9827-0f5f-41db-a825-64d68d242d7e",
        });
        // Guest Role
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
        {
            RoleId = "b600478d-f98b-4a27-aa95-14563920d28f",
            UserId = "df31566d-5ccb-45dc-b1be-864d72133ca4",
        });
    }

    private void SeedRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(new Role()
        {
            Id = "cc3b4c20-7ab3-4daa-b777-0018ee8c615c",
            Name = RoleEnum.Admin.ToString(),
            NormalizedName = RoleEnum.Admin.ToString().ToUpper()
        });
        modelBuilder.Entity<Role>().HasData(new Role()
        {
            Id = "dddd1a59-3b57-45f6-96b5-91b3e269e87c",
            Name = RoleEnum.User.ToString(),
            NormalizedName = RoleEnum.User.ToString().ToUpper()
        });
        modelBuilder.Entity<Role>().HasData(new Role()
        {
            Id = "b600478d-f98b-4a27-aa95-14563920d28f",
            Name = RoleEnum.Guest.ToString(),
            NormalizedName = RoleEnum.Guest.ToString().ToUpper()
        });
    }
}