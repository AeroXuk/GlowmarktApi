using System;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDeviceType
	{
		/// <summary>Find all device types</summary>
		public string GetDeviceTypesRaw()
		{
			var reply = GetDeviceTypesRawAsync();
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find Device Type by ID</summary>
		public string GetDeviceTypeRaw(string id)
		{
			var reply = GetDeviceTypeRawAsync(id);
			reply.Wait();
			return reply.Result;
		}
	}
}
