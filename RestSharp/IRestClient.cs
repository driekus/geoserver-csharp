using System;
using System.Net;
using System.Collections.Generic;

namespace RestSharp
{
	public interface IRestClient
	{
		/// <summary>
		/// 
		/// </summary>
		CookieContainer CookieContainer { get; set; }
		/// <summary>
		/// 
		/// </summary>
		string UserAgent { get; set; }
		/// <summary>
		/// 
		/// </summary>
		int Timeout { get; set; }
		/// <summary>
		/// 
		/// </summary>
		bool UseSynchronizationContext { get; set; }
		/// <summary>
		/// 
		/// </summary>
		IAuthenticator Authenticator { get; set; }
		/// <summary>
		/// 
		/// </summary>
		string BaseUrl { get; set; }
		/// <summary>
		/// 
		/// </summary>
		IList<Parameter> DefaultParameters { get; }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback);

#if FRAMEWORK
		/// <summary>
		/// X509CertificateCollection to be sent with request
		/// </summary>
		X509CertificateCollection ClientCertificates { get; set; }
		IRestResponse Execute(IRestRequest request);
		IRestResponse<T> Execute<T>(IRestRequest request) where T : new();
		
		IWebProxy Proxy { get; set; }
#endif

		Uri BuildUri(IRestRequest request);
	}
}
