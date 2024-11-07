using System;
using System.Threading.Tasks;
using Title;
using Command;
using RandomCommands;

namespace Title
{
	class Title1
	{
		public static string title = "Welcome to: Todo List";
		public static string nameTitle = "By: RYAN | CLI - DEV";


		public static async Task GetMessage()
		{
			Console.WriteLine(title);
			Console.WriteLine(nameTitle);
			await Task.Delay(2000);


		}

		public static void GotMessage()
		{
			_ = GetMessage();

		}

		public static async Task GetTodos(string e)
		{
			List<string> todos = [e];

			foreach (var todo in todos)
			{

				int index = todos.LastIndexOf(todo);
				Console.WriteLine($"You Should do: {todo} Right now ");
				await Task.Delay(1000);

			}
		}
		
	}
}

public class SecondTimer 
{
	public static async Task Timer() 
	{
		Console.WriteLine("Enter Timer Minutes: ");
		int timerSet = Int32.Parse(Console.ReadLine());
		Thread.Sleep(int.Parse(timerSet.ToString()));

		Console.WriteLine($"Timer of: {timerSet} Minutes - is Done");
		Console.ReadLine();
		await Task.Delay(2000);
	}	
}



namespace Program
{

	class Program
	{
		
		public static bool isReady = false;
		public static void Main(string[] args)
		{

			Title1.GotMessage();



			Console.WriteLine("Enter Name: ");
			string? name = Console.ReadLine();


			bool isReady = name == "";
			if (isReady)
			{
				Console.WriteLine("String is Emptyy");
				Console.ReadLine();
			}

			else
			{

				Console.WriteLine("Enter Command: ");
				Command.Cmmd.commands = Console.ReadLine();
				string commandsOne = "/Todo";
				string commandTwo = "/";


				if (Command.Cmmd.commands.Equals("/Todos")) {

					Command.Cmmd.listCommands(commandsOne);
					Command.Cmmd.listCommands(commandTwo);

					Command.Cmmd.Commands();
				}

				if (Command.Cmmd.commands.Equals("/cmd")) {
					RandCommand m;
						

					Console.WriteLine("Please Enter Todo One: ");

					string? todoOne = Console.ReadLine();
					Console.WriteLine("Please Enter Todo Two: ");
					string? todoTwo = Console.ReadLine();
                    _ = RandCommand.RandonCommand(todoOne, todoTwo);
				}
			}


			Console.ReadLine();

		}
	}
}