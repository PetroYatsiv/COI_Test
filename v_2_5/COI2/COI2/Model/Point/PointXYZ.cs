using COI2.Model.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model.Point
{
    public class PointXYZ<T> : IPoint<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }

        public string GetType()
        {
            return "XYZ";
        }

        public string ValueToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
    }
}
