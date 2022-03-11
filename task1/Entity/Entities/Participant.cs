using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entity.Entities
{
    public class Participant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required, Column("id"), JsonProperty("id")]
        public int id { get; set; }

        [Required, Column("name"), JsonProperty("name")]
        public string name { get; set; }
    }
}
