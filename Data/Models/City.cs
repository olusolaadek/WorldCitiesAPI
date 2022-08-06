using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCitiesAPI.Data.Models
{
    [Table("Cities")]
    [Index(nameof(Name))]
    [Index(nameof(Lon))]
    [Index(nameof(Lat))]
    public class City
    {
        #region properties
        /// <summary>
        /// The unique id and primary key for this City
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// City name (in UTF8 format)
        /// </summary>
        public string? Name { get; set; } = null;

        /// <summary>
        /// City Latitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lat { get; set; }
        /// <summary>
        /// City longitude
        /// </summary>
        [Column(TypeName = "decimal(7,4)")]
        public decimal Lon { get; set; }
        /// <summary>
        /// Country Id (foreign key)
        /// </summary>
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        // Navigation

        public Country? Country { get; set; } = null;
        #endregion
    }
}
