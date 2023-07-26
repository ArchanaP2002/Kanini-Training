﻿using HotelApi.model_s;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelApi.Repository
{
    public interface IHotelRepository
    {
        [HttpGet]
        [Route("api/hotel")]
        public IEnumerable<Hotel> GetHotel();

        [HttpGet]
        [Route("api/hotel/{HotelId}")]
        public Hotel GetHotelById(int HotelId);

        [HttpPost]
        [Route("api/hotel")]
        public Hotel PostHotel(Hotel hotel);

        [HttpPut]
        [Route("api/hotel/{HotelId}")]
        public Hotel PutHotel(int HotelId, Hotel hotel);

        [HttpDelete]
        [Route("api/hotel/{HotelId}")]
        public Hotel DeleteHotel(int HotelId);

        Task<List<Hotel>> FilterHotels(string location);
        [HttpGet]
        public IEnumerable<Hotel> GetHotels(Hotel filter);
    }
}

