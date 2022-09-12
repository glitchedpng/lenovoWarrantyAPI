using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lenovoWarranty.lenovoresult
{
    public class getdeviceproperty
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Guid")]
        public string Guid { get; set; }

        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Serial")]
        public string Serial { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("ParentID")]
        public List<string> ParentID { get; set; }

        [JsonProperty("Image")]
        public string Image { get; set; }

        [JsonProperty("Popularity")]
        public string Popularity { get; set; }

        [JsonProperty("IsChina")]
        public int IsChina { get; set; }

        [JsonProperty("IsSupported")]
        public bool IsSupported { get; set; }

        [JsonProperty("IsSolutionParent")]
        public bool IsSolutionParent { get; set; }
    }
}
