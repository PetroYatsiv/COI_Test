using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Container<T> : Containers<T>
    {
        private List<Matrix<T>> matrixList;
        //methods
        public void AddMatrix(Matrix<T> T)
        {
            matrixList.Add(T);
        }
        public void RemoveMatrix(int item)
        {
            matrixList.RemoveAt(item);
        }
        public void ClearMatrixList()
        {
            matrixList.Clear();
        }
        //ctors
        public Container()
        {
            matrixList = new List<Matrix<T>>();
        }
        public Container(Matrix<T> matrix)
        {
            matrixList = new List<Matrix<T>>();
            matrixList.Add(matrix);
        }
    }
}
