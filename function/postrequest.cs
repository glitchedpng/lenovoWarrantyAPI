using lenovoWarranty.lenovoresult;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lenovoWarranty.function
{
    internal class postrequest
    {
        static async Task<string> PostURI(Uri uri, HttpContent c)
        {
            var client = new HttpClient();

            var result = await client.PostAsync(uri, c);

            var content = result.Content.ReadAsStringAsync().Result;

            return content;
        }
        public void HTTPOST(string? serial , string? type)
        {
            HttpClient httpClient = new HttpClient();

            Uri url = new Uri("https://pcsupport.lenovo.com/en/en/api/v4/upsell/redport/getIbaseInfo");

            Dictionary<string, string> map = new Dictionary<string, string>()
            {
                {"country" , "en" },
                {"language" , "en" },
                {"serialNumber" , serial },
                {"machineType" , type  }
            };

            string serialized = JsonConvert.SerializeObject(map);

            HttpContent content = new StringContent(serialized, null, "application/json");

            var t = Task.Run(() => PostURI(url, content));
            t.Wait();

            var mydeserilazed = JsonConvert.DeserializeObject<Root>(t.Result);
            if (mydeserilazed.Data == null)
            { 
                Console.WriteLine("There is an error caused of service tag.");           
            }
            else
            {
                Console.WriteLine("\nProduct Name : " + mydeserilazed.Data.MachineInfo.ProductName);
                Console.WriteLine("Serial Number : " + mydeserilazed.Data.MachineInfo.Serial);
                Console.WriteLine("Ship-To Location : " + mydeserilazed.Data.MachineInfo.ShipToCountry);
                Console.WriteLine("Ship Date : " + mydeserilazed.Data.MachineInfo.ShipDate);
                Console.WriteLine("Warranty Start Date : " + mydeserilazed.Data.CurrentWarranty.StartDate);
                Console.WriteLine("Warranty End Date : " + mydeserilazed.Data.CurrentWarranty.EndDate);
                Console.WriteLine("Warranty Status : " + mydeserilazed.Data.CurrentWarranty.Level);
            }
        }
    }
}
