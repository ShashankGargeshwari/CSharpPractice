using System;
namespace PracticeProject
{
	public class Enumeration
	{
		enum Marks
		{
			Abyssmal = 0,
			Useless = 25,
			JustPass = 40,
			MidPack = 60,
			SomeWhatOK = 75,
			BelowExpectation = 90,
			CanDoBetter = 98,
			Ideal = 102,
		}
		static void iMain()
		{
			Console.WriteLine("Why have you got {0}??? Look at your cousin, She got {1} and still she is crying!" , (int)Marks.SomeWhatOK , (int)Marks.CanDoBetter);
		}
		public Enumeration()
		{
		}
	}
}
