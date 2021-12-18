using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace PostgresqlGenerator.Models
{
    /// <inheritdoc />
    public class MetaverseDbContext : DbContext
    {
        public MetaverseDbContext(DbContextOptions<MetaverseDbContext> options) : base(options)
        {
        }

        public MetaverseDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql(
                @"Server=.;Port=5432;Database=SALEDB;User Id=postgres;Password=**********");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //public virtual DbSet<Block> Block { get; set; }

        //public virtual DbSet<Blockchain> Blockchain { get; set; }

        //public virtual DbSet<Transaction> Transaction { get; set; }
    }
}




