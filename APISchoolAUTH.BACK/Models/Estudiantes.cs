﻿using System.ComponentModel.DataAnnotations;

namespace APISchoolAUTH.BACK.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public DateTime? FechaMatriculacion { get; set;}

    }
}
