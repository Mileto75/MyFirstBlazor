﻿using MyFirstBlazor.Services.Interfaces;
using MyFirstBlazor.Services.Models;
using System.Text.Json;

namespace MyFirstBlazor.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResultModel<IEnumerable<MovieModel>>> GetAllAsync()
        {
            var result = await _httpClient.GetAsync("https://imdb.iamidiotareyoutoo.com/search?q=a");
            var content = await result.Content.ReadAsStringAsync();
            var resultModel = JsonSerializer.Deserialize<ResultModel<IEnumerable<MovieModel>>>(content);
            return resultModel;
        }
    }
}
