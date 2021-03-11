namespace Glowmarkt.Api
{
	public partial class UserSystem : ISystem
	{
		public UserSystemAuthentication Authentication { get; }

		internal UserSystem(GlowmarktApiClient client) : base(client)
		{
			Authentication = new UserSystemAuthentication(client);
		}
	}
}
