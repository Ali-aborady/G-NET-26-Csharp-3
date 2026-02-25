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

            #region Q7: What will this print and explain why and if there is a problem handle it ?
            //=========================================================
            //object o = 10;
            //long x = (long)o;  // throw invalidCastingException
            //Console.WriteLine(x);
            //=========================================================
            //object o2 = 10;
            //// unbox first to int  "convert  to exact orginal type first" , then implicit to long
            //long x2 = (int)o2;
            //Console.WriteLine(x2);
            #endregion

            #region Q8: Fix this to avoid exceptions and print -1 if conversion isn’t possible ?
            //=========================================================
            //object o = 10;
            //long x = o;
            //Console.WriteLine(x);
            //=========================================================

            //object obj = "10a";
            //long x1 = 0;
            //if(obj is int || obj is long)
            //{
            //   x1 = Convert.ToInt32(obj);
            //}
            //else 
            //{
            //    x1 = -1;
            //}
            //Console.WriteLine(x1);

            ////Another solution 

            //object o = 10;
            //long x = -1;    //default value of exception

            //if (o is int || o is long || o is short || o is byte || o is uint || o is ulong || o is ushort || o is sbyte)
            //{
            //    x = Convert.ToInt32(o);
            //}

            //Console.WriteLine(x);

            #endregion

            #region Q9: What will this print and explain why ?
            //=========================================================
            //string? name = null;
            //Console.WriteLine(name?.Length);
            //=========================================================
            // ? is null-conditional operator
            // If name is null, it returns null instead of throwing exception
            // Console.WriteLine receives null, which prints nothing
            #endregion

            #region Q10: What will this print and explain the process?
            //=========================================================
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //=========================================================

            // name2 ?.Length returns null (since name2 is null)
            // ?? is null-coalescing operator - returns right side if left is null
            // So length gets 0
            #endregion

            #region Q11: What’s wrong with this “safe” code and how can we solve it ?
            //=========================================================
            //string? s = null;
            //int x = int.Parse(s ?? "0");
            //Console.WriteLine(x);   // print 0
            //=========================================================

            // s ?? "0" returns "0" when s is null
            // int.Parse("0") returns 0
            #endregion

            #region Q12: What happens here and if there is a problem, handle it
            //=========================================================
            //string? s = null;
            //Console.WriteLine(s!.Length);    ! suppresses warning, but will crash"NullReferenceException"
            //=========================================================

            //string? s = null;
            //Console.WriteLine(s?.Length??0);
            #endregion

            #region Q13: What will this print?
            //=========================================================
            string? s = null;
            int x = Convert.ToInt32(s);  // Returns 0, doesn't throw exception
            Console.WriteLine(x);        //print 0
            //=========================================================

            // Convert.ToInt32(null) returns 0 for null strings  Unlike int.Parse() which throws exception

            #endregion


        }
    }
}
