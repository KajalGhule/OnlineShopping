using ShipmentLib;

namespace ShipmentRerpository.Repository {
    public interface IShipmentRepository {
        // List<Shipment> GetAll();
        Task<List<Shipment>> GetAll();
        // Shipment GetById(int id);
        Task<Shipment> GetById(int id);
        void Add(Shipment shipment);
        // void Update(Shipment shipment);
        Task<bool> Update(Shipment shipment);
        // void Delete(int id);
        Task<bool> Delete(int id);
    }

}