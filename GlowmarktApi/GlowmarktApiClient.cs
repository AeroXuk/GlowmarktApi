using Glowmarkt.Api;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Glowmarkt
{
	public partial class GlowmarktApiClient
	{
		private const string baseUrl = @"https://api.glowmarkt.com/api/v0-1/";
		private string _applicationId = @"b0f1b774-a586-4f72-9edd-27ead8aa7a8d";
		private JwtSecurityToken _token;
		private HttpClient _httpClient;

		public string ApplicationId
		{
			get => _applicationId;
			set
			{
				_applicationId = value;
				if (_applicationId != null)
				{
					_httpClient.DefaultRequestHeaders.Add("applicationId", _applicationId);
				}
			}
		}

		public JwtSecurityToken Token
		{
			get => _token;
			set
			{
				_token = value;
				if (_httpClient != null)
				{
					_httpClient.DefaultRequestHeaders.Add("token", _token.RawData);
				}
			}
		}

		internal HttpClient HttpClient
		{
			get
			{
				if (_httpClient == null)
				{
					_httpClient = new HttpClient()
					{
						BaseAddress = new Uri(baseUrl)
					};

					_httpClient.DefaultRequestHeaders.Accept.Clear();
					_httpClient.DefaultRequestHeaders.Accept.Add(
						new MediaTypeWithQualityHeaderValue("application/json")
						);
					_httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue() { NoCache = true };
					_httpClient.DefaultRequestHeaders.Connection.Add("keep-alive");
					_httpClient.DefaultRequestHeaders.UserAgent.Clear();
					_httpClient.DefaultRequestHeaders.UserAgent.Add(
						new ProductInfoHeaderValue("GlowmarktApi.Net", "0.1")
						);
					_httpClient.DefaultRequestHeaders.Add("applicationId", _applicationId);

					if (_token != null)
					{
						_httpClient.DefaultRequestHeaders.Add("token", _token.RawData);
					}
				}
				return _httpClient;
			}
		}

		public ResourceSystem ResourceSystem { get; }

		public UserSystem UserSystem { get; }

		public GlowmarktApiClient()
		{
			ResourceSystem = new ResourceSystem(this);
			UserSystem = new UserSystem(this);
		}
	}
}
