using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagementApp
{
    class Assignment
    {
		public string AssignmentTitle { get; set; }
		public DateTime DueDate { get; set; }

		public Assignment(string assignmentTitle, DateTime dueDate)
		{
			AssignmentTitle = assignmentTitle;
			DueDate = dueDate;
		}
	}
}
