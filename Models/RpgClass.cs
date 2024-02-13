using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Warrior = 1,
        Mage = 2,
        Cleric = 3,
        Rogue = 4
    }
}