using System.Net.Http.Json;

namespace BlazorAppSample.DataModel
{
    public class AdminService
    {
        public HttpClient _httpClient;
        public AdminService()
        {
            _httpClient = new HttpClient();// httpClient;
        }

        // return the list of Users 
         public async Task<List<User>> GetAdminsAsync()
         {
           // sending a get request to get the data from the api
            return await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
         }
    }
}
