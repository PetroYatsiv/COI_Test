using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model
{
   public class Point<T> : Position<T>
   {
        public T X { get; set; }
        public T Y { get; set; }
        public T Z { get; set; }
        //ctors
        public Point(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point(T x)
        {
            X = x;
        }
        public Point()
        {
           X = default(T);
           Y = default(T);
           Z = default(T);
        }
    }
}
