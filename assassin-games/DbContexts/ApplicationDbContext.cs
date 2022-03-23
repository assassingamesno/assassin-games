using assassingames_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Organiser> Organisers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Leadership> Leaderships { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Hunt> Hunts { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<UniversityAttendance> UniversityAttendances { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .Property(e => e.UserId)
                .HasConversion<byte[]>();
        }*/
    }
}
