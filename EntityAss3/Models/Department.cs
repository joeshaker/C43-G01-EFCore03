using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace EntityAss3.Models
{
    [Table("Departments")]
    internal class NewDepartment
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }

        [Required]
        [Column("DeptName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [ForeignKey(nameof(Manager))]
        public int ?Ins_Id { get; set; }

        public DateTime Hiring_Date { get; set; }

        [InverseProperty(nameof(NewInstructor.ManagedDepartment))]
        public virtual NewInstructor Manager { get; set; }

        [InverseProperty(nameof(NewInstructor.InsDepartment))]
        public virtual  ICollection<NewInstructor> Instructors { get; set; } = new List<NewInstructor>();
        public virtual ICollection<NewStudent> Students { get; set; } = new List<NewStudent>();
    }
}
