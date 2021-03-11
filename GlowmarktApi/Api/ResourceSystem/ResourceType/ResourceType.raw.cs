using System;

namespace Glowmarkt.Api
{
	public partial class ResourceSystemResourceType
	{
		/// <summary>Find all resourceTypes</summary>
		public string GetResourceTypesRaw()
		{
			var reply = GetResourceTypesRawAsync();
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find resourceType by ID</summary>
		public string GetResourceTypeRaw(Guid id)
		{
			var reply = GetResourceTypeRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find resources of a specific resource type that belong to a user</summary>
		public string GetResourceTypeResourcesRaw(Guid id)
		{
			var reply = GetResourceTypeResourcesRawAsync(id);
			reply.Wait();
			return reply.Result;
		}

		/// <summary>Find resources of a specific resource type that an application has access to</summary>
		public string GetResourceTypeAppResourcesRaw(Guid id)
		{
			var reply = GetResourceTypeAppResourcesRawAsync(id);
			reply.Wait();
			return reply.Result;
		}
	}
}
