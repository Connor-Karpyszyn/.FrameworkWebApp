using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityApp.Models
{
	public enum Grade
	{
		A, B, C, D, F
	}
	public class Enrollment
	{
		public int EnrollmentID	{ get; set; }
		public int CourseID { get; set; }
		public int StudentID { get; set; }
		public Grade? Grade { get; set; } // ? shows value can be null, meaning student not graded yet

		public virtual Course Course { get; set; } // References the model then needs obj name
		public virtual Student Student { get; set; }
	}
}