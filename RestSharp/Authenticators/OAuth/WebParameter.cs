#if !Smartphone
using System;
using System.Diagnostics;

#endif

namespace RestSharp.Authenticators.OAuth
{
	internal class WebParameter : WebPair
	{
		public WebParameter(string name, string value) : base(name, value)
		{
		}
	}
}