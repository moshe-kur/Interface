using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    internal class Triangle : IShape
    {
        public int thickness(int thick)
        {
            return thick;
        }
        public string color(string color)
        {
            return color;
        }
        public int baseWidth { get; set; }
        public int hight { get; set; }
      
        public int kodkod
        {
            get { return 3; }
        }
        public void roll()
        {
            MessageBox.Show("Triangle");
        }
    }
}
