using COI2.Logic;
using COI2.Model.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Matrix<T>
   {
       public List<Position<T>> PositionCollection;

        public Matrix()
       {
            PositionCollection = new List<Position<T>>();
       }

        public void InitializePosition(int numberOfposition)
        {
            for (int i = 0; i < numberOfposition; i++)
            {
                this.PositionCollection.Add(new Position<T>());
            }
        }
    }
}
