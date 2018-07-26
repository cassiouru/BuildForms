using BuildForms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildForms.Repository
{
    public class BuildFormDbContext : DbContext
    {
        public BuildFormDbContext()
        {
        }

        public BuildFormDbContext(DbContextOptions<BuildFormDbContext> options)
        : base(options)
        {
        }

        public DbSet<Form> Form { get; set; }

        public DbSet<FormAnswer> FormAnswer { get; set; }

        public DbSet<FormItemAnswer> FormItemAnswer { get; set; }
    }
}
