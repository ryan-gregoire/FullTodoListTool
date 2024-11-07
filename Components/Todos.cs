using System;

namespace Todo {

    public class Todos {
        public static string? todoOne;
        public static string? todoTwo;
        

        public async static Task getTodosMixed() {
            Console.WriteLine(todoOne + " " + todoTwo);
            Console.ReadLine();
            await Task.Delay(2000);
        }

        public void setTodosX(string? todoX) {
            todoOne = todoX;
            Console.WriteLine("Todo 1: " + todoX);
            Console.ReadLine();
        }

        public void setTodoY(string? todoY) {
            todoTwo = todoY;
            Console.WriteLine("Todo 2: " + todoY);
            Console.ReadLine();

        }



    }
}