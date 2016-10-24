using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
    public class Position<T> : Matrix<T>
    {
        public List<Point<T>> pointList;
        //methods
        public void AddPoint(Point<T> T)
        {
            pointList.Add(T);
        }
        public void RemovePoint(int item)
        {
            pointList.RemoveAt(item);
        }
        public void ClearPointList()
        {
            pointList.Clear();
        }
        //ctors
        public Position()
        {
            pointList = new List<Point<T>>();
        }
        public Position(Point<T> point)
        {
            pointList = new List<Point<T>>();
            pointList.Add(point);
        }


    }
}
