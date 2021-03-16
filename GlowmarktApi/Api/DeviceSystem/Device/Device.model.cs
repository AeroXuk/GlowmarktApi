using Glowmarkt.Model.DeviceSystem.Device;
using System;
using System.Collections.Generic;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDevice
	{
		public List<Device> GetDevices()
		{
			var reply = GetDevicesAsync();
			reply.Wait();
			return reply.Result;
		}

		public Device GetDevice(Guid id)
		{
			var reply = GetDeviceAsync(id);
			reply.Wait();
			return reply.Result;
		}

		//public Device GetDeviceStatus(Guid id)
		//{
		//	var reply = GetDeviceStatusAsync(id);
		//	reply.Wait();
		//	return reply.Result;
		//}
	}
}
