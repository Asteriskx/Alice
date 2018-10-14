using System;
using System.Runtime.Serialization;

namespace Alice.Exceptions
{
	/// <summary>
	/// Alice で起きた例外を管理します。
	/// </summary>
	[Serializable()]
	public class AliceException : Exception
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		public AliceException() : base("") { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="msg"></param>
		public AliceException(string msg) : base(msg) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="inner"></param>
		public AliceException(string msg, Exception inner) : base(msg, inner) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AliceException(SerializationInfo info, StreamingContext context) { }

		#endregion Constructors
	}
}
