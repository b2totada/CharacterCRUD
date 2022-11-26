using System.Text.Json.Serialization;

namespace backend.Models
{
    //Models(maps) the RpgClass table in the db
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}