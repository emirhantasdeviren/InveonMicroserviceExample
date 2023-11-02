using System.Net;
using System.Text;
using Inveon.Web.Models.Dto;
using Inveon.Web.Services.IService;
using Newtonsoft.Json;
using static Inveon.Web.Utility.SD;

namespace Inveon.Web.Services;

public class BaseService : IBaseService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BaseService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<ResponseDto?> SendAsync(RequestDto reqDto)
    {
        try
        {
            HttpClient client = _httpClientFactory.CreateClient("InveonAPI");
            HttpRequestMessage msg = new();
            msg.Headers.Add("Accept", "application/json");

            // TODO: token

            msg.RequestUri = new Uri(reqDto.Url);

            if (reqDto.Data != null)
            {
                msg.Content = new StringContent(JsonConvert.SerializeObject(reqDto.Data), Encoding.UTF8, "application/json");
            }

            switch (reqDto.ApiType)
            {
                case ApiType.GET:
                    msg.Method = HttpMethod.Get;
                    break;
                case ApiType.POST:
                    msg.Method = HttpMethod.Post;
                    break;
                case ApiType.PUT:
                    msg.Method = HttpMethod.Put;
                    break;
                case ApiType.DELETE:
                    msg.Method = HttpMethod.Delete;
                    break;
            }

            HttpResponseMessage apiRes = await client.SendAsync(msg);

            switch (apiRes.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    return new() { Message = "Not Found" };
                case HttpStatusCode.Forbidden:
                    return new() { Message = "Access Denied" };
                case HttpStatusCode.Unauthorized:
                    return new() { Message = "Unauthorized" };
                case HttpStatusCode.InternalServerError:
                    return new() { Message = "Internal Server Error" };
                default:
                    string apiContent = await apiRes.Content.ReadAsStringAsync();
                    ResponseDto? apiResDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                    return apiResDto;
            }
        }
        catch (Exception e)
        {
            ResponseDto resDto = new()
            {
                Message = e.Message.ToString(),
            };

            return resDto;
        }
    }
}