using System;
namespace Exam
{
	public class User : Exam
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Score { get; set; }

        public override string ToString()
        {
            return $"INFO: FirstName: {FirstName} -- LastName: {LastName}";
        }
        public void Registration(List<User> users)
		{
			User user = null;
			string firstname;
			string lastname;
			while (user == null)
			{
                try
                {
					Console.WriteLine("How well do you know Lasha and Diana?/Registration");
					Console.Write("Enter FirstName: ");
					firstname = Console.ReadLine();
					Console.Write("Enter LastName: ");
					lastname = Console.ReadLine();

					if (user == null)
					{
						user = new User()
						{
							FirstName = firstname,
							LastName = lastname,
						};
						users.Add(user);
						Console.WriteLine(user);
					}
					else
						throw new Exception("Something Wrong!");
                }
                catch (Exception ex)
                {
					Console.WriteLine(ex.Message);
                }
            }
		}
		public void Login(List<User> users)
		{
			User user1 = new User();
			string firstname;
			string lastname;
			bool auth = false;
			while (auth == false)
			{
				try
				{
					Console.Write("Enter FirstName: ");
					firstname = Console.ReadLine();
					Console.Write("Enter LastName: ");
					lastname = Console.ReadLine();

					foreach (var user in users)
					{
						if (user.FirstName.ToLower() == firstname.ToLower() && user.LastName.ToLower() == lastname.ToLower())
						{
							auth = true;
							user1.StartQuiz(user);
                        }
						else
							throw new Exception("Something Wrong!");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}
}

