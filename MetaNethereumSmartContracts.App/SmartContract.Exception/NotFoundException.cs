using System.Runtime.Serialization;
namespace SmartContract.Exception
{
    [System.Serializable]
    public class NotFoundException : System.Exception
    {
        public NotFoundException() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, System.Exception inner) : base(message, inner) { }
        protected NotFoundException(
          SerializationInfo info,
          StreamingContext context) : base(info, context) { }
    }

}