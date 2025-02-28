using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss3.Models
{
    [Table("Course_Ins")]
    internal class NewCourse_Inst
    {
        [ForeignKey(nameof(NewCourse))]
        public  int ?Course_Id { get; set; }
        [ForeignKey(nameof(NewInstructor))]
        public int ?Ins_Id { get; set; }
        public  string ?Evaluate { get; set; }
        public virtual NewCourse NewCourse { get; set; }
        public virtual NewInstructor NewInstructor { get; set; }
    }
}
