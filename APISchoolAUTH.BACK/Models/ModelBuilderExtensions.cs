using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace APISchoolAUTH.BACK.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Estudiantes> categories = new List<Estudiantes>()
    {
        new Estudiantes{EstudianteId=1,Nombre="James",Apellido="Andrade",FechaMatriculacion= new DateTime(2000,11,1)},
        new Estudiantes{EstudianteId=1,Nombre="MariaJose",Apellido="Forero",FechaMatriculacion= new DateTime(2002,07,1)},
        new Estudiantes{EstudianteId=1,Nombre="Jana",Apellido="Andrade",FechaMatriculacion= new DateTime(2009,01,5)},
       
    };

            modelBuilder.Entity<Estudiantes>().HasData(categories);
        }




    }
}
