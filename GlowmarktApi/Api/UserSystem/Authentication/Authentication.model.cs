using Glowmarkt.Model;

namespace Glowmarkt.Api
{
	public partial class UserSystemAuthentication
	{
		/// <summary>Authenticate an account</summary>
		public UserSystemAuthenticationPostAuthenticationResponse PostAuthentication(string username, string password)
			=> PostAuthentication(new UserSystemAuthenticationPostAuthenticationRequest(username, password));

		/// <summary>Authenticate an account</summary>
		public UserSystemAuthenticationPostAuthenticationResponse PostAuthentication(UserSystemAuthenticationPostAuthenticationRequest request)
		{
			var reply = PostAuthenticationAsync(request);
			reply.Wait();
			return reply.Result;
		}
	}
}
