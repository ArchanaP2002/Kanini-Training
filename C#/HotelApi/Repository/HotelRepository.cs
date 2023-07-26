using HotelApi.data;
using HotelApi.model_s;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelContext _hotelContext;  //inherits from DbContext and represents the database context

        public HotelRepository(HotelContext con)
        {
            _hotelContext = con; // to access the Hotels property
        }


        public IEnumerable<Hotel> GetHotel()
        {
            try
            {
                return _hotelContext.Hotels.Include(x => x.Room).ToList();  //result the list using tolist()method
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve hotels.", ex);
            }
        }

        public Hotel GetHotelById(int HotelId)
        {
            try
            {    // first or default() method to find the first hotel by id 
                return _hotelContext.Hotels.FirstOrDefault(x => x.HotelId == HotelId);  
              
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve hotel by ID.", ex);
            }
        }

        public Hotel PostHotel(Hotel hotel)
        {
            try
            {
                _hotelContext.Hotels.Add(hotel); //insert into db
                _hotelContext.SaveChanges(); // commit into db
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create hotel.", ex);
            }
        }

        public Hotel PutHotel(int HotelId, Hotel hotel)
        {
            try
            {
                _hotelContext.Entry(hotel).State = EntityState.Modified;
                _hotelContext.SaveChanges(); // update into database 
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update hotel.", ex);
            }
        }

        public Hotel DeleteHotel(int HotelId)
        {
            try
            {
                var hotel = _hotelContext.Hotels.Find(HotelId); // finds the hotel by  id 
                _hotelContext.Hotels.Remove(hotel);  // delete from db
                _hotelContext.SaveChanges(); // commit 
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete hotel.", ex);
            }
        }
     
        public IEnumerable<Hotel> GetHotels(Hotel filter)
        {
            var query = _hotelContext.Hotels.AsQueryable();

            if (!string.IsNullOrEmpty(filter.Location)) //conditional filters 
            {
                query = query.Where(h => h.Location == filter.Location);
            }

          

            return query.ToList();
        }

        public Task<List<Hotel>> FilterHotels(string location)
        {
            throw new NotImplementedException();
        }
    }
    }
 
