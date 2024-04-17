using Consumir_WebApi2_Produtos.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Consumir_WebApi2_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("https://api.mercadolibre.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add(nameof(HttpRequestHeader.Authorization), "Bearer APP_USR-6500094978999069-041715-3c4372c31a4c10f87e57d55406d860f7-1774520770");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));




                //HttpResponseMessage responCategories = await client.GetAsync("/sites/MLB/search?category=MLB1071"); // END POINT
                HttpResponseMessage responCategories = await client.GetAsync("/sites/MLB/categories"); // END POINT
                if (responCategories.IsSuccessStatusCode)
                {
                    Console.WriteLine(responCategories.Content.ReadAsStringAsync());

                    //GET
                    List<Category> categoria = await responCategories.Content.ReadAsAsync<List<Category>>();

                    foreach (var item in categoria)
                    {
                        Console.WriteLine(item.Name + " " + item.Id);



                    }
                }
            }
        }

    }

}