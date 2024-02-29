using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeChapter7
{
    public class MetricsCalculator
    {
        public double xProjection(Point p1, Point p2)
        {
            return (p2.x - p1.x) * 1.5;
        }

        public double xProjectionWithException(Point p1, Point p2)
        {

            if (p1 == null || p2 == null)
            {

                throw new ArgumentException(  // ArgumentNullException funker også her

                    "Invalid argument for MetricsCalculator.xProjection");

            }

            return (p2.x - p1.x) * 1.5;

        }

        public double xProjectionWithAssert(Point p1, Point p2)
        {
            Debug.Assert(p1 != null, "p1 should not be null");
            Debug.Assert(p2 != null, "p2 should not be null");


            return (p2.x - p1.x) * 1.5;

        }
    }
}
