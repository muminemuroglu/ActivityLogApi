using System.ComponentModel.DataAnnotations;

namespace ActivityLogApi.Dto.GoalDto
{
    public class GoalCreateDto
    {
        [Required]
        [StringLength(150, MinimumLength = 3)]
        public string GoalType { get; set; }

        [Required]
        [Range(0.1, double.MaxValue)]
        public double TargetValue { get; set; }

        // Mevcut değer (CurrentValue) genellikle 0 olarak başlar, bu yüzden DTO'da olmasına gerek yok.
        // Servis katmanında varsayılan olarak 0 atanabilir.

        [Required(ErrorMessage = "Başlangıç tarihi boş olamaz.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Bitiş tarihi boş olamaz.")]
        public DateTime EndDate { get; set; }
    }
}