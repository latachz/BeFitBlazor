using BeFitBlazor.Models;
using System.ComponentModel.DataAnnotations;

namespace BeFitBlazor.DTOs
{
    public class ExerciseTypeDTO
    {
        public int Id { get; set; }
        
        [Display(Name = "Nazwa ćwiczenia")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Opis")]
        public string? Description { get; set; }

        public ExerciseTypeDTO() { }
        
        public ExerciseTypeDTO(ExerciseType exerciseType)
        {
            Id = exerciseType.Id;
            Name = exerciseType.Name;
            Description = exerciseType.Description;
        }
    }
}

