using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lenovoWarranty.lenovoresult
{
    public class BaseWarranty
    {
        [JsonProperty("sdf")]
        public string? Sdf { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("category")]
        public string? Category { get; set; }

        [JsonProperty("deliveryType")]
        public string? DeliveryType { get; set; }

        [JsonProperty("deliveryTypeName")]
        public string? DeliveryTypeName { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("startDate")]
        public string? StartDate { get; set; }

        [JsonProperty("endDate")]
        public string? EndDate { get; set; }

        [JsonProperty("level")]
        public string? Level { get; set; }
    }

    public class CurrentWarranty
    {
        [JsonProperty("sdf")]
        public string? Sdf { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("category")]
        public string? Category { get; set; }

        [JsonProperty("deliveryType")]
        public string? DeliveryType { get; set; }

        [JsonProperty("deliveryTypeName")]
        public string? DeliveryTypeName { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("startDate")]
        public string? StartDate { get; set; }

        [JsonProperty("endDate")]
        public string? EndDate { get; set; }

        [JsonProperty("level")]
        public string? Level { get; set; }
    }

    public class Data
    {
        [JsonProperty("machineInfo")]
        public MachineInfo? MachineInfo { get; set; }

        [JsonProperty("baseWarranties")]
        public List<BaseWarranty>? BaseWarranties { get; set; }

        [JsonProperty("upgradeWarranties")]
        public List<UpgradeWarranty>? UpgradeWarranties { get; set; }

        [JsonProperty("contractWarranties")]
        public List<object>? ContractWarranties { get; set; }

        [JsonProperty("currentWarranty")]
        public CurrentWarranty? CurrentWarranty { get; set; }

        [JsonProperty("hasActiveContract")]
        public bool HasActiveContract { get; set; }

        [JsonProperty("regularEndDate")]
        public object? RegularEndDate { get; set; }

        [JsonProperty("hasSpecialWarranty")]
        public bool HasSpecialWarranty { get; set; }

        [JsonProperty("regularDeliveryType")]
        public object? RegularDeliveryType { get; set; }

        [JsonProperty("warrantyRegistered")]
        public object? WarrantyRegistered { get; set; }

        [JsonProperty("oow")]
        public bool Oow { get; set; }
    }

    public class MachineInfo
    {
        [JsonProperty("buildDate")]
        public string? BuildDate { get; set; }

        [JsonProperty("model")]
        public string? Model { get; set; }

        [JsonProperty("product")]
        public string? Product { get; set; }

        [JsonProperty("productName")]
        public string? ProductName { get; set; }

        [JsonProperty("serial")]
        public string? Serial { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("imei")]
        public string? Imei { get; set; }

        [JsonProperty("popDate")]
        public string? PopDate { get; set; }

        [JsonProperty("swapImei")]
        public string? SwapImei { get; set; }

        [JsonProperty("shipToCountry")]
        public string? ShipToCountry { get; set; }

        [JsonProperty("shipDate")]
        public string? ShipDate { get; set; }

        [JsonProperty("brand")]
        public string? Brand { get; set; }

        [JsonProperty("series")]
        public string? Series { get; set; }

        [JsonProperty("group")]
        public string? Group { get; set; }

        [JsonProperty("productImage")]
        public string? ProductImage { get; set; }

        [JsonProperty("baseStartDate")]
        public string? BaseStartDate { get; set; }

        [JsonProperty("eosDate")]
        public string? EosDate { get; set; }

        [JsonProperty("maxDuration")]
        public int MaxDuration { get; set; }

        [JsonProperty("tablet")]
        public bool Tablet { get; set; }
    }

    public class Msg
    {
        [JsonProperty("desc")]
        public string? Desc { get; set; }

        [JsonProperty("value")]
        public object? Value { get; set; }
    }

    public class Root
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("costMillis")]
        public int CostMillis { get; set; }

        [JsonProperty("requestId")]
        public string? RequestId { get; set; }

        [JsonProperty("responseHost")]
        public string? ResponseHost { get; set; }

        [JsonProperty("msg")]
        public Msg? Msg { get; set; }

        [JsonProperty("data")]
        public Data? Data { get; set; }
    }

    public class UpgradeWarranty
    {
        [JsonProperty("sdf")]
        public string? Sdf { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("category")]
        public string? Category { get; set; }

        [JsonProperty("deliveryType")]
        public string? DeliveryType { get; set; }

        [JsonProperty("deliveryTypeName")]
        public string? DeliveryTypeName { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("startDate")]
        public string? StartDate { get; set; }

        [JsonProperty("endDate")]
        public string? EndDate { get; set; }

        [JsonProperty("level")]
        public string? Level { get; set; }
    }

}
