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
            if (args.Length == 0 || args.Any(A => A.Contains("-help")))
            {
                BackwardCounter.Help();
            }
            else
            {
                BackwardCounter backwardCounter = null;
                switch (args.Length.ToString())
                {
                    case "2":
                        {
                            backwardCounter = new BackwardCounter(args[0], args[1]);
                        }
                        break;
                    case "1":
                        {
                            backwardCounter = new BackwardCounter(args[0]);
                        }
                        break;
                    default:
                        {
                            backwardCounter = new BackwardCounter();
                        }
                        break;
                }
                Console.WriteLine(backwardCounter.PrintBackwardCount());
                if (!backwardCounter.IsValid)
                    BackwardCounter.Help();

            }
        }
    }
}
