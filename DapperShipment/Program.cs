using ShipmentLib;
using ShipmentRerpository.Repository;
string connectionString = "server=localhost;user=root;database=products;password=manager";
IShipmentRepository repo = new ShipmentRepository(connectionString);

// Shipment shipment = new Shipment
// {
//     ShipmentNumber = "SHP2001",
//     Origin = "Delhi",
//     Destination = "Hyderabad",
//     ShipmentDate = DateTime.Now,
//     DeliveryDate = DateTime.Now.AddDays(3),
//     Status = "Scheduled",
//     Carrier = "BlueDart",
//     TrackingNumber = "TRK123"
// };

// repo.Add(shipment);
// Console.WriteLine("Shipment Added.");

List<Shipment> shipments = await repo.GetAll();
foreach(Shipment ship in shipments) {
     Console.WriteLine($"{ship.Destination}: {ship.Origin}");
}

Shipment getShipment = await repo.GetById(2);
Console.WriteLine($"{getShipment.Id}:{getShipment.Destination}");

if(getShipment != null) {
     getShipment.Status = "Delivered";
     await repo.Update(getShipment);
     Console.WriteLine("get shipment Updated");
}
