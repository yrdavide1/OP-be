using Microsoft.EntityFrameworkCore;
using OP_beModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beContext.EFContext
{
    public class OPbeContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Administrator>? Administrators { get; set; }
        public DbSet<Report>? Reports { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<Closet>? Closets { get; set; }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Person>? Persons { get; set; }

        public OPbeContext() { }
        public OPbeContext(DbContextOptions<OPbeContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server = 173.249.39.182; User Id=SA; Password=9EFD8a1744@; Database = OP");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Persons");
            modelBuilder.Entity<Administrator>().ToTable("Persons");
            modelBuilder.Entity<Report>().ToTable("Reports");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<Closet>().ToTable("Closet");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Person>().ToTable("Persons");

            modelBuilder.Entity<Person>()
                        .HasDiscriminator<string>("Discriminator")
                        .HasValue<User>("User")
                        .HasValue<Administrator>("Administrator");

            modelBuilder.Entity<Person>()
                        .Property("Discriminator")
                        .HasMaxLength(13);

            modelBuilder.Entity<User>()
                        .HasOne(u => u.Closet)
                        .WithOne(c => c.User)
                        .HasForeignKey<Closet>(x => x.UserId);
        }
    }
}
