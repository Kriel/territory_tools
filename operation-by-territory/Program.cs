using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operation_by_territory.DataLayer;
using operation_by_territory.IntersectionAlgorithm;

namespace operation_by_territory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hardcodedTerritoryName = "A1";
            var manager = new EntityManager();
            var points = manager.GetTerritoryPoints(hardcodedTerritoryName);

            var minLat = Decimal.MaxValue;
            var maxLat = Decimal.MinValue;
            var minLong = Decimal.MaxValue;
            var maxLong = Decimal.MinValue;

            foreach (var point in points)
            {
                minLat = Math.Min(minLat, point.Lat);
                maxLat = Math.Max(maxLat, point.Lat);

                minLong = Math.Min(minLong, point.Long);
                maxLong = Math.Max(maxLong, point.Long);

                Console.WriteLine($"Id: {point.PointId}, Name: {point.Name}, Lat: {point.Lat}, Long: {point.Long}");
            }

            var addresses = manager.AddressesInLatLongBox(new Point() { Lat = minLat, Long = minLong },
                new Point() { Lat = maxLat, Long = maxLong });

            foreach (var address in addresses)
            {
                Console.WriteLine($"Number: {address.NUMBER}, Street: {address.STREET}, Latitude: {address.LAT}, Longitude: {address.LON}");
            }
            
            Console.WriteLine($"Min Lat: {minLat}, Min Long: {minLong}");
            Console.WriteLine($"Max Lat: {maxLat}, Max Long: {maxLong}");
        }
    }
}
