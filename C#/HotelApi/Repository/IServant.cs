using HotelApi.model_s;

namespace HotelApi.Repository
{
    public interface IServant
    {
        IEnumerable<ServantsDetails> GetServers();
        ServantsDetails GetServerById(int id);
        ServantsDetails PostServer(ServantsDetails server);
        ServantsDetails PutServer(int id, ServantsDetails server);
       

    }
}
