using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Containers<T> 
    {
        private List<Container<T>> containers;

        public void AddConainer(Container<T> T)
        {
            containers.Add(T);
        }
        public Containers()
        {
            containers = new List<Container<T>>();
        }
    }
}
