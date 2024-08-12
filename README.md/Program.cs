using System;
namespace demsothanhchu;
class Program{
    static void Main (string[] args){
        int num = Int32.Parse(Console.ReadLine());
switch (num / 100)
{
    case 1:
        {
            Console.WriteLine("One hundred and ");
            break;
        }
    case 2:
        {
            Console.WriteLine("Two hundred and ");
            break;
        }
    case 3:
        {
            Console.WriteLine("Three hundred and ");
            break;
        }
    case 4:
        {
            Console.WriteLine("Four hundred and ");
            break;
        }
    case 5:
        {
            Console.WriteLine("Five hundred and ");
            break;
        }
    case 6:
        {
            Console.WriteLine("Six hundred and ");
            break;
        }
    case 7:
        {
            Console.WriteLine("Seven hundred and ");
            break;
        }
    case 8:
        {
            Console.WriteLine("Eight hundred and ");
            break;
        }
    case 9:
        {
            Console.WriteLine("Nine hundred and ");
            break;
        }
if ((num % 100) > 10 && (num % 100) < 20)
        {
            switch (num % 100)
            {
                case 11:
                    {
                        Console.WriteLine("Eleven");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Twelve");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("thirteen");
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine("Fourteen");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("Fifthteen");
                        break;
                    }
                case 16:
                    {
                        Console.WriteLine("Sixteen");
                        break;
                    }
                case 17:
                    {
                        Console.WriteLine("Seventeen");
                        break;
                    }
                case 18:
                    {
                        Console.WriteLine("Eightteen");
                        break;
                    }
                case 19:
                    {
                        Console.WriteLine("Nineteen");
                        break;
                    }
            }
        }
else {
    switch ((num & 100) / 10)
            {
                case 2:
                    {
                        Console.WriteLine("Twenty");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Thirty");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Fourty");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Fifthty");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sixty");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Seventy");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Eightty");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Ninety");
                        break;
                    }
            }
            switch ((num % 100) % 10)
            {
                case 1:
                    {
                        Console.WriteLine("One");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Two");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Three");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Four");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Five");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Six");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Seven");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Eight");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Nine");
                        break;
                    }
           
            }

        }
    }
}
}
    

