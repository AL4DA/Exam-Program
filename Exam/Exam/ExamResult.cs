using System;
namespace Exam
{
	public class ExamResult
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int MarksEarned { get; set; }
		public string PassStatus { get; set; }
		public bool Status { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName} -- LastName: {LastName} -- Status: {PassStatus} -- Marks Earned: {MarksEarned}";
        }
    }
}