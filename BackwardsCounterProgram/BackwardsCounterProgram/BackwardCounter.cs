using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwardsCounterProgram
{
	/// <summary>
	/// Backward counter 
	/// </summary>
    public class BackwardCounter
    {
		/// <summary>
		/// First Number
		/// </summary>
        public int FirstNumber { get; set; }

		/// <summary>
		/// Second Number
		/// </summary>
        public int SecondNumber { get; set; }

		/// <summary>
		/// Message
		/// </summary>
        private Message Message { get; set; }

        // Message Is Valid
        public bool IsValid { get {
                return Message.IsValid;
            } }

        // Validation Message
        public string Status { get {
                return Message.Status;
            } }

		/// <summary>
		/// Construct BackwardCounter
		/// </summary>
		/// <param name="firstNumber">First Number as string</param>
		/// <param name="secondNumber">Secon Number as string</param>
        public BackwardCounter(string firstNumber = "", string secondNumber = "") {
			// Validate Numbers
            this.Message = ValidateNumbers(firstNumber, secondNumber);
        }

		/// <summary>
		/// Validate input string
		/// </summary>
		/// <param name="firstNumberString">Frist Number</param>
		/// <param name="secondNumberString">Second Number</param>
		/// <returns>Message is valid and its status</returns>
        private Message ValidateNumbers(string firstNumberString, string secondNumberString)
        {
            int firstNumber, secondNumber;
            if (string.IsNullOrEmpty(firstNumberString.Trim()) || string.IsNullOrEmpty(secondNumberString.Trim()))
                return Message.Create(false, "Either of the Numbers cannot be empty");
            //- Either number is not an integer 
            if (!int.TryParse(firstNumberString, out firstNumber) || !int.TryParse(secondNumberString, out secondNumber))
                return Message.Create(false, "Numbers has to be integer");
            //- Either number is negative 
            if (firstNumber < 0 || secondNumber < 0)
                return Message.Create(false, "Numbers must be non negative");
            //- First number < 2 
            if (firstNumber < 2)
                return Message.Create(false, "First Number must be greater than 2");
            //- First number must be < 1000  
            if (firstNumber > 1000)
                return Message.Create(false, "First Number must be less than 1000");
            //- Second number = 0
            if (secondNumber == 0)
                return Message.Create(false, "Second Number must be greater than zero");
            //- Second number > first number
            if (secondNumber > firstNumber)
                return Message.Create(false, "Second Number must be less than First Number");
            // -First number not evenly divisible by second number
            if (firstNumber % secondNumber != 0)
                return Message.Create(false, "First Number not evenly divisible by Second Number");
            // Assign valid first number
            FirstNumber = firstNumber;
            // Assign valid second number
            SecondNumber = secondNumber;
            // Return valid message
            return Message.Create(true, "Numbers are valid");
        }

		/// <summary>
		/// Run backward counter on valid arguments
		/// </summary>
		/// <returns>Counter result if valid else return error</returns>
        public string PrintBackwardCount()
        {
			// List of backwardCount
            List<string> bakcwardCount = new List<string>();
			// Check if valid
            if (IsValid)
            {
				// First number is greater than 1 and First number is divisible by Second Number
                while((FirstNumber > 1) && (FirstNumber % SecondNumber == 0))
                {
					// Add First number to list
                    bakcwardCount.Add(FirstNumber.ToString());
					// Deduct FirstNumber By SecondNumber
                    FirstNumber -= SecondNumber;
                }
            } else {
				// Return Error
                return "Error: "+Status;
            }
			// Join the list by space
            return string.Join(" ", bakcwardCount);
        }

		// Show Help to user
        public static void Help()
        {
			// Valid input
            Console.WriteLine("- Execute:   >BackwardsCounterProgram.exe {First Number} {Second Number}");
			// Example of valid input
            Console.WriteLine("- Example:   >BackwardsCounterProgram.exe 25 5");
			// Help option
            Console.WriteLine("- Help:      >BackwardsCounterProgram.exe -help");
        }
    }
}
