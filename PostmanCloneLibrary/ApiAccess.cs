using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    // Initialize HttpClient once.
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true, Dictionary<string, string>? headers = null)
    {
        StringContent stringContent = new(content, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, stringContent, action, formatOutput, headers);
    }

    public async Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET, bool formatOutput = true, Dictionary<string, string>? headers = null)
    {
        HttpResponseMessage? response;
        using var requestMessage = new HttpRequestMessage
        {
            RequestUri = new Uri(url)
        };

        if (headers != null)
        {
            foreach (var header in headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }
        }

        switch (action)
        {
            case HttpAction.GET:
                requestMessage.Method = HttpMethod.Get;
                break;
            case HttpAction.POST:
                requestMessage.Method = HttpMethod.Post;
                requestMessage.Content = content;
                break;
            case HttpAction.PUT:
                requestMessage.Method = HttpMethod.Put;
                requestMessage.Content = content;
                break;
            case HttpAction.PATCH:
                requestMessage.Method = HttpMethod.Patch;
                requestMessage.Content = content;
                break;
            case HttpAction.DELETE:
                requestMessage.Method = HttpMethod.Delete;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }

        response = await client.SendAsync(requestMessage);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            // If format output is selected...
            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        // If true also validate that the output is also of type https.
        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
                      (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}