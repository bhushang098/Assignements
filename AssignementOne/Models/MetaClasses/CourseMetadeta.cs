using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignementOne.Models
{
    public class CourseMetadeta
    {
        [StringLength(50)]
        [Display(Name ="Course")]
        public string course_name { get; set; }

        [Range(1,10)]
        [Display(Name ="Course Grade")]
        public Nullable<int> course_grade { get; set; }

        [Display(Name ="Student Name")]
        public Nullable<int> student_id { get; set; }
        
        [Display(Name ="Staff Name")]
        public Nullable<int> staff_id { get; set; }

        [Display(Name = "Student Name")]
        public virtual Staff_Details Staff_Details { get; set; }

        [Display(Name = "Staff Name")]
        public virtual Student_Detail Student_Detail { get; set; }
    }

    [MetadataType(typeof(CourseMetadeta))]
    public partial class Cours
    {

    }
}