using ShipmentLib;
namespace Services.ShipmentService {
public interface IShipmentService
{
        Task<List<Shipment>> GetAll();
        Task<Shipment> GetById(int id);
        void Add(Shipment shipment);
        Task<bool> Update(Shipment shipment);
        Task<bool> Delete(int id);
}
}