using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ActivityLogApi.Models
{
    
    public class Workout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long WId { get; set; }

        public string WorkoutName { get; set; } = string.Empty;// Antrenman adı

        public string Detail { get; set; } = string.Empty;// Antrenman detayı

        public int DurationMinute { get; set; }// Antrenman süresi (dakika)
        public long UserId { get; set; } // Foreign Key
        public User User { get; set; }  // Navigation Property
        public int CaloriesBurned { get; set; }// Yakılan kalori

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;// Oluşturulma tarihi
    }
}