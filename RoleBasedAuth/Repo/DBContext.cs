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

    public DbSet<Article> Blogs { get; set; }
    public DbSet<Comment> Posts { get; set; }
    public DbSet<Comment> User { get; set; }
}
