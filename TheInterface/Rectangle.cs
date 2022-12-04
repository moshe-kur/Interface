using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    class Rectangle : IShape
    {
         // private int athickness;
        public int thickness(int thick)
        {
            return thick;
        }
        public string color(string color)
        {
            return color;
        }
        public int length { get; set; }
        
        public int width { get; set; }

       public int kodkod 
        {
            get { return 4; }
        }
       
      
        public void roll()
        {
            MessageBox.Show("Rectangle");
        }
    }
}
