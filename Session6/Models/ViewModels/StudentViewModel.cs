using System.ComponentModel.DataAnnotations;

namespace Session6.Models.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage = "Phone Must be 11 Number")]
        [MinLength(11 ,ErrorMessage ="Phone Must be 11 Number")]
        public string PhoneNumber { get; set; }
    }
}
