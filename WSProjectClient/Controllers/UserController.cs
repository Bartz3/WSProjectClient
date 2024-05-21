using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ServiceReference1;

namespace WSProjectClient.Controllers
{
    public class UserController
    {
        private readonly UserServiceClient _client;



        public UserController()
        {
            var cert = new X509Certificate2(System.IO.File.ReadAllBytes(
                "/Users/jakubkowalewski/Documents/StudiaMagisterskie/RSI/SOAPssl/client_cacerts.p12"), "password");
            _client = new UserServiceClient();
            _client.ClientCredentials.ClientCertificate.Certificate = cert;
            _client.ClientCredentials.UserName.UserName = "peter";
            _client.ClientCredentials.UserName.Password = "qwerty1";
        }



        public async Task<user[]> GetUsers()
        {
            var response = await _client.GetUsersAsync();
            return response.@return;
        }

        public async void AddUser(addUserRequest _user)
        {
            await _client.AddUserAsync(_user);
        }

        public async Task<user> Login(userCredentialsRequest credentials)
        {

            return await _client.SignInUserAsync(credentials);
        }

    }
}
