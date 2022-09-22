using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{


    [Serializable]
    internal class InvalidBirthYearException : Exception
    {
        public InvalidBirthYearException()
        {
        }

        public InvalidBirthYearException(string? message) : base(message)
        {
        }

        public InvalidBirthYearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidBirthYearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
  
