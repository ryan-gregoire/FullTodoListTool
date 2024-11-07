using System;
using GetMath;

namespace GetMath {

    public class MathProblem
    {
        public static byte posX;
        public static byte posY;
        public static List<string> Operator = [];


        public static byte Nums(byte num1, byte num2)
        {

            Random r = new Random();
            return (byte)r.Next(num1, num2 + 1);
        }
    }
}

namespace Math {

    public class Maths {

        public static string Opertor() {

            Random r = new Random();

            GetMath.MathProblem.Operator.Add("+");
            GetMath.MathProblem.Operator.Add("-");
            GetMath.MathProblem.Operator.Add("*");
            GetMath.MathProblem.Operator.Add("/");

            int randomOperator = r.Next(GetMath.MathProblem.Operator.Count);

            return GetMath.MathProblem.Operator[randomOperator];

        }


        public static void GetMaths(byte num1, byte num2) {


            Console.WriteLine("Num1: " + num1);
            Console.WriteLine("Num2: " + num2);
            
            Console.ReadLine();


        }
    }
}