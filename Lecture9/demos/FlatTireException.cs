using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionsOverview
{
    [Serializable]
    public class FlatTireException : Exception
    {
        public FlatTireException() { }
        public FlatTireException(string message) : base(message) { }
        public FlatTireException(string message, Exception inner) : base(message, inner) { }
        protected FlatTireException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
