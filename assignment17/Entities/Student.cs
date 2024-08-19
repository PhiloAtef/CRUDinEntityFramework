using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment17.Entities
{
    [Table("Students", Schema = "dbo")]
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int St_Id { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        [StringLength(50,MinimumLength = 10)]
        public string FName { get; set; }

        public string LName { get; set; }
        
        public string Address { get; set; }

        [Range(20,60)]
        public int Age { get; set; }

        [PasswordPropertyText]
        [NotMapped]
        public string Password { get; set; }

        public int Dep_Id { get; set; }
        public Department Department { get; set; }
    }
}
