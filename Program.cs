using System;
using System.Threading.Tasks;
using Title;
using Command;
using RandomCommands;
using Todo;
using Math;


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

				if (Command.Cmmd.commands.Equals("/Math")) {

					byte num1 = GetMath.MathProblem.Nums(1, 10);
					byte num2 = GetMath.MathProblem.Nums(2, 10);

					Maths.GetMaths(num1, num2);

			

					string op = Maths.Opertor();

					Console.WriteLine($"What is: {num1} {op} {num2}");
					Console.WriteLine();

					byte answer = byte.Parse(Console.ReadLine());

					

					if (op.Equals("+") && answer == AddMath.Add.AddNums(num1, num2))
					{
						Console.WriteLine($"Correct: {num1} + {num2} = {num1 + num2}");
						Console.ReadLine();
					}

					if (op.Equals("-") && answer == SubNum.Sub.SubNums(num1, num2)) {

						Console.WriteLine($"Correct: {num1} + {num2} = {num1 - num2}");
						Console.ReadLine();

					}


				}


				if (Command.Cmmd.commands.Equals("/Todos")) {

					_ = Command.Cmmd.listCommands(commandsOne);
					_ = Command.Cmmd.listCommands(commandTwo);

					_ = Command.Cmmd.Commands();
				}

				if (Command.Cmmd.commands.Equals("/cmd")) {
					RandCommand m;

					Console.WriteLine("Enter Todo 1: ");
					Todos.todoOne = Console.ReadLine();

					Console.WriteLine("Enter Todo 2: ");
					Todos.todoTwo = Console.ReadLine();
					Todo.Todos todos = new Todos();
					Todo.Todos.getTodosMixed();
					todos.setTodosX(Todo.Todos.todoOne);
					todos.setTodoY(Todos.todoOne);


				}
			}


			Console.ReadLine();

		}
	}
}