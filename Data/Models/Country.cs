using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WorldCitiesAPI.Data.Models
{
    [Table("Countries")]
    [Index(nameof(Name))]
    [Index(nameof(ISO2))]
    [Index(nameof(ISO3))]

    public class Country
    {
        #region Properties

        /// <summary>
        /// The unique id and primary key for this Country
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// Country name (in UTF8 format)
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Country code (in ISO 3166-1 ALPHA-2 format)
        /// </summary>
        [JsonPropertyName("iso2")]
        [Required]
        public string ISO2 { get; set; } = null!;
        /// <summary>
        /// Country code (in ISO 3166-1 ALPHA-3 format)
        /// </summary>
        [JsonPropertyName("iso3")]
        [Required]
        public string ISO3 { get; set; } = null!;

        #region Client-side properties
        /// <summary>
        /// The number of cities related to this country.
        /// </summary>
        /// 

        public int TotCities
        {
            get
            {
                return Cities?.Count ?? 0;
            }
            set
            {
                _TotCities = value;
            }
        }
        private int _TotCities = 0;
        #endregion

        /// <summary>
        /// A collection of all the cities related to this country
        /// </summary>
        [JsonIgnore]
        public ICollection<City>? Cities { get; set; } = null;


        #endregion
    }
}
