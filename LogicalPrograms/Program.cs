namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opt = 'Y';
            while ((opt == 'y') || (opt == 'Y'))
            {
                    Console.Clear();
                    Console.Write("\n********************************************************\n");
                    Console.Write("WEL-COME TO LOGICAL PROGRAM APPLICATION\n");
                    Console.Write("********************************************************\n");
                    //Taking user input
                    Console.Write("\t-------------------\n");
                    Console.Write("\tOPTIONS\n");
                    Console.Write("\t-------------------\n");
                    Console.WriteLine("\t1:Fibonacci Series\n\t2:Perfect Number\n\t3:Reverse Number\n\t4:Reverse Number\n\t5:Coupon Number\n\t6:StopWatch");
                    Console.Write("\n_______________________________________\n");
                    Console.Write("Your choice : ");
                    short option = Convert.ToInt16(Console.ReadLine());
                    Console.Write("_______________________________________\n");
                    int number, output = 0;
                    //Switch case to call different method 
                    switch (option)
                    {
                        case 1:
                            Console.Write("=========================================\n");
                            Console.Write("\tFibonacci Series Application\n");
                            Console.Write("=========================================\n");
                            Console.WriteLine("Please enter number");
                            int count = Convert.ToInt32(Console.ReadLine());
                            FibonacciSeries fibonacciSeries = new FibonacciSeries();
                            fibonacciSeries.Fibonacci(count);
                            Console.Write("\n==================END====================\n");
                            Console.Write("Enter any key to Exit.......");
                            Console.ReadKey();
                            Console.Write("\n\n\tDo you want to Continue With Application(Y/N) : ");
                            opt = Console.ReadKey().KeyChar;
                            break;
                        case 2:
                            Console.Write("=========================================\n");
                            Console.Write("\tPerfect Number Application\n");
                            Console.Write("=========================================\n");
                            PerfectNumber perfect = new PerfectNumber();
                            Console.Write("enter the Number : ");
                            number = Convert.ToInt32(Console.ReadLine());
                            perfect.PerfectNo(number);
                            Console.Write("\n==================END====================\n");
                            Console.Write("Enter any key to Exit.......");
                            Console.ReadKey();
                            Console.Write("\n\n\tDo you want to Continue With Application(Y/N) : ");
                            opt = Console.ReadKey().KeyChar;
                            break;
                        case 3:
                            Console.Write("=========================================\n");
                            Console.Write("\tPrime Number Application\n");
                            Console.Write("=========================================\n");
                            PrimeNumber prime = new PrimeNumber();
                            Console.Write("Please enter input number : ");
                            number = Convert.ToInt32(Console.ReadLine());
                            prime.PrimeNumbers(number);
                            Console.Write("\n==================END====================\n");
                            Console.Write("Enter any key to Exit.......");
                            Console.ReadKey();
                            Console.Write("\n\n\tDo you want to Continue With Application(Y/N) : ");
                            opt = Console.ReadKey().KeyChar;
                            break;
                        case 4:
                            Console.Write("=========================================\n");
                            Console.Write("\tReverse Number Application\n");
                            Console.Write("=========================================\n");
                            ReverseNumber rev = new ReverseNumber();
                            Console.Write("Please enter input number : ");
                            number = Convert.ToInt32(Console.ReadLine());
                            output = rev.ReverseNum(number);
                            Console.WriteLine("Reverse of Entered Number is : " + output);
                            Console.Write("\n==================END====================\n");
                            Console.Write("Enter any key to Exit.......");
                            Console.ReadKey();
                            Console.Write("\n\n\tDo you want to Continue With Application(Y/N) : ");
                            opt = Console.ReadKey().KeyChar;
                            break;
                        case 5:
                            Console.Write("=========================================\n");
                            Console.Write("\tCoupon Number Application\n");
                            Console.Write("=========================================\n");
                            CouponNumber coupon = new CouponNumber();
                            Console.Write("Enter the number of distinct coupons: ");
                            number = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Total random numbers needed: " + coupon.CollectCoupons(number));
                            Console.Write("\n==================END====================\n");
                            Console.Write("Enter any key to Exit.......");
                            Console.ReadKey();
                            Console.Write("\n\n\tDo you want to Continue With Application(Y/N) : ");
                            opt = Console.ReadKey().KeyChar;
                            break;

                        default:
                                Console.WriteLine("Please enter right option");
                                Console.Write("Enter any key to Exit.......");
                                Console.ReadKey();
                                break;
                    }
               
            }
                Console.Clear();
                Console.Write("\n\n\tThank You For Using Application.......");
                Console.ReadKey();
          }
    }
}