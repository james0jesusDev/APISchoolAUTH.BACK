using APISchoolAUTH.BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace APISchoolAUTH.BACK.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {




        }


        public DbSet<Estudiantes> Estudiantes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }



    }
}
