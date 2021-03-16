using Newtonsoft.Json;

namespace Glowmarkt.Model.UserSystem.Authentication
{
	[JsonObject]
	public class AuthenticationPostAuthenticationRequest : JsonModelBase
	{
		[JsonProperty("username")]
		public string Username { get; }

		[JsonProperty("password")]
		public string Password { get; }

		[JsonConstructor]
		public AuthenticationPostAuthenticationRequest(
			[JsonProperty] string username,
			[JsonProperty] string password
			) : base()
		{
			Username = username;
			Password = password;
		}
	}
}
