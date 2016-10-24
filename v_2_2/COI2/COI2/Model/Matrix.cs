using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Matrix<T> : Container<T>
   {
       public List<Position<T>> positionList;
       //methods
       public void AddPosition(Position<T> T)
       {
           positionList.Add(T);
       }
       public void RemovePosition(int item)
       {
           positionList.RemoveAt(item);
       }
       public void ClearPositionList()
       {
           positionList.Clear();
       }
       //ctors
       public Matrix()
       {
           positionList = new List<Position<T>>();
       }
       public Matrix(Position<T> position)
        {
            positionList = new List<Position<T>>();
            positionList.Add(position);
        }
    }
}
