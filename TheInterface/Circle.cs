using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    internal class Circle : IShape
    {
        public int thickness(int thick)
        {
            return thick;
        }
        public string color(string color)
        {
            return color;
        }
        public int radiuslength { get; set; }
        public int kodkod
        {
            get { return 0; }
        }
    }
}
