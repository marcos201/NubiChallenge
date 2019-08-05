using Newtonsoft.Json;
using NubiChallengeApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NubiChallengeApi.IntegrationTests.Controllers
{
    public class UsersControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public UsersControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CanGetUsers()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.GetAsync("/api/users");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var players = JsonConvert.DeserializeObject<IEnumerable<User>>(stringResponse);
            Assert.Contains(players, p => p.Nombre == "Luke");
            Assert.Contains(players, p => p.Apellido == "Skywalker");
        }


        [Fact]
        public async Task CanGetUsersById()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.GetAsync("/api/users/A0000000-0000-0000-0000-000000000001");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(stringResponse);
            Assert.Equal(new Guid("A0000000-0000-0000-0000-000000000001"), user.Id);
            Assert.Equal("Luke", user.Nombre);
        }


        [Fact]
        public async Task CanDeleteUsersById()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.DeleteAsync("/api/users/A0000000-0000-0000-0000-000000000002");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(stringResponse);
            Assert.Equal(new Guid("A0000000-0000-0000-0000-000000000002"), user.Id);
            Assert.Equal("Anakin", user.Nombre);
        }

        [Fact]
        public async Task CanPostUser()
        {
            string myJson = "{'nombre':'Obi-Wan', 'apellido': 'Kenobi', 'email': 'obi-wan@mail.com', 'password': 'obi-wan123', 'id': 'a0000000-0000-0000-0000-000000000012', 'created': '2019-08-04T23:39:41.5954149Z', 'modified': '2019-08-04T23:39:41.5954152Z'}";
            HttpContent httpContent = new StringContent(myJson, Encoding.UTF8 ,"application/json");

            // The endpoint or route of the controller action.
            var httpResponse = await _client.PostAsync("/api/users/", httpContent);

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(stringResponse);
            Assert.Equal(new Guid("A0000000-0000-0000-0000-000000000012"), user.Id);
            Assert.Equal("Obi-Wan", user.Nombre);
        }
    }
}
