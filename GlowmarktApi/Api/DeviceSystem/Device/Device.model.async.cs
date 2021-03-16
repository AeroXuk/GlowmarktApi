using Glowmarkt.Model.DeviceSystem.Device;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Glowmarkt.Api
{
	public partial class DeviceSystemDevice
	{
		public async Task<List<Device>> GetDevicesAsync()
			=> JsonConvert.DeserializeObject<List<Device>>(await GetDevicesRawAsync());

		public async Task<Device> GetDeviceAsync(Guid id)
			=> JsonConvert.DeserializeObject<Device>(await GetDeviceRawAsync(id));

		//public async Task<Device> GetDeviceStatusAsync(Guid id)
		//	=> JsonConvert.DeserializeObject<Device>(await GetDeviceStatusRawAsync(id));
	}
}
