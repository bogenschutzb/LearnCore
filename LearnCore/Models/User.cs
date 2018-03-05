using System.ComponentModel.DataAnnotations;

namespace LearnCore.Models
{
    public class User
    {
        [Display(Name="Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "EmailAddress")]
        [StringLength(255)]
        [Required]
        public string EmailAddress { get; set; }
    }
}
