using System;
using System.IO;
using System.Net.Http;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Assignment.Grader
{
    internal static class Utilities
    {
        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public static async Task<T> AssertResponseBodyWellFormedJsonAsync<T>(HttpResponseMessage response)
        {
            // content-type json
            Assert.Equal(MediaTypeNames.Application.Json, response.Content.Headers.ContentType.MediaType);
            // body well-formed json
            Stream content = await response.Content.ReadAsStreamAsync();
            T value = await JsonSerializer.DeserializeAsync<T>(content, _jsonSerializerOptions);
            return value;
        }
    }
}
