using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheInterface
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        IShape[] array = new IShape[100];
        public int arrcount = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            moon moon = new moon();
            moon.roll();
        }
        public IShape bigShape(IShape shape1,IShape shape2)
        {
            if (shape1.kodkod > shape2.kodkod)
            {
                return shape1;
            }
            else
            {
                return shape2;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (arrcount<100)
            {
                if (checkBox1.Checked)
                {
                    array[arrcount] = new Rectangle();
                    arrcount++;
                }
                if (checkBox2.Checked)
                {
                    array[arrcount] = new Circle();
                    arrcount++;
                }
                if (checkBox3.Checked)
                {
                    array[arrcount] = new ellispe();
                    arrcount++;
                }
                if (checkBox4.Checked)
                {
                    array[arrcount] = new Triangle();
                    arrcount++;
                }
                if (checkBox5.Checked)
                {
                    array[arrcount] = new moon();
                    arrcount++;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kodkodsum = 0;
            for (int i = 0; i < arrcount; i++)
            {
                kodkodsum += array[i].kodkod;
            }
            label1.Text = kodkodsum.ToString();

        }
    }
}
