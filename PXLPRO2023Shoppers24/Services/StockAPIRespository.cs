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
        public void UpdateLaptop(int id, Laptop laptop)
        {     
            try
            {
				HttpClient client = _httpClientFactory.CreateClient(ApiConstants.StockApiHttpClientName);
				HttpResponseMessage response = client.PutAsJsonAsync($"stock/{id}", laptop).Result;
				if (!response.IsSuccessStatusCode)
				{
					throw new Exception("Could not update item");
				}
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
                throw new Exception("Could not save item");
            }
        }

        public void Update(int id, Laptop laptop)
        {
            laptop.StockQuantity--;
		    HttpClient client = _httpClientFactory.CreateClient(ApiConstants.StockApiHttpClientName);
			HttpResponseMessage response = client.PutAsJsonAsync($"stock/{id}", laptop).Result;
			if (!response.IsSuccessStatusCode)
			{
				throw new Exception("Could not update item");
			}
		}
        public async void Delete(int id)
        {
            try
            {
				HttpClient client = _httpClientFactory.CreateClient(ApiConstants.StockApiHttpClientName);
				HttpResponseMessage response = await client.DeleteAsync($"stock/{id}");
				if (!response.IsSuccessStatusCode)
				{
					throw new Exception("Could not delete item");
				}
			}
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
