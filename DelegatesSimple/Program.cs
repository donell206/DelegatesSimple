using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSimple
{
    //public delegate void AddDelegate(int a, int b);
    //public delegate string GreetingsDelegate(string str);

   

    class Program
    {
       

        static void Main(string[] args)
        {


            //  Program p = new Program();
            Action<int, int> addDelegate = AddNumbers;
            addDelegate(3, 2);





            //AddDelegate AddDelegate = new AddDelegate(AddNumbers);
            //AddDelegate(3, 2);
            //AddDelegate(6, 7);

            //AddDelegate subtract = new AddDelegate(Subtract);
            //subtract(7, 2);
            //subtract(6, 1);

            Action<int, int> subtract = Subtract;
            subtract(8, 2);


            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
            //string result = greetingsDelegate("Hello c# group");
            //Console.WriteLine(result);


            Func<string, string> sayHello = Sayhello;
            string sayhelloresult = sayHello("Hello james");
            Console.WriteLine(sayhelloresult);

            Func<string, string> greetingsDelegate = Greetings;
            string result = greetingsDelegate("Hello james");

            //string HELLO = Sayhello("Say Hello as I want to learn JAVA");
            //Console.WriteLine(HELLO);

            //  Program p = new Program();
            //p.AddNumbers(2, 3);
        }
        public static void AddNumbers(int a,int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is : {a+b}");

        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"The substract of {a} and {b} is : {a-b}");

        }

        public static string Greetings(string str)
        {
            return str;
        }
        public static string Sayhello(string str)
        {
            return str;
        }
    }
}
