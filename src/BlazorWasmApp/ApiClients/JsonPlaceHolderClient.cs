using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorWasmApp.Models;

namespace BlazorWasmApp.ApiClients
{
    public class JsonPlaceHolderClient
    {
        private HttpClient _httpClient;
        public JsonPlaceHolderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> GetAllPost()
        {
            return await _httpClient.GetFromJsonAsync<List<Post>>("/posts");
        }

        public async Task<Post> CreateOrUpdatePost(Post newPost)
        {
            await Task.FromResult(0);
            return newPost;
        }

        public async Task DeletePost(int id)
        {
            await Task.FromResult(0);
        }
    }
}