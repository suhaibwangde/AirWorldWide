using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwardsCounterProgram
{
    public class BackwardCounter
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        private Message Message { get; set; }
        // Message Is Valid
        public bool IsValid { get {
                return Message.IsValid;
            } }
        // Validation Message
        public string Status { get {
                return Message.Status;
            } }
        public BackwardCounter(string firstNumber = "", string secondNumber = "") {
            this.Message = ValidateInput(firstNumber, secondNumber);
        }
        private Message ValidateInput(string firstNumberString, string secondNumberString)
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

        public string PrintBackwardCount()
        {
            List<string> bacwardCount = new List<string>();
            if (IsValid)
            {
                while((FirstNumber > 1) && (FirstNumber % SecondNumber == 0))
                {
                    bacwardCount.Add(FirstNumber.ToString());
                    FirstNumber -= SecondNumber;
                }
            } else
            {
                return "Error: "+Status;
            }
            return string.Join(" ", bacwardCount);
        }

        public static void Help()
        {
            Console.WriteLine("- Execute:   >BackwardsCounterProgram.exe {First Number} {Second Number}");
            Console.WriteLine("- Example:   >BackwardsCounterProgram.exe 25 5");
            Console.WriteLine("- Help:      >BackwardsCounterProgram.exe -help");
        }
    }
}
