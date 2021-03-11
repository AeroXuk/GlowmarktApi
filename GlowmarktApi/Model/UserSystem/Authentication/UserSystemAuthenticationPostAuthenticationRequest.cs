using Newtonsoft.Json;

namespace Glowmarkt.Model
{
	[JsonObject]
	public class UserSystemAuthenticationPostAuthenticationRequest
	{
		[JsonProperty("username")]
		public string Username { get; }

		[JsonProperty("password")]
		public string Password { get; }

		public UserSystemAuthenticationPostAuthenticationRequest(string username, string password)
		{
			Username = username;
			Password = password;
		}
	}
}
