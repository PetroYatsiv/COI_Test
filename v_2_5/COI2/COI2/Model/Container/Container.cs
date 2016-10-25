using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Container<T>
    {
        public List<Matrix<T>> MatrixCollection;

        public Container()
        {
            MatrixCollection = new List<Matrix<T>>();
        }

        public void InitializeMatrix(int numberOfMatrix)
        {
            for (int i = 0; i < numberOfMatrix; i++)
            {
                this.MatrixCollection.Add(new Matrix<T>());
            }
        }
    }
}
