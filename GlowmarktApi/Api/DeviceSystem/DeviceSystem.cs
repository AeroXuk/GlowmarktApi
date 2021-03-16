namespace Glowmarkt.Api
{
	public partial class DeviceSystem : SystemBase
	{
		public DeviceSystemDevice Device { get; }

		public DeviceSystemDeviceType DeviceType { get; }

		public DeviceSystemDiscover Discover { get; }

		internal DeviceSystem(GlowmarktApiClient client) : base(client)
		{
			Device = new DeviceSystemDevice(client);
			DeviceType = new DeviceSystemDeviceType(client);
			Discover = new DeviceSystemDiscover(client);
		}
	}
}
