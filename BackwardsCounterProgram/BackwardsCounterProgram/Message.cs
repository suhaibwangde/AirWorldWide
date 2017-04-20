using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackwardsCounterProgram
{
    public class Message
    {
        // Message Is Valid
        public bool IsValid { get; set; }
        // Validation Message
        public string Status { get; set; }

        /// <summary>
        /// Create Message
        /// </summary>
        /// <param name="isValid">Boolean message is valid</param>
        /// <param name="status">Message status</param>
        /// <returns>Message</returns>
        public static Message Create(bool isValid, string status)
        {
            return new Message() { IsValid = isValid, Status = status };
        }
    }
}
