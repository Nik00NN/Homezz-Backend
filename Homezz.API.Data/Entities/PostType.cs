using System.Text.Json.Serialization;

namespace Homezz.API.Data.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PostType
    {
        FOR_SALE,
        FOR_LOAN
    }
}
