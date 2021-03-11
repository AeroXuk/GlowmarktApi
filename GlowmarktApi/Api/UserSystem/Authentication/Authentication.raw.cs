using Glowmarkt.Model;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public string PostAuthenticationRaw(string username, string password)
			=> PostAuthenticationRaw(new UserSystemAuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public string PostAuthenticationRaw(UserSystemAuthenticationPostAuthenticationRequest request)
		{
			var reply = PostAuthenticationRawAsync(request);
			reply.Wait();
			return reply.Result;
		}
	}
}
