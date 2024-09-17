using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<Article> Article { get; set; }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<User> User { get; set; }
}
