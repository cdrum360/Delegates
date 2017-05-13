using System;

namespace Delegates
{
    class Program
    {
        delegate void MyDel(int value);     // Declare delegate TYPE.

        static void Main(string[] args)
        {
           Program program = new Program();
            
            MyDel myDel;      // Declare delegate variable.
            
            Random rand = new Random();
            int randomValue = rand.Next(99);

            // Create a delegate object that contains either PrintLow or PrintHigh, and 
            // assign the object to the delegate variable.
            myDel = randomValue < 50
                        ? new MyDel(program.PrintLow)
                        : new MyDel(program.PrintHigh);

            myDel(randomValue);       // Execute the delegate.

        }

        void PrintLow(int value)
        {
            Console.WriteLine("{0} - Low Value", value);
            Console.Read();
        }

        void PrintHigh(int value)
        {
            Console.WriteLine("{0} - High Value", value);
            Console.Read();

        }

    }
}
