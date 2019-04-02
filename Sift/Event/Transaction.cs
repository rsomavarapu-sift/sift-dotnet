//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sift
{
    
    
    public partial class Transaction : SiftEvent
    {
    }
}
//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.13.28.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Sift
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.28.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Transaction 
    {
        [Newtonsoft.Json.JsonProperty("$type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string type { get; set; } = "$transaction";
    
        [Newtonsoft.Json.JsonProperty("$user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string user_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$session_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string session_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$user_email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string user_email { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$transaction_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string transaction_type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$transaction_status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string transaction_status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$order_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string order_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$transaction_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string transaction_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$billing_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address billing_address { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$payment_method", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentMethod payment_method { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$shipping_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address shipping_address { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$seller_user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string seller_user_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$transfer_recipient_user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string transfer_recipient_user_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$app", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public App app { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$browser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Browser browser { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Transaction FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Transaction>(data);
        }
    
    }
}