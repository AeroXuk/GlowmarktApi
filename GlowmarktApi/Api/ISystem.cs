namespace Glowmarkt.Api
{
	public class ISystem
	{
		internal GlowmarktApiClient Client { get; }

		internal ISystem(GlowmarktApiClient client)
		{
			Client = client;
		}
	}
}
