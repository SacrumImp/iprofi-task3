using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Abstractions.Data.Input
{
    public class PomoInput
    {
        [Required, JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
