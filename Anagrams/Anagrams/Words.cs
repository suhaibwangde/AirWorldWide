using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    /// <summary>
    /// Words
    /// </summary>
    public class Words
    {
        /// <summary>
        /// First Word
        /// </summary>
        public string FirstWord { get; set; }

        /// <summary>
        /// Second Word
        /// </summary>
        public string SecondWord { get; set; }

        /// <summary>
        /// Is Valid
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Contruct words
        /// </summary>
        /// <param name="firstWord">First word</param>
        /// <param name="secondWord">Second Word</param>
        public Words(string firstWord = "", string secondWord = "")
        {
            // Check id first word is empty
            if (string.IsNullOrEmpty(firstWord.Trim()))
            {
                // Update is valid
                IsValid = false;
                // Update status
                Status = "First Word should not be empty or space";
            }
            // Check if second word is empty
            else if (string.IsNullOrEmpty(secondWord.Trim()))
            {
                // Update is valid
                IsValid = false;
                // Update status
                Status = "Second Word should not be empty or space";
            }
            else
            {
                // Assign the first word with all lower
                FirstWord = firstWord.ToLowerInvariant();
                // Assign the second word with all lower
                SecondWord = secondWord.ToLowerInvariant();
                // Update is valid
                IsValid = true;
                // Update status
                Status = "Words are valid";
            }
        }

        /// <summary>
        /// Check if words are anagram
        /// </summary>
        /// <returns></returns>
        public bool AreAnagram()
        {
            if (IsValid)
            {
                // Sort first word 
                // Sort second word 
                // Apply sequence equal
                // return result
                return FirstWord.ToArray().OrderBy(A => A).SequenceEqual(SecondWord.ToArray().OrderBy(B => B));
            } else
            {
                return false;
            }
        }

        // Show Help to user
        public static void Help()
        {
            // Valid input
            Console.WriteLine("- Execute:   >Anagrams.exe {First Word} {Second Word}");
            // Example of valid input
            Console.WriteLine("- Example:   >Anagrams.exe eat ate");
            // Help option
            Console.WriteLine("- Help:      >Anagrams.exe -help");
        }

    }
}
