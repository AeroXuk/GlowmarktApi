using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Glowmarkt.Model.DeviceSystem.Device
{
	[JsonObject]
	public class Device : JsonModelBase
	{
		[JsonProperty("active")]
		public bool Active { get; }

		[JsonProperty("deviceId")]
		public Guid DeviceId { get; }

		[JsonProperty("deviceTypeId")]
		public Guid DeviceTypeId { get; }

		[JsonProperty("ownerId")]
		public Guid OwnerId { get; }

		[JsonProperty("description")]
		public string Description { get; }

		[JsonProperty("hardwareId")]
		public string HardwareId { get; }

		[JsonProperty("hardwareIds")]
		public IReadOnlyDictionary<string, string> HardwareIds { get; }

		[JsonProperty("parentHardwareId")]
		public IReadOnlyList<string> ParentHardwareId { get; }

		[JsonProperty("protocol")]
		public DeviceProtocol Protocol { get; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; }

		[JsonProperty("tags")]
		public IReadOnlyList<string> Tags { get; }

		[JsonConstructor]
		public Device(
			[JsonProperty] bool active,
			[JsonProperty] Guid deviceId,
			[JsonProperty] Guid deviceTypeId,
			[JsonProperty] Guid ownerId,
			[JsonProperty] string description,
			[JsonProperty] string hardwareId,
			[JsonProperty] Dictionary<string, string> hardwareIds,
			[JsonProperty] List<string> parentHardwareId,
			[JsonProperty] DeviceProtocol protocol,
			[JsonProperty] DateTimeOffset createdAt,
			[JsonProperty] DateTimeOffset updatedAt,
			[JsonProperty] List<string> tags
			) : base()
		{
			Active = active;
			DeviceId = deviceId;
			DeviceTypeId = deviceTypeId;
			OwnerId = ownerId;
			Description = description;
			HardwareId = hardwareId;
			HardwareIds = hardwareIds;
			ParentHardwareId = parentHardwareId;
			Protocol = protocol;
			CreatedAt = createdAt;
			UpdatedAt = updatedAt;
			Tags = tags;
		}
	}
}
