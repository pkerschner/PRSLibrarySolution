using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRSLibrary.Models {
    // to allow PrsDbContext to inherit from DbContext class
    public class PrsDbContext : DbContext {
        // properties
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestLine> RequestLines { get; set; }
        // default constructor
        public PrsDbContext() { }
        // constructor
        public PrsDbContext(DbContextOptions<PrsDbContext> options) : base(options) { }
        // method uses protected access modifier to match protected access modifier in DbContext class
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if(!builder.IsConfigured) {
                builder.UseSqlServer(
                    "server=localhost\\sqlexpress;database=TestPrsDb;trusted_connection=true;"
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>(e => {
                e.HasIndex(p => p.Username).IsUnique(true);
            }); //added to make Username unique
            builder.Entity<Vendor>(e => {
                e.HasIndex(p => p.Code).IsUnique(true);
            }); //added to make Code unique
            builder.Entity<Product>(e => {
                e.HasIndex(p => p.PartNbr).IsUnique(true);
            }); //added to make PartNbr unique
        }
    }
}
