using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operation_by_territory.DataLayer;

namespace operation_by_territory
{
    class Program
    {
        static void Main(string[] args)
        {
            var hardcodedTerritoryName = "A1";
            var manager = new EntityManager();
            var points = manager.GetTerritoryPoints(hardcodedTerritoryName);

            foreach (var point in points)
            {
                Console.WriteLine($"Id: {point.PointId}, Name: {point.Name}, Lat: {point.Lat}, Long: {point.Long}");
            }
        }
    }
}
