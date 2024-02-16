namespace Exam;

class Program
{
    static void Main(string[] args)
    {
        int manage = 0;
        User user = new User();
        List<User> users = new List<User>();
        Exam examResult = new Exam();
        List<ExamResult> exams = new List<ExamResult>();
        while (manage != 4)
        {
            try
            {
                Console.WriteLine("How well do you know Lasha and Diana?\n1.Registration\n2.Join Quiz\n3.Results\n4.exit");
                manage = int.Parse(Console.ReadLine());

                if (manage > 5)
                    throw new Exception("value should not be more than 3");
                if (manage == 1)
                {
                    user.Registration(users);
                }
                if (manage == 2)
                {
                    user.Login(users);
                }
                if(manage == 3)
                {
                    examResult.FullExamResult(exams);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

