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

            #region Q4: What happens here and why?
            //=========================================================
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            //=========================================================
            //Throw formating exception
            // string s contain letter can't br convert to int
            #endregion

            #region Q5: Complete the code from the previous question so it prints Invalid if conversion into int fails, otherwise prints the number

            //string s = "12a";
            //if (int.TryParse(s,out int result ))
            //{
            //    Console.WriteLine($"Number:{result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Formating");
            //}
            #endregion

            #region Q6: What will this print and explain why ?
            //=========================================================
            //object o = 10;
            //int a = (int)o; //UnBoxing , convert object back to int 
            //Console.WriteLine(a + 1);  // print 11
            //=========================================================

            // Boxing stored int in object . Un boxing retrives it
            #endregion

        }
    }
}
