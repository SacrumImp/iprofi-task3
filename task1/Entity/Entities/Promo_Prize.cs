using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entity.Entities
{
    public class Promo_Prize
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required, Column("id"), JsonProperty("id")]
        public int id { get; set; }

        [Required, Column("promo"), JsonProperty("promo")]
        public int promo { get; set; }

        [Required, Column("prize"), JsonProperty("prize")]
        public int prize { get; set; }
    }
}
