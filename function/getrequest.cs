using lenovoWarranty.lenovoresult;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lenovoWarranty.function
{
    public class getrequest
    {
        public async Task<List<getdeviceproperty>> HTTPGET(string? serviceTag)
        {

            string urlwithquery = "https://lenovomobilesupport.lenovo.com/en/en/api/v4/mse/getproducts?productId=" + serviceTag;

            HttpClient client = new HttpClient
                (
                new HttpClientHandler { AllowAutoRedirect = true }
                ) ;
            var response = await client.GetAsync(urlwithquery);           
            var jsonresponse = await response.Content.ReadAsStringAsync();

            var myDeserializedClass = JsonConvert.DeserializeObject<List<getdeviceproperty>>(jsonresponse);

            return myDeserializedClass;

        }
    }
}
