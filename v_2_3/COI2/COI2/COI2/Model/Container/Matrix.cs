using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Matrix<T>
   {
       public List<Position<T>> positionList;

        public Matrix()
       {
           positionList = new List<Position<T>>();
       }
    }
}
