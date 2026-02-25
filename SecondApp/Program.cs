namespace SecondApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What will this print and explain what happens?
            //=========================================================
            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);  
            //=========================================================

            //double d = 9.99; int x = (int)d; Console.WriteLine(x);
            // print 9
            // Explanation: Explicit casting (int) truncates the decimal part
            // It doesn't round, just removes everything after decimal point
            #endregion

            #region Q2: This code doesn’t compile. Fix it with the smallest change?
            //=========================================================
            //int n = 5;
            //double d2 = n / 2;
            //Console.WriteLine(d2);
            //=========================================================
            // explicit casting :-
            //int n = 5;
            //double d2 = (double)n / 2;
            //Console.WriteLine(d2);
            #endregion

            #region Q3:You read a number from user input .. Write the correct line to get age as int.
            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());

            //// Another solution

            //int age;
            //Console.WriteLine("Enter Your age:");
            //if (int.TryParse(Console.ReadLine(), out age))
            //    Console.WriteLine($"AGE : {age}");
            #endregion

        }
    }
}
