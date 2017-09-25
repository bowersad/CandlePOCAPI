using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandlePOCAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CandlePOCAPI
{
    public class CandlePOCContext : DbContext
    {
        public static string ConnectionString { get; set; }

        public CandlePOCContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<ScentEntity> Scents { get; set; }
    }
}
