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
    public partial class Form2 : Form
    {
        private int arrCount=0;
        IItem[] items= new IItem[5];
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IItem myitem = new cola();
            textBox1.Text = myitem.GetPrice().ToString();
        }

        private void colaBtn(object sender, EventArgs e)
        {
            try
            {
                IItem item = new cola();
                items[arrCount] = item;
                arrCount++;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void kinlyBtn(object sender, EventArgs e)
        {
            try
            {
                IItem item = new kinly();
                items[arrCount] = item;
                arrCount++;
            }
            catch (Exception)
            {

                return;
            }
        }

        private void printBtn(object sender, EventArgs e)
        {
            string myMessage="";
            for (int i = 0; i < arrCount; i++)
            {
                myMessage+="item in: "+i+" his price is "+ items[i].GetPrice().ToString()+"\n";
            }

            MessageBox.Show(myMessage);
        }
    }
}
