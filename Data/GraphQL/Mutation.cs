using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using WorldCitiesAPI.Data.Models;

namespace WorldCitiesAPI.Data.GraphQL
{
    public class Mutation
    {
        /// <summary>
        /// Add a new City
        /// </summary

        public async Task<City> AddCity([Service] ApplicationDbContext context, CityDTO cityDTO)
        {
            var city = new City()
            {
                Name = cityDTO.Name,
                Lat = cityDTO.Lat,
                Lon = cityDTO.Lon,
                CountryId = cityDTO.CountryId
            };

            context.Cities.Add(city);
            await context.SaveChangesAsync();
            return city;
        }
    }
}
