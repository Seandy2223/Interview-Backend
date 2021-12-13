using moduit.Base.Enum;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace moduit.Base
{
    public interface IRESTService
    {
        Task<HttpResponseMessage> REST(string requestUri, RequestEnum restType);
        Task<HttpResponseMessage> REST(string requestUri, RequestEnum restType, string postBody);
        Task<T> ConvertResponseToEntity<T>(HttpResponseMessage message);
    }
}
