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



        public TodoContext() {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
