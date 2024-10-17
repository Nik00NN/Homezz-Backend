using System.Text.Json.Serialization;

namespace Homezz.API.Data.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PropertyType
    {
        HOUSE,
        APARTMENT
    }
}
