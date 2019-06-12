using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using operation_by_territory.IntersectionAlgorithm;

namespace operation_by_territory.Tests
{
    [TestClass]
    public class IntersectionTests
    {
        [TestMethod]
        public void PointIntersectionTest()
        {
            Point p1 = new Point {Lat = 1, Long = 1}, q1 = new Point {Lat = 10, Long= 1}; 
            Point p2 = new Point {Lat = 1, Long = 2}, q2 = new Point {Lat = 10, Long = 2};

            if (Point.doIntersect(p1, q1, p2, q2))
            {
                Debug.WriteLine("Yes\n");
            }
            else
            {
                Debug.WriteLine("No\n");
            }


            p1 = new Point {Lat = 10, Long = 0}; q1 = new Point {Lat= 0, Long=10};
            p2 = new Point {Lat = 0, Long = 0}; q2 = new Point {Lat = 10, Long = 10};
            
            if(Point.doIntersect(p1, q1, p2, q2))
            {
                Debug.WriteLine("Yes\n");
            }
            else
            {
                Debug.WriteLine("No\n");
            }

            p1 = new Point {Lat = -5, Long = -5}; q1 = new Point {Lat=0, Long=0};
            p2 = new Point {Lat = 1, Long = 1}; q2 = new Point {Lat=10, Long=10};
            
            if(Point.doIntersect(p1, q1, p2, q2))
            {
                Debug.WriteLine("Yes\n");
            }
            else
            {
                Debug.WriteLine("No\n");
            }
        }
    }
}
