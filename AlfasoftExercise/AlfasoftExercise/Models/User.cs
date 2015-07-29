using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlfasoftExercise.Models
{
    [Table("User")]
    public class User
    {
        public User() { }

        public User(int number, String name, String password)
        {
            Number = number;
            Name = name;
            Password = password;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InternalId { get; set; }
        [Required]
        [Index(IsUnique =true)]
        public int Number { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(200)]
        public String Name { get; set; }
        [Required]
        public String Password { get; set; }
    }
}