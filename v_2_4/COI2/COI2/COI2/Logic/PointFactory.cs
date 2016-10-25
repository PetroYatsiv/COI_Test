using COI2.Model;
using COI2.Model.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Logic
{
    public class PointFactory
    {
        public static IPoint<T> GetPointType<T>(PointType pointType)
        {
            IPoint<T> pointObj = null;
            switch (pointType)
            {
                case PointType.X:
                    pointObj = new PointX<T>();
                    break;
                case PointType.XY:
                    pointObj = new PointXY<T>();
                    break;
                case PointType.XYZ:
                    pointObj = new PointXYZ<T>();
                    break;
                default:
                    break;
            }

            return pointObj;
        }

        public static IPoint<T> CreatePoint<T>(PointType pointType, params T[] values)
        {
            IPoint<T> point = null;

            switch (pointType)
            {
                case PointType.X:
                    point = CreatePointX(values);
                    break;
                case PointType.XY:
                    point = CreatePointXY(values);
                    break;
                case PointType.XYZ:
                    point = CreatePointXYZ(values);
                    break;
                default:
                    break;
            }

            return point;
        }

        private static PointX<T> CreatePointX<T>(params T[] value)
        {
            return new PointX<T>()
            {
                X = value[0]
            };
        }
        private static PointXY<T> CreatePointXY<T>(params T[] value)
        {
            return new PointXY<T>()
            {
                X = value[0],
                Y = value[1]
            };
        }
        private static PointXYZ<T> CreatePointXYZ<T>(params T[] value)
        {
            return new PointXYZ<T>()
            {
                X = value[0],
                Y = value[1],
                Z = value[2]
            };
        }
    }
}
