using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartContract.Exception
{

	[Serializable]
	public class RequestInvalidException : System.Exception
	{
		public RequestInvalidException() { }
		public RequestInvalidException(string message) : base(message) { }
		public RequestInvalidException(string message, System.Exception inner) : base(message, inner) { }
		protected RequestInvalidException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
