using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerSide.Models;

namespace ServerSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public StoreController(IHttpClientFactory clientFactory)
        {
            HttpClient client = clientFactory.CreateClient();
            client.BaseAddress = new Uri("http://localhost:5001/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            _httpClient = client;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<int>> CountAsync()
        {
            HttpResponseMessage response;
            try
            {
                response = await _httpClient.GetAsync("/api/store");
            }
            catch (HttpRequestException)
            {
                return StatusCode(StatusCodes.Status502BadGateway);
            }
            if (!response.IsSuccessStatusCode)
            {
                return StatusCode(StatusCodes.Status502BadGateway);
            }

            Stream content = await response.Content.ReadAsStreamAsync();
            GroceryStore[] stores = await JsonSerializer.DeserializeAsync<GroceryStore[]>(content, _jsonSerializerOptions);
            int count = stores.Length;
            return count;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateThreeAsync()
        {
            var newStore = new GroceryStore { Name = "Martin General Stores", Address = "4160 Oakwood Avenue" };
            string json = JsonSerializer.Serialize(newStore);
            var content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json);

            var tasks = new List<Task<bool>>();
            for (int i = 0; i < 3; i++)
            {
                Task<bool> task = _httpClient.PostAsync("/api/store", content)
                    .ContinueWith(t => t.Result.IsSuccessStatusCode, TaskContinuationOptions.OnlyOnRanToCompletion);
                tasks.Add(task);
            }

            bool[] results;
            try
            {
                results = await Task.WhenAll(tasks);
            }
            catch (TaskCanceledException)
            {
                return StatusCode(StatusCodes.Status502BadGateway);
            }

            if (!results.All(x => x))
            {
                return StatusCode(StatusCodes.Status502BadGateway);
            }
            return NoContent();
        }
    }
}
