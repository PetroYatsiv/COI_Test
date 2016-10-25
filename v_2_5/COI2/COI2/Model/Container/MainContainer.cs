using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model.Container
{
    public class MainContainer<T>
    {
        public List<Container<T>> ContainerCollection;

        public MainContainer()
        {
            ContainerCollection = new List<Container<T>>();
        }

        public void InitializeContainers(int numberOfContainer)
        {
            for (int i = 0; i < numberOfContainer; i++)
            {
                this.ContainerCollection.Add(new Container<T>());
            }
        }
    }
}
