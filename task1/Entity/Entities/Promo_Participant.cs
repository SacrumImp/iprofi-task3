using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entity.Entities
{
    public class Promo_Participant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required, Column("id"), JsonProperty("id")]
        public int id { get; set; }

        [Required, Column("promo"), JsonProperty("promo")]
        public int promo { get; set; }

        [Required, Column("participant"), JsonProperty("participant")]
        public int participant { get; set; }
    }
}
