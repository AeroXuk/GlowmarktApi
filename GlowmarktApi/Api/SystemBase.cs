namespace Glowmarkt.Api
{
	public class SystemBase
	{
		internal GlowmarktApiClient Client { get; }

		internal SystemBase(GlowmarktApiClient client)
		{
			Client = client;
		}
	}
}
