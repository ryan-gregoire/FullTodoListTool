using System;
using System.Threading.Tasks;
using Title;

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

				Console.WriteLine("Please Enter Todo One: ");

				string? todoOne = Console.ReadLine();
				Title1.GetTodos(todoOne);

				Console.WriteLine("Please Enter Todo Two: ");
				string? todoTwo = Console.ReadLine();
				Title1.GetTodos(todoTwo);
			}

			Console.ReadLine();

		}
	}
}