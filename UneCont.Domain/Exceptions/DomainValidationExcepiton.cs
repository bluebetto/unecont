namespace UneCont.Domain.Exceptions
{
    public class DomainValidationException : Exception
    {
        public DomainValidationException()
            : base() { }

        public DomainValidationException(string? message)
            : base(message) { }

        public DomainValidationException(string? message, Exception? innerException)
            : base(message, innerException) { }

        public static void When(bool exceptionCondition, string message)
        {
            if (exceptionCondition)
                throw new DomainValidationException(message);
        }
    }
}
