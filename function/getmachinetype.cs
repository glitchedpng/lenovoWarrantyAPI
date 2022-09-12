using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lenovoWarranty.function
{
    public class getmachinetype
    {
        public async Task<string> getMT(string? serial)
        {
            getrequest gr = new getrequest();
            HttpClient client = new HttpClient();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            var resp = await gr.HTTPGET(serial);

            foreach (var item in resp)
            {
                var response = await client.GetStringAsync("https://pcsupport.lenovo.com/en/en/products/" + item.Id.ToLower(new CultureInfo("en-US", false)) + "?linkTrack=Homepage%3ABody_Search%20Products&searchType=6&keyWordSearch=" + item.Serial);
                doc.LoadHtml(response);
                var node = doc.DocumentNode.SelectSingleNode("/html/head/meta[25]");
                return node.GetAttributeValue("content","");
              
            }
            return "";

        }
    }
}