using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Container<T>
    {
        public List<Matrix<T>> matrixList;

        public Container()
        {
            matrixList = new List<Matrix<T>>();
        }
    }
}
