namespace Task05
{
    internal class Program
    {
        //public static void SWAP(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        //    public static int SumArray( ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}

        //static void SumMul(int a, int b, out int sum , out int mul)
        //{ sum = a + b;
        //    mul = a * b;
        //}
        //static int SumCal(int x)
        // {
        //     string y= Convert.ToString(x);
        //     int sum = 0;
        //     for (int i = 0; i < y.Length; i++)
        //     {
        //         sum += Convert.ToInt32(y.Substring(i, 1));
        //     }
        //     return sum;

        // }

        //public static bool IsPrime(int num)
        //{

        //    for (int i = 2; i < num; i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false; 
        //        }
        //    }
        //    return true;
        //}
        
        //static int MinMaxArray(ref int[] array,ref int n)
        //{

        //    int[] minmax = new int[array.Length];
        //    Array.Sort(array);

        //    minmax.min = array[0];
        //    minmax.Length = array[0];
      
        //    minmax.max = array[n - 1];
        //}
        //public static float Factorial(int n)
        //{
        //    int result = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        //public static void ChangeChar(ref string text, int position, char letter)
        //{
        //    text = text.Remove(position, 1);
        //    text = text.Insert(position, letter.ToString());
        //}
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters)
            //int A = 9, B = 4;
            //Console.WriteLine(A); 
            //Console.WriteLine(B); 
            //SWAP(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //int A = 9, B = 4;
            //Console.WriteLine(A); 
            //Console.WriteLine(B); 
            //SWAP(ref A, ref B);
            //Console.WriteLine(A); 
            //Console.WriteLine(B); 

            #endregion
            #region Explain the difference between passing (Reference type parameters)
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            ////Console.WriteLine(Numbers[0]);
            //////////////
            //int[] Numbers = { 1, 2, 3 }; 
            //Console.WriteLine(SumArray(ref Numbers));
            #endregion
            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int a = 10; int b = 10; int sum;  int mul;
            //SumMul(a, b, out sum , out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            #endregion
            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int num;

            //Console.Write("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The sum of the digits of the number {0} is : {1} ", num, SumCal(num));
            #endregion
            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Input a number : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n);
            //if (IsPrime(n))
            //{
            //    Console.WriteLine(n + " is a prime number");
            //}
            //else
            //{
            //    Console.WriteLine(n + " is not a prime number");
            //}
            #endregion
            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            #endregion
            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write(Factorial(5));
            #endregion
            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
           // string word = "Manar";
           //ChangeChar(ref word, 0, 'p');
           // Console.WriteLine(word);
            #endregion
        }

    }
}
