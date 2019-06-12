using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using operation_by_territory.IntersectionAlgorithm;

namespace operation_by_territory.DataLayer
{
    public class EntityManager
    {
        /// <summary>
        /// Get all of the points for a specific territory.
        /// </summary>
        /// <param name="territoryName"></param>
        /// <returns></returns>
        public List<TerritoryPoint> GetTerritoryPoints(string territoryName)
        {
            try
            {
                Console.WriteLine($"Entering {nameof(GetTerritoryPoints)}");
                var context = new letter_writingEntities();
                var pointsQuery = context.TerritoryPoints.Where(tp => tp.Name == territoryName);
                return pointsQuery.ToList();
            }
            finally
            {
                Console.WriteLine($"Leaving {nameof(GetTerritoryPoints)}");
            }
        }

        public List<ClarkAddress> AddressesInLatLongBox(Point minPoint, Point maxPoint)
        {
            try
            {
                Console.WriteLine($"Entering {nameof(AddressesInLatLongBox)}");
                var context = new letter_writingEntities();
                var addressesQuery = context.ClarkAddresses.Where(ca => ca.LAT >= minPoint.Lat && ca.LAT <= maxPoint.Lat && ca.LON >= minPoint.Long && ca.LON <= maxPoint.Long);

                Console.WriteLine(addressesQuery.Count());
                return addressesQuery.ToList();
            }
            finally
            {
                Console.WriteLine($"Leaving {nameof(AddressesInLatLongBox)}");
            }
        }
    }
}
