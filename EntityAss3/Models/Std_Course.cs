using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss3.Models
{
    [Table("Std_Courses")]
    internal class NewStd_Course
    {
        [ForeignKey(nameof(Student))]
        public  int ?Std_Id { get; set; }
        [ForeignKey(nameof(Course))]
        public int ?Course_Id { get; set; }
        public  int  Grade { get; set; }
        public virtual NewStudent? Student { get; set; }
        public virtual NewCourse? Course { get; set; }
    }
}
