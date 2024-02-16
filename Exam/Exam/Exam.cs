using System;
namespace Exam
{
	public class Exam
	{
		List<Question_Class> question1 = new List<Question_Class>()
		{
			new Question_Class(){question = "Question About Diana: What percentage of work did Diana put in to this project?",choice1 = "75%",choice2 = "50%",choice3 = "0%", choice4 = "15%",correctanswer = "15%"},
            new Question_Class(){question = "Question About Lasha: Who is Lasha's idol?",choice1 = "Guram Sherozia",choice2 = "Anne Hathaway",choice3 = "Taylor Swift", choice4 = "Shota Darbaidze",correctanswer = "Guram Sherozia"},
            new Question_Class(){question = "Question About Diana: What is the name of Diana's dog?",choice1 = "Zuko",choice2 = "Jeka",choice3 = "Loma", choice4 = "Wolk",correctanswer = "Zuko"},
            new Question_Class(){question = "Question About Lasha: Lasha's favorite burger",choice1 = "Bigsams",choice2 = "Mcdonald",choice3 = "Burger Lions", choice4 = "Burger King",correctanswer = "Bigsams"},
            new Question_Class(){question = "Question About Diana: What is Diana's favorite sport?",choice1 = "rollers",choice2 = "Basketball",choice3 = "Power Slaps", choice4 = "",correctanswer = ""},
            new Question_Class(){question = "Question About Lasha: What is Lasha's hobby?",choice1 = "Music",choice2 = "Gym",choice3 = "Bar hub", choice4 = "sports",correctanswer = "Music"},
            new Question_Class(){question = "Question About Diana: Diana's celebrity crush",choice1 = "Brad Beat",choice2 = "Jeniffer Lawrance",choice3 = "Tom Cruise", choice4 = "Leonardo DiCaprio",correctanswer = "Jeniffer Lawranse"},
            new Question_Class(){question = "Question About Lasha: Lasha's celebrity crush",choice1 = "Anne Hathaway",choice2 = "Elizabeth Olsen",choice3 = "Ana de Armas", choice4 = "Samara Weaving",correctanswer = "Anne Hathaway"},
            new Question_Class(){question = "Question About Diana: What is Diana's favorite color?",choice1 = "Red",choice2 = "Blue",choice3 = "Purple", choice4 = "Yellow",correctanswer = "Purple"},
            new Question_Class(){question = "Question About Lasha: What is Lasha's favorite color?",choice1 = "Green",choice2 = "Brown",choice3 = "Pink", choice4 = "Purple",correctanswer = "Purple"},
            new Question_Class(){question = "Question About Diana: Which car does Diana like?",choice1 = "BMW",choice2 = "Mercedes",choice3 = "Mustang", choice4 = "Honda",correctanswer = ""},
            new Question_Class(){question = "Question About Lasha: Which car does Lasha like?",choice1 = "Silvia S15",choice2 = "Mk4",choice3 = "Nissan R34", choice4 = "Porsche",correctanswer = "Silvia S15"},
            new Question_Class(){question = "Question About Diana: What does Diana do in her free time?",choice1 = "reading",choice2 = "writing",choice3 = "walk", choice4 = "Exercise in the gym",correctanswer = "reading"},
            new Question_Class(){question = "Question About Lasha: What does Lasha do in her free time?",choice1 = "reading",choice2 = "He is practicing programming",choice3 = "to eat", choice4 = "togetherness with friends",correctanswer = "togetherness with friends"},
            new Question_Class(){question = "Question About Diana: What is Diana afraid of?",choice1 = "of dogs",choice2 = "Two-legged dogs",choice3 = "of darkness", choice4 = "height",correctanswer = "Two-legged dogs"},
        };
        List<ExamResult> examResults = new List<ExamResult>();

        public void FullExamResult(List<ExamResult> examResults)
        {
            foreach (var examResult in examResults)
            {
                Console.WriteLine(examResult);
            }
        }

        public ExamResult Result(User user,List<ExamResult> examResults)
        {
            ExamResult examResult = new ExamResult()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                MarksEarned = user.Score
            };
            if (user.Score >= 6)
            {
                examResult.Status = true;
                examResult.PassStatus = "Passed";
            }
            else
            {
                examResult.Status = false;
                examResult.PassStatus = "Failed";
            }
            examResults.Add(examResult);
            return examResult;
        }

        public void StartQuiz(User user)
        {
            Random random = new Random();
            int answer;
            int index;
            bool end = true;
            Question_Class questions;
            List<Question_Class> selectquestions = new List<Question_Class>();
            while (end)
            {
                for (int i = 0; i < 10; i++)
                {
                    index = random.Next(0, question1.Count);
                    questions = question1[index];
                    selectquestions.Add(questions);
                    Console.WriteLine($"Question: {questions}");
                    answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        if (questions.choice1 == questions.correctanswer)
                        {
                            user.Score++;
                        }
                    }
                    if (answer == 2)
                    {
                        if (questions.choice2 == questions.correctanswer)
                        {
                            user.Score++;
                        }
                    }
                    if (answer == 3)
                    {
                        if (questions.choice3 == questions.correctanswer)
                        {
                            user.Score++;
                        }
                    }
                    if (answer == 3)
                    {
                        if (questions.choice4 == questions.correctanswer)
                        {
                            user.Score++;
                        }
                    }
                }
                end = false;
                Console.WriteLine(Result(user,examResults));
            }
        }
    }
}

