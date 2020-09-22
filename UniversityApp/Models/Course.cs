using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)] //Lets u enter primary key rather than the db
		public int CourseID { get; set; }
		public string Title { get; set; }
		public int Credits { get; set; }

		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}