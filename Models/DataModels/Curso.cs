using System.ComponentModel.DataAnnotations;

namespace UniversityAPI2.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [MaxLength(560)]
        public string LongDescription { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Objetivo { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public enum Nivel{ Basico = 1,Intermedio = 2, Avanzado = 3}

    }
}
