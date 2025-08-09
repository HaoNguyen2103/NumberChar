public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap mot so");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 10 && number >= 0)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    break;

            }
        }
        else if (number < 20 && number >= 10)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("seventeen");
                    break;
                case 18:
                    Console.WriteLine("eighteen");
                    break;
                case 19:
                    Console.WriteLine("nineteen");
                    break;
                default:
                    break;
            }
        }
        else if (number >= 20 && number <= 99)
        {
            int chuc = number / 10;
            int donvi = number % 10;
            switch (chuc)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty");
                    break;
                case 4:
                    Console.Write("forty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
                default:
                    break;

            }
            switch (donvi)
            {
                case 0:
                    Console.WriteLine(" ");
                    break;
                case 1:
                    Console.WriteLine(" one");
                    break;
                case 2:
                    Console.WriteLine(" two");
                    break;
                case 3:
                    Console.WriteLine(" three");
                    break;
                case 4:
                    Console.WriteLine(" four");
                    break;
                case 5:
                    Console.WriteLine(" five");
                    break;
                case 6:
                    Console.WriteLine(" six");
                    break;
                case 7:
                    Console.WriteLine(" seven");
                    break;
                case 8:
                    Console.WriteLine(" eight");
                    break;
                case 9:
                    Console.WriteLine(" nine");
                    break;
                default:
                    break;
            }
        }
        else if (99 < number && number <= 999)
        {
            int tram = number / 100;
            int chuc = (number % 100) / 10;
            int donvi = number % 10;

            switch (tram)
            {
                case 1:
                    Console.Write("one hundred");
                    break;
                case 2:
                    Console.Write("two hundred");
                    break;
                case 3:
                    Console.Write("three hundred");
                    break;
                case 4:
                    Console.Write("four hundred");
                    break;
                case 5:
                    Console.Write("five hundred");
                    break;
                case 6:
                    Console.Write("six hundred");
                    break;
                case 7:
                    Console.Write("seven hundred");
                    break;
                case 8:
                    Console.Write("eight hundred");
                    break;
                case 9:
                    Console.Write("nine hundred");
                    break;
                default:
                    break;

            }
            if (chuc == 0 && donvi == 0)
            {
                Console.WriteLine();
            }
            else if (chuc == 0 && donvi != 0)
            {
                switch (donvi)
                {
                    case 0:
                        Console.WriteLine(" ");
                        break;
                    case 1:
                        Console.WriteLine(" one");
                        break;
                    case 2:
                        Console.WriteLine(" two");
                        break;
                    case 3:
                        Console.WriteLine(" three");
                        break;
                    case 4:
                        Console.WriteLine(" four");
                        break;
                    case 5:
                        Console.WriteLine(" five");
                        break;
                    case 6:
                        Console.WriteLine(" six");
                        break;
                    case 7:
                        Console.WriteLine(" seven");
                        break;
                    case 8:
                        Console.WriteLine(" eight");
                        break;
                    case 9:
                        Console.WriteLine(" nine");
                        break;
                }
            }
            else
            {
                switch (chuc)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                    if (donvi == 0)
                        {
                            Console.Write(" ten ");
                        }
                        else if (donvi == 1)
                        {
                            Console.Write(" eleven ");
                        }
                        else if (donvi == 2)
                        {
                            Console.Write(" twelve ");
                        }
                        else if (donvi == 3)
                        {
                            Console.Write(" thirteen ");
                        }
                        else if (donvi == 4)
                        {
                            Console.Write(" fourteen ");
                        }
                        else if (donvi == 5)
                        {
                            Console.Write(" fifteen ");
                        }
                        else if (donvi == 6)
                        {
                            Console.Write(" sixteen ");
                        }
                        else if (donvi == 7)
                        {
                            Console.Write(" seventeen ");
                        }
                        else if (donvi == 8)
                        {
                            Console.Write(" eighteen ");
                        }
                        else if (donvi == 9)
                        {
                            Console.Write(" nineteen ");
                        }

                        break;
                    case 2:
                        Console.Write(" twenty ");
                        break;
                    case 3:
                        Console.Write(" thirty ");
                        break;
                    case 4:
                        Console.Write(" forty ");
                        break;
                    case 5:
                        Console.Write(" fifty ");
                        break;
                    case 6:
                        Console.Write(" sixty ");
                        break;
                    case 7:
                        Console.Write(" seventy ");
                        break;
                    case 8:
                        Console.Write(" eighty ");
                        break;
                    case 9:
                        Console.Write(" ninety ");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}