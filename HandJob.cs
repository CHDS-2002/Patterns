using System;

namespace Communication
{
	class HandJob : IJob
	{
		public void DoJob()
		{
			Console.WriteLine("Hand Job!");
		}
	}
}
