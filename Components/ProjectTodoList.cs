using System;

namespace ProjectExample {

    class ProjectTodoList {
        public static string titleApplication = "Web Applicatrion Project Todo Listed";


        public static string? FrameWork;
        public static string? cssLibrary;
        public static string? programmingLanguage;

        public static string? testingLibrary;

        public static async Task SetFramework(string? framework) {

            FrameWork = framework;
            await Task.Delay(3000);

            Console.WriteLine($"You Have Decided to Use Picked: {framework} for a Web Application");
            Console.ReadLine();
        }


        public static async Task SetCSSLibrary(string? cssLLibrary) {

            cssLibrary = cssLLibrary;
            await Task.Delay(3000);
            Console.WriteLine($"You Have Decided to Use Picked: {cssLLibrary} CSS Librar for a Web Application");

            Console.ReadLine();
        }

        public static async Task SetProgrammingLanguage(string? lang) {

            programmingLanguage = lang;
            await Task.Delay(3000);
            Console.WriteLine($"You Have Decided to Use Picked: {lang} Language for a Web Application");

            Console.ReadLine();
        }

        public static async Task SetTestingLanguage(string? lang) {

            testingLibrary = lang;
            await Task.Delay(3000);
            Console.WriteLine($"You Have Decided to Use Picked: {lang} Testing Language for a Web Application");

            Console.ReadLine();
        }


        

    }
}