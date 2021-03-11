using System;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDiscover
	{
		/// <summary>Find device by ID</summary>
		public string GetDiscoverRaw(string hardwareId)
		{
			var reply = GetDiscoverRawAsync(hardwareId);
			reply.Wait();
			return reply.Result;
		}
	}
}
