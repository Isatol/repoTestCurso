using Microsoft.EntityFrameworkCore;
using repoTestCurso.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoTestCurso.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Todo>().Property(t => t.CreatedAt).HasDefaultValueSql("getdate()");
        }

        public TodoContext() {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
