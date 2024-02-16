using System;
namespace Exam
{
	public class Question_Class 
	{
		public string question { get; set; }
		public string correctanswer { get; set; }
        public string choice1 { get; set; }
        public string choice2 { get; set; }
        public string choice3 { get; set; }
        public string choice4 { get; set; }

        public override string ToString()
        {
            return $"Question: {question} \n1.{choice1}\n2.{choice2}\n3.{choice3}\n4.{choice4}"; 
        }
    }
}

