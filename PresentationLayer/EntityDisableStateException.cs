using System;
using System.Runtime.Serialization;

namespace PresentationLayer
{
    [Serializable]
    internal class EntityDisableStateException : Exception
    {
        public EntityDisableStateException()
        {
        }

        public EntityDisableStateException(string message) : base(message)
        {
        }

        public EntityDisableStateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityDisableStateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}