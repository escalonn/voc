using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ClientSide;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Assignment.Grader
{
    public class ClientWithoutServerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ClientWithoutServerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task EndpointsFailWithoutRunningServer()
        {
            // arrange
            HttpClient client = _factory.CreateClient();

            // act
            HttpResponseMessage countResponse = await client.GetAsync("/api/store/count");
            HttpResponseMessage createResponse = await client.PostAsync("/api/store/createthree", null);

            // assert
            Assert.Equal(HttpStatusCode.BadGateway, countResponse.StatusCode);
            Assert.Equal(HttpStatusCode.BadGateway, createResponse.StatusCode);
        }
    }
}
