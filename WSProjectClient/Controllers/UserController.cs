using System.Threading.Tasks;
using ServiceReference1;

namespace WSProjectClient.Controllers
{
    public class UserController
    {
        private readonly UserServiceClient _client;



        public UserController()
        {
            _client = new UserServiceClient();
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
