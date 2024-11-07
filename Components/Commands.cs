using System;

namespace Command 
{
	
	class Cmmd 
	{
		public static string? commands;		

		public static async Task listCommands(string a) {

			foreach(var e in a) {

				Console.WriteLine(e);
				Console.ReadLine();
				await Task.Delay(2000);

			}
		}
		public static async Task Commands() 
		{
			await Task.Delay(1000);
		}
	
	}
	
	
}