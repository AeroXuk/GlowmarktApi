using System;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDevice
	{
		/// <summary>Get a user's devices</summary>
		public string GetDevicesRaw()
		{
			var reply = GetDevicesRawAsync();
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find Device by ID</summary>
		public string GetDeviceRaw(string id)
		{
			var reply = GetDeviceRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>This call can be used to see whether a gateway device is sending packets to the Glow Platform (i.e. via WiFi).</summary>
		public string GetDeviceStatusRaw(string id)
		{
			var reply = GetDeviceStatusRawAsync(id);
			reply.Wait();
			return reply.Result;
		}
	}
}
