using System;
using System.Threading.Tasks;

namespace RandomCommands {

    class RandCommand {

        public static async Task RandonCommand(string? cmd1, string? cmd2) {

            List<string> lists = new List<string>();
            Random r = new Random();
            lists.Add(cmd1);
            lists.Add(cmd2);

            int randomCountList = lists.Count;

            int randomNum = r.Next(randomCountList);
            var o = lists[randomNum];

            Console.WriteLine("Today You Will be Working on: " + o);
            Console.ReadLine();


            await Task.Delay(2000);



        }

    }
}