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
        public List<IPoint<T>> PointList;

        public void AddPoint(IPoint<T> T)
        {
            PointList.Add(T);
        }
        public void RemovePoint(int item)
        {
            PointList.RemoveAt(item);
        }
        public void ClearPointList()
        {
            PointList.Clear();
        }

        public Position()
        {
            PointList = new List<IPoint<T>>();
        }
        

        
    }
}
