using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ClientSide;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Assignment.Grader
{
    [Trait("Requires", "Server")]
    public class ClientWithServerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ClientWithServerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task StoreGetCountAndPostCreateThreeWork()
        {
            // arrange
            HttpClient client = _factory.CreateClient();

            // act: get count
            HttpResponseMessage countResponse1 = await client.GetAsync("/api/store/count");

            // assert
            Assert.Equal(HttpStatusCode.OK, countResponse1.StatusCode);
            int count1 = await Utilities.AssertResponseBodyWellFormedJsonAsync<int>(countResponse1);

            // act: create three
            HttpResponseMessage createResponse = await client.PostAsync("/api/store/createthree", null);

            // assert
            Assert.Equal(HttpStatusCode.NoContent, createResponse.StatusCode);

            // act: get count
            HttpResponseMessage countResponse2 = await client.GetAsync("/api/store/count");

            // assert
            Assert.Equal(HttpStatusCode.OK, countResponse2.StatusCode);
            int count2 = await Utilities.AssertResponseBodyWellFormedJsonAsync<int>(countResponse2);
            Assert.Equal(count1 + 3, count2);
        }
    }
}
