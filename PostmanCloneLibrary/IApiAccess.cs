using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true, Dictionary<string, string>? headers = null);
        Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET, bool formatOutput = true, Dictionary<string, string>? headers = null);
        bool IsValidUrl(string url);
    }
}