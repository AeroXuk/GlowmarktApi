using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Glowmarkt.Model.ResourceSystem.Resource
{
	[JsonObject]
	public class ResourceGetResourcesResponse : JsonModelBase
	{
		[JsonProperty("classifier")]
		public string Classifier { get; }

		[JsonProperty("resourceTypeId")]
		public Guid ResourceTypeId { get; }

		[JsonProperty("resourceId")]
		public Guid ResourceId { get; }

		[JsonProperty("ownerId")]
		public Guid OwnerId { get; }

		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("description")]
		public string Description { get; }

		[JsonProperty("dataSourceUnitInfo")]
		public ResourceDataSourceUnitInfo DataSourceUnitInfo { get; }

		[JsonProperty("storage")]
		public IReadOnlyList<ResourceStorageType> Storage { get; }

		[JsonProperty("active")]
		public bool Active { get; }

		[JsonProperty("hasOwnerPermissions")]
		public bool HasOwnerPermissions { get; }

		[JsonProperty("dataSourceResourceTypeInfo")]
		public ResourceDataSourceResourceTypeInfo DataSourceResourceTypeInfo { get; }

		[JsonProperty("dataSourceType")]
		public string DataSourceType { get; }

		[JsonProperty("baseUnit")]
		public string BaseUnit { get; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; }

		[JsonConstructor]
		public ResourceGetResourcesResponse(
			[JsonProperty] string classifier,
			[JsonProperty] Guid resourceTypeId,
			[JsonProperty] Guid resourceId,
			[JsonProperty] Guid ownerId,
			[JsonProperty] string name,
			[JsonProperty] string description,
			[JsonProperty] ResourceDataSourceUnitInfo dataSourceUnitInfo,
			[JsonProperty] List<ResourceStorageType> storage,
			[JsonProperty] bool active,
			[JsonProperty] bool hasOwnerPermissions,
			[JsonProperty] ResourceDataSourceResourceTypeInfo dataSourceResourceTypeInfo,
			[JsonProperty] string dataSourceType,
			[JsonProperty] string baseUnit,
			[JsonProperty] DateTimeOffset updatedAt,
			[JsonProperty] DateTimeOffset createdAt
			)
		{
			Classifier = classifier;
			ResourceTypeId = resourceTypeId;
			ResourceId = resourceId;
			OwnerId = ownerId;
			Name = name;
			Description = description;
			DataSourceUnitInfo = dataSourceUnitInfo;
			Storage = storage;
			Active = active;
			HasOwnerPermissions = hasOwnerPermissions;
			DataSourceResourceTypeInfo = dataSourceResourceTypeInfo;
			DataSourceType = dataSourceType;
			BaseUnit = baseUnit;
			UpdatedAt = updatedAt;
			CreatedAt = createdAt;
		}
	}
}
