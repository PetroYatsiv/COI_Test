using COI2.Logic;
using COI2.Model;
using COI2.Model.Point;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
    public class Position<T>
    {
        public List<IPoint<T>> PointCollection;

        public Position()
        {
            PointCollection = new List<IPoint<T>>();
        }

        public void InitializePoints(int numberOfPoints, PointType pointType)
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                PointCollection.Add(PointFactory.GetPointType<T>(pointType));
            }
        }
    }
}
