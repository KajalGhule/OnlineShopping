using Dapper;
using System.Data;
using System.Data.SqlClient;
using ShipmentLib;
using MySql.Data.MySqlClient;
using System.Linq; 

namespace ShipmentRerpository.Repository {

public class ShipmentRepository : IShipmentRepository
{
        private readonly string _connectionString;
        private IDbConnection Connection;
        public ShipmentRepository(string connectionString)
        {
            _connectionString = connectionString;
            Connection = new MySqlConnection(_connectionString);
        }
        
        public async Task<List<Shipment>> GetAll()
        {
            using var db = Connection;
            // Use QueryAsync and convert the result to List<Shipment>
            var shipments = await db.QueryAsync<Shipment>("SELECT * FROM Shipments");
            return shipments.ToList();  // Convert the IEnumerable to List
        }


        public async Task<Shipment> GetById(int id)
        {
            // using var db = Connection;
            // return db.QueryFirstOrDefault<Shipment>("SELECT * FROM Shipments WHERE Id = @Id", new { Id = id });

            using var db = Connection;
            var shipment = db.QueryFirstOrDefault<Shipment>("SELECT * FROM Shipments WHERE Id = @Id", new { Id = id });

            if (shipment == null)
            {
                throw new InvalidOperationException($"Shipment with Id {id} not found.");
            }

            return shipment;
        }

        public async void Add(Shipment shipment)
        {
            using var db = Connection;
            var sql = @"INSERT INTO Shipments 
                (ShipmentNumber, Origin, Destination, ShipmentDate, DeliveryDate, Status, Carrier, TrackingNumber) 
                VALUES 
                (@ShipmentNumber, @Origin, @Destination, @ShipmentDate, @DeliveryDate, @Status, @Carrier, @TrackingNumber)";
            db.Execute(sql, shipment);
        }

        public async Task<bool> Update(Shipment shipment)
        {
            using var db = Connection;
            var sql = @"UPDATE Shipments SET 
                ShipmentNumber = @ShipmentNumber,
                Origin = @Origin,
                Destination = @Destination,
                ShipmentDate = @ShipmentDate,
                DeliveryDate = @DeliveryDate,
                Status = @Status,
                Carrier = @Carrier,
                TrackingNumber = @TrackingNumber
                WHERE Id = @Id";
            // db.Execute(sql, shipment);
            var rowsAffected = await db.ExecuteAsync(sql, shipment);
            return rowsAffected > 0;
        }

        public async Task<bool> Delete(int id)
        {
            using var db = Connection;
            var rowsAffected =  db.Execute("DELETE FROM Shipments WHERE Id = @Id", new { Id = id });
            return rowsAffected > 0;
        }
    }
    
}
