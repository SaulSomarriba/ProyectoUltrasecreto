using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using YourLootClassLibrary.Models;

namespace YourLootClassLibrary.Context
{
    class ModelContext : DbContext
    {
        public ModelContext() : base("DefaultConnection")
        {

        }

        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Input> Entries { get; set; }
        public DbSet<InputDetail> EntryDetails { get; set; }
        public DbSet<Inventary> Inventaries { get; set; }
        public DbSet<Translation> Movements { get; set; }
        public DbSet<TranslationDetail> MovementDetails { get; set; }
        public DbSet<Output> Outputs { get; set; }
        public DbSet<OutputDetail> OutputDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
      
        }
        

    }
}

