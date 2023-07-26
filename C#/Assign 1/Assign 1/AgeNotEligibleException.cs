using System.Runtime.Serialization;

namespace Assign_1
{
    [Serializable]
    internal class AgeNotEligibleException : Exception
    {
        public AgeNotEligibleException()
        {
        }

        public AgeNotEligibleException(string? message) : base(message)
        {
        }

        public AgeNotEligibleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AgeNotEligibleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}