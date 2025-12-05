using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// DbContext is configured in Program.cs
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
