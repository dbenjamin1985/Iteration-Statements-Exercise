namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool DaTwoInts(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;

        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even Stevens!");
            }
            else
                Console.WriteLine("Oddball!");

        }
        //Write a method to check whether a given number is positive or negative
        public static void Posinegative(int b)
        {
            if (b >= 0)
            {
                Console.WriteLine("You are positively positive!");
            }
            else
                Console.WriteLine("It's not good to be negative!");

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge(int x)
        {
            if (x > 18)
            {
                Console.WriteLine("You can vote! Make it count!");
            }
            else
                Console.WriteLine("Go finish high school first then try again youngin'!");
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void RangeTen()
        {
            Console.Write("Type a number, any number within my range. Go On! Try it!!: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= -10 && x <= 10)
            {
                Console.WriteLine("Well done! You're in my range!");
            }
            else
            {
                Console.WriteLine("You're way off!");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            int x, num;
            Console.WriteLine("Enter an integer to see it's multiples from 1 to 12: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (x = 1; x <= 12; x++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, x, num * x);
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            PrintByThrees();
            Console.WriteLine(DaTwoInts(7, 4));
            EvenOdd(2);
            Posinegative(-50);
            VotingAge(16);
            RangeTen();
            MultiTable();
        }
    }
}
