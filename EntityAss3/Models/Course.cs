using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss3.Models
{
    [Table("Courses")]
    internal class NewCourse
    {
        [Key]
        public  int Crs_Id { get; set; }
        public  int Duration { get; set; }
        [Required]
        [Column("CourseName",TypeName ="varchar")]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        public string ?Description { get; set; }
        //[Required]
        [ForeignKey(nameof(CrsTopic))]
        public  int ?Top_Id { get; set; }
        public virtual NewTopic ?CrsTopic { get; set; }
        public virtual ICollection<NewCourse_Inst> NewCourse_Insts { get; set; } = new List<NewCourse_Inst>();
        public virtual ICollection<NewStd_Course> Std_Courses { get; set; } = new List<NewStd_Course>();

    }
}
