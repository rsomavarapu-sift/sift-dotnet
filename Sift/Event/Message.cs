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
    
    
    public partial class Message : SiftEntity
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
    public partial class Message 
    {
        [Newtonsoft.Json.JsonProperty("$subject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string subject { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string body { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$contact_email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string contact_email { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$root_content_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string root_content_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$recipient_user_ids", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> recipient_user_ids { get; set; }
    
        [Newtonsoft.Json.JsonProperty("$images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Image> images { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        
        public static Message FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(data);
        }
    
    }
}