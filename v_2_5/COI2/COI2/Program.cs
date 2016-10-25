using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COI2.Model;
using COI2.Model.Point;
using COI2.Logic;
using COI2.Model.Container;
using System.Xml;

namespace COI2
{
    class Program
    {
        static void InitializeContainer<T>(Container<T>[] containers)
        {
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i] = new Container<T>();
            }
        }
        static void Main(string[] args)
        {
            MakeXmlFile();
            //var mainContainer = MakeContainer();
        }

        static MainContainer<decimal> MakeContainer()
        {
            var mainContainer = new MainContainer<decimal>();
            mainContainer.InitializeContainers(3);

            var containers = mainContainer.ContainerCollection;

            for (int i = 0; i < containers.Count; i++)
                containers[i].InitializeMatrix(2);

            for (int i = 0; i < containers.Count; i++)
                for (int j = 0; j < containers[i].MatrixCollection.Count; j++)
                {
                    containers[i].MatrixCollection[j].InitializePosition(100);
                }

            for (int i = 0; i < containers.Count; i++)
                for (int matrixIndex = 0; matrixIndex < containers[i].MatrixCollection.Count; matrixIndex++)
                    for (int positionIndex = 0; positionIndex < containers[i].MatrixCollection[matrixIndex].PositionCollection.Count; positionIndex++)
                    {
                        var position = containers[i].MatrixCollection[matrixIndex].PositionCollection[positionIndex];

                        if (matrixIndex == 0 && positionIndex == 0)
                        {
                            position.InitializePoints(50, PointType.XY);

                            //add some test data
                            for (int testIndex = 0; testIndex < 50; testIndex++)
                            {
                                var point = PointFactory.CreatePoint(PointType.XY, Convert.ToDecimal(testIndex), Convert.ToDecimal(testIndex + testIndex));
                                position.PointCollection[testIndex] = point;
                            }
                        }
                        else if (matrixIndex == 0 && positionIndex == 1)
                        {
                            position.InitializePoints(200, PointType.XY);

                            //add some test data
                            for (int testIndex = 0; testIndex < 200; testIndex++)
                            {
                                var point = PointFactory.CreatePoint(PointType.XY, Convert.ToDecimal(testIndex), Convert.ToDecimal(testIndex + testIndex));
                                position.PointCollection[testIndex] = point;
                            }
                        }
                        else if (matrixIndex == 0)
                            position.PointCollection = null;

                        if (matrixIndex == 1 && (positionIndex == 0 || positionIndex == 1))
                        {
                            position.InitializePoints(50, PointType.X);

                            //add some test data
                            for (int testIndex = 0; testIndex < 50; testIndex++)
                            {
                                var point = PointFactory.CreatePoint(PointType.X, Convert.ToDecimal(testIndex + testIndex));
                                position.PointCollection[testIndex] = point;
                            }
                        }
                        else if (matrixIndex == 1)
                            position.PointCollection = null;

                    }
            return mainContainer;
        }
        static void MakeXmlFile()
        {
            var mainContainer = MakeContainer();

            using (XmlWriter writer = XmlWriter.Create("points.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("MainContainer");

                foreach (var container in mainContainer.ContainerCollection)
                {
                    writer.WriteStartElement("Container");

                    try
                    {
                        foreach (var matrix in container.MatrixCollection)
                        {
                            writer.WriteStartElement("Matrix");

                            try
                            {
                                foreach (var position in matrix.PositionCollection)
                                {
                                    writer.WriteStartElement("Position");

                                    try
                                    {
                                        foreach (var point in position.PointCollection)
                                        {
                                            writer.WriteStartElement("Point");

                                            writer.WriteElementString("Type", point.GetType());
                                            writer.WriteElementString("Value", point.ValueToString());

                                            writer.WriteEndElement();
                                        }
                                    }
                                    catch (Exception ex) { /*point == null */ }

                                    writer.WriteEndElement();
                                }
                            }
                            catch (Exception ex) { /*position == null */ }

                            writer.WriteEndElement();
                        }
                    }
                    catch (Exception ex) { /*matrix == null */ }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
