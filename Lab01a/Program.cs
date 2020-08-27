using System;

namespace Lab01a
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
            Console.WriteLine("Complete! Good job.");
        }

        static void StartSequence()
        {
            // Determine the length of the array
            Console.WriteLine("Enter a number more than zero.");

            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(string);
            int[] array = new int[inputNum];
            Populate(array);
            int sum = GetSum(array);
            int product = GetProduct(array, sum, inputNum);
            decimal quotient = GetQuotient(product);
            Console.WriteLine($"This is your array length: {inputNum}");
            Console.Write("Your array contains these numbers:");
            Console.Write(String.Join(",", array));
            Console.WriteLine($"Added up, your array total is: {sum}");
            int index = product / sum;
            Console.WriteLine($"{sum} * {index} = {product}");
            decimal divisor = product / quotient;
            Console.WriteLine($"{product} / {divisor} = {quotient}");
        }

        // The for loop iterates over the full length of the array, then the game asks the user for a number between 1, 10.
        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Use a number between 1 and 10.");
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);
                array[i] = inputNum;
            }
            return array;
        }

        //this method/function adds the ints in the array, if the sum is below 20, it returns an exception.
        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            if (sum < 20)
            {
                Console.WriteLine($"Oops, the array total amount of {sum} is below the minimum");
            }
            return sum;
        }
        // next the game asks the user for an int and does some algebra and addition and returns the total. 
        static int GetProduct(int[] array, int sum, int x)
        {
            Console.WriteLine($"Choose a number, between 1 and {x - 1}.");
            int product = 0;
        prompt:
            try
            {
                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);
                product = array[inputNum] * sum;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Nope, do over!");
                goto prompt;
            }
            return product;
        }


        //now the game takes the sum from above and asks the user for a number to divide the product by. 
        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Choose a number to divide {product} by.");
            string input = Console.ReadLine();
            decimal inputNum = Convert.ToDecimal(input);
            decimal decimalProduct = Convert.ToDecimal(product);
            decimal quotient;
            try
            {
                quotient = decimal.Divide(decimalProduct, inputNum);
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            return quotient;
        }
    }
}
