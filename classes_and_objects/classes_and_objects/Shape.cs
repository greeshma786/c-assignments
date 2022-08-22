using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class Shape
    {
        public int Area(int l)
        {
            return l * l;
        }
        public float Area(float r)
        {
            return 3.14f * r * r;
        }
        public int Area(int l,int b)
        {
            return l * b;
        }
        public float Area(float b,float h)
        {
            return 0.5f * b * h;
        }
    }
}
