using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IdentityModel.Tokens.Jwt;

namespace Glowmarkt.Model
{
	[JsonObject]
	public class UserSystemAuthenticationPostAuthenticationResponse
	{
		[JsonProperty("accountId")]
		public Guid AccountId { get; set; }

		[JsonProperty("applicationId")]
		public Guid ApplicationId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("valid")]
		public bool Valid { get; set; }

		[JsonProperty("exp")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTimeOffset Expiry { get; set; }

		[JsonProperty("token")]
		[JsonConverter(typeof(JwtSecurityTokenConverter))]
		public JwtSecurityToken Token { get; set; }
	}
}
