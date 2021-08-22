using System;

namespace Communication
{
	class Human
	{
		public string Name
		{
			get; private set;
		}
		public string SurName
		{
			get; private set;
		}
		public string LastName
		{
			get; private set;
		}
		public int Age
		{
			get; private set;
		}
		
		public Human(string Name, string SurName, string LastName, int Age)
		{
			this.Name = Name;
			this.SurName = SurName;
			this.LastName = LastName;
			this.Age = Age;
		}

		public void Say(string message)
		{
			Console.WriteLine(message);
		}

		public void Work(IJob job)
		{
			job.DoJob();
		}
	}
}
