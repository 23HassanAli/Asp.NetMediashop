using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;

namespace PXLPRO2023Shoppers24.Services
{
    public class StockAPIRespository : IStockApiRepository
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        private readonly IHttpClientFactory _httpClientFactory;
        public StockAPIRespository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<Laptop> UpdateLaptop(int id, Laptop item)
        {
         
            try
            {
                //item.StockQuantity--;
                //_httpClient.BaseAddress = new Uri("https://localhost:7144/api/stock/");
                //var laptop = new Laptop()
                //{
                //    Id = item.Id,
                //    Name = item.Name,
                //    Price = item.Price,
                //    Description = item.Description,
                //    StockQuantity = item.StockQuantity,
                //    ImageURL = item.ImageURL,
                //    ProductCategory = item.ProductCategory,
                //    Brand = item.Brand,
                //    Color = item.Color,
                //    Processor = item.Processor,
                //    ScreenSize = item.ScreenSize,
                //    InternalRAM = item.InternalRAM,
                //    TotalStorageCapacity = item.TotalStorageCapacity,
                //    Touchscreen = item.Touchscreen,
                //    VideoCard = item.VideoCard
                //}; 
                //_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                //var laptopEditVM = JsonSerializer.Serialize(laptop);
                //var model = new StringContent(
                // JsonSerializer.Serialize(laptop),
                //Encoding.UTF8,
                //Application.Json);

                //using var httpResponseMessage = await _httpClient.PutAsync($"{id}", model);
                //httpResponseMessage.EnsureSuccessStatusCode();
                
                //using(var client2 = new HttpClient())
                //{
    
                //    client2.DefaultRequestHeaders.Accept.Clear();
                //    client2.DefaultRequestHeaders.Accept.Add(
                //    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                //    client2.BaseAddress = new Uri("https://localhost:7144/");
                //    var laptopPut = client2.PutAsJsonAsync("api/Stock/Edit", laptopEditVM);
                //    laptopPut.Wait();
                //    var putResult = laptopPut.Result;
                //    if (putResult.IsSuccessStatusCode)
                //    {

                //    }
                //}
                //var response = await _httpClient.SendAsync(request);
   
                Laptop laptop1 = new Laptop();

                return laptop1;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<StockLaptop>> GetAll()
        {
            HttpClient client = _httpClientFactory.CreateClient(ApiConstants.StockApiHttpClientName);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            HttpResponseMessage response = client.GetAsync("stock").Result;
            if (response.IsSuccessStatusCode)
            {
                IList<StockLaptop> laptops = response.Content.ReadAsAsync<IList<StockLaptop>>().Result;
                return laptops;
            }
            else
            {
                return Enumerable.Empty<StockLaptop>();
            }
        }

        public Laptop GetById(long id)
        {
            
            throw new NotImplementedException();
        }
        public void Add(Laptop laptop)
        {
            HttpClient client = _httpClientFactory.CreateClient(ApiConstants.StockApiHttpClientName);
            HttpResponseMessage response = client.PostAsJsonAsync("stock", laptop).Result; 
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Could not save person");
            }
        }

        public void Update(int id, Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public void Delete(Laptop laptop)
        {
            throw new NotImplementedException();
        }
    }
}
