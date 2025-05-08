using ShipmentLib;
using ShipmentRerpository.Repository;

namespace Services.ShipmentService {
public class ShipmentService : IShipmentService
{
    private readonly IShipmentRepository _shipmentRepository;

    public ShipmentService(IShipmentRepository shipmentRepository)
    {
        _shipmentRepository = shipmentRepository;
    }

    public async Task<List<Shipment>> GetAll() {
        return await _shipmentRepository.GetAll();
    }
    public async Task<Shipment> GetById(int id) {
        return await _shipmentRepository.GetById(id);
    }
    public void Add(Shipment shipment) {
          _shipmentRepository.Add(shipment);
    }
    public async Task<bool> Update(Shipment shipment) {
        return await _shipmentRepository.Update(shipment);
    }   
    
    public async Task<bool> Delete(int id)
    {
        return await _shipmentRepository.Delete(id);
    } 
}
}