using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IdentityModel.Tokens.Jwt;

namespace Glowmarkt.Model.UserSystem.Authentication
{
	[JsonObject]
	public class AuthenticationPostAuthenticationResponse : JsonModelBase
	{
		[JsonProperty("accountId")]
		public Guid AccountId { get; }

		[JsonProperty("applicationId")]
		public Guid ApplicationId { get; }

		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("valid")]
		public bool Valid { get; }

		[JsonProperty("exp")]
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTimeOffset Expiry { get; }

		[JsonProperty("token")]
		[JsonConverter(typeof(JwtSecurityTokenConverter))]
		public JwtSecurityToken Token { get; }

		[JsonConstructor]
		public AuthenticationPostAuthenticationResponse(
			[JsonProperty] Guid accountId,
			[JsonProperty] Guid applicationId,
			[JsonProperty] string name,
			[JsonProperty] bool valid,
			[JsonProperty] DateTimeOffset exp,
			[JsonProperty] JwtSecurityToken token
			) : base()
		{
			AccountId = accountId;
			ApplicationId = applicationId;
			Name = name;
			Valid = valid;
			Expiry = exp;
			Token = token;
		}
	}
}
