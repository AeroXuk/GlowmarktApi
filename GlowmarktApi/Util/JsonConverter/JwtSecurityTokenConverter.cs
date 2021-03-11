using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;

namespace Glowmarkt
{
	internal class JwtSecurityTokenConverter : JsonConverter<JwtSecurityToken>
	{
		public override void WriteJson(JsonWriter writer, JwtSecurityToken value, JsonSerializer serializer)
		{
			writer.WriteValue(value.RawData);
		}

		public override JwtSecurityToken ReadJson(JsonReader reader, Type objectType, JwtSecurityToken existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return new JwtSecurityToken(reader.Value as string);
		}
	}
}
