namespace Glowmarkt.Api
{
	public partial class ResourceSystem : ISystem
	{
		public ResourceSystemResource Resource { get; }

		public ResourceSystemResourceType ResourceType { get; }

		internal ResourceSystem(GlowmarktApiClient client) : base(client)
		{
			Resource = new ResourceSystemResource(client);
			ResourceType = new ResourceSystemResourceType(client);
		}
	}
}
