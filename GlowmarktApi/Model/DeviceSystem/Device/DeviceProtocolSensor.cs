using Newtonsoft.Json;
using System;

namespace Glowmarkt.Model.DeviceSystem.Device
{
	[JsonObject]
	public class DeviceProtocolSensor : JsonModelBase
	{
		[JsonProperty("protocolId")]
		public string ProtocolId { get; }

		[JsonProperty("resourceTypeId")]
		public Guid ResourceTypeId { get; }

		[JsonProperty("resourceId")]
		public Guid ResourceId { get; }

		[JsonConstructor]
		public DeviceProtocolSensor(
			[JsonProperty] string protocolId,
			[JsonProperty] Guid resourceTypeId,
			[JsonProperty] Guid resourceId
			) : base()
		{
			ProtocolId = protocolId;
			ResourceTypeId = resourceTypeId;
			ResourceId = resourceId;
		}
	}
}
