using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwardsCounterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
			// Check for arguments if zero or help
            if (args.Length == 0 || args.Any(A => A.Contains("-help")))
            {
				// Show help
                BackwardCounter.Help();
            }
            else
            {
				// Initialize backwardCounter
                BackwardCounter backwardCounter = null;
				// Check args lengh
                switch (args.Length.ToString())
                {
                    case "2":
                        {
							// Create intance of BackwardCounter with two args
                            backwardCounter = new BackwardCounter(args[0], args[1]);
                        }
                        break;
                    case "1":
                        {
							// Create intance of BackwardCounter with first args
                            backwardCounter = new BackwardCounter(args[0]);
                        }
                        break;
                    default:
                        {
							// Create intance of BackwardCounter with no args
                            backwardCounter = new BackwardCounter();
                        }
                        break;
                }
				// Output result of counter
                Console.WriteLine(backwardCounter.PrintBackwardCount());
				// if result is invalid
                if (!backwardCounter.IsValid)
					// Show help
                    BackwardCounter.Help();

            }
        }
    }
}
