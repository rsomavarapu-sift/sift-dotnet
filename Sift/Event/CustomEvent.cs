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
    
    
    public partial class CustomEvent : SiftEvent
    {
    }
}
//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.12.5.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Sift
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.12.5.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CustomEvent 
    {
        [Newtonsoft.Json.JsonProperty("$type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string user_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$session_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string session_id { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static CustomEvent FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CustomEvent>(data);
        }
    
    }
}