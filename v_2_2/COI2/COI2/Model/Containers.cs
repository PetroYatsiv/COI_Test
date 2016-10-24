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
        //methods
        public void AddConainer(Container<T> T)
        {
            containers.Add(T);
        }
        public void RemoveContainer(int item)
        {
            containers.RemoveAt(item);
        }
        public void ClearContainers()
        {
            containers.Clear();
        }
        //ctor
        public Containers()
        {
            containers = new List<Container<T>>();
        }
        public Containers(Container<T> container)
        {
            containers = new List<Container<T>>();
            containers.Add(container);
        }
    }
}
