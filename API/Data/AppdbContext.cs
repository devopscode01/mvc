using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using API.Data;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{ 
public DbSet<AppUser> Users { get; set; }

}    


    
