using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COI2.Model;

namespace COI2
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point<int>(3);
            var point2 = new Point<double>(10.4, 30.5);
            var point3 = new Point<decimal>(10, 20, 30);
            
            var position1 = new Position<int>(point1);
            position1.AddPoint(point1);

            var position2 = new Position<decimal>(point3);
            var matrix = new Matrix<int>();
            var container = new Container<int>();
            var containers = new Containers<int>();


            position2.AddPoint(point3);
            position2.AddPoint(point3);
            position2.AddPoint(point3);

            matrix.AddPosition(position1);

            container.AddMatrix(matrix);

            containers.AddConainer(container);

            
            Console.ReadLine();
        }
    }
}
