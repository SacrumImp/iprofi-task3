using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entity.Entities
{
    public class Prize
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required, Column("id"), JsonProperty("id")]
        public int id { get; set; }

        [Required, Column("description"), JsonProperty("description")]
        public string description { get; set; }
    }
}
