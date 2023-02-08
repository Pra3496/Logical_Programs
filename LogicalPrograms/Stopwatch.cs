using System;

using System.Diagnostics;

namespace LogicalPrograms
{
    internal class StopwatchSimulate
    {
        public void StopwatchElapsed()
        {
            Console.WriteLine("Press '1' to start the stopwatch");
            Console.WriteLine("Press '2' to stop the stopwatch");
            Char userInput = Console.ReadKey().KeyChar;

            if (userInput == '1')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Console.WriteLine("\nStopwatch started");

                userInput = Console.ReadKey().KeyChar;
                if (userInput == '2')
                {
                    stopwatch.Stop();
                    Console.WriteLine("\nStopwatch stopped");
                    Console.WriteLine("Elapsed time: " + stopwatch.Elapsed);
                }
            }
        }

    }
}
