using System.ComponentModel.DataAnnotations;

namespace LearnCore.CommonLibrary.Models
{
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// User Email Address
        /// </summary>
        [StringLength(255)]
        [Required]
        public string EmailAddress { get; set; }
    }
}
