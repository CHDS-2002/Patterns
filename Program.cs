using System;
using System.Diagnostics;

namespace Communication
{
	class Program
	{
		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.White;

			Human human1 = new Human("Daniil", "Golubtsov", "Vladislavovich", 19);
			Human human2 = new Human("John", "Beng", "Nikovskiy", 24);

			Stopwatch WorkTime = new Stopwatch();

			WorkTime.Start(); 

			human1.Say("Hello!");
			human2.Say("Hello!");
			human1.Say("How are you?");
			human2.Say("Very good!");
			human1.Work(new HandJob());
			human2.Work(new FootJob());

			WorkTime.Stop();

			Console.WriteLine($"Work time: {WorkTime.ElapsedMilliseconds} milliseconds;");

			Console.ReadKey();
			Console.Clear();
		}
	}
}