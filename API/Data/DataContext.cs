using System;
using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions Options): DbContext(Options)
{
    public DbSet<AppUser> Users {get;set;}
}
