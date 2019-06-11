using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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
    }
}
