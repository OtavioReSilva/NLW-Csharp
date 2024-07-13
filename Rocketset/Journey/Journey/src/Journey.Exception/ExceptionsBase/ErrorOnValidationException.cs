using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class ErrorOnValidationException : JourneyException
    {
        private readonly IList<string> _erros;
        public ErrorOnValidationException(IList<string> messages) : base(string.Empty)
        {
            _erros = messages;
        }

        public override IList<string> GetErrorMessages()
        {
            throw new NotImplementedException();
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }
    }
}
