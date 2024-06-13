using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var application = new WebApplicationFactory<WebApiApplication>() 
            .WithWebHostBuilder(builder => 
            {
                builder.ConfigureServices(services => 
                {
                    // Add services
                });
            });

            var client = application.CreateClient();    
            
            
            var response = await client.GetAsync("/api/values");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("[\"value1\",\"value2\"]", responseString);

        }
    }
}