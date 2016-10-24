using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COI2.Model;
using COI2.Model.Point;
using COI2.Logic;

namespace COI2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            var containerCollection = new Container<decimal>[3];//count containers

            for (int i = 0; i < containerCollection.Length; i++)
            {
                containerCollection[i] = new Container<decimal>();

                for (int j = 0; j < 2; j++)
                {
                    var tmpMatrix = new Matrix<decimal>();

                    switch (j)
                    {
                        case 0:

                            for (int k = 0; k < 100; k++)//matrix contains 100 position
                            {
                                var tmpPosition = new Position<decimal>();

                                switch (k)
                                {
                                    case 0:
                                        for (int g = 0; g < 50; g++)//
                                        {
                                            var point = PointFactory<decimal>.CreatePoint(PointType.XY, Convert.ToDecimal(g), Convert.ToDecimal(g + g));
                                            tmpPosition.PointList.Add(point);
                                        }
                                        break;
                                    case 1:
                                        for (int g = 0; g < 200; g++)
                                        {
                                            var point = PointFactory<decimal>.CreatePoint(PointType.XY, Convert.ToDecimal(g), Convert.ToDecimal(g + g));
                                            tmpPosition.PointList.Add(point);
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                tmpMatrix.positionList.Add(tmpPosition);
                            }
                            break;
                        case 1:
                            for (int k = 0; k < 100; k++)
                            {
                                var tmpPosition = new Position<decimal>();

                                switch (k)
                                {
                                    case 0:
                                        for (int g = 0; g < 5; g++)
                                        {
                                            var point = PointFactory<decimal>.CreatePoint(PointType.X, Convert.ToDecimal(g));
                                            tmpPosition.PointList.Add(point);
                                        }
                                        break;
                                    case 1:
                                        for (int g = 0; g < 5; g++)
                                        {
                                            var point = PointFactory<decimal>.CreatePoint(PointType.X, Convert.ToDecimal(g));
                                            tmpPosition.PointList.Add(point);
                                        }
                                        break;
                                    default:
                                        tmpPosition = null;
                                        break;
                                }

                                tmpMatrix.positionList.Add(tmpPosition);
                            }
                            break;
                    }

                    containerCollection[i].matrixList.Add(tmpMatrix);
                }
            }
        }
    }
}
