using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
	public class Student
	{
		public int ID { get; set; } // ID = Primary Key
		public string LastName { get; set; }
		[Required]
		public string FirstName { get; set; }
		public DateTime EnrollmentDate { get; set; } 

		public virtual ICollection<Enrollment> Enrollments { get; set; } // Navigation Property
	}
}