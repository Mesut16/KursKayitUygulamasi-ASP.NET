using System.ComponentModel.DataAnnotations;

namespace KursKayıt.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email is required")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage ="FirstNAme is required")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage ="LastName is required")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; } 
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }


        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}