using ShipmentLib;
using Services.ShipmentService;
namespace Controllers.ShipmentController {
public class ShipmentController
{
    private readonly IShipmentService _shipmentService;

    public ShipmentController(IShipmentService shipmentService)
    {
        _shipmentService = shipmentService;
    }

    public async Task<List<Shipment>> GetAll() {
        var shipments = await _shipmentService.GetAll();
        if (shipments != null && shipments.Count > 0)
            return shipments;
        else
            Console.WriteLine("No shipments found.");
        return null;
    }

    public async Task<Shipment> GetById(int id) {
        if (id != 0 || id > 0)
        {
            var shipment = await _shipmentService.GetById(id);
            if (shipment != null)
                return shipment;
            else
                Console.WriteLine("Shipment not found.");
        }
        else
        {
            Console.WriteLine("Invalid ID entered.");
        }
        return null;
    }
    public async void Add(Shipment shipment) {
        if (shipment != null)
        {
            _shipmentService.Add(shipment);
            Console.WriteLine("Shipment added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid shipment data.");
        }
    }

    public async Task<bool> Update(Shipment shipment) {
        bool status = false;
        if (shipment != null)
        {
            status = await _shipmentService.Update(shipment);
            Console.WriteLine("Shipment added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid shipment data.");
        }
        return status;
    }

    public async Task<bool> Delete(int id)
    {
        bool success = false;
        if (id != 0 || id > 0)
        {
            success = await _shipmentService.Delete(id);
            if (success)
                Console.WriteLine("Shipment deleted successfully.");
            else
                Console.WriteLine("Shipment not found.");
        }
        else
        {
            Console.WriteLine("Invalid ID entered.");
        }
        return success;
    }
}
}
