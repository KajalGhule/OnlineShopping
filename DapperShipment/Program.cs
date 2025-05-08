using ShipmentLib;
using ShipmentRerpository.Repository;
using Controllers.ShipmentController;
using Services.ShipmentService;
string connectionString = "server=localhost;user=root;database=products;password=manager";
IShipmentRepository repo = new ShipmentRepository(connectionString);

IShipmentService service = new ShipmentService(repo);
ShipmentController controller = new ShipmentController(service);

Shipment shipment = new Shipment
{
    ShipmentNumber = "SHP2011",
    Origin = "Pune",
    Destination = "Kerala",
    ShipmentDate = DateTime.Now,
    DeliveryDate = DateTime.Now.AddDays(3),
    Status = "Scheduled",
    Carrier = "BlueDart",
    TrackingNumber = "TRK125"
};

// controller.Add(shipment);

List<Shipment> shipments = await controller.GetAll();
foreach(Shipment ship in shipments) {
     Console.WriteLine($"{ship.Destination}: {ship.Origin}");
}

Shipment getShipment = await controller.GetById(1);
Console.WriteLine($"{getShipment.Id}:{getShipment.Destination}");

if(getShipment != null) {
     getShipment.Status = "Delivered";
     await controller.Update(getShipment);
     Console.WriteLine("get shipment Updated");
}


if(getShipment != null) {
     await controller.Delete(getShipment.Id);
     Console.WriteLine("get shipment deleted");     
}