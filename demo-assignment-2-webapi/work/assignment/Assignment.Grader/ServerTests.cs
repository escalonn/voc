using System;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using ServerSide;
using Xunit;

namespace Assignment.Grader
{
    public class ServerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public ServerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void StorePostAndGetByIdWork()
        {
            // arrange
            string name = "a";
            string address = "a";
            string jsonToPost = JsonSerializer.Serialize(new GroceryStore { Name = name, Address = address });
            var contentToPost = new StringContent(jsonToPost, Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpClient client = _factory.CreateClient();

            // act: post a store
            HttpResponseMessage postResponse = await client.PostAsync("/api/store", contentToPost);

            // assert
            Assert.Equal(HttpStatusCode.Created, postResponse.StatusCode);
            Uri storeLocation = postResponse.Headers.Location;
            Assert.NotNull(storeLocation);
            GroceryStore postStore = await Utilities.AssertResponseBodyWellFormedJsonAsync<GroceryStore>(postResponse);
            Assert.Equal(name, postStore.Name);
            Assert.Equal(address, postStore.Address);

            // act: get the created store
            HttpResponseMessage getResponse = await client.GetAsync(storeLocation);

            // assert
            Assert.Equal(HttpStatusCode.OK, getResponse.StatusCode);
            GroceryStore getStore = await Utilities.AssertResponseBodyWellFormedJsonAsync<GroceryStore>(getResponse);
            Assert.Equal(name, getStore.Name);
            Assert.Equal(address, getStore.Address);
        }
    }
}
