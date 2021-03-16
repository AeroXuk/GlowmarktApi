using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Glowmarkt.Model
{
	public class JsonModelBase
	{
		/// <summary>Holds json properties with no matching class member.</summary>
		[JsonExtensionData]
		private IDictionary<string, JToken> _additionalData;

		public JsonModelBase()
		{
			_additionalData = new Dictionary<string, JToken>();
		}
	}
}
