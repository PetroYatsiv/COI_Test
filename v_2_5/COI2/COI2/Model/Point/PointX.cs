using COI2.Model.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model.Point
{
    public class PointX<T> : IPoint<T>
    {
        public T X { get; set; }

        public string GetType()
        {
            return "X";
        }

        public string ValueToString()
        {
            return $"X = {X}";
        }
    }
}
