using Newtonsoft.Json;
using System.Collections.Generic;

namespace Glowmarkt.Model.DeviceSystem.Device
{
	[JsonObject]
	public class DeviceProtocol : JsonModelBase
	{
		[JsonProperty("sensors")]
		public IReadOnlyList<DeviceProtocolSensor> Sensors { get; }

		[JsonProperty("protocol")]
		public string Protocol { get; }

		[JsonConstructor]
		public DeviceProtocol(
			[JsonProperty] List<DeviceProtocolSensor> sensors,
			[JsonProperty] string protocol
			) : base()
		{
			Sensors = sensors;
			Protocol = protocol;
		}
	}
}
