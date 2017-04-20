using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for arguments if zero or help
            if (args.Length == 0 || args.Any(A => A.Contains("-help")))
            {
                // Show help
                Words.Help();
            }
            else
            {
                // Initialize backwardCounter
                Words words = null;
                // Check args lengh
                switch (args.Length.ToString())
                {
                    case "2":
                        {
                            // Create intance of BackwardCounter with two args
                            words = new Words(args[0], args[1]);
                        }
                        break;
                    case "1":
                        {
                            // Create intance of BackwardCounter with first args
                            words = new Words(args[0]);
                        }
                        break;
                    default:
                        {
                            // Create intance of BackwardCounter with no args
                            words = new Words();
                        }
                        break;
                }
                // Output result of counter
                // Check if words are valid
                if (words.IsValid)
                    Console.WriteLine(words.AreAnagram() ? string.Format("Yes words {0} and {1} are anagrams", words.FirstWord, words.SecondWord) : string.Format("No words {0} and {1} are not anagrams", words.FirstWord, words.SecondWord));
                
                // if result is invalid
                if (!words.IsValid)
                {
                    // Log error
                    Console.WriteLine("Error: " + words.Status);
                    // Show help
                    Words.Help();
                }

            }
        }
    }
}
