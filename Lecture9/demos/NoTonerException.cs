using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionsOverview
{
    [Serializable]
    public class NoTonerException : Exception
    {
        public NoTonerException() {
        }
        public NoTonerException(string message) : base(message) {

        }
        public NoTonerException(string message, Exception inner) : base(message, inner) {
        }
        protected NoTonerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
