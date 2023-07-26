using System.ComponentModel.DataAnnotations;

namespace HotelApi.model_s
{
    public class ServantsDetails
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
