using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace HttpClientExample.Grader
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<ClientSide.Startup>>
    {
        private readonly WebApplicationFactory<ClientSide.Startup> _factory;

        public IntegrationTests(WebApplicationFactory<ClientSide.Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
