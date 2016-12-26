using System.Web.Http;

namespace RestCasinoMovil
{
	public class LoginController : ApiController
	{
		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		public string Get(string user, string pass, string user_login, string pass_login)
		{
			string salida = "OK";
			if ((!user.Equals("skpUserName")) || (!pass.Equals("Ghy54,.pfR")))
			{
				salida = "ERROR: Credenciales Inválidas";
			}
			return salida;
		}

	}
}
